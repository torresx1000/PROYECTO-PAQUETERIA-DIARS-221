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
    public partial class FrmMenuContador : MaterialSkin.Controls.MaterialForm
    {
        public FrmMenuContador()
        {
            InitializeComponent();
        }
        public void AbrirFrmInPanel(object FormHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = FormHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Login login = new Login();
            login.ShowDialog();
        }

        private void btnManPlanilla_Click(object sender, EventArgs e)
        {
            AbrirFrmInPanel(new FrmPlanilla());
        }

        private void FrmMenuContador_Load(object sender, EventArgs e)
        {

        }

        private void btnConfigLogin_Click(object sender, EventArgs e)
        {
            AbrirFrmInPanel(new FromPassword());
        }
    }
}
