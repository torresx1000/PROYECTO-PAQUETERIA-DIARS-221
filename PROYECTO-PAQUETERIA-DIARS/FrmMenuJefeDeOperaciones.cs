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
    public partial class FrmMenuJefeDeOperaciones : Form
    {
        public FrmMenuJefeDeOperaciones(string cargo, string nombre)
        {
            InitializeComponent();
            AbrirPanelistaIma(new Fondos());
            labelCargo.Text = cargo;
            labelNombre.Text = nombre;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.inicio.Show(); ;
        }

        private void btnConfigLogin_Click(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }
        public void AbrirPanelistaIma(object FormHijo)
        {
            if (this.PANTALLA.Controls.Count > 0)
                this.PANTALLA.Controls.RemoveAt(0);
            Form fh = FormHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PANTALLA.Controls.Add(fh);
            this.PANTALLA.Tag = fh;
            fh.Show();
        }
        public void Abrir(object FormHijo)
        {
            if (this.OPERACIONES.Controls.Count > 0)
                this.OPERACIONES.Controls.RemoveAt(0);
            Form fh = FormHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.OPERACIONES.Controls.Add(fh);
            this.OPERACIONES.Tag = fh;
            fh.Show();
        }

        private void btnManRuta_Click(object sender, EventArgs e)
        {
            Abrir(new FrmRuta());
        }

        private void txthora_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
