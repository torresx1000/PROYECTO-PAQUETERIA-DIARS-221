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
    public partial class FrmReporteListaRepuesto : Form
    {
        public static string IdLista;
        public FrmReporteListaRepuesto()
        {
            InitializeComponent();
            ListarListaRepuesto();
        }
        public void ListarListaRepuesto()
        {
            dgvListaRepuesto.DataSource = LogListarRepuestos.Instancia.ListarRepuesto();
        }

        private void txtItem_TextChanged(object sender, EventArgs e)
        {
            txtItem.Focus();
            EntListaRespuesto rut = new EntListaRespuesto();
            rut.Codigo = Convert.ToInt32(txtItem.Text);
            DataTable dt = new DataTable();
            dt = LogListarRepuestos.Instancia.BuscarListaRepuesto(rut.Codigo);
            if (txtItem.Text != "")
            {
                dgvListaRepuesto.DataSource = dt;
            }
            else
            {
                dgvListaRepuesto.DataSource = LogListarRepuestos.Instancia.ListarRepuesto();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvListaRepuesto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                IdLista = dgvListaRepuesto.Rows[e.RowIndex].Cells["Codigo"].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("No es perminito", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (IdLista == null)
            {
                MessageBox.Show("Seleccione una fila", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                Close();
            }
        }
    }
}
