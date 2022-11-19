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
    public partial class Minijuego : Form
    {
        public Minijuego()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           if( pictureBox2.BackColor == Color.White)
            {
                pictureBox2.Image = pictureBox1.Image;
                pictureBox2.BackColor = Color.Gray;
                pictureBox1.Image = imageList1.Images[0];   
                pictureBox1.BackColor = Color.White;    

            }

            if (pictureBox4.BackColor == Color.White)
            {
                pictureBox4.Image = pictureBox1.Image;
                pictureBox4.BackColor = Color.Gray;
                pictureBox1.Image = imageList1.Images[0];
                pictureBox1.BackColor = Color.White;

            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.BackColor == Color.White)
            {
                pictureBox1.Image = pictureBox2.Image;
                pictureBox1.BackColor = Color.Gray;
                pictureBox2.Image = imageList1.Images[0];
                pictureBox2.BackColor = Color.White;

            }

            if (pictureBox3.BackColor == Color.White)
            {
                pictureBox3.Image = pictureBox2.Image;
                pictureBox3.BackColor = Color.Gray;
                pictureBox2.Image = imageList1.Images[0];
                pictureBox2.BackColor = Color.White;

            }
            if (pictureBox5.BackColor == Color.White)
            {
                pictureBox5.Image = pictureBox2.Image;
                pictureBox5.BackColor = Color.Gray;
                pictureBox2.Image = imageList1.Images[0];
                pictureBox2.BackColor = Color.White;

            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (pictureBox1.BackColor == Color.White)
            {
                pictureBox1.Image = pictureBox4.Image;
                pictureBox1.BackColor = Color.Gray;
                pictureBox4.Image = imageList1.Images[0];
                pictureBox4.BackColor = Color.White;

            }

            if (pictureBox7.BackColor == Color.White)
            {
                pictureBox7.Image = pictureBox4.Image;
                pictureBox7.BackColor = Color.Gray;
                pictureBox4.Image = imageList1.Images[0];
                pictureBox4.BackColor = Color.White;

            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (pictureBox2.BackColor == Color.White)
            {
                pictureBox2.Image = pictureBox3.Image;
                pictureBox2.BackColor = Color.Gray;
                pictureBox3.Image = imageList1.Images[0];
                pictureBox3.BackColor = Color.White;

            }

            if (pictureBox6.BackColor == Color.White)
            {
                pictureBox6.Image = pictureBox3.Image;
                pictureBox6.BackColor = Color.Gray;
                pictureBox3.Image = imageList1.Images[0];
                pictureBox3.BackColor = Color.White;

            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (pictureBox2.BackColor == Color.White)
            {
                pictureBox2.Image = pictureBox5.Image;
                pictureBox2.BackColor = Color.Gray;
                pictureBox5.Image = imageList1.Images[0];
                pictureBox5.BackColor = Color.White;

            }

            if (pictureBox6.BackColor == Color.White)
            {
                pictureBox6.Image = pictureBox5.Image;
                pictureBox6.BackColor = Color.Gray;
                pictureBox5.Image = imageList1.Images[0];
                pictureBox5.BackColor = Color.White;

            }
            if (pictureBox4.BackColor == Color.White)
            {
                pictureBox4.Image = pictureBox5.Image;
                pictureBox4.BackColor = Color.Gray;
                pictureBox5.Image = imageList1.Images[0];
                pictureBox5.BackColor = Color.White;

            }

            if (pictureBox8.BackColor == Color.White)
            {
                pictureBox8.Image = pictureBox5.Image;
                pictureBox8.BackColor = Color.Gray;
                pictureBox5.Image = imageList1.Images[0];
                pictureBox5.BackColor = Color.White;

            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (pictureBox4.BackColor == Color.White)
            {
                pictureBox4.Image = pictureBox7.Image;
                pictureBox4.BackColor = Color.Gray;
                pictureBox7.Image = imageList1.Images[0];
                pictureBox7.BackColor = Color.White;

            }

            if (pictureBox8.BackColor == Color.White)
            {
                pictureBox8.Image = pictureBox7.Image;
                pictureBox8.BackColor = Color.Gray;
                pictureBox7.Image = imageList1.Images[0];
                pictureBox7.BackColor = Color.White;

            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (pictureBox5.BackColor == Color.White)
            {
                pictureBox5.Image = pictureBox8.Image;
                pictureBox5.BackColor = Color.Gray;
                pictureBox8.Image = imageList1.Images[0];
                pictureBox8.BackColor = Color.White;

            }

            if (pictureBox9.BackColor == Color.White)
            {
                pictureBox9.Image = pictureBox8.Image;
                pictureBox9.BackColor = Color.Gray;
                pictureBox8.Image = imageList1.Images[0];
                pictureBox8.BackColor = Color.White;

            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (pictureBox6.BackColor == Color.White)
            {
                pictureBox6.Image = pictureBox9.Image;
                pictureBox6.BackColor = Color.Gray;
                pictureBox9.Image = imageList1.Images[0];
                pictureBox9.BackColor = Color.White;

            }

            if (pictureBox8.BackColor == Color.White)
            {
                pictureBox8.Image = pictureBox9.Image;
                pictureBox8.BackColor = Color.Gray;
                pictureBox9.Image = imageList1.Images[0];
                pictureBox9.BackColor = Color.White;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[0];
            pictureBox2.Image = imageList1.Images[1];
            pictureBox3.Image = imageList1.Images[2];
            pictureBox4.Image = imageList1.Images[3];
            pictureBox5.Image = imageList1.Images[4];
            pictureBox6.Image = imageList1.Images[5];
            pictureBox7.Image = imageList1.Images[6];
            pictureBox8.Image = imageList1.Images[7];
            pictureBox8.Image = imageList1.Images[8];




            pictureBox1.BackColor = Color.Gray;
            pictureBox2.BackColor = Color.Gray;
            pictureBox3.BackColor = Color.Gray;
            pictureBox4.BackColor = Color.Gray;
            pictureBox5.BackColor = Color.Gray;
            pictureBox6.BackColor = Color.Gray;
            pictureBox7.BackColor = Color.Gray;
            pictureBox8.BackColor = Color.Gray;
            pictureBox9.BackColor = Color.White;



        }
    }
}
