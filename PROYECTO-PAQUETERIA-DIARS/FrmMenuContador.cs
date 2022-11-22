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
    public partial class FrmMenuContador : Form
    {
        public FrmMenuContador(string cargo, string nombre)
        {
            
            InitializeComponent();
            AbrirPanelistaIma(new Fondos());
            lblCargo.Text = cargo;
            lblNombre.Text = nombre;
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
        public void AbrirPanelistaIma(object FormHijo)
        {
            if (this.Pantalla.Controls.Count > 0)
                this.Pantalla.Controls.RemoveAt(0);
            Form fh = FormHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Pantalla.Controls.Add(fh);
            this.Pantalla.Tag = fh;
            fh.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.inicio.Show(); ;
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

        private void btnGenerarInformeEconomico_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void txthora_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
