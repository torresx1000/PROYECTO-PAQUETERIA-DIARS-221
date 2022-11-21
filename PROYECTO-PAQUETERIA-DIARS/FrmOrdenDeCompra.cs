using CAPADATOS;
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
    public partial class FrmOrdenDeCompra : Form
    {
        public FrmOrdenDeCompra()
        {
            InitializeComponent();
            ListarOrdenCompra();    
            btnAñadir.Enabled= false;
            btnActualizar.Enabled= false;
            btnEliminar.Enabled= false;
            btnBuscar.Enabled= true;
        }
        public void Limpiarxd() {
            txtCodigo.Text = "";
            txtIdListas.Text = "";
            txtfirma.Text = "";
            txtDescripocion.Text = "";
           // dtpFechaOrden.Value;
        }
        public void ListarOrdenCompra() {
            dataGridView1.DataSource = LogOrdenCompra.Instancia.ListarOrdenCompra();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                EntOrdenDeCompra ordenDeCompra = new EntOrdenDeCompra();
                ordenDeCompra.IdLista = Convert.ToInt32(txtIdListas.Text.Trim());
                ordenDeCompra.FirmaNom = txtfirma.Text.Trim();
                ordenDeCompra.Descripcion = txtDescripocion.Text.Trim();
                ordenDeCompra.Fecha = dtpFechaOrden.Value;

                LogOrdenCompra.Instancia.InsertarOrdenCompra(ordenDeCompra);
                ListarOrdenCompra();
                Limpiarxd();
                btnAñadir.Enabled = false;
                btnActualizar.Enabled = false;
                btnEliminar.Enabled = false;
                btnBuscar.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Llene todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

            private void btnSeleccionarAutoriza_Click(object sender, EventArgs e)
        {

        }

        private void btnSeleccionarListaRepuesto_Click(object sender, EventArgs e)
        {
            FrmReporteListaRepuesto frmReporteListaRepuesto = new FrmReporteListaRepuesto();
            frmReporteListaRepuesto.ShowDialog();
            txtIdListas.Text = FrmReporteListaRepuesto.IdLista;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                EntOrdenDeCompra ordenDeCompra = new EntOrdenDeCompra();
                ordenDeCompra.Codigo= Convert.ToInt32(txtCodigo.Text.Trim());
                ordenDeCompra.IdLista = Convert.ToInt32(txtIdListas.Text.Trim());
                ordenDeCompra.FirmaNom = txtfirma.Text.Trim();
                ordenDeCompra.Descripcion = txtDescripocion.Text.Trim();
                ordenDeCompra.Fecha = dtpFechaOrden.Value;

                LogOrdenCompra.Instancia.EditarOrdenCompra(ordenDeCompra);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex);
            }
           
            ListarOrdenCompra();
            Limpiarxd();
            btnAñadir.Enabled = false;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
            btnBuscar.Enabled = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtCodigo.Focus();
            int codigo = Convert.ToInt32(txtCodigo.Text.Trim());
            EntOrdenDeCompra Rut = LogOrdenCompra.Instancia.BuscarOrdenCompraId(codigo);
            if (Rut != null)
            {
                txtCodigo.Text = Convert.ToString(Rut.Codigo);
                txtIdListas.Text = Convert.ToString(Rut.IdLista);
                txtfirma.Text = Rut.FirmaNom.ToString();
                txtDescripocion.Text = Rut.Descripcion.ToString();
                dtpFechaOrden.Value = Convert.ToDateTime(Rut.Fecha);
            }
            else
            {
                MessageBox.Show("La orden de compa no existe or esta inhabilitado, verifique.", "Trabajador: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            btnAñadir.Enabled = false;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
            btnBuscar.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                EntOrdenDeCompra Rut = new EntOrdenDeCompra();
                Rut.Codigo = int.Parse(txtCodigo.Text.Trim());
                LogOrdenCompra.Instancia.EliminarOrdenCompra(Rut);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            ListarOrdenCompra();
            Limpiarxd();
            btnAñadir.Enabled = false;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
            btnBuscar.Enabled = true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnAñadir.Enabled = true;
            btnBuscar.Enabled = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiarxd();
            btnAñadir.Enabled = false;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
            btnBuscar.Enabled = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string id = dataGridView1.Rows[e.RowIndex].Cells["Codigo"].Value.ToString();
                txtCodigo.Text = id;
            }
            catch (Exception)
            {
                MessageBox.Show("No permitido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
