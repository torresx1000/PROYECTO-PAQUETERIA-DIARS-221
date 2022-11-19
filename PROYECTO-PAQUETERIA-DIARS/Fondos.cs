using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_PAQUETERIA_DIARS
{
    public partial class Fondos : Form
    {
        static int a;
        public Fondos()
        {
            InitializeComponent(); 
                
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            a = a + 1;
            pictureBox1.Image = imageList1.Images[a];
            if (a==10)
            {
                a = 0;
            }

        }
    }
}
