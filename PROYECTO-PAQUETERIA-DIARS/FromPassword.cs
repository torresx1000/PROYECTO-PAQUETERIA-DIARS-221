using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAPADATOS;
using CAPAENTIDAD;
using CAPALOGICA;

namespace PROYECTO_PAQUETERIA_DIARS
{
    public partial class FromPassword : Form
    {
        public FromPassword()
        {
            InitializeComponent();
            ListarNombres();
        }
        private void ListarNombres()
        {
            // cboNombre.Items.ToString
            cboNombre.DataSource = LogTrabajador.Instancia.ListarTrabajador();
            cboNombre.DisplayMember = "Nombres";
           // cboNombre.ValueMember = "idtrabajador";
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
          
            try
            {
                EntTrabajador Tra = new EntTrabajador();
                Tra.Nombres = cboNombre.Text.Trim();
                Tra.Usuario = txtUsuario.Text.Trim();
                Tra.Password = txtContraAnt.Text.Trim();
                Tra.Password = txtContraNueva.Text.Trim();
                

                LogModificarPaswword.Instancia.ModificarContraseña(Tra);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex);
            }
           
            //ListarTrabajador();
          //  LimpiarVariables();
        }
    }
}
