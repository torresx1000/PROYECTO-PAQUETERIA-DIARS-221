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
            Desabilitar();
            
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
                MessageBox.Show("Ingresa ID valido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIdProgramacion.Clear();
            }
            ListarProgramacionSalida();
            LimpiarCampos();
            Desabilitar();
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
            try
            {
                FrmReporteVehiculo FrmReporteVehiculo = new FrmReporteVehiculo();//no es importtante
                FrmListaConductores_Trabajadores FrmListaConductores_Trabajadores = new FrmListaConductores_Trabajadores();//no es importtante
                FrmReporteRuta frmReporteRuta = new FrmReporteRuta();//no es importtante
                EntProgramacionSalida pro = new EntProgramacionSalida();
                //pro.IdProgramacionSalida = Convert.ToInt32(txtIdProgramacion.Text.Trim());
                if (txtIdProgramacion.Text != "")
                {
                    MessageBox.Show("El id lo gestiona el sistema");

                    txtIdProgramacion.Clear();

                }
                pro.FechaInicio = dtFechaInicio.Value;
                pro.FechaFin = dtFechaFin.Value;
                pro.IdRuta = Convert.ToInt32(FrmReporteRuta.IdRuta.Trim());
                pro.IdConductor = Convert.ToInt32(FrmListaConductores_Trabajadores.id.Trim());
                pro.IdVehiculo = Convert.ToInt32(FrmReporteVehiculo.idVehiculo.Trim());
                LogProgramacionSalida.Instancia.InsertarProgramacioSalida(pro);
                ListarProgramacionSalida();
                LimpiarCampos();
                Desabilitar();
            }
            catch (Exception)
            {
                MessageBox.Show("Llene todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           try
            {

                txtIdProgramacion.Focus();
                EntProgramacionSalida pro = new EntProgramacionSalida();
                pro.IdProgramacionSalida = Convert.ToInt32(txtIdProgramacion.Text);
                DataTable dt = new DataTable();
                dt = LogProgramacionSalida.Instancia.BuscarProgramacion(pro.IdProgramacionSalida);
                if (txtIdProgramacion.Text != "")
                {
                    dataGridViewProgramacion.DataSource = dt;
                }
                else
                {

                    dataGridViewProgramacion.DataSource = LogProgramacionSalida.Instancia.ListarProgrmacionSalida();
                }
                Desabilitar();
            }
            catch (Exception)
            {
                ListarProgramacionSalida();
                MessageBox.Show("Ingrese un dato correcto", "", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
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
            catch (Exception )
            {
                MessageBox.Show("Llene todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            habilitar();
            LimpiarCampos();
        }
        private void habilitar (){
            btnRegistrar.Enabled = true;
            btnNuevo.Enabled = false;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
            btnEditar.Enabled = false;
            selcon.Enabled = true;
            selplaca.Enabled = true;
            selrut.Enabled = true;

            txtIdProgramacion.Enabled = false;
            dtFechaInicio.Enabled = true;
            dtFechaFin.Enabled = true;
            txtRuta.Enabled = false;
            txtConductor.Enabled = false;
            txtVehiculo.Enabled = false;

        }
        private void Desabilitar()
        {
            btnRegistrar.Enabled = false;
            btnNuevo.Enabled = true;
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = true;
            btnEditar.Enabled = true;
            selcon.Enabled = false;
            selplaca.Enabled = false;
            selrut.Enabled = false;

            txtIdProgramacion.Enabled = true;
            dtFechaInicio.Enabled = false;
            dtFechaFin.Enabled = false;
            txtRuta.Enabled = false;
            txtConductor.Enabled = false;
            txtVehiculo.Enabled = false;

        }
        private void txtIdProgramacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
             
            }
            ListarProgramacionSalida();
        }

        private void SalirVentana_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmProgramacionSalida_Load(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtIdProgramacion.Text == "")
            {
                MessageBox.Show("Ingresa id para completar la accion");
                Desabilitar();

            }
            else
            {
                habilitar();
                btnRegistrar.Enabled = false;
                btnActualizar.Enabled = true;
            }
        }

        private void dataGridViewProgramacion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string id = dataGridViewProgramacion.Rows[e.RowIndex].Cells["IdGastosdeViaje"].Value.ToString();
                txtConductor.Text = id;
            }
            catch (Exception)
            {
                MessageBox.Show("No permitido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
