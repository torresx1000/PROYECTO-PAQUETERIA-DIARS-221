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
    public partial class FrmListaDeRepuestos : Form
    {
        public FrmListaDeRepuestos()
        {
            InitializeComponent();
            ListarListaRepuestos();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmReporteDiagnostico frmReporteDiagnostico = new FrmReporteDiagnostico();
            frmReporteDiagnostico.ShowDialog();
            txtdiagnostico.Text = FrmReporteDiagnostico.IdDiagnostico;
        }
        public void ListarListaRepuestos()
        {
            dgvlistarespuestos.DataSource = LogListarRepuestos.Instancia.ListarRepuesto();
        }
        private void btnañadir_Click(object sender, EventArgs e)
        {
            EntListaRespuesto lis = new EntListaRespuesto();

            lis.idDiagnostico = Convert.ToInt32(txtdiagnostico);
            lis.Fecha = dtFecha.Value;
            lis.DescripcionRepuestos = txtdescripcionrespuestos.Text.Trim();
            
            LogListarRepuestos.Instancia.InsertaListaRepuesto(lis);
         
            ListarListaRepuestos();
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {

                EntListaRespuesto lis = new EntListaRespuesto();
                //Veh.IdVehiculo=Convert.ToInt32(txtIdVehiculo.Text.Trim());
                lis.Codigo = Convert.ToInt32(txtcodigolista.Text.Trim());


                LogListarRepuestos.Instancia.Elimminar(lis);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex);
            }
            
            ListarListaRepuestos();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (txtcodigolista.Text != "")
            {
                txtcodigolista.Focus();
                EntListaRespuesto D = new EntListaRespuesto();

                D.Codigo = Convert.ToInt32(txtcodigolista.Text.Trim());

                DataTable dt = new DataTable();

                dt = LogListarRepuestos.Instancia.BuscarListaRepuesto(D.Codigo);
                if (txtcodigolista.Text != "")
                {
                    dgvlistarespuestos.DataSource = dt;
                }
                else
                {

                    dgvlistarespuestos.DataSource = LogListarRepuestos.Instancia.ListarRepuesto();
                }
            }
            else
            {
                ListarListaRepuestos();

            }
        }
    }
}
