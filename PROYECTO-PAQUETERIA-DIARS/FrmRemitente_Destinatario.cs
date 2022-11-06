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
            Close();
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
    }
}
