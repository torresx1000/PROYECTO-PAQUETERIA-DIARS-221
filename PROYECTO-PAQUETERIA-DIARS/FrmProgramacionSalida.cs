using Bunifu.Framework.UI;
using CAPAENTIDAD;
using CAPALOGICA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace PROYECTO_PAQUETERIA_DIARS
{
    public partial class FrmProgramacionSalida : Form
    {
        public FrmProgramacionSalida()
        {
            InitializeComponent();
            ListarProgramacionSalida();
            LimpiarCampos();
            btnRegistrar.Enabled = false;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
        }
        public void ListarProgramacionSalida() {
            dataGridViewProgramacion.DataSource = LogProgramacionSalida.Instancia.ListarProgrmacionSalida();
        }
        public void LimpiarCampos() {
            txtIdProgramacion.Text = "";
            dtFechaInicio.Text = "";
            dtFechaFin.Text = "";
            txtRuta.Text = "";
            txtConductor.Text = "";
            txtVehiculo.Text = "";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                EntProgramacionSalida pro = new EntProgramacionSalida();
                pro.IdProgramacionSalida = int.Parse(txtIdProgramacion.Text.Trim());
                LogProgramacionSalida.Instancia.ElimminarProgramacionSalida(pro);
            }
            catch (Exception ex) {
                MessageBox.Show("Error.." + ex);
            }
            ListarProgramacionSalida();
            LimpiarCampos();
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmListaConductores_Trabajadores FrmListaConductores_Trabajadores = new FrmListaConductores_Trabajadores();
            FrmListaConductores_Trabajadores.ShowDialog();
            txtConductor.Text = FrmListaConductores_Trabajadores.nombre;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FrmReporteVehiculo FrmReporteVehiculo = new FrmReporteVehiculo();
            FrmReporteVehiculo.ShowDialog();
            txtVehiculo.Text = FrmReporteVehiculo.placa;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmReporteRuta FrmReporteRuta = new FrmReporteRuta();
            FrmReporteRuta.ShowDialog();
            txtRuta.Text = FrmReporteRuta.IdRuta;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmReporteVehiculo FrmReporteVehiculo = new FrmReporteVehiculo();//no es importtante
            FrmListaConductores_Trabajadores FrmListaConductores_Trabajadores = new FrmListaConductores_Trabajadores();//no es importtante
            FrmReporteRuta frmReporteRuta = new FrmReporteRuta();//no es importtante
            EntProgramacionSalida pro=new EntProgramacionSalida();
            //pro.IdProgramacionSalida = Convert.ToInt32(txtIdProgramacion.Text.Trim());
            pro.FechaInicio = dtFechaInicio.Value;
            pro.FechaFin = dtFechaFin.Value;
            pro.IdRuta = Convert.ToInt32(FrmReporteRuta.IdRuta.Trim());
            pro.IdConductor = Convert.ToInt32(FrmListaConductores_Trabajadores.id.Trim());
            pro.IdVehiculo = Convert.ToInt32(FrmReporteVehiculo.idVehiculo.Trim());
            LogProgramacionSalida.Instancia.InsertarProgramacioSalida(pro);
            ListarProgramacionSalida();
            LimpiarCampos();
            btnRegistrar.Enabled = false;
            txtIdProgramacion.Enabled = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            /*txtIdProgramacion.Focus();
            int id = Convert.ToInt32(txtIdProgramacion.Text.Trim());
            EntProgramacionSalida pro = LogProgramacionSalida.Instancia.BuscarProgramacionSalidaId(id);
            //EntProgramacionSalida procon = LogProgramacionSalida.Instancia.BuscarProgramacionSalidaCon(id);
            EntTrabajador tra=new EntTrabajador();
            if (pro != null)
            {
                txtIdProgramacion.Text = Convert.ToString(pro.IdProgramacionSalida);
                dtFechaInicio.Value = Convert.ToDateTime(pro.FechaInicio);
                dtFechaFin.Value = Convert.ToDateTime(pro.FechaFin);
                txtRuta.Text = Convert.ToString(pro.IdRuta);
                txtConductor.Text = Convert.ToString(tra.Nombres);
                txtVehiculo.Text = Convert.ToString(pro.IdVehiculo);
            }
            else
            {
                MessageBox.Show("La programacion de salida no existe, verifique.", "Trabajador: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }*/
            txtIdProgramacion.Focus();
            EntProgramacionSalida pro = new EntProgramacionSalida();
            pro.IdProgramacionSalida = Convert.ToInt32(txtIdProgramacion.Text);
            DataTable dt = new DataTable();
            dt = LogProgramacionSalida.Instancia.BuscarProgramacion(pro.IdProgramacionSalida);
            if (txtIdProgramacion.Text != "" )
            {
                dataGridViewProgramacion.DataSource = dt;
            }
            else
            {

                dataGridViewProgramacion.DataSource = LogProgramacionSalida.Instancia.ListarProgrmacionSalida();
            }
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmReporteVehiculo FrmReporteVehiculo = new FrmReporteVehiculo();//no es importtante
                FrmListaConductores_Trabajadores FrmListaConductores_Trabajadores = new FrmListaConductores_Trabajadores();//no es importtante
                FrmReporteRuta frmReporteRuta = new FrmReporteRuta();//no es importtante
                EntProgramacionSalida pro = new EntProgramacionSalida();
                pro.IdProgramacionSalida = Convert.ToInt32(txtIdProgramacion.Text.Trim());
                pro.FechaInicio = dtFechaInicio.Value;
                pro.FechaFin = dtFechaFin.Value;
                pro.IdRuta = Convert.ToInt32(FrmReporteRuta.IdRuta.Trim());
                pro.IdConductor = Convert.ToInt32(FrmListaConductores_Trabajadores.id.Trim());
                pro.IdVehiculo = Convert.ToInt32(FrmReporteVehiculo.idVehiculo.Trim());

                LogProgramacionSalida.Instancia.EditarProgramacionSalida(pro);
            
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex);
            }
            ListarProgramacionSalida();
            LimpiarCampos();
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnRegistrar.Enabled = true;
            txtIdProgramacion.Enabled = false;
        }

        private void txtIdProgramacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
