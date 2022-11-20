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

namespace PROYECTO_PAQUETERIA_DIARS
{
    public partial class FmrRegistroCheckList : Form
    {
        public FmrRegistroCheckList()
        {
            InitializeComponent();
            ListarCheck();
            Desactivar();

        }
        public void ListarCheck()
        {
            dgvCheckLista.DataSource = LogCheckList.Instancia.ListarCheckLista();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtIdCheck.Text != "")
            {
                txtIdCheck.Focus();
                EntCheckList D = new EntCheckList();

                D.IdCheck = Convert.ToInt32(txtIdCheck.Text.Trim());

                DataTable dt = new DataTable();

                dt = LogCheckList.Instancia.BuscarCheckId(D.IdCheck);
                if (txtIdCheck.Text != "")
                {
                    dgvCheckLista.DataSource = dt;
                }
                else
                {

                    dgvCheckLista.DataSource = LogCheckList.Instancia.ListarCheckLista();
                }

            }
            else
            {
                ListarCheck();
                MessageBox.Show("Ingrese un dato correcto", "", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            FrmListaConductores_Trabajadores FrmListaConductores_Trabajadores = new FrmListaConductores_Trabajadores();
            FrmListaConductores_Trabajadores.ShowDialog();
            txtChofer.Text = FrmListaConductores_Trabajadores.nombre;
        }

        private void btnSelVehiculo_Click(object sender, EventArgs e)
        {
            FrmReporteVehiculo FrmReporteVehiculo = new FrmReporteVehiculo();
            FrmReporteVehiculo.ShowDialog();
            txtvehiculo.Text = FrmReporteVehiculo.placa;
        }
        private void Limpiar()
        {
            txtIdCheck.Clear();
            txtHorometro.Clear();
            txtCombustible.Text = " ";
            txtChofer.Clear();
            txtInspeccion.Clear();
            txtKilometraje.Clear();
            txtvehiculo.Clear();


        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try { 
            FrmReporteVehiculo FrmReporteVehiculo = new FrmReporteVehiculo();
            FrmListaConductores_Trabajadores FrmListaConductores_Trabajadores = new FrmListaConductores_Trabajadores();
            EntCheckList check = new EntCheckList();

            check.FechaCheck = DtFecha.Value;
            check.Combustible = txtCombustible.Text.Trim();
            check.Horometro = txtHorometro.Text.Trim();
            check.Inspeccion = txtInspeccion.Text.Trim();
            check.Kilometraje = txtKilometraje.Text.Trim();
            check.IdVehiculo = Convert.ToInt32(FrmReporteVehiculo.idVehiculo.Trim());
            check.IdConductor = Convert.ToInt32(FrmListaConductores_Trabajadores.id.Trim());

            LogCheckList.Instancia.InsertaCheckList(check);
            Limpiar();
            Desactivar();
            ListarCheck();
            }
             catch (Exception)
            {
                MessageBox.Show("Llene todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvCheckLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string id = dgvCheckLista.Rows[e.RowIndex].Cells["IdCheck"].Value.ToString();
                txtIdCheck.Text = id;
            }
            catch (Exception)
            {
                MessageBox.Show("No permitido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmReporteVehiculo FrmReporteVehiculo = new FrmReporteVehiculo();
                FrmListaConductores_Trabajadores FrmListaConductores_Trabajadores = new FrmListaConductores_Trabajadores();
                EntCheckList check = new EntCheckList();
                //Veh.IdVehiculo=Convert.ToInt32(txtIdVehiculo.Text.Trim());
                check.IdCheck = Convert.ToInt32(txtIdCheck.Text.Trim());
                check.FechaCheck = DtFecha.Value;
                check.Combustible = txtCombustible.Text.Trim();
                check.Horometro = txtHorometro.Text.Trim();
                check.Inspeccion = txtInspeccion.Text.Trim();
                check.Kilometraje = txtKilometraje.Text.Trim();
                check.IdVehiculo = Convert.ToInt32(FrmReporteVehiculo.idVehiculo.Trim());
                check.IdConductor = Convert.ToInt32(FrmListaConductores_Trabajadores.id.Trim());

                LogCheckList.Instancia.EditarCheckLista(check);


            }
            catch (Exception )
            {
                MessageBox.Show("Llene todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Limpiar();
            ListarCheck();
            Desactivar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Activar();
            btnActualizar.Visible = true;
            btnRegistrar.Enabled = false;
        }
        private void Activar()
        {
            btnNuevo.Enabled = false;
            btnRegistrar.Enabled = true;
            btnBuscar.Enabled = false;
            btnEditar.Enabled = false;
            btnQuitar.Enabled = false;
            btnActualizar.Visible = false;
            btnSelConductor.Enabled = true;
            btnSelVehiculo.Enabled = true;
            //TEXBOX
            txtIdCheck.Enabled = false;
            txtHorometro.Enabled = true;
            txtChofer.Enabled = false;
            DtFecha.Enabled = true;
            txtCombustible.Enabled = true;
            txtvehiculo.Enabled = false;
            txtKilometraje.Enabled = true;
            txtInspeccion.Enabled = true;
        }
        private void Desactivar()
        {
            //BOTONES 
            btnNuevo.Enabled = true;
            btnRegistrar.Enabled = false;
            btnBuscar.Enabled = true;
            btnEditar.Enabled = true;
            btnActualizar.Visible = false;
            btnSelConductor.Enabled = false;
            btnSelVehiculo.Enabled = false;
            //TEXBOX
            txtIdCheck.Enabled = true;
            txtHorometro.Enabled = false;
            txtChofer.Enabled = false;
            DtFecha.Enabled = false;
            txtCombustible.Enabled = false;
            txtvehiculo.Enabled = false;
            txtKilometraje.Enabled = false;
            txtInspeccion.Enabled = false;
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (txtIdCheck.Text != "")
            {
                try
                {

                    EntCheckList check = new EntCheckList();
                    //Veh.IdVehiculo=Convert.ToInt32(txtIdVehiculo.Text.Trim());
                    check.IdCheck = Convert.ToInt32(txtIdCheck.Text.Trim());


                    LogCheckList.Instancia.Elimminar(check);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar: " + ex);
                }
                Limpiar();
                ListarCheck();
            }
            else
            {
                MessageBox.Show("Ingresa ID para poder realizar tu accion", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            //BOTONES 
            Activar();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            Desactivar();
            ListarCheck();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtIdCheck_TextChanged(object sender, EventArgs e)
        {

        }

        private void SalirVentana_Click(object sender, EventArgs e)
        {
            Close();
        }

                

        private void txtIdCheck_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            ListarCheck();
        }

        private void txtHorometro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtKilometraje_KeyPress(object sender, KeyPressEventArgs e)
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
