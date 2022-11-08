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
    public partial class FrmGastosDeViaje : Form
    {
        public FrmGastosDeViaje()
        {
            InitializeComponent();
            ListarGastosViaje();
        }

        private void txtpreciosviaticos_TextChanged(object sender, EventArgs e)
        {

        }
        public void ListarGastosViaje() {
            dgvdatosgastosdeviaje.DataSource = LogGastosDeViaje.Instancia.ListarGastosDeViajes();
        }
        private void btnseleccionar_Click(object sender, EventArgs e)
        {
            FrmReporteProgramacionSalida FrmReporteProgramacionSalida = new FrmReporteProgramacionSalida();
            FrmReporteProgramacionSalida.ShowDialog();
            txtidprogramaciondesalida.Text = FrmReporteProgramacionSalida.IdPS;
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            FrmReporteProgramacionSalida FrmReporteProgramacionSalida = new FrmReporteProgramacionSalida();
            EntGastosDeViaje gas = new EntGastosDeViaje();

            gas.IdProgramaciondesalida = Convert.ToInt32(FrmReporteProgramacionSalida.IdPS.Trim());
            gas.Fecha = dtpfecha.Value;
            gas.Viaticos = txtviaticos.Text.Trim();
            gas.preciosviaticos = Convert.ToDouble(txtpreciosviaticos.Text.Trim());
            gas.Combustible = txtcombustible.Text.Trim();
            gas.precioscombustible = Convert.ToDouble(txtprecioscombustible.Text.Trim());
            gas.Otros = txtotros.Text.Trim();
            gas.preciosotros = Convert.ToDouble(txtpreciosotros.Text.Trim());
            LogGastosDeViaje.Instancia.InsertaGastosDeViaje(gas);
            ListarGastosViaje();
        }
    }
}
