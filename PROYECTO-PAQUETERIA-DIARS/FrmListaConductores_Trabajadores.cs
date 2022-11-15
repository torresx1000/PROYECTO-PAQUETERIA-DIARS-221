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

    public partial class FrmListaConductores_Trabajadores : Form
    {
        public static string nombre;
        public static string id;

        
        public FrmListaConductores_Trabajadores()
        {
            InitializeComponent();
            ListarConductores();
        }
        public void ListarConductores()
        {
            dgvConductores.DataSource = LogTrabajador.Instancia.ListarConductor();
        }

        private void txtItem_TextChanged(object sender, EventArgs e)
        {
            if (txtItem.Text == "")
            {
                ListarConductores();
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

                    dgvConductores.DataSource = LogTrabajador.Instancia.ListarConductor();
                }
            }
        }

      
        private void btnSeleccionarConductores_Click(object sender, EventArgs e)
        {
          if(nombre ==null) 
            {
                MessageBox.Show("Seleccione una fila","Atencion",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
       
                Close();
            }
        }

        private void dgvConductores_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmListaConductores_Trabajadores_DoubleClick(object sender, EventArgs e)
        {
         
        }

        private void dgvConductores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            nombre = dgvConductores.Rows[e.RowIndex].Cells["Nombres"].Value.ToString();
            id = dgvConductores.Rows[e.RowIndex].Cells["Id_Trabajador"].Value.ToString();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FrmListaConductores_Trabajadores_Load(object sender, EventArgs e)
        {

        }
    }

}
