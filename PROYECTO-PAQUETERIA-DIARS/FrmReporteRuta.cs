using CAPADATOS;
using CAPAENTIDAD;
using CAPALOGICA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_PAQUETERIA_DIARS
{
    public partial class FrmReporteRuta : Form
    {
        public static string IdRuta;
        public FrmReporteRuta()
        {
            InitializeComponent();
            ListarRuta();
        }

        public void ListarRuta() {
            dgvRutas.DataSource = LogRuta.Instancia.ListarRuta();
        }

        private void txtItem_TextChanged(object sender, EventArgs e)
        {
            txtItem.Focus();
            EntRuta rut = new EntRuta();
            rut.PuntoPartida = txtItem.Text;
            DataTable dt = new DataTable();
            dt = LogRuta.Instancia.BuscarRutas(rut.PuntoPartida);
            if (txtItem.Text != "" &&(rut.EstadoRuta= true))
            {
                dgvRutas.DataSource = dt;
            }
            else
            {

                dgvRutas.DataSource = LogRuta.Instancia.ListarRuta();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (IdRuta == null)
            {
                MessageBox.Show("Seleccione una fila", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                Close();
            }
        }

        private void dgvRutas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IdRuta = dgvRutas.Rows[e.RowIndex].Cells["IdRuta"].Value.ToString();
        }

        private void FrmReporteRuta_Load(object sender, EventArgs e)
        {

        }
    }
}
