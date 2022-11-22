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
    public partial class FrmReporteDiagnostico : Form
    {
        public static string IdDiagnostico;
        public FrmReporteDiagnostico()
        {
            InitializeComponent();
            ListarDiagnostico();
        }
        public void ListarDiagnostico()
        {
            dgvDiagnostico.DataSource = LogDiagnostico.Instancia.ListarDiagnostico();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (IdDiagnostico == null)
            {
                MessageBox.Show("Seleccione una fila", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                Close();
            }
        }

        private void dgvDiagnostico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                IdDiagnostico = dgvDiagnostico.Rows[e.RowIndex].Cells["IDdIAGNOSTICO"].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("No es perminito", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void txtItem_TextChanged(object sender, EventArgs e)
        {
            txtItem.Focus();
            EntDiagnostico rut = new EntDiagnostico();
            rut.IdDiagnostico = Convert.ToInt32(txtItem.Text);
            DataTable dt = new DataTable();
            dt = LogDiagnostico.Instancia.BuscarDiagnosticoId(rut.IdDiagnostico);
            if (txtItem.Text != "" )
            {
                dgvDiagnostico.DataSource = dt;
            }
            else
            {

                dgvDiagnostico.DataSource = LogDiagnostico.Instancia.ListarDiagnostico();
            }
        }
    }
}
