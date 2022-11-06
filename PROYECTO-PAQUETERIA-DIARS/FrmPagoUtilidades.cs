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

        private void SeleccionarPla_Click(object sender, EventArgs e)
        {
            FrmReportePlanilla frmReportePlanilla = new FrmReportePlanilla();
            frmReportePlanilla.ShowDialog();
            txtPlanilla.Text = FrmReportePlanilla.id;
        }
    }
}
