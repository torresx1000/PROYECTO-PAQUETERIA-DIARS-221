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
    public partial class FrmMenuCajero : Form
    {
        public FrmMenuCajero()
        {
            InitializeComponent();
            AbrirPanelistaIma(new Fondos());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.inicio.Show();
        }
        public void AbrirFrmInPanel(object FormHijo)
        {
            if (this.Cajero.Controls.Count > 0)
                this.Cajero.Controls.RemoveAt(0);
            Form fh = FormHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Cajero.Controls.Add(fh);
            this.Cajero.Tag = fh;
            fh.Show();
        }
        public void AbrirPanelistaIma(object FormHijo)
        {
            if (this.SalvaPantalla.Controls.Count > 0)
                this.SalvaPantalla.Controls.RemoveAt(0);
            Form fh = FormHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.SalvaPantalla.Controls.Add(fh);
            this.SalvaPantalla.Tag = fh;
            fh.Show();
        }
        private void btnConfigLogin_Click(object sender, EventArgs e)
        {
          
        }

        private void btnRegistrarPagoDeCotizacion_Click(object sender, EventArgs e)
        {
            AbrirFrmInPanel( new FrmCotizacion());
        }

        private void btnRegistrarPagoUtilidades_Click(object sender, EventArgs e)
        {
            AbrirFrmInPanel(new FrmPagoUtilidades());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
