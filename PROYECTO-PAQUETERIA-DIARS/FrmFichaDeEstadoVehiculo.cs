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

namespace PROYECTO_PAQUETERIA_DIARS
{
    public partial class FrmFichaDeEstadoVehiculo : Form
    {
        public FrmFichaDeEstadoVehiculo()
        {
            InitializeComponent();
            ListarFichaEstado();
            inabilitar();
        }
        public void Limpiar()
        {
            //TEXBOX

            txtconductor.Clear();
            txtestadodevehiculo.Clear();    
            txtlatoneriaypintura.Clear();
            txtotros.Clear();
            txtsistemaelectrico.Clear();
            txtsistemamecanico.Clear();
            txtvehiculo.Clear();
        }
        public void inabilitar()
        {
            //BOTONES
            btnbuscar.Enabled = true;
            btnlimpiar.Enabled = true;
            btnNuenvo.Enabled = true;
            btnquitar.Enabled = true;
            btnregistrar.Enabled = false;
            btnseleccionarconductor.Enabled = false;
            btnseleccionarvehiculo.Enabled = false;
            //TEXBOX

            txtconductor.Enabled = false;
            txtestadodevehiculo.Enabled = true;
            txtlatoneriaypintura.Enabled = false;
            txtotros.Enabled = false;
            txtsistemaelectrico.Enabled = false;
            txtsistemamecanico.Enabled = false;
            txtvehiculo.Enabled = false;
            dtpfecha.Enabled = false;

        }
        public void habilitar()
        {
            //BOTONES
            btnbuscar.Enabled = false;
            btnlimpiar.Enabled = true;
            btnNuenvo.Enabled = false;
            btnquitar.Enabled = false;
            btnregistrar.Enabled = true;
            btnseleccionarconductor.Enabled = true;
            btnseleccionarvehiculo.Enabled = true;
            //TEXBOX

            txtconductor.Enabled = false;
            txtestadodevehiculo.Enabled = false;
            txtlatoneriaypintura.Enabled = true;
            txtotros.Enabled = true;
            txtsistemaelectrico.Enabled = true;
            txtsistemamecanico.Enabled = true;
            txtvehiculo.Enabled = false;
            dtpfecha.Enabled = true;

        }
        public void ListarFichaEstado() {
            dgvfichadeestado.DataSource = LogFichaDeEstadoVehiculo.Instancia.ListarFichaDeViaje();
        }
        private void btnregistrar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmReporteVehiculo FrmReporteVehiculo = new FrmReporteVehiculo();
                FrmListaConductores_Trabajadores FrmListaConductores_Trabajadores = new FrmListaConductores_Trabajadores();
                EntFichaDeEstadoVehiculo fich = new EntFichaDeEstadoVehiculo();

                fich.Conductor = Convert.ToInt32(FrmListaConductores_Trabajadores.id);
                fich.Vehiculo = Convert.ToInt32(FrmReporteVehiculo.idVehiculo.Trim());
                fich.Fecha = dtpfecha.Value;
                fich.SistemaElectrico = txtsistemaelectrico.Text.Trim();
                fich.SistemaMecanico = txtsistemamecanico.Text.Trim();
                fich.LetoneriayPintura = txtlatoneriaypintura.Text.Trim();
                fich.Otros = txtotros.Text.Trim();

                LogFichaDeEstadoVehiculo.Instancia.InsertaFichaDeEstadoVehiculo(fich);
                ListarFichaEstado();
                Limpiar();
                inabilitar();
            }
            catch (Exception)
            {
                MessageBox.Show("Ingresa ID para poder realizar tu accion", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnseleccionarconductor_Click(object sender, EventArgs e)
        {
            FrmListaConductores_Trabajadores FrmListaConductores_Trabajadores = new FrmListaConductores_Trabajadores();
            FrmListaConductores_Trabajadores.ShowDialog();
            txtconductor.Text = FrmListaConductores_Trabajadores.nombre;
        }

        private void btnseleccionarvehiculo_Click(object sender, EventArgs e)
        {
            FrmReporteVehiculo FrmReporteVehiculo = new FrmReporteVehiculo();
            FrmReporteVehiculo.ShowDialog();
            txtvehiculo.Text = FrmReporteVehiculo.placa;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void SalirVentana_Click(object sender, EventArgs e)
        {
            Close();    
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (txtestadodevehiculo.Text != "")
            {
                txtestadodevehiculo.Focus();
                EntFichaDeEstadoVehiculo D = new EntFichaDeEstadoVehiculo();

                D.IdEstadoVehiculo= Convert.ToInt32(txtestadodevehiculo.Text.Trim());

                DataTable dt = new DataTable();

                dt = LogFichaDeEstadoVehiculo.Instancia.BuscarFichaDeEstadoVehicular(D.IdEstadoVehiculo);
                if (txtestadodevehiculo.Text != "")
                {
                    dgvfichadeestado.DataSource = dt;
                }
                else
                {

                    dgvfichadeestado.DataSource = LogDiagnostico.Instancia.ListarDiagnostico();
                }
                
                inabilitar();
                
            }
            else
            {
                ListarFichaEstado();

            }

        }

        private void btnquitar_Click(object sender, EventArgs e)
        {
            if (txtestadodevehiculo.Text==" ") 
            { 

            try
            {

                EntFichaDeEstadoVehiculo D = new EntFichaDeEstadoVehiculo();

                D.IdEstadoVehiculo = Convert.ToInt32(txtestadodevehiculo.Text.Trim());


                LogFichaDeEstadoVehiculo.Instancia.Elimminar(D);

            }
            catch (Exception )
            {
                MessageBox.Show("Ingresa ID para poder realizar tu accion", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            ListarFichaEstado();
            Limpiar();
            inabilitar();
            }
            else
            {
                MessageBox.Show("Ingresa ID valido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtestadodevehiculo.Clear();
            }
}

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            inabilitar();
        }

        private void btnNuenvo_Click(object sender, EventArgs e)
        {
            Limpiar();
            habilitar();
        }

        private void dgvfichadeestado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string id = dgvfichadeestado.Rows[e.RowIndex].Cells["IdEstadoVehiculo"].Value.ToString();
                txtestadodevehiculo.Text = id;
            }
            catch
            {
                MessageBox.Show("Opcion no permitida", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txtestadodevehiculo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            ListarFichaEstado();
        }
    }
}
