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
    public partial class FrmReportePlanilla : Form
    {
        public static string id;
        public FrmReportePlanilla()
        {
            InitializeComponent();
            ListarPlanilla();
        }

        public void ListarPlanilla() {
            dgvPlanilla.DataSource = LogPlanilla.Instancia.ListarPlanilla();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (id == null)
            {
                MessageBox.Show("Seleccione una fila", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                Close();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPlanilla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id=dgvPlanilla.Rows[e.RowIndex].Cells["IdPlanilla"].Value.ToString();
        }
    }
}
