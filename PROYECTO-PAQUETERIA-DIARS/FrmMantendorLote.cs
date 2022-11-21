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
            
            ListarLote();
            Desabilitar();


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
                if (txtIdLote.Text != "")
                {
                    MessageBox.Show("El id lo gestiona el sistema");

                    txtIdLote.Clear();

                }
                EntLote lo = new EntLote();               
                lo.Identificador = txtNombres.Text.Trim();
                lo.EstadoLote = cbestado.Checked;
                lo.Fecha = dtPickerFecha.Value;
                LogLote.Instancia.InsertarLote(lo);
            }
            catch (Exception)
            {
                MessageBox.Show("Llene todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Limpiar();
            ListarLote();
            Desabilitar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            Habilitar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            Desabilitar();
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
                MessageBox.Show("Ingresa ID valido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Limpiar();
            ListarLote();
            Desabilitar();
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
            Limpiar();
            Desabilitar();
            ListarLote();
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Habilitar()
        {
            txtIdLote.Enabled = false;
            txtNombres.Enabled = true;
            cbestado.Enabled = true;

            btnAgregar.Enabled = true;
            btnBuscar.Enabled = false;
            btnEliminar.Enabled = false;
            btnLimpiar.Enabled = true;
            btnModificar.Enabled = false;
            btnNuevo.Enabled = false; 
            btnEditar.Enabled = false;
            dtPickerFecha.Enabled = true;  

        }
        private void Desabilitar()
        {
            txtIdLote.Enabled = true;
            txtNombres.Enabled = false;
            cbestado.Enabled = false;

            btnAgregar.Enabled = false;
            btnBuscar.Enabled = true;
            btnEliminar.Enabled = true;
            btnLimpiar.Enabled = true;
            btnModificar.Enabled = false;
            btnNuevo.Enabled = true;
            btnEditar.Enabled = true;
            dtPickerFecha.Enabled = false;

        }
        private void Limpiar()
        {
            txtIdLote.Clear();
            txtNombres.Clear();
            cbestado.Checked = false;

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
                MessageBox.Show("Ingrese un dato correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                ListarLote();

            }
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true; 
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtIdLote_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) /*|| (e.KeyChar >= 45 && e.KeyChar <= 47)*/ || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Numeros Y un (.)permitidos ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            ListarLote();

        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) /*|| (e.KeyChar >= 45 && e.KeyChar <= 47)*/ || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Numeros Y un (.)permitidos ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtIdLote.Text == "")
            {
                MessageBox.Show("Ingresa id para completar la accion");
                Desabilitar();

            }
            else
            {

             
            
            Habilitar();
            btnAgregar.Enabled = false;
            btnModificar.Enabled = true;
            }
        }

        private void dgvLote_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string id = dgvLote.Rows[e.RowIndex].Cells["IdLote"].Value.ToString();
                txtIdLote.Text = id;
            }
            catch (Exception)
            {
                MessageBox.Show("No permitido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
