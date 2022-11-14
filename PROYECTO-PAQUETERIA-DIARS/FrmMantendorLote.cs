using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAPAENTIDAD;
using CAPALOGICA;

namespace PROYECTO_PAQUETERIA_DIARS
{
    public partial class FrmMantendorLote : Form
    {
        public FrmMantendorLote()
        {
            InitializeComponent();
            gbDatosDelLote.Enabled = true;
            ListarLote();
            btnAgregar.Enabled=false;
            btnModificar.Enabled=false;
            btnEliminar.Enabled=false;
        }

        public void LimpiarVariables()
        {
            txtIdLote.Text = ("");
            txtNombres.Text = ("");
            cbestado.Checked = false;
            dtPickerFecha.Text = ("");                      
        }

        public void ListarLote()
        {
            dgvLote.DataSource = LogLote.Instancia.ListarLote();

        }

        //Agregar Lote
        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                EntLote lo = new EntLote();               
                lo.Identificador = txtNombres.Text.Trim();
                lo.EstadoLote = cbestado.Checked;
                lo.Fecha = dtPickerFecha.Value;
                LogLote.Instancia.InsertarLote(lo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            ListarLote();
            btnAgregar.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnBuscar.Enabled = true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnAgregar.Enabled = true;
            txtIdLote.Enabled= false;
            btnBuscar.Enabled = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
        }

        private void btnEdita_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                EntLote lo = new EntLote();
                //int IdLote = int.Parse(txtIdLote.Text.Trim());                
                lo.IdLote = Convert.ToInt32(txtIdLote.Text.Trim());
                LogLote.Instancia.EliminarLote(lo);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            ListarLote();
            btnAgregar.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnBuscar.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                EntLote lo = new EntLote();
                lo.IdLote = int.Parse(txtIdLote.Text.Trim());
                lo.Identificador = txtNombres.Text.Trim();
                lo.EstadoLote = cbestado.Checked;
                lo.Fecha = dtPickerFecha.Value;
                LogLote.Instancia.EditarLote(lo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            ListarLote();
            btnAgregar.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnBuscar.Enabled = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvLote_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvLote.Rows[e.RowIndex]; //
            txtIdLote.Text = filaActual.Cells[0].Value.ToString();
            txtNombres.Text = filaActual.Cells[1].Value.ToString();
            string est = filaActual.Cells[2].Value.ToString();//para tomar el dato de la tabla ya que asi nomas no se deja xd
            cbestado.Checked = Convert.ToBoolean(est);
            dtPickerFecha.Text = filaActual.Cells[3].Value.ToString();           
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtIdLote.Text != "")
            {
                txtIdLote.Focus();
                EntLote D = new EntLote();

                D.IdLote = Convert.ToInt32(txtIdLote.Text.Trim());

                DataTable dt = new DataTable();

                dt = LogLote.Instancia.BuscarLoteCodigo(D.IdLote);
                if (txtIdLote.Text != "")
                {
                    dgvLote.DataSource = dt;
                }
                else
                {

                    dgvLote.DataSource = LogLote.Instancia. ListarLote();
                }

            }
            else
            {
                ListarLote();

            }
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true; 
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        
    }
}
