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
           /* //para convertir imagen
            MemoryStream archivoMemoria = new MemoryStream();
            pbPerfilTrabajador.Image.Save(archivoMemoria, ImageFormat.Jpeg);
            try
            {
                EntTrabajador Tra = new EntTrabajador();
                Tra.Id_Trabajador = Convert.ToInt32(txtIdTrabajador.Text.Trim());
                Tra.Dni = Convert.ToInt32(txtDni.Text.Trim());
                Tra.Nombres = txtNombres.Text.Trim();
                Tra.ApPaterno = txtApellidoPaterno.Text.Trim();
                Tra.ApMaterno = txtApellidoMaterno.Text.Trim();
                Tra.FechaNac = dtFechaNacimiento.Value;
                Tra.Sexo = txtSexo.Text.Trim();
                Tra.EstCivil = cmbxEstadoCivil.Text.Trim();
                Tra.Ubigeo = Convert.ToInt32(txtUbigeo.Text.Trim());
                Tra.Direccion = txtDireccion.Text.Trim();
                Tra.Distrito = txtDistrito.Text.Trim();
                Tra.Provincia = txtProvincia.Text.Trim();
                Tra.Departamento = txtDepartamento.Text.Trim();
                Tra.FechaContrato = dtFechaContrato.Value;
                Tra.Usuario = txtUsuario.Text.Trim();
                Tra.Password = txtClave.Text.Trim();
                Tra.Cargo = txtCargo.Text.Trim();
                Tra.EstadoTrabajador = cbEstadoTrabajador.Checked;
                Tra.PerfilTrabajador = archivoMemoria.GetBuffer();

                LogTrabajador.Instancia.EditarTrabajador(Tra);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex);
            }
            gbDatosDelTrabajador.Enabled = false;
            ListarTrabajador();
            LimpiarVariables();*/
        }
    }
}
