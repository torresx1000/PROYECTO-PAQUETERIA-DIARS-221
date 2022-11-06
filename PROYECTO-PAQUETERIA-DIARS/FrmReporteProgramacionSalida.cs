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
    public partial class FrmReporteProgramacionSalida : Form
    {
        public static string IdPS;
        public FrmReporteProgramacionSalida()
        {
            InitializeComponent();
            ListarProgramacionSalida();
        }
        public void ListarProgramacionSalida() {
            dgvPS.DataSource = LogProgramacionSalida.Instancia.ListarProgrmacionSalida();
        }

        private void txtItem_TextChanged(object sender, EventArgs e)
        {
            txtItem.Focus();
            EntProgramacionSalida pro = new EntProgramacionSalida();
            pro.IdProgramacionSalida = Convert.ToInt32(txtItem.Text);
            DataTable dt = new DataTable();
            dt = LogProgramacionSalida.Instancia.BuscarProgramacion(pro.IdProgramacionSalida);
            if (txtItem.Text != "")
            {
                dgvPS.DataSource = dt;
            }
            else
            {

                dgvPS.DataSource = LogProgramacionSalida.Instancia.ListarProgrmacionSalida();
            }
        }

        private void dgvPS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IdPS = dgvPS.Rows[e.RowIndex].Cells["IdProgramacionSalida"].Value.ToString();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (IdPS == null)
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
