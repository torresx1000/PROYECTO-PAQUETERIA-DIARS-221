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
    public partial class FrmMenuJefeDeMantenimiento : Form
    {
        public FrmMenuJefeDeMantenimiento()
        {
            InitializeComponent();
        }
        public void AbrirFrmInPanel(object FormHijo)
        {
            if (this.panelContenedor2.Controls.Count > 0)
                this.panelContenedor2.Controls.RemoveAt(0);
            Form fh = FormHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor2.Controls.Add(fh);
            this.panelContenedor2.Tag = fh;
            fh.Show();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Login login = new Login();
            login.ShowDialog();
        }

        private void btnRegistrarDiagnostico_Click(object sender, EventArgs e)
        {
            AbrirFrmInPanel(new FrmDiagnostico());
        }
    }
}
