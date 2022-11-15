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
    public partial class FrmReporteLote : Form
    {
        public static string IdLote;
        public FrmReporteLote()
        {
            InitializeComponent();
            ListarLote();
        }
        public void ListarLote()
        {
            dgvLote.DataSource = LogLote.Instancia.ListarLote();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (IdLote == null)
            {
                MessageBox.Show("Seleccione una fila", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                Close();
            }
        }

        private void dgvLote_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IdLote = dgvLote.Rows[e.RowIndex].Cells["IdLote"].Value.ToString();
        }

        private void txtItem_TextChanged(object sender, EventArgs e)
        {
            txtItem.Focus();
            EntLote rut = new EntLote();
            rut.IdLote = Convert.ToInt32(txtItem.Text);
            DataTable dt = new DataTable();
            dt = LogLote.Instancia.BuscarLoteCodigo(rut.IdLote);
            if (txtItem.Text != "" && (rut.EstadoLote = true))
            {
                dgvLote.DataSource = dt;
            }
            else
            {

                dgvLote.DataSource = LogLote.Instancia.ListarLote();
            }
        }
    }
}
