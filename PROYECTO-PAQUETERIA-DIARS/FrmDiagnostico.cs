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
    public partial class FrmDiagnostico : Form
    {
        
        public FrmDiagnostico()
        {
            InitializeComponent();
            ListarDiagnostico();
            btAñadir.Visible = false;
            txtIdDiagnostico.Enabled = true;
            txtObservacion.Enabled = false;
            txtFallas.Enabled = false;
            txtFechaDiagnostico.Enabled=false;
            btnSeleccionar.Visible = true;
            btnSelVehiculo.Visible = true;
            btnEditar.Visible = false;
            btnSeleccionar.Enabled = false;
            btnSelVehiculo.Enabled = false;
            btnnuevoo.Visible = true;

            
        }
        public void ListarDiagnostico()
        {
            dataGridView1.DataSource = LogDiagnostico.Instancia.ListarDiagnostico();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            
            FrmReporteVehiculo FrmReporteVehiculo = new FrmReporteVehiculo();
            FrmListaConductores_Trabajadores FrmListaConductores_Trabajadores = new FrmListaConductores_Trabajadores();
            EntDiagnostico Diag = new EntDiagnostico();
            //Veh.IdVehiculo=Convert.ToInt32(txtIdVehiculo.Text.Trim());
            
            Diag.Observaciones=txtObservacion.Text.Trim();
            Diag.Fallas=txtFallas.Text;
            Diag.IdVehiculo = Convert.ToInt32(FrmReporteVehiculo.idVehiculo.Trim());
            Diag.fecha = txtFechaDiagnostico.Value;
            Diag.IdConductor = Convert.ToInt32(FrmListaConductores_Trabajadores.id.Trim());

            LogDiagnostico.Instancia.InsertaDiagnostico(Diag);


            btAñadir.Visible = false;
            txtIdDiagnostico.Enabled = true;
            txtObservacion.Enabled = false;
            txtFallas.Enabled = false;
            txtFechaDiagnostico.Enabled = false;
            btnSeleccionar.Enabled = false;
            btnSelVehiculo.Enabled = false;
            btnNuevo.Visible = true;
            button1.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            btnnuevoo.Visible = true;
            Limpiar();
            ListarDiagnostico();

        }
        private DataGridView producto;

        public DataGridView Producto { get => producto; set => producto = value; }
        public void dt_producto()
        {
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            FrmListaConductores_Trabajadores FrmListaConductores_Trabajadores = new FrmListaConductores_Trabajadores();
            FrmListaConductores_Trabajadores.ShowDialog();
            TxtnombreConductor.Text= FrmListaConductores_Trabajadores.nombre;

        }

        private void btnSelVehiculo_Click(object sender, EventArgs e)
        {
            FrmReporteVehiculo FrmReporteVehiculo = new FrmReporteVehiculo();
            FrmReporteVehiculo.ShowDialog();
            txtColor.Text = FrmReporteVehiculo.Color;
            txtModelo.Text= FrmReporteVehiculo.Modelo;
            txtPlaca.Text = FrmReporteVehiculo.placa;




        }

        private void SalirVentana_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtnombreConductor_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            btAñadir.Visible = false;
            txtIdDiagnostico.Enabled = false;
            txtObservacion.Enabled = true;
            txtFallas.Enabled = true;
            txtFechaDiagnostico.Enabled = true;
            btnSeleccionar.Enabled = true;
            btnSelVehiculo.Enabled = true;
            btnnuevoo.Visible = false;
            button1.Visible = false;
            button7.Visible = false;
            btnELIMINAR.Visible = false;
            btnEditar.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (txtIdDiagnostico.Text != "")
            {
                txtIdDiagnostico.Focus();
                EntDiagnostico D = new EntDiagnostico();

                D.IdDiagnostico = Convert.ToInt32(txtIdDiagnostico.Text.Trim());

                DataTable dt = new DataTable();

                dt = LogDiagnostico.Instancia.BuscarDiagnosticoId(D.IdDiagnostico);
                if (txtIdDiagnostico.Text != "")
                {
                    dataGridView1.DataSource = dt;
                }
                else
                {

                    dataGridView1.DataSource = LogDiagnostico.Instancia.ListarDiagnostico();
                }
                Limpiar();
            }
            else
            {
                ListarDiagnostico();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                FrmReporteVehiculo FrmReporteVehiculo = new FrmReporteVehiculo();
                FrmListaConductores_Trabajadores FrmListaConductores_Trabajadores = new FrmListaConductores_Trabajadores();
                EntDiagnostico Diag = new EntDiagnostico();
                //Veh.IdVehiculo=Convert.ToInt32(txtIdVehiculo.Text.Trim());
                Diag.IdDiagnostico = Convert.ToInt32(txtIdDiagnostico.Text.Trim()); 
                Diag.Observaciones = txtObservacion.Text.Trim();
                Diag.Fallas = txtFallas.Text;
                Diag.IdVehiculo = Convert.ToInt32(FrmReporteVehiculo.idVehiculo.Trim());
                Diag.fecha = txtFechaDiagnostico.Value;
                Diag.IdConductor = Convert.ToInt32(FrmListaConductores_Trabajadores.id.Trim());

                LogDiagnostico.Instancia.EditarDiagnostico(Diag);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex);
            }
            btAñadir.Visible = false;
            txtIdDiagnostico.Enabled = true;
            txtObservacion.Enabled = false;
            txtFallas.Enabled = false;
            txtFechaDiagnostico.Enabled = false;
            btnSeleccionar.Enabled = false;
            btnSelVehiculo.Enabled = false;
            btnNuevo.Visible = true;
            button1.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            btnnuevoo.Visible = true;
            btnEditar.Visible=false;
            Limpiar();
            ListarDiagnostico();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
           
                EntDiagnostico Diag = new EntDiagnostico();
                //Veh.IdVehiculo=Convert.ToInt32(txtIdVehiculo.Text.Trim());
                Diag.IdDiagnostico = Convert.ToInt32(txtIdDiagnostico.Text.Trim());
           

                LogDiagnostico.Instancia.Elimminar(Diag);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex);
            }
            ListarDiagnostico();
            Limpiar();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Limpiar();
            btAñadir.Visible = true;
            txtIdDiagnostico.Enabled = false;
            txtObservacion.Enabled = true;
            txtFallas.Enabled = true;
            txtFechaDiagnostico.Enabled = true;
            btnSeleccionar.Enabled = true;
            btnSelVehiculo.Enabled = true;
            btnnuevoo.Visible = false;
            button1.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            btnELIMINAR.Visible = false;
            btnEditar.Visible = false;


        }
        private void Limpiar()
        {
            txtIdDiagnostico.Clear();
            txtColor.Clear();
            txtFallas.Clear();
            txtModelo.Clear();
            txtObservacion.Clear();
            txtPlaca.Clear();
            TxtnombreConductor.Clear();
            btnEditar.Visible = false;


        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            btAñadir.Visible = false;
            txtIdDiagnostico.Enabled = true;
            txtObservacion.Enabled = false;
            txtFallas.Enabled = false;
            txtFechaDiagnostico.Enabled = false;
            btnSeleccionar.Enabled = false;
            btnSelVehiculo.Enabled = false;
            btnNuevo.Visible = true;
            button1.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            btnnuevoo.Visible = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.Rows[e.RowIndex].Cells["IdDiagnostico"].Value.ToString();
            txtIdDiagnostico.Text = id;

        }
    }
}
