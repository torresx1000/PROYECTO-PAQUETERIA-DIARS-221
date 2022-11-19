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
                Limpiar();
            }
            else
            {
                ListarCheck();
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

        private void dgvCheckLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dgvCheckLista.Rows[e.RowIndex].Cells["IdCheck"].Value.ToString();
            txtIdCheck.Text = id;
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
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex);
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
            txtChofer.Enabled = true;
            DtFecha.Enabled = true;
            txtCombustible.Enabled = true;
            txtvehiculo.Enabled = true;
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
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtIdCheck_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
