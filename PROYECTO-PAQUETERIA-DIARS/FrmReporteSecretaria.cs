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
    public partial class FrmReporteSecretaria : Form
    {
        public static string nombre;
        public static string id;
        public FrmReporteSecretaria()
        {
            InitializeComponent();
            ListarSecretaria();
        }

        public void ListarSecretaria() { 
        dgvConductores.DataSource=LogTrabajador.Instancia.ListarSecretaria();
        }
        private void btnSeleccionarConductores_Click(object sender, EventArgs e)
        {
            if (nombre == null)
            {
                MessageBox.Show("Seleccione una fila", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Close();
            }
        }

        private void txtItem_TextChanged(object sender, EventArgs e)
        {
            if (txtItem.Text == "")
            {
                ListarSecretaria();
            }
            else
            {
                txtItem.Focus();
                EntTrabajador tra = new EntTrabajador();
                tra.Nombres = txtItem.Text;
                DataTable dt = new DataTable();
                dt = LogTrabajador.Instancia.BuscarTrabajadores(tra.Nombres);
                if (txtItem.Text != "" && (tra.EstadoTrabajador = true))
                {
                    dgvConductores.DataSource = dt;
                }
                else
                {

                    dgvConductores.DataSource = LogTrabajador.Instancia.ListarSecretaria();
                }
            }
        }

        private void dgvConductores_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            try
            {
                nombre = dgvConductores.Rows[e.RowIndex].Cells["Nombres"].Value.ToString();
                id = dgvConductores.Rows[e.RowIndex].Cells["Id_Trabajador"].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("No es perminito", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            
        }
    }
}
