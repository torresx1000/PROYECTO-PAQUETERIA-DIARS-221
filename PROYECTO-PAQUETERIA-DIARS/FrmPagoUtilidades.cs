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
    public partial class FrmPagoUtilidades : Form
    {
        public Double TotalRemuneraciones=0;
        public Double TotalDescuentos=0;
        public Double TotalAportes=0;
        public Double NetoPago = 0;
        public FrmPagoUtilidades()
        {
            InitializeComponent();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            FrmReporteTrabajadores frmReporteTrabajadores=new FrmReporteTrabajadores();
            frmReporteTrabajadores.ShowDialog();
            txtTrabajador.Text = FrmReporteTrabajadores.nombre;
        }

        public void SumarNetoPago() {
            NetoPago = TotalRemuneraciones + TotalDescuentos + TotalAportes;
            txtNetoPago.Text=Convert.ToString(NetoPago);
        }
        private void SeleccionarPla_Click(object sender, EventArgs e)
        {
            FrmReportePlanilla frmReportePlanilla = new FrmReportePlanilla();
            frmReportePlanilla.ShowDialog();
            txtPlanilla.Text = FrmReportePlanilla.id;
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void btnCalcularRem_Click(object sender, EventArgs e)
        {
            Double SueldoCom = Convert.ToDouble(txtSueldoComp.Text);
            Double AsigFam=Convert.ToDouble(txtAsigFam.Text);
            Double RemunerVa = Convert.ToDouble(txtReumVac.Text);
            Double Movsuo=Convert.ToDouble(txtMovAsist.Text);
            Double CTS = Convert.ToDouble(txtCts.Text);
            TotalRemuneraciones = SueldoCom + AsigFam + RemunerVa +Movsuo+ CTS;
            txtAdicionalR.Text = Convert.ToString(TotalRemuneraciones);
            SumarNetoPago();
        }

        private void btnCalcularDes_Click(object sender, EventArgs e)
        {
            Double AfpFonfo = Convert.ToDouble(txtAfpFondo.Text);
            Double AfpCom = Convert.ToDouble(txtAfpCom.Text);
            Double AfpSeguro=Convert.ToDouble(txtAfpSeguro.Text);
            Double Onp=Convert.ToDouble(txtOnpMonto.Text);
            Double Faltas=Convert.ToDouble(txtFaltas.Text);
            Double Retencionquin = Convert.ToDouble(txtretenc5.Text);
            Double RetencionJud = Convert.ToDouble(txtRetenJud.Text);
            Double Adelantos = Convert.ToDouble(txtAdelantos.Text);
            TotalDescuentos = AfpFonfo + AfpCom + AfpSeguro + Onp + Faltas + Retencionquin + RetencionJud + Adelantos;
            txttotalDescuentos.Text = Convert.ToString(TotalDescuentos);
            SumarNetoPago();
        }

        private void txtSueldoComp_MouseClick(object sender, MouseEventArgs e)
        {
            txtSueldoComp.Text = "";
        }

        private void txtAsigFam_MouseClick(object sender, MouseEventArgs e)
        {
            txtAsigFam.Text = "";
        }

        private void txtReumVac_MouseClick(object sender, MouseEventArgs e)
        {
            txtReumVac.Text = "";
        }

        private void txtMovAsist_MouseClick(object sender, MouseEventArgs e)
        {
            txtMovAsist.Text = "";
        }

        private void txtCts_MouseClick(object sender, MouseEventArgs e)
        {
            txtCts.Text = "";
        }

        private void btnCalcularApo_Click(object sender, EventArgs e)
        {
            Double Essaud = Convert.ToDouble(txtEsalud.Text);
            Double sctr = Convert.ToDouble(txtSctr.Text);
            TotalAportes = Essaud + sctr;
            txtAportesTotal.Text = Convert.ToString(TotalAportes);
            SumarNetoPago();
        }

        private void txtEsalud_MouseClick(object sender, MouseEventArgs e)
        {
            txtEsalud.Text = "";
        }

        private void txtSctr_MouseClick(object sender, MouseEventArgs e)
        {
            txtSctr.Text = "";
        }

        private void txtAfpFondo_MouseClick(object sender, MouseEventArgs e)
        {
            txtAfpFondo.Text = "";
        }

        private void txtAfpCom_MouseClick(object sender, MouseEventArgs e)
        {
            txtAfpCom.Text = "";
        }

        private void txtAfpSeguro_MouseClick(object sender, MouseEventArgs e)
        {
            txtAfpSeguro.Text = "";
        }

        private void txtOnpMonto_MouseClick(object sender, MouseEventArgs e)
        {
            txtOnpMonto.Text = "";
        }

        private void txtFaltas_MouseClick(object sender, MouseEventArgs e)
        {
            txtFaltas.Text = "";
        }

        private void txtretenc5_MouseClick(object sender, MouseEventArgs e)
        {
            txtretenc5.Text = "";
        }

        private void txtRetenJud_MouseClick(object sender, MouseEventArgs e)
        {
            txtRetenJud.Text = "";
        }

        private void txtAdelantos_MouseClick(object sender, MouseEventArgs e)
        {
            txtAdelantos.Text = "";
        }
    }
}
