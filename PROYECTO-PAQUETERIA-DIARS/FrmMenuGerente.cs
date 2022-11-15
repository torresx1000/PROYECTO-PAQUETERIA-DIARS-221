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
    public partial class FrmMenuGerente : MaterialSkin.Controls.MaterialForm
    {
        public FrmMenuGerente(string cargo, string nombre)
        {
            InitializeComponent();
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
        private void FormMenuGerente_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Login login = new Login();
            login.ShowDialog();
        }

        private void btnManTrabajadores_Click(object sender, EventArgs e)
        {
            
        }

        private void btnManVehiculo_Click(object sender, EventArgs e)
        {
            AbrirFrmInPanel(new FrmMantVehiculo());
        }

        private void btnRegistroOrdenDeCompra_Click(object sender, EventArgs e)
        {
            
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            AbrirFrmInPanel(new FrmMantRegistroPersonas());
        }

        private void materialRaisedButton1_Click_1(object sender, EventArgs e)
        {
            AbrirFrmInPanel(new FrmMantVehiculo());
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            AbrirFrmInPanel(new FrmOrdenDeCompra());
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            Close();    
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }
    }
}
