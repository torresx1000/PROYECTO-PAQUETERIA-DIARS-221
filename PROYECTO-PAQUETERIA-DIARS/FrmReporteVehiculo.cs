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
    public partial class FrmReporteVehiculo : Form
    {
            
        public static string Color;
        public static string Modelo;
        public static string placa;
        public static string idVehiculo;

        public FrmReporteVehiculo()
        {
            InitializeComponent();
            ListarVehiculo();
        }

        public void ListarVehiculo() {
            dgvVehiculo.DataSource = LogVehiculo.Instancia.ListarVehiculo();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtItem_TextChanged(object sender, EventArgs e)
        {
            txtItem.Focus();
            EntVehiculo veh = new EntVehiculo();
            veh.Placa = txtItem.Text;
            DataTable dt = new DataTable();
            dt = LogVehiculo.Instancia.BuscarVehiculos(veh.Placa);
            if (txtItem.Text != "")// &&(veh.Condicion=""))//arreglar aca 
            {
                dgvVehiculo.DataSource = dt;
            }
            else
            {
                
                dgvVehiculo.DataSource = LogVehiculo.Instancia.ListarVehiculo();
            }
        }

        private void dgvVehiculo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idVehiculo= dgvVehiculo.Rows[e.RowIndex].Cells["IdVehiculo"].Value.ToString();
            Color = dgvVehiculo.Rows[e.RowIndex].Cells["Color"].Value.ToString();
            Modelo = dgvVehiculo.Rows[e.RowIndex].Cells["Modelo"].Value.ToString();
            placa = dgvVehiculo.Rows[e.RowIndex].Cells["Placa"].Value.ToString();
        }

        private void btnSeleccionarConductores_Click(object sender, EventArgs e)
        {
            if (Modelo == null)
            {
                MessageBox.Show("Seleccione una fila", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmReporteVehiculo_Load(object sender, EventArgs e)
        {

        }
    }
    
    
}
