using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using CAPALOGICA;
using CAPAENTIDAD;
using CAPADATOS;

namespace PROYECTO_PAQUETERIA_DIARS
{
   
    public partial class FrmRemitente_Destinatario : Form
    {
        ApisPeru ApisPeru = new ApisPeru();
        public FrmRemitente_Destinatario()
        {
            InitializeComponent();
            ListarPedido();
            LimpiarVariables();
            gbRemitente.Enabled = false;
            gbDestinatario.Enabled = false;
            GenerarAleatorio();
        }
        public void LimpiarVariables()
        {
            txtIdPedido.Text = ("");
            txtDniR.Text = ("");
            txtCorreoR.Text = ("");
            txtTelefonoR.Text = ("");
            txtDireccionR.Text = ("");
            txtNombresR.Text = ("");
            txtDistritoR.Text = ("");
            txtProvinciaR.Text = ("");
            txtDepartamentoR.Text = ("");

            txtDniD.Text = ("");
            txtCorreoD.Text = ("");
            txtTelefonoD.Text = ("");
            txtDireccionD.Text = ("");
            txtNombresD.Text = ("");
            txtDistritoD.Text = ("");
            txtProvinciaD.Text = ("");
            txtDepartamentoR.Text = ("");
        }
        public void GenerarAleatorio() { 

        Random alea= new Random();
        txtCodigoPaquete.Text=alea.Next().ToString();
        }
        public void ListarPedido()
        {
            dataGridView1.DataSource =LogPedido.Instancia.ListarPedido();
        }
        private void button8_Click(object sender, EventArgs e)
        {

            try
            {
                EntPedido c = new EntPedido();
                c.IdEncargado=Convert.ToInt32(FrmReporteSecretaria.id);
                c.Responsable = txtResponsable.Text.Trim();
                c.DniR = Convert.ToInt32(txtDniR.Text.Trim());
                c.NombreR = txtNombresR.Text.Trim();
                c.CorreoR = txtCorreoR.Text.Trim();
                c.TelefonoR = int.Parse(txtTelefonoR.Text.Trim());
                c.DireccionR = txtDireccionR.Text.Trim();
                c.DistritoR = txtDistritoR.Text.Trim();
                c.ProvinciaR = txtProvinciaR.Text.Trim();
                c.DepartamentoR = txtDepartamentoR.Text.Trim();

                c.DniD = Convert.ToInt32(txtDniD.Text.Trim());
                c.NombreD = txtNombresD.Text.Trim();
                c.CorreoD = txtCorreoD.Text.Trim();
                c.TelefonoD = Convert.ToInt32(txtTelefonoD.Text.Trim());
                c.DireccionD = txtDireccionD.Text.Trim();
                c.DistritoD = txtDistritoD.Text.Trim();
                c.ProvinciaD = txtProvinciaD.Text.Trim();
                c.DepartamentoD = txtDepartamentoD.Text.Trim();

                c.CodigoPaquete = Convert.ToInt32(txtCodigoPaquete.Text.Trim());
                c.CantidadPaquete = Convert.ToInt32(txtCantidadPaquete.Text.Trim());
                c.CategoriaPedido = cbCategoriaPaquete.Text.Trim();
                c.DescripcionPedido = txtDescripcionPaquete.Text.Trim();
                c.IdLote = Convert.ToInt32(txtLote.Text.Trim());

                LogPedido.Instancia.InsertarPedido(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbRemitente.Enabled = false;
            gbDestinatario.Enabled = false;
            ListarPedido();
        }
        private void button4_Click(object sender, EventArgs e)
        {
         
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
            GenerarAleatorio();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbRemitente.Enabled = true;
            gbDestinatario.Enabled = true;
            LimpiarVariables();
            btnRegistrar.Visible = true;
            btnActualizar.Enabled = false;
            btnInabilitar.Enabled = false;
            txtResponsable.Enabled = true;
         
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtIdPedido.Focus();
            int idPedidoo = Convert.ToInt32(txtIdPedido.Text.Trim());
            EntPedido Ent = LogPedido.Instancia.BuscarPedidoId(idPedidoo);
            if (Ent != null)
            {
                txtIdPedido.Text = Convert.ToString(Ent.IdPedido);
                txtIdResp.Text = Convert.ToString(Ent.IdEncargado);
                txtResponsable.Text = Ent.Responsable.ToString();
                txtDniR.Text = Convert.ToString(Ent.DniR);
                txtNombresR.Text = Ent.NombreR.ToString();
                txtCorreoR.Text = Convert.ToString(Ent.CorreoR);
                txtTelefonoR.Text = Convert.ToString(Ent.TelefonoR);
                txtDireccionR.Text = Ent.DireccionR.ToString();
                txtDistritoR.Text = Ent.DistritoR.ToString();
                txtProvinciaR.Text = Ent.ProvinciaR.ToString();
                txtDepartamentoR.Text = Ent.DepartamentoR.ToString();

                txtDniD.Text = Convert.ToString(Ent.DniD);
                txtCorreoD.Text = Convert.ToString(Ent.CorreoD);
                txtTelefonoD.Text = Convert.ToString(Ent.TelefonoD);
                txtDireccionD.Text = Ent.DireccionD.ToString();
                txtNombresD.Text = Ent.NombreD.ToString();
                txtDistritoD.Text = Ent.DistritoD.ToString();
                txtProvinciaD.Text = Ent.ProvinciaD.ToString();
                txtDepartamentoD.Text = Ent.DepartamentoD.ToString();

                txtCodigoPaquete.Text = Convert.ToString(Ent.CodigoPaquete);
                txtCantidadPaquete.Text = Convert.ToString(Ent.CantidadPaquete);
                cbCategoriaPaquete.Text = Ent.CategoriaPedido.ToString();
                txtDescripcionPaquete.Text = Ent.DescripcionPedido.ToString();
                txtLote.Text = Convert.ToString(Ent.IdLote);
            }
            else
            {
                MessageBox.Show("El Trabajdor no existe or esta inhabilitado, verifique.", "Trabajador: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            gbRemitente.Enabled = true;
            gbDestinatario.Enabled = true;
            btnRegistrar.Visible = false;
            btnActualizar.Enabled = true;
            btnInabilitar.Enabled = true;
            btnBuscar.Enabled = true;

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow  filaActual = dataGridView1.Rows[e.RowIndex]; 
            txtIdPedido.Text = filaActual.Cells[0].Value.ToString();
            txtIdResp.Text= filaActual.Cells[1].Value.ToString();
            txtResponsable.Text = filaActual.Cells[2].Value.ToString();
            txtDniR.Text =  filaActual.Cells[3].Value.ToString();
            txtNombresR.Text = filaActual.Cells[4].Value.ToString();
            txtCorreoR.Text =  filaActual.Cells[5].Value.ToString();
            txtTelefonoR.Text =  filaActual.Cells[6].Value.ToString();
            txtDireccionR.Text = filaActual.Cells[7].Value.ToString();
            txtDistritoR.Text = filaActual.Cells[8].Value.ToString();
            txtProvinciaR.Text =  filaActual.Cells[9].Value.ToString();
            txtDepartamentoR.Text =  filaActual.Cells[10].Value.ToString();

            txtDniD.Text = filaActual.Cells[11].Value.ToString();
            txtNombresD.Text = filaActual.Cells[12].Value.ToString();
            txtCorreoD.Text = filaActual.Cells[13].Value.ToString();
            txtTelefonoD.Text = filaActual.Cells[14].Value.ToString();
            txtDireccionD.Text = filaActual.Cells[15].Value.ToString();
            txtDistritoD.Text = filaActual.Cells[16].Value.ToString();
            txtProvinciaD.Text = filaActual.Cells[17].Value.ToString();
            txtDepartamentoD.Text = filaActual.Cells[18].Value.ToString();

            txtCodigoPaquete.Text = filaActual.Cells[19].Value.ToString();
            txtCantidadPaquete.Text = filaActual.Cells[20].Value.ToString();
            cbCategoriaPaquete.Text = filaActual.Cells[21].Value.ToString();
            txtDescripcionPaquete.Text = filaActual.Cells[22].Value.ToString();
            txtLote.Text = filaActual.Cells[23].Value.ToString();
        }

    private void SalirVentana_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDniD.Text.Length == 8)
                {
                    dynamic respuesta = ApisPeru.Get("https://dniruc.apisperu.com/api/v1/dni/" + txtDniD.Text + "?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJlbWFpbCI6InNhbnRvc2Jlcm51eTIwQGdtYWlsLmNvbSJ9.d7_Tcyi35EWR8QOFVdzd2OrcMiCP1D3juS5DZNOu6gQ");
                    string Nombres = respuesta.nombres.ToString();
                    string apellidosP = respuesta.apellidoPaterno.ToString();
                    string apellidosM = respuesta.apellidoMaterno.ToString();
                    txtNombresD.Text = Nombres + " " + apellidosP + " " + apellidosM;
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDniR.Text.Length == 8)
                {
                    dynamic respuesta = ApisPeru.Get("https://dniruc.apisperu.com/api/v1/dni/" + txtDniR.Text + "?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJlbWFpbCI6InNhbnRvc2Jlcm51eTIwQGdtYWlsLmNvbSJ9.d7_Tcyi35EWR8QOFVdzd2OrcMiCP1D3juS5DZNOu6gQ");
                    string Nombres = respuesta.nombres.ToString();
                    string apellidosP = respuesta.apellidoPaterno.ToString();
                    string apellidosM = respuesta.apellidoMaterno.ToString();
                    txtNombresR.Text = Nombres + " " + apellidosP + " " + apellidosM;
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

        private void btnInabilitar_Click(object sender, EventArgs e)
        {

        }

        private void btnSeleccionarLote_Click(object sender, EventArgs e)
        {
            FrmReporteLote FrmReporteLote = new FrmReporteLote();
            FrmReporteLote.ShowDialog();
            txtLote.Text = FrmReporteLote.IdLote;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmReporteSecretaria frmReporteSecretaria = new FrmReporteSecretaria();
            frmReporteSecretaria.ShowDialog();
            txtResponsable.Text = FrmReporteSecretaria.nombre;
            txtIdResp.Text = FrmReporteSecretaria.id;
        }
    }
}
