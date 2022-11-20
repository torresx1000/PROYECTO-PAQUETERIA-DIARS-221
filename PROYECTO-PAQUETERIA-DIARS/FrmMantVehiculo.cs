using CAPAENTIDAD;
using CAPALOGICA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_PAQUETERIA_DIARS
{
    public partial class FrmMantVehiculo : Form
    {
        public FrmMantVehiculo()
        {
            InitializeComponent();
            ListarVehiculo();
        }

        private void FrmMantVehiculo_Load(object sender, EventArgs e)
        {

        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogo = new OpenFileDialog();
            DialogResult resultado = dialogo.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                pbFotoVehiculo.Image = Image.FromFile(dialogo.FileName);
                pbFotoVehiculo.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        public void LimpiarVariables() {
            txtIdVehiculo.Text = ("");
            txtCategoria.Text = ("");
            txtModelo.Text = ("");
            txtColor.Text = ("");
            txtMotor.Text = ("");
            cbCombustible.Text = ("");
            txtFormRodante.Text = ("");
            txtAñoFabricacion.Text = ("");
            txtAñoModelo.Text = ("");
            txtVersion.Text = ("");
            txtEjes.Text = ("");
            txtAsientos.Text = ("");
            txtPasajeros.Text = ("");
            txtRuedas.Text = ("");
            txtCarrocerias.Text = ("");
            txtPotencia.Text = ("");
            txtCilindros.Text = ("");
            txtCilindrada.Text = ("");
            txtPesoBruto.Text = ("");
            txtPesoNeto.Text = ("");
            txtCargaUtil.Text = ("");
            txtLongitud.Text = ("");
            txtAltura.Text = ("");
            txtAncho.Text = ("");
            txtZonaRegistro.Text = ("");
            txtDuaDuam.Text = ("");
            txtTitulo.Text = ("");
            dtFechaTitulo.Text = ("");
            cbCondicion.Text = ("");
            txtPlaca.Text = ("");
            txtPlacaAnterior.Text = ("");
            pbFotoVehiculo.Image = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                EntVehiculo Veh = new EntVehiculo();
                Veh.Placa = txtPlaca.Text.Trim();
                cbCondicion.Text="Inactivo";
                Veh.Condicion = cbCondicion.Text;
                LogVehiculo.Instancia.DeshabilitarVehiculo(Veh);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            ListarVehiculo();
        }

        private void txtEjes_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //para convertir imagen
            MemoryStream archivoMemoria = new MemoryStream();
            pbFotoVehiculo.Image.Save(archivoMemoria, ImageFormat.Jpeg);

            EntVehiculo Veh = new EntVehiculo();
            //Veh.IdVehiculo=Convert.ToInt32(txtIdVehiculo.Text.Trim());
            Veh.Categoria = txtCategoria.Text.Trim();
            Veh.Modelo = txtModelo.Text.Trim();
            Veh.Color = txtColor.Text.Trim();
            Veh.Motor = txtMotor.Text.Trim();
            Veh.Combustible = cbCombustible.Text.Trim();
            Veh.FormRodante = txtFormRodante.Text.Trim();
            Veh.AñoFabricacion = txtAñoFabricacion.Text.Trim();
            Veh.AñoModelo = txtAñoModelo.Text.Trim();
            Veh.Version = txtVersion.Text.Trim();
            Veh.Ejes = Convert.ToInt32(txtEjes.Text.Trim());
            Veh.Asientos = Convert.ToInt32(txtAsientos.Text.Trim());
            Veh.Pasajeros = Convert.ToInt32(txtPasajeros.Text.Trim());
            Veh.Ruedas = Convert.ToInt32(txtRuedas.Text.Trim());
            Veh.Carroceria = txtCarrocerias.Text.Trim();
            Veh.Potencia = txtPotencia.Text.Trim();
            Veh.Cilindros = Convert.ToInt32(txtCilindros.Text.Trim());
            Veh.Cilindrada = Convert.ToDouble(txtCilindrada.Text.Trim());
            Veh.PesoBruto = Convert.ToDouble(txtPesoBruto.Text.Trim());
            Veh.PesoNeto = Convert.ToDouble(txtPesoNeto.Text.Trim());
            Veh.CargaUtil = Convert.ToDouble(txtCargaUtil.Text.Trim());
            Veh.Longitud = Convert.ToDouble(txtLongitud.Text.Trim());
            Veh.Altura = Convert.ToDouble(txtAltura.Text.Trim());
            Veh.Ancho = Convert.ToDouble(txtAncho.Text.Trim());
            Veh.ZonaRegistro = txtZonaRegistro.Text.Trim();
            Veh.DuaDuam = Convert.ToInt32(txtDuaDuam.Text.Trim());
            Veh.Titulo = Convert.ToInt32(txtTitulo.Text.Trim());
            Veh.FechaTitulo = dtFechaTitulo.Value;
            Veh.Condicion = cbCondicion.Text.Trim();
            Veh.Placa = txtPlaca.Text.Trim();
            Veh.PlacaAnterior = txtPlacaAnterior.Text.Trim();
            Veh.FotoVehiculo = archivoMemoria.GetBuffer();

            LogVehiculo.Instancia.InsertarVehiculo(Veh);
            ListarVehiculo();

        }
        public void ListarVehiculo()
        {
            dataGridViewVehiculo.DataSource = LogVehiculo.Instancia.ListarVehiculo();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtPlaca.Focus();
            string placa=txtPlaca.Text.Trim();
            EntVehiculo Veh = LogVehiculo.Instancia.BuscarVehiculo(placa);
            if (Veh != null && (Veh.Condicion == "Activo"))
            {
                txtIdVehiculo.Text =Convert.ToString(Veh.IdVehiculo);
                txtCategoria.Text =Veh.Categoria.ToString();
                txtModelo.Text = Veh.Modelo.ToString();
                txtColor.Text = Veh.Color.ToString();
                txtMotor.Text = Veh.Motor.ToString();
                cbCombustible.Text = Veh.Combustible.ToString();
                txtFormRodante.Text = Veh.FormRodante.ToString();
                txtAñoFabricacion.Text = Veh.AñoFabricacion.ToString();
                txtAñoModelo.Text = Veh.AñoModelo.ToString();
                txtVersion.Text = Veh.Version.ToString();
                txtEjes.Text = Convert.ToString(Veh.Ejes);
                txtAsientos.Text = Convert.ToString(Veh.Asientos);
                txtPasajeros.Text = Convert.ToString(Veh.Pasajeros);
                txtRuedas.Text = Convert.ToString(Veh.Ruedas);
                txtCarrocerias.Text = Veh.Carroceria.ToString();
                txtPotencia.Text = Veh.Potencia.ToString();
                txtCilindros.Text = Convert.ToString(Veh.Cilindros);
                txtCilindrada.Text = Convert.ToString(Veh.Cilindrada);
                txtPesoBruto.Text = Convert.ToString(Veh.PesoBruto);
                txtPesoNeto.Text = Convert.ToString(Veh.PesoNeto);
                txtCargaUtil.Text = Convert.ToString(Veh.CargaUtil);
                txtLongitud.Text = Convert.ToString(Veh.Longitud);
                txtAltura.Text = Convert.ToString(Veh.Altura);
                txtAncho.Text = Convert.ToString(Veh.Ancho);
                txtZonaRegistro.Text = Veh.ZonaRegistro.ToString();
                txtDuaDuam.Text = Convert.ToString(Veh.DuaDuam);
                txtTitulo.Text = Convert.ToString(Veh.Titulo);
                dtFechaTitulo.Value = Convert.ToDateTime(Veh.FechaTitulo);
                cbCondicion.Text = Veh.Condicion.ToString();
                txtPlaca.Text = Veh.Placa.ToString();
                txtPlacaAnterior.Text = Veh.PlacaAnterior.ToString();
                System.IO.MemoryStream ms = new System.IO.MemoryStream(Veh.FotoVehiculo);//para convertir a imagen
                pbFotoVehiculo.Image = System.Drawing.Bitmap.FromStream(ms);
            }
            else {
                MessageBox.Show("El Vehiculo no existe o esta inhabilitado, verifique.", "Vehiculo: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            btnActualizar.Enabled = true;
            btnInhabilitar.Enabled = true;
            btnBuscar.Enabled = true;
            btnRegistrar.Enabled = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

            btnRegistrar.Visible = true;
            LimpiarVariables();
            btnActualizar.Enabled = false;
            btnInhabilitar.Enabled = false;
            btnBuscar.Enabled = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //para convertir imagen
            MemoryStream archivoMemoria = new MemoryStream();
            pbFotoVehiculo.Image.Save(archivoMemoria, ImageFormat.Jpeg);
            try
            {
                EntVehiculo Veh = new EntVehiculo();
                Veh.IdVehiculo = Convert.ToInt32(txtIdVehiculo.Text.Trim());
                Veh.Categoria = txtCategoria.Text.Trim();
                Veh.Modelo = txtModelo.Text.Trim();
                Veh.Color = txtColor.Text.Trim();
                Veh.Motor = txtMotor.Text.Trim();
                Veh.Combustible = cbCombustible.Text.Trim();
                Veh.FormRodante = txtFormRodante.Text.Trim();
                Veh.AñoFabricacion = txtAñoFabricacion.Text.Trim();
                Veh.AñoModelo = txtAñoModelo.Text.Trim();
                Veh.Version = txtVersion.Text.Trim();
                Veh.Ejes = Convert.ToInt32(txtEjes.Text.Trim());
                Veh.Asientos = Convert.ToInt32(txtAsientos.Text.Trim());
                Veh.Pasajeros = Convert.ToInt32(txtPasajeros.Text.Trim());
                Veh.Ruedas = Convert.ToInt32(txtRuedas.Text.Trim());
                Veh.Carroceria = txtCarrocerias.Text.Trim();
                Veh.Potencia = txtPotencia.Text.Trim();
                Veh.Cilindros = Convert.ToInt32(txtCilindros.Text.Trim());
                Veh.Cilindrada = Convert.ToDouble(txtCilindrada.Text.Trim());
                Veh.PesoBruto = Convert.ToDouble(txtPesoBruto.Text.Trim());
                Veh.PesoNeto = Convert.ToDouble(txtPesoNeto.Text.Trim());
                Veh.CargaUtil = Convert.ToDouble(txtCargaUtil.Text.Trim());
                Veh.Longitud = Convert.ToDouble(txtLongitud.Text.Trim());
                Veh.Altura = Convert.ToDouble(txtAltura.Text.Trim());
                Veh.Ancho = Convert.ToDouble(txtAncho.Text.Trim());
                Veh.ZonaRegistro = txtZonaRegistro.Text.Trim();
                Veh.DuaDuam = Convert.ToInt32(txtDuaDuam.Text.Trim());
                Veh.Titulo = Convert.ToInt32(txtTitulo.Text.Trim());
                Veh.FechaTitulo = dtFechaTitulo.Value;
                Veh.Condicion = cbCondicion.Text.Trim();
                Veh.Placa = txtPlaca.Text.Trim();
                Veh.PlacaAnterior = txtPlacaAnterior.Text.Trim();
                Veh.FotoVehiculo = archivoMemoria.GetBuffer();

                LogVehiculo.Instancia.EditarVehiculo(Veh);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex);
            }
            ListarVehiculo();
            LimpiarVariables();
        }

        private void txtEjes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtAsientos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPasajeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtRuedas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCilindros_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCilindros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtDuaDuam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtTitulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtIdVehiculo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCilindrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) ||(e.KeyChar==47)|| (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Numeros Y un (.)permitidos ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPesoBruto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar == 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Numeros Y un (.)permitidos ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPesoNeto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar == 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Numeros Y un (.)permitidos ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCargaUtil_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar == 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Numeros Y un (.)permitidos ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtLongitud_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar == 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Numeros Y un (.)permitidos ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar == 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Numeros Y un (.)permitidos ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtAncho_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 45 && e.KeyChar<=47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Numeros Y un (.)permitidos ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
