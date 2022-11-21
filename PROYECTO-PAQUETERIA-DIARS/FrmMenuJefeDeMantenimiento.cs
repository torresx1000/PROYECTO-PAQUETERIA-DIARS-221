using CAPAENTIDAD;
using CAPALOGICA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_PAQUETERIA_DIARS
{
    public partial class FrmMenuJefeDeMantenimiento : Form
    {
        public FrmMenuJefeDeMantenimiento(string cargo, string nombre)
        {
            InitializeComponent();
            AbrirPanelistaIma(new Fondos());
            labelCargo.Text = cargo;
            labelNombre.Text = nombre;
        }
        public void AbrirFrmInPanel(object FormHijo)
        {
            if (this.mantenimietopanel.Controls.Count > 0)
                this.mantenimietopanel.Controls.RemoveAt(0);
            Form fh = FormHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.mantenimietopanel.Controls.Add(fh);
            this.mantenimietopanel.Tag = fh;
            fh.Show();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.inicio.Show();
        }
        public void AbrirPanelistaIma(object FormHijo)
        {
            if (this.pantalla.Controls.Count > 0)
                this.pantalla.Controls.RemoveAt(0);
            Form fh = FormHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pantalla.Controls.Add(fh);
            this.pantalla.Tag = fh;
            fh.Show();
        }
        private void btnRegistrarDiagnostico_Click(object sender, EventArgs e)
        {
            AbrirFrmInPanel(new FrmDiagnostico());
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

        private void txthora_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
