using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAPAENTIDAD;
using CAPALOGICA;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace PROYECTO_PAQUETERIA_DIARS
{
    public partial class FrmRuta : Form
    {
        GMarkerGoogle marker;
        GMapOverlay markerOverlay;
        DataTable dt;

        //Ruta automatizada(dirección)
        bool trazarRuta = false;
        int ContadorIndicadoresRuta = 0;
        PointLatLng inicio;
        PointLatLng final;
        int filaSeleccionada = 0;
        double LatInicial = -8.106441;
        double LngInicial = -79.032030;
        public FrmRuta()
        {
            InitializeComponent();
            ListarRuta();
        
        }

        public void LimpiarVariables() {
            txtIdRuta.Text = ("");
            txtPuntoPartida.Text = ("");
            txtPuntoLlegada.Text = ("");
            txtObservaciones.Text = ("");
            checkBoxEstadoRuta.Checked = false;
        }

        private void SelecionarRegistro(object sender, DataGridViewCellMouseEventArgs e)
        {
            filaSeleccionada = e.RowIndex;//Fila Seleccionada
            //Recuperamos los datos del grid y los asignamos a los texbo
            txtlatitud.Text = dataGridView1.Rows[filaSeleccionada].Cells[0].Value.ToString();
            txtlongitud.Text = dataGridView1.Rows[filaSeleccionada].Cells[1].Value.ToString();

            //se asignan los valores del grid al macador
            marker.Position = new PointLatLng(Convert.ToDouble(txtlatitud.Text), Convert.ToDouble(txtlongitud.Text));
            //se posiciona el foco del mapa en ese punto
            gMapControl1.Position = marker.Position;

        }
        private void btnRelieve_Click(object sender, EventArgs e)
        {

        }

        private void btnOriginal_Click(object sender, EventArgs e)
        {

        }
        private void gMapControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //se obtiene los datos de lat y lng del mapa donde usuario presiono
            double lat = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;
            double lng = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;

            //se posicionan en el txt de la latitud y longitud
            txtlatitud.Text = lat.ToString();
            txtlongitud.Text = lng.ToString();

            //crearemos el marcador para moverlo al lugar indicado por el usuario
            marker.Position = new PointLatLng(lat, lng);
            //tambien se agregara el mensaje al marcador es decir el ToolTip
            marker.ToolTipText = string.Format("Punto Llegada:\n Latitud:{0}\n Longitud:{1}", lat, lng);

            CrearDireccionTrazarRuta(lat, lng);

        }
        public void CrearDireccionTrazarRuta(double lat, double lng)
        {
            if (trazarRuta)
            {
                switch (ContadorIndicadoresRuta)
                {
                    case 0://primer marcador de inico
                        ContadorIndicadoresRuta++;
                        inicio = new PointLatLng(lat, lng);
                        break;
                    case 1://Segundo marcador o final
                        ContadorIndicadoresRuta++;
                        final = new PointLatLng(lat, lng);
                        GDirections direccion;
                        var RutasDireccion = GMapProviders.GoogleMap.GetDirections(out direccion, inicio, final, false, false, false, false, false);
                        GMapRoute RutaObtenida = new GMapRoute(direccion.Route, "Ruta ubicación");
                        GMapOverlay CapaRutas = new GMapOverlay("Capa de la ruta");
                        CapaRutas.Routes.Add(RutaObtenida);
                        gMapControl1.Overlays.Add(CapaRutas);
                        gMapControl1.Zoom = gMapControl1.Zoom + 1;
                        gMapControl1.Zoom = gMapControl1.Zoom - 1;
                        ContadorIndicadoresRuta = 0;
                        trazarRuta = false;
                        break;
                }
            }
        }
 

        private void btnSat_Click(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GMapProviders.GoogleChinaSatelliteMap;
        }

        private void btnOriginal_Click_1(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
        }

        private void btnRelieve_Click_1(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GMapProviders.GoogleTerrainMap;
        }

        private void btnRuta_Click(object sender, EventArgs e)
        {
            GMapOverlay Ruta = new GMapOverlay("CapaRuta");

            List<PointLatLng> puntos = new List<PointLatLng>();
            //variables para almacenar los datos
            double lng, lat;
            //agregamos los datos del grid
            for (int filas = 0; filas < dataGridView1.Rows.Count; filas++)
            {
                lat = Convert.ToDouble(dataGridView1.Rows[filas].Cells[0].Value);
                lng = Convert.ToDouble(dataGridView1.Rows[filas].Cells[1].Value);
                puntos.Add(new PointLatLng(lat, lng));
            }

            GMapRoute PuntosRuta = new GMapRoute(puntos, "Ruta");
            Ruta.Routes.Add(PuntosRuta);
            gMapControl1.Overlays.Add(Ruta);

            //Actulizar el mapa
            gMapControl1.Zoom = gMapControl1.Zoom + 1;
            gMapControl1.Zoom = gMapControl1.Zoom - 1;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            dt.Rows.Add(txtlatitud.Text, txtlongitud.Text);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(filaSeleccionada);//remover de la tabla
        }

        private void gMapControl1_Load_1(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt.Columns.Add(new DataColumn("Lat", typeof(double)));
            dt.Columns.Add(new DataColumn("Long", typeof(double)));

            //insertando datos al dt para mostrar en la lista
            dt.Rows.Add(LatInicial, LngInicial);
            dataGridView1.DataSource = dt;

            //desactivar las columnas de lat y long
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            //Creando las dimensiones del GMAPCONTROL(herramienta)
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(LatInicial, LngInicial);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 9;
            gMapControl1.AutoScroll = true;

            //Marcador
            markerOverlay = new GMapOverlay("Marcador");
            marker = new GMarkerGoogle(new PointLatLng(LatInicial, LngInicial), GMarkerGoogleType.red);
            markerOverlay.Markers.Add(marker);//Agregamos al mapa

            //agregamos un tooltip de texto a los marcadores
            marker.ToolTipMode = MarkerTooltipMode.Always;
            marker.ToolTipText = string.Format("Punto Partida:\n Latitud:{0}\n Longitud:{1}", LatInicial, LngInicial);

            //ahora agregamos el mapa y el marcador al control map

            gMapControl1.Overlays.Add(markerOverlay);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            trackZoom.Value = Convert.ToInt32(gMapControl1.Zoom);

        }

        private void trackZoom_ValueChanged(object sender, EventArgs e)
        {
            gMapControl1.Zoom = trackZoom.Value;
        }
        public void ListarRuta()
        {
            dataGridViewRuta.DataSource = LogRuta.Instancia.ListarRuta();
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            EntRuta Rut = new EntRuta();
            //Rut.IdRuta = Convert.ToInt32(txtIdRuta.Text.Trim());
            Rut.PuntoPartida = txtPuntoPartida.Text.Trim();
            Rut.PuntoLlegada = txtPuntoLlegada.Text.Trim();
            Rut.Observaciones = txtObservaciones.Text.Trim();
            Rut.EstadoRuta = checkBoxEstadoRuta.Checked;

            LogRuta.Instancia.InsertarRuta(Rut);
            ListarRuta();
            LimpiarVariables();
        }

        private void dataGridViewRuta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EntRuta Rut = new EntRuta();
            DataGridViewRow filaActual = dataGridViewRuta.Rows[e.RowIndex];
            txtIdRuta.Text = filaActual.Cells[0].Value.ToString();
            txtPuntoPartida.Text = filaActual.Cells[1].Value.ToString();
            txtPuntoLlegada.Text = filaActual.Cells[2].Value.ToString();
            txtObservaciones.Text = filaActual.Cells[3].Value.ToString();
            string est = filaActual.Cells[4].Value.ToString();//para tomar el dato de la tabla ya que asi nomas no se deja xd
            checkBoxEstadoRuta.Checked = Convert.ToBoolean(est);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                EntRuta Rut = new EntRuta();
                Rut.IdRuta = Convert.ToInt32(txtIdRuta.Text.Trim());
                Rut.PuntoPartida = txtPuntoPartida.Text.Trim();
                Rut.PuntoLlegada = txtPuntoLlegada.Text.Trim();
                Rut.Observaciones = txtObservaciones.Text.Trim();
                Rut.EstadoRuta = checkBoxEstadoRuta.Checked;

                LogRuta.Instancia.EditarRuta(Rut);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex);
            }
            dataGridViewRuta.Enabled = false;
            ListarRuta();
            LimpiarVariables();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtIdRuta.Focus();
            int IdRuta = Convert.ToInt32(txtIdRuta.Text.Trim());
            EntRuta Rut = LogRuta.Instancia.BuscarRutaId(IdRuta);
            if (Rut != null && (Rut.EstadoRuta = true))
            {
                txtIdRuta.Text = Convert.ToString(Rut.IdRuta);
                txtPuntoPartida.Text = Rut.PuntoPartida.ToString();
                txtPuntoLlegada.Text = Rut.PuntoLlegada.ToString();
                txtObservaciones.Text = Rut.Observaciones.ToString();
                checkBoxEstadoRuta.Checked = Convert.ToBoolean(Rut.EstadoRuta);
            }
            else
            {
                MessageBox.Show("El Trabajdor no existe or esta inhabilitado, verifique.", "Trabajador: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnInhabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                EntRuta Rut = new EntRuta();
                Rut.IdRuta = int.Parse(txtIdRuta.Text.Trim());
                checkBoxEstadoRuta.Checked = false;
                Rut.EstadoRuta = checkBoxEstadoRuta.Checked;
                LogRuta.Instancia.DeshabilitarRuta(Rut);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            dataGridViewRuta.Enabled = false;
            ListarRuta();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
        }

        private void txtIdRuta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Numeros Y un (.)permitidos ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
