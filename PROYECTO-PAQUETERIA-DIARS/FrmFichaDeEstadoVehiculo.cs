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
    public partial class FrmFichaDeEstadoVehiculo : Form
    {
        public FrmFichaDeEstadoVehiculo()
        {
            InitializeComponent();
            ListarFichaEstado();
        }
        public void ListarFichaEstado() {
            dgvfichadeestado.DataSource = LogFichaDeEstadoVehiculo.Instancia.ListarFichaDeViaje();
        }
        private void btnregistrar_Click(object sender, EventArgs e)
        {
            FrmReporteVehiculo FrmReporteVehiculo = new FrmReporteVehiculo();
            FrmListaConductores_Trabajadores FrmListaConductores_Trabajadores = new FrmListaConductores_Trabajadores();
            EntFichaDeEstadoVehiculo fich = new EntFichaDeEstadoVehiculo();

            fich.Conductor = Convert.ToInt32(FrmListaConductores_Trabajadores.id);
            fich.Vehiculo = Convert.ToInt32(FrmReporteVehiculo.idVehiculo.Trim());
            fich.Fecha = dtpfecha.Value;
            fich.SistemaElectrico = txtsistemaelectrico.Text.Trim();
            fich.SistemaMecanico = txtsistemamecanico.Text.Trim();
            fich.LetoneriayPintura = txtlatoneriaypintura.Text.Trim();
            fich.Otros = txtotros.Text.Trim();

            LogFichaDeEstadoVehiculo.Instancia.InsertaFichaDeEstadoVehiculo(fich);
            ListarFichaEstado();
        }

        private void btnseleccionarconductor_Click(object sender, EventArgs e)
        {
            FrmListaConductores_Trabajadores FrmListaConductores_Trabajadores = new FrmListaConductores_Trabajadores();
            FrmListaConductores_Trabajadores.ShowDialog();
            txtconductor.Text = FrmListaConductores_Trabajadores.nombre;
        }

        private void btnseleccionarvehiculo_Click(object sender, EventArgs e)
        {
            FrmReporteVehiculo FrmReporteVehiculo = new FrmReporteVehiculo();
            FrmReporteVehiculo.ShowDialog();
            txtvehiculo.Text = FrmReporteVehiculo.placa;
        }
    }
}
