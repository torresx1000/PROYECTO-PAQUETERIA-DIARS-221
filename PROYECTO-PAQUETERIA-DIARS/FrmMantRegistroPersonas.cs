using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAPAENTIDAD;
using CAPADATOS;
using System.Management;
using System.Drawing.Imaging;
using System.IO;
using CAPALOGICA;

namespace PROYECTO_PAQUETERIA_DIARS
{
    public partial class FrmMantRegistroPersonas : Form
    {
        ApisPeru ApisPeru = new ApisPeru();
        public FrmMantRegistroPersonas()
        {
            InitializeComponent();
            ListarTrabajador();
            LimpiarVariables();
            gbDatosDelTrabajador.Enabled = true;
            btnRegistrar.Enabled= false;
            btnBuscarTrabajador.Enabled= false;
            btnActualizar.Enabled= false;
            btnInhabilitar.Enabled= false;
            txtDni.Enabled = true;
            DeshabilitarCampos();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }
        public void HabilitarCampos()
        {

            txtNombres.Enabled = true;
            txtApellidoPaterno.Enabled = true;
            txtApellidoMaterno.Enabled = true;
            dtFechaNacimiento.Enabled = true;
            txtSexo.Enabled = true;
            cmbxEstadoCivil.Enabled = true;
            txtUbigeo.Enabled = true;
            txtDireccion.Enabled = true;
            txtDistrito.Enabled = true;
            txtProvincia.Enabled = true;
            txtDepartamento.Enabled = true;
            dtFechaContrato.Enabled = true;
            txtUsuario.Enabled = true;
            txtClave.Enabled = true;
            txtCargo.Enabled = true;
            cbEstadoTrabajador.Enabled = true;
            pbPerfilTrabajador.Enabled = true;
        }
        public void DeshabilitarCampos()
        {
            
            txtNombres.Enabled=false;
            txtApellidoPaterno.Enabled = false;
            txtApellidoMaterno.Enabled = false;
            dtFechaNacimiento.Enabled = false;
            txtSexo.Enabled = false;
            cmbxEstadoCivil.Enabled = false;
            txtUbigeo.Enabled = false;
            txtDireccion.Enabled = false;
            txtDistrito.Enabled = false;
            txtProvincia.Enabled = false;
            txtDepartamento.Enabled = false;
            dtFechaContrato.Enabled = false;
            txtUsuario.Enabled = false;
            txtClave.Enabled = false;
            txtCargo.Enabled = false;
            cbEstadoTrabajador.Enabled = false;
            pbPerfilTrabajador.Enabled = false;
        }
        public void LimpiarVariables() {
            txtIdTrabajador.Text=("");
            txtDni.Text = ("");
            txtNombres.Text = ("");
            txtApellidoPaterno.Text = ("");
            txtApellidoMaterno.Text = ("");
            dtFechaNacimiento.Text = ("");
            txtSexo.Text = ("");
            cmbxEstadoCivil.Text = ("");
            txtUbigeo.Text = ("");
            txtDireccion.Text = ("");
            txtDistrito.Text = ("");
            txtProvincia.Text = ("");
            txtDepartamento.Text = ("");
            dtFechaContrato.Text = ("");
            txtUsuario.Text = ("");
            txtClave.Text = ("");
            txtCargo.Text = ("");
            cbEstadoTrabajador.Checked=false;
            pbPerfilTrabajador.Image=null;
        }
        private void btnBuscarTrabajador_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDni.Text.Length == 8)
                {
                    dynamic respuesta = ApisPeru.Get("https://dniruc.apisperu.com/api/v1/dni/" + txtDni.Text + "?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJlbWFpbCI6InNhbnRvc2Jlcm51eTIwQGdtYWlsLmNvbSJ9.d7_Tcyi35EWR8QOFVdzd2OrcMiCP1D3juS5DZNOu6gQ");
                    txtNombres.Text = respuesta.nombres.ToString();
                    txtApellidoPaterno.Text = respuesta.apellidoPaterno.ToString();
                    txtApellidoMaterno.Text = respuesta.apellidoMaterno.ToString();
                }
                else
                {
                    MessageBox.Show("Ingrese un número de documento válido.", "Documento inválido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese un número de documento válido (Exception).", "Documento inválido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogo=new OpenFileDialog();
            DialogResult resultado= dialogo.ShowDialog();
            if (resultado==DialogResult.OK) {
                pbPerfilTrabajador.Image = Image.FromFile(dialogo.FileName);
                pbPerfilTrabajador.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                //para convertir imagen
                MemoryStream archivoMemoria = new MemoryStream();
                pbPerfilTrabajador.Image.Save(archivoMemoria, ImageFormat.Jpeg);

                EntTrabajador Tra = new EntTrabajador();
                //Tra.Id_Trabajador = Convert.ToInt32(txtIdTrabajador.Text.Trim());
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

                LogTrabajador.Instancia.InsertarTrabajador(Tra);
                ListarTrabajador();
                LimpiarVariables();
                gbDatosDelTrabajador.Enabled = true;
                btnRegistrar.Enabled = false;
                btnBuscarTrabajador.Enabled = false;
                btnActualizar.Enabled = false;
                btnInhabilitar.Enabled = false;
                txtDni.Enabled = true;
                DeshabilitarCampos();
            }
            catch (Exception)
            {
                MessageBox.Show("Llene todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void dataGridViewTrabajador_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {/*
            EntTrabajador Tra = new EntTrabajador();
            DataGridViewRow filaActual = dataGridViewTrabajador.Rows[e.RowIndex];
            txtIdTrabajador.Text = filaActual.Cells[0].Value.ToString();
            txtDni.Text = filaActual.Cells[1].Value.ToString();
            txtNombres.Text = filaActual.Cells[2].Value.ToString();
            txtApellidoPaterno.Text = filaActual.Cells[3].Value.ToString();
            txtApellidoMaterno.Text = filaActual.Cells[4].Value.ToString();
            dtFechaNacimiento.Text = filaActual.Cells[5].Value.ToString();
            txtSexo.Text= filaActual.Cells[6].Value.ToString();
            cmbxEstadoCivil.Text=filaActual.Cells[7].Value.ToString();
            txtUbigeo.Text = filaActual.Cells[8].Value.ToString();
            txtDireccion.Text=filaActual.Cells[9].Value.ToString();
            txtDistrito.Text=filaActual.Cells[10].Value.ToString();
            txtProvincia.Text=filaActual.Cells[11].Value.ToString();
            txtDepartamento.Text=filaActual.Cells[12].Value.ToString();
            dtFechaContrato.Text = filaActual.Cells[13].Value.ToString();
            txtUsuario.Text=filaActual.Cells[14].Value.ToString();
            txtClave.Text = filaActual.Cells[15].Value.ToString();
            txtCargo.Text =filaActual.Cells[16].Value.ToString();
            string est = filaActual.Cells[17].Value.ToString();//para tomar el dato de la tabla ya que asi nomas no se deja xd
            cbEstadoTrabajador.Checked = Convert.ToBoolean(est);
            
           //nose como cargar la imagen aaah
           */

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //para convertir imagen
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
            catch (Exception ex) {
                MessageBox.Show("Error al actualizar: " + ex);
            }
            gbDatosDelTrabajador.Enabled=false;
            ListarTrabajador();
            LimpiarVariables();
            gbDatosDelTrabajador.Enabled = true;
            btnRegistrar.Enabled = false;
            btnBuscarTrabajador.Enabled = false;
            btnActualizar.Enabled = false;
            btnInhabilitar.Enabled = false;
            txtDni.Enabled = true;
            btnBuscar.Enabled = true;
            DeshabilitarCampos();
        }
        public void ListarTrabajador()
        {
            dataGridViewTrabajador.DataSource = LogTrabajador.Instancia.ListarTrabajador();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
            gbDatosDelTrabajador.Enabled = true;
            btnRegistrar.Enabled = false;
            btnBuscarTrabajador.Enabled = false;
            btnActualizar.Enabled = false;
            btnInhabilitar.Enabled = false;
            txtDni.Enabled = true;
            btnBuscar.Enabled = true;
            DeshabilitarCampos();

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbDatosDelTrabajador.Enabled = true;
            btnBuscarTrabajador.Enabled = true;
            btnRegistrar.Enabled = true;
            btnActualizar.Enabled = false;
            btnInhabilitar.Enabled = false;
            btnBuscar.Enabled=false;
            HabilitarCampos();
            LimpiarVariables();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtDni.Focus();
            int dni=Convert.ToInt32(txtDni.Text.Trim());
            EntTrabajador Tra = LogTrabajador.Instancia.BuscarTrabajadorDni(dni);
            if (Tra != null && (Tra.EstadoTrabajador = true))
            {
                txtIdTrabajador.Text = Convert.ToString(Tra.Id_Trabajador);
                txtDni.Text = Convert.ToString(Tra.Dni);
                txtNombres.Text = Tra.Nombres.ToString();
                txtApellidoPaterno.Text = Tra.ApPaterno.ToString();
                txtApellidoMaterno.Text = Tra.ApMaterno.ToString();
                dtFechaNacimiento.Value = Convert.ToDateTime(Tra.FechaNac);
                txtSexo.Text = Tra.Sexo.ToString();
                cmbxEstadoCivil.Text = Tra.EstCivil.ToString();
                txtUbigeo.Text = Tra.Ubigeo.ToString();
                txtDireccion.Text = Tra.Direccion.ToString();
                txtDistrito.Text = Tra.Distrito.ToString();
                txtProvincia.Text = Tra.Provincia.ToString();
                txtDepartamento.Text = Tra.Departamento.ToString();
                dtFechaContrato.Value = Convert.ToDateTime(Tra.FechaContrato);
                txtUsuario.Text = Tra.Usuario.ToString();
                txtClave.Text = Tra.Password.ToString();
                txtCargo.Text = Tra.Cargo.ToString();
                cbEstadoTrabajador.Checked = Convert.ToBoolean(Tra.EstadoTrabajador);
                System.IO.MemoryStream ms = new System.IO.MemoryStream(Tra.PerfilTrabajador);//para convertir a imagen
                pbPerfilTrabajador.Image = System.Drawing.Bitmap.FromStream(ms);
            }
            else
            {
                MessageBox.Show("El Trabajdor no existe or esta inhabilitado, verifique.", "Trabajador: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            btnActualizar.Enabled = true;
            btnInhabilitar.Enabled = true;
            btnBuscar.Enabled = false;
            btnRegistrar.Enabled = false;
        }

        private void btnInhabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                EntTrabajador Tra = new EntTrabajador();
                Tra.Dni = int.Parse(txtDni.Text.Trim());
                cbEstadoTrabajador.Checked = false;
                Tra.EstadoTrabajador = cbEstadoTrabajador.Checked;
                LogTrabajador.Instancia.DeshabilitarTrabajador(Tra);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbDatosDelTrabajador.Enabled = false;
            ListarTrabajador();
            gbDatosDelTrabajador.Enabled = true;
            btnRegistrar.Enabled = false;
            btnBuscarTrabajador.Enabled = false;
            btnActualizar.Enabled = false;
            btnInhabilitar.Enabled = false;
            txtDni.Enabled = true;
            btnBuscar.Enabled = true;
            DeshabilitarCampos();
        }
        //valida solo numeros
        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar>=32 && e.KeyChar<=47)||(e.KeyChar>=58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        //solo letras
        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtUbigeo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 45 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Numeros Y un (.)permitidos ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDistrito_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtProvincia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void dataGridViewTrabajador_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string id = dataGridViewTrabajador.Rows[e.RowIndex].Cells["IdTrabajador"].Value.ToString();
                txtIdTrabajador.Text = id;
            }
            catch (Exception)
            {
                MessageBox.Show("No permitido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
