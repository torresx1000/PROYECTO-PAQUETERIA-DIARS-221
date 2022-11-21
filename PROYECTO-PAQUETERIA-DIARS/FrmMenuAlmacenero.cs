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
    public partial class FrmMenuAlmacenero : Form
    {
        public FrmMenuAlmacenero()
        {
            InitializeComponent();
            AbrirPanelistaIma(new Fondos());
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
            this.Close();
            Program.inicio.Show();
        }

        private void btnManLote_Click(object sender, EventArgs e)
        {
            AbrirFrmInPanel(new FrmMantendorLote());
        }

        private void btnConfigLogin_Click(object sender, EventArgs e)
        {
            AbrirFrmInPanel(new FromPassword());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }
        public void AbrirPanelistaIma(object FormHijo)
        {
            if (this.Pantallaxd.Controls.Count > 0)
                this.Pantallaxd.Controls.RemoveAt(0);
            Form fh = FormHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Pantallaxd.Controls.Add(fh);
            this.Pantallaxd.Tag = fh;
            fh.Show();
        }

        private void txthora_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
