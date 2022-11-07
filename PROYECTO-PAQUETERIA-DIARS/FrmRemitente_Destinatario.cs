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
        }
        public void LimpiarVariables()
        {
            txtIdPedido.Text = ("");
            txtDniR.Text = ("");
            txtCorreoR.Text = ("");
            txtTelefonoR.Text = ("");
            txtDireccionR.Text = ("");
            txtNombresR.Text = ("");
            txtObservacionesR.Text = ("");
            txtDistritoR.Text = ("");
            txtProvinciaR.Text = ("");
            txtDepartamentoR.Text = ("");
            txtContactoR.Text = ("");

            txtDniD.Text = ("");
            txtCorreoD.Text = ("");
            txtTelefonoD.Text = ("");
            txtDireccionD.Text = ("");
            txtNombresD.Text = ("");
            txtObservacionesD.Text = ("");
            txtDistritoD.Text = ("");
            txtProvinciaD.Text = ("");
            txtDepartamentoR.Text = ("");
            txtContactoR.Text = ("");
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

                c.DniR = Convert.ToInt32(txtDniR.Text.Trim());
                c.CorreoR = txtCorreoR.Text.Trim();
                c.TelefonoR = int.Parse(txtTelefonoR.Text.Trim());
                c.DireccionR = txtDireccionR.Text.Trim();
                c.NombreR = txtNombresR.Text.Trim();
                c.ObservacionesR = txtObservacionesR.Text.Trim();
                c.ContactoR = int.Parse(txtContactoR.Text.Trim());
                c.DistritoR = txtDistritoR.Text.Trim();
                c.ProvinciaR = txtProvinciaR.Text.Trim();
                c.DepartamentoR = txtDepartamentoR.Text.Trim();

                c.DniD = Convert.ToInt32(txtDniD.Text.Trim());
                c.CorreoD = txtCorreoD.Text.Trim();
                c.TelefonoD = Convert.ToInt32(txtTelefonoD.Text.Trim());
                c.DireccionD = txtDireccionD.Text.Trim();
                c.NombreD = txtNombresD.Text.Trim();
                c.ObservacionesD = txtObservacionesD.Text.Trim();
                c.ContactoD = Convert.ToInt32(txtContactoD.Text.Trim());
                c.DistritoD = txtDistritoD.Text.Trim();
                c.ProvinciaD = txtProvinciaD.Text.Trim();
                c.DepartamentoD = txtDepartamentoD.Text.Trim();

              
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
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbRemitente.Enabled = true;
            gbDestinatario.Enabled = true;
            LimpiarVariables();
            btnRegistrar.Visible = true;
            btnActualizar.Enabled = false;
            btnInabilitar.Enabled = false;
         
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtIdPedido.Focus();
            int idPedidoo = Convert.ToInt32(txtIdPedido.Text.Trim());
            EntPedido Ent = LogPedido.Instancia.BuscarPedidoId(idPedidoo);
            if (Ent != null)
            {
                txtIdPedido.Text = Convert.ToString(Ent.IdPedido);
                txtDniR.Text = Convert.ToString(Ent.DniR);
                txtCorreoR.Text = Convert.ToString(Ent.CorreoR);
                txtTelefonoR.Text = Convert.ToString(Ent.TelefonoR);
                txtDireccionR.Text = Ent.DireccionR.ToString();
                txtNombresR.Text = Ent.NombreR.ToString();
                txtObservacionesR.Text = Ent.ObservacionesR.ToString();
                txtContactoR.Text = Convert.ToString(Ent.ContactoR);
                txtDistritoR.Text = Ent.DistritoR.ToString();
                txtProvinciaR.Text = Ent.ProvinciaR.ToString();
                txtDepartamentoR.Text = Ent.DepartamentoR.ToString();

                txtDniD.Text = Convert.ToString(Ent.DniD);
                txtCorreoD.Text = Convert.ToString(Ent.CorreoD);
                txtTelefonoD.Text = Convert.ToString(Ent.TelefonoD);
                txtDireccionD.Text = Ent.DireccionD.ToString();
                txtNombresD.Text = Ent.NombreD.ToString();
                txtObservacionesD.Text = Ent.ObservacionesD.ToString();
                txtContactoD.Text = Convert.ToString(Ent.ContactoD);
                txtDistritoD.Text = Ent.DistritoD.ToString();
                txtProvinciaD.Text = Ent.ProvinciaD.ToString();
                txtDepartamentoD.Text = Ent.DepartamentoD.ToString();
                }
            else
            {
                MessageBox.Show("El Trabajdor no existe or esta inhabilitado, verifique.", "Trabajador: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            gbRemitente.Enabled = true;
            gbDestinatario.Enabled = true;
            LimpiarVariables();
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
            DataGridViewRow  filaActual = dataGridView1.Rows[e.RowIndex]; //
            txtIdPedido.Text =            filaActual.Cells[0].Value.ToString();
            txtDniR.Text =                filaActual.Cells[1].Value.ToString();
            txtCorreoR.Text =             filaActual.Cells[2].Value.ToString();
            txtTelefonoR.Text =           filaActual.Cells[3].Value.ToString();
            txtDireccionR.Text =          filaActual.Cells[4].Value.ToString();
            txtNombresR.Text =            filaActual.Cells[5].Value.ToString();
            txtObservacionesR.Text =      filaActual.Cells[6].Value.ToString();
            txtContactoR.Text =           filaActual.Cells[7].Value.ToString();
            txtDistritoR.Text =           filaActual.Cells[8].Value.ToString();
            txtProvinciaR.Text =          filaActual.Cells[9].Value.ToString();
            txtDepartamentoR.Text =       filaActual.Cells[10].Value.ToString();
            txtDniD.Text = filaActual.Cells[11].Value.ToString();
            txtCorreoD.Text = filaActual.Cells[12].Value.ToString();
            txtTelefonoD.Text = filaActual.Cells[13].Value.ToString();
            txtDireccionD.Text = filaActual.Cells[14].Value.ToString();
            txtNombresD.Text = filaActual.Cells[15].Value.ToString();
            txtObservacionesD.Text = filaActual.Cells[16].Value.ToString();
            txtContactoD.Text = filaActual.Cells[17].Value.ToString();
            txtDistritoD.Text = filaActual.Cells[18].Value.ToString();
            txtProvinciaD.Text = filaActual.Cells[19].Value.ToString();
            txtDepartamentoD.Text = filaActual.Cells[20].Value.ToString();





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
    }
}
