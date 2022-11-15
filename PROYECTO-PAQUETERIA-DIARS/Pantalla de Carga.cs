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
    public partial class Pantalla_de_Carga : Form
    {
        public Pantalla_de_Carga()
        {
            InitializeComponent();
            this.Opacity = 0.0;
            circularProgressBar1.Value = 0;
            circularProgressBar1.Minimum = 0;
            circularProgressBar1.Maximum = 100;
            timer1.Start();
        

        }
      
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(this.Opacity<1) this.Opacity += 0.05;
            for (int i = 0; i < 10; i++)
            {
                txtcargando.Enabled = false;
                txtcargando.Enabled = true;
            }

            circularProgressBar1.Value += 1;
            circularProgressBar1.Text = circularProgressBar1.Value.ToString();
            txtcargando.Enabled = true;

         
            

            if (circularProgressBar1.Value == 100)
            {
               
                timer1.Stop();
                timer2.Start(); 
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                txtcargando.Enabled = false;
                txtcargando.Enabled = true;
            }
            this.Opacity -= 0.4;
            if (this.Opacity == 0)
            {
                timer2.Stop();
                this.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            this.Opacity = 0.0;
            circularProgressBar1.Value = 0;
            circularProgressBar1.Minimum = 0;
            circularProgressBar1.Maximum = 100;
            timer1.Start();
        }
    }
}
