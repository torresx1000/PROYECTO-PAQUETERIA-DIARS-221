using MaterialSkin;
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
    public partial class FrmMenuConductor : MaterialSkin.Controls.MaterialForm
    {
      
        public FrmMenuConductor()
        {
            InitializeComponent();
            
        }
        private void formulario()
        {
            SkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            SkinManager.ColorScheme = new ColorScheme(Primary.Green600,Primary.Green900, Primary.Blue600,Accent.Lime100,TextShade.WHITE);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Login login = new Login();
            login.ShowDialog();
        }
        public void AbrirFrmInPanel(object FormHijo)
        {
            if (this.PanelConductor.Controls.Count > 0)
                this.PanelConductor.Controls.RemoveAt(0);
            Form fh = FormHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelConductor.Controls.Add(fh);
            this.PanelConductor.Tag = fh;
            fh.Show();
        }
        private void btnRegistrarFichaDeEstadoVehicular_Click(object sender, EventArgs e)
        {
            AbrirFrmInPanel(new FrmFichaDeEstadoVehiculo());
            
        }

        private void btnRegistrarGastosDeViaje_Click(object sender, EventArgs e)
        {
            AbrirFrmInPanel( new FrmGastosDeViaje());
        }

        private void btnRegistrarChecklist_Click(object sender, EventArgs e)
        {
            AbrirFrmInPanel(new FmrRegistroCheckList());
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            AbrirFrmInPanel(new FrmGastosDeViaje());
        }

        private void materialRaisedButton1_Click_1(object sender, EventArgs e)
        {
            AbrirFrmInPanel(new FmrRegistroCheckList());
        }

        private void materialRaisedButton1_Click_2(object sender, EventArgs e)
        {
            AbrirFrmInPanel(new FrmFichaDeEstadoVehiculo());
        }

        private void bgtnSalir_Click(object sender, EventArgs e)
        {
            Close();    
        }

        private void FrmMenuConductor_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }
    }
}
