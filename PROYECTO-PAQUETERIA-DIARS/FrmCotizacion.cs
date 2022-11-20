using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAPALOGICA;
using CAPAENTIDAD;

namespace PROYECTO_PAQUETERIA_DIARS
{
    public partial class FrmCotizacion : Form
    {
        public FrmCotizacion()
        {
            InitializeComponent();
            ListarCotizacion();
            ListarItemns();
            habiliatar();
            
        }
        public void ListarCotizacion()
        {
            DgvCotizacion.DataSource = LogCotizacion.Instancia.ListarCotizacion();
        }
        public void habiliatar()
        {
            //Botonesotones
            btnAñadir.Visible = false;
            btnBuscar.Enabled = true;
            btnEditar.Enabled = true;
            BtnActualizar.Visible = false;
            btnEliminar.Enabled = true;
            btnNuevo.Enabled = true;
            //txt
            txtCodcot.Enabled = true;
            txtDecripcion.Enabled = false;
            txtPrecio.Enabled = false;
            cbIdPedido.Enabled = false;
        }
        public void Inabilitar()
        {
            //Botonesotones
            btnAñadir.Visible = false;
            btnBuscar.Enabled = false;
            btnEditar.Enabled = false;
            BtnActualizar.Visible = false;
            btnEliminar.Enabled = false;
            btnNuevo.Enabled = false;
            //txt
            txtCodcot.Enabled = false;
            txtDecripcion.Enabled = true;
            txtPrecio.Enabled = true;
            cbIdPedido.Enabled = true;
        }
        private void Limpiar()
        {
            txtCodcot.Clear();
            txtDecripcion.Clear(); 
            txtPrecio.Clear();
            cbIdPedido.Text = " ";
        }
        private void SalirVentana_Click(object sender, EventArgs e)
        {
           
        }

        private void SalirVentana_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmCotizacion_Load(object sender, EventArgs e)
        {

        }
        private void ListarItemns()
        {
            cbIdPedido.DataSource=LogPedido.Instancia.ListarPedido();
            cbIdPedido.ValueMember = "IDPEDIDO";
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            EntCotizacion cot = new EntCotizacion();
            

            cot.Descripcion = txtDecripcion.Text.Trim();
            cot.precio=Convert.ToDouble(txtPrecio.Text.Trim());
            cot.IDPEDIDO = Convert.ToInt32(cbIdPedido.Text);
            LogCotizacion.Instancia.InsertaCotizacion(cot);
            habiliatar();
            Limpiar();
            ListarCotizacion();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {

                EntCotizacion cot = new EntCotizacion();
                
                cot.IdCotizacion = Convert.ToInt32(txtCodcot.Text.Trim());


                LogCotizacion.Instancia.Elimminar(cot);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex);
            }
            habiliatar();
            Limpiar();
            ListarCotizacion();
        }

        private void DgvCotizacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DgvCotizacion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = DgvCotizacion.Rows[e.RowIndex].Cells["IdCotizacion"].Value.ToString();
            txtCodcot.Text = id;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtCodcot.Text != "")
            {
                txtCodcot.Focus();
                EntCotizacion cot = new EntCotizacion();

                cot.IdCotizacion = Convert.ToInt32(txtCodcot.Text.Trim());

                DataTable dt = new DataTable();

                dt = LogCotizacion.Instancia.BuscarCotizacionId(cot.IdCotizacion);
                if (txtCodcot.Text != "")
                {
                    DgvCotizacion.DataSource = dt;
                }
                else
                {

                    DgvCotizacion.DataSource = LogCotizacion.Instancia.ListarCotizacion();
                }
                Limpiar();
            }
            else
            {
                ListarCotizacion();
            }
            habiliatar();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                EntCotizacion cot = new EntCotizacion();

                cot.IdCotizacion = Convert.ToInt32(txtCodcot.Text.Trim());
                cot.Descripcion = txtDecripcion.Text.Trim();
                cot.precio = Convert.ToDouble(txtPrecio.Text.Trim());
                cot.IDPEDIDO = Convert.ToInt32(cbIdPedido.Text);

                LogCotizacion.Instancia.EditarCotizacion(cot);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex);
            }
            Limpiar();
            habiliatar();
            ListarCotizacion();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            Inabilitar();
            btnAñadir.Visible = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
           
            Inabilitar();
            BtnActualizar.Visible = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            habiliatar();
        }

        private void txtCodcot_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void cbIdPedido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255)||e.KeyChar==46)
            {
                MessageBox.Show("Solo Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
