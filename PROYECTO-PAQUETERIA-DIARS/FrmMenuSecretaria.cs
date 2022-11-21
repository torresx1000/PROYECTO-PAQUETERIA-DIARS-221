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
    public partial class FrmMenuSecretaria : Form
    {
        public FrmMenuSecretaria(string cargo, string nombre)
        {
            InitializeComponent();
            AbrirPanelistaIma(new Fondos());
            labelCargo.Text = cargo;
            labelNombre.Text = nombre;
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
            if (this.panel2.Controls.Count > 0)
                this.panel2.Controls.RemoveAt(0);
            Form fh = FormHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(fh);
            this.panel2.Tag = fh;
            fh.Show();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void btnManPedido_Click(object sender, EventArgs e)
        {
            AbrirFrmInPanel(new FrmRemitente_Destinatario());
        }

        private void FrmMenuSecretaria_Load(object sender, EventArgs e)
        {

        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnManProgramSalida_Click(object sender, EventArgs e)
        {
            AbrirFrmInPanel(new FrmProgramacionSalida());
        }

        private void btnConfigLogin_Click(object sender, EventArgs e)
        {
            AbrirFrmInPanel(new FromPassword());
        }

        private void label1_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.inicio.Show(); 
        }

        private void btnAdministrarVehiculo_Click(object sender, EventArgs e)
        {
            AbrirFrmInPanel(new FrmMantVehiculo());
        }
    }
}
