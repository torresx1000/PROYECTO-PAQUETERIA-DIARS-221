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
            txtIdLote.Enabled = true;
            ListarLote();
        }

        public void LimpiarVariables()
        {
            txtIdLote.Text = ("");
            txtNombres.Text = ("");
            txtProducto.Text = ("");
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
                lo.Nombres = txtNombres.Text.Trim();
                lo.Producto = txtProducto.Text.Trim();
                lo.Fecha = dtPickerFecha.Value;
                LogLote.Instancia.InsertarLote(lo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbDatosDelLote.Enabled = false;
            ListarLote();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbDatosDelLote.Enabled = true;
            btnAgregar.Visible = true;
            LimpiarVariables();
            btnModificar.Visible = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
        }

        private void btnEdita_Click(object sender, EventArgs e)
        {
            gbDatosDelLote.Enabled = true;
            btnModificar.Visible = true;
            btnAgregar.Visible = false;
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
            gbDatosDelLote.Enabled = false;
            ListarLote();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                EntLote lo = new EntLote();
                lo.IdLote = int.Parse(txtIdLote.Text.Trim());
                lo.Nombres = txtNombres.Text.Trim();
                lo.Producto = txtProducto.Text.Trim();
                lo.Fecha = dtPickerFecha.Value;               
                LogLote.Instancia.EditarLote(lo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbDatosDelLote.Enabled = false;
            ListarLote();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvLote_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvLote.Rows[e.RowIndex]; //
            txtIdLote.Text = filaActual.Cells[0].Value.ToString();
            txtNombres.Text = filaActual.Cells[1].Value.ToString();
            txtProducto.Text = filaActual.Cells[2].Value.ToString();
            dtPickerFecha.Text = filaActual.Cells[3].Value.ToString();           
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        /*private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtIdLote.Focus();
            int idlote = Convert.ToInt32(txtIdLote.Text.Trim());
            EntLote lo = LogLote.Instancia.BuscarLoteCodigo(idlote);
            if (lo != null && (lo.IdLote = true))
            {
                txtIdTrabajador.Text = Convert.ToString(Tra.Id_Trabajador);
                txtDni.Text = Convert.ToString(Tra.Dni);
                txtNombres.Text = Tra.Nombres.ToString();
                txtApellidoPaterno.Text = Tra.ApPaterno.ToString();
                txtApellidoMaterno.Text = Tra.ApMaterno.ToString();
                dtFechaNacimiento.Value = Convert.ToDateTime(Tra.FechaNac);
                txtSexo.Text = Tra.Sexo.ToString();
                cmbxEstadoCivil.Text = Tra.EstCivil.ToString();
                txtUbigeo.Text = Tra.Ubigeo.ToString();
                txtDireccion.Text = Tra.Direccion.ToString();
                txtDistrito.Text = Tra.Distrito.ToString();
                txtProvincia.Text = Tra.Provincia.ToString();
                txtDepartamento.Text = Tra.Departamento.ToString();
                dtFechaContrato.Value = Convert.ToDateTime(Tra.FechaContrato);
                txtUsuario.Text = Tra.Usuario.ToString();
                txtClave.Text = Tra.Password.ToString();
                txtCargo.Text = Tra.Cargo.ToString();
                cbEstadoTrabajador.Checked = Convert.ToBoolean(Tra.EstadoTrabajador);
                System.IO.MemoryStream ms = new System.IO.MemoryStream(Tra.PerfilTrabajador);//para convertir a imagen
                pbPerfilTrabajador.Image = System.Drawing.Bitmap.FromStream(ms);
            }
            else
            {
                MessageBox.Show("El Trabajdor no existe , verifique.", "Trabajador: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            btnBuscar.Enabled = true;
            btnAgregar.Enabled = false;
        }*/
    }
}
