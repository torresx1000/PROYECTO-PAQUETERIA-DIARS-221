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
using System.Windows.Forms.VisualStyles;

namespace PROYECTO_PAQUETERIA_DIARS
{
    public partial class FrmReporteTrabajadores : Form
    {
        public static string dni;
        public static string direccion;
        public static string fechanac;
        public static string apellidopat;
        public static string apellidomat;
        public static string nombre;
        public static string id;
        public FrmReporteTrabajadores()
        {
            InitializeComponent();
            ListarTrabajadores();
        }
        public void ListarTrabajadores() {
            dgvTrabajadores.DataSource = LogTrabajador.Instancia.ListarTrabajador();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtItem_TextChanged(object sender, EventArgs e)
        {
            txtItem.Focus();
            EntTrabajador tra = new EntTrabajador();
            tra.Nombres = txtItem.Text;
            DataTable dt = new DataTable();
            dt = LogTrabajador.Instancia.BuscarTrabajadores(tra.Nombres);
            if (txtItem.Text != "" && (tra.EstadoTrabajador = true))
            {
                dgvTrabajadores.DataSource = dt;
            }
            else
            {

                dgvTrabajadores.DataSource = LogTrabajador.Instancia.ListarTrabajador();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
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

        private void dgvTrabajadores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                nombre = dgvTrabajadores.Rows[e.RowIndex].Cells["Nombres"].Value.ToString();
                id = dgvTrabajadores.Rows[e.RowIndex].Cells["Id_Trabajador"].Value.ToString();
                apellidopat = dgvTrabajadores.Rows[e.RowIndex].Cells["ApPaterno"].Value.ToString();
                apellidomat = dgvTrabajadores.Rows[e.RowIndex].Cells["ApMaterno"].Value.ToString();
                fechanac = dgvTrabajadores.Rows[e.RowIndex].Cells["FechaNac"].Value.ToString();
                direccion = dgvTrabajadores.Rows[e.RowIndex].Cells["Direccion"].Value.ToString();
                dni = dgvTrabajadores.Rows[e.RowIndex].Cells["Dni"].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("No es perminito", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
