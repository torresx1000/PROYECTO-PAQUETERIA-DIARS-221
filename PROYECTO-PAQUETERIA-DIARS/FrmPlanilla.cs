using CAPADATOS;
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
using CAPALOGICA;
namespace PROYECTO_PAQUETERIA_DIARS
{
    public partial class FrmPlanilla : Form
    {
        public FrmPlanilla()
        {
            InitializeComponent();
            ListarPlanilla();
            //llenarDatosComboIdAlumno();
        }

        ApisPeru ApisPeru = new ApisPeru();

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void LimpiarDatos()
        {
            txtIdPlanilla.Text = ("");
            txtRuc.Text = ("");
            txtRazSocial.Text = ("");
            txtRubro.Text = ("");
            txtDireccion.Text = ("");

            txtIdTr.Text = ("");
            txtDniTr.Text = ("");
            txtnomTr.Text = ("");
            txtAppTr.Text = ("");
            cboHijos.Text = ("");
            txtFechNacTr.Text = ("");
            txtDirTr.Text = ("");

            cboCargo.Text = ("");
            cboCategoria.Text = ("");
            cboPerPago.Text = ("");
            txtOnp.Text = ("");
            txtAfp.Text = ("");
            txtCuspp.Text = ("");
            txtImportOtro.Text = ("");

            dtmFechIngreso.Text = ("");
            dtmFechCese.Text = ("");
            dtmInitVac.Text = ("");
            dtmFindVac.Text = ("");
            txtDiasVac.Text = ("");
            txtDiasLAb.Text = ("");
            txtHrTrab.Text = ("");
            txtHrExtr.Text = ("");
            txtDiasNoLAb.Text = ("");
        }

        private void bunifuCustomLabel6_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarRuc_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtRuc.Text.Length == 11)
                {
                    dynamic respuesta = ApisPeru.Get("https://dniruc.apisperu.com/api/v1/ruc/" + txtRuc.Text + "?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJlbWFpbCI6InNhbnRvc2Jlcm51eTIwQGdtYWlsLmNvbSJ9.d7_Tcyi35EWR8QOFVdzd2OrcMiCP1D3juS5DZNOu6gQ");
                    txtRazSocial.Text = respuesta.razonSocial.ToString();
                    txtDireccion.Text = respuesta.direccion.ToString();
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

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }

        private void txtObsA1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
        }

        private void btnBuscarDni_Click(object sender, EventArgs e)
        {

        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void ListarPlanilla()
        {
            dataGridView1.DataSource = LogPlanilla.Instancia.ListarPlanilla();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //nuevo
            btnAgregar.Visible = true;
            LimpiarDatos();
            btnActualizar.Enabled = false;
            btnInhabilitar.Enabled = true;
            btnBuscar.Enabled = true;

        }/*
        private void llenarDatosComboIdAlumno()
        {
            txtIdTr.DataSource = LogTrabajador.Instancia.ListarTrabajador();
            txtIdTr.DisplayMember = "ApMaterno";//nombres
            txtIdTr.DisplayMember = "Nombres" + "ApMaterno";
          
            txtIdTr.ValueMember = "Nombres";
            
        }*/
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            EntPlanilla Ent = new EntPlanilla();
            //  Ent.IdPlanilla = Convert.ToInt32(txtIdPlanilla.Text.Trim());
            Ent.Ruc = Convert.ToDouble(txtRuc.Text.Trim());
            Ent.RazSocial = txtRazSocial.Text.Trim();
            Ent.Rubro = txtRubro.Text.Trim();
            Ent.Direccion = txtDireccion.Text.Trim();


            Ent.IdTr = Convert.ToInt32(txtIdTr.Text.Trim());
            Ent.DniTr = Convert.ToDouble(txtDniTr.Text.Trim());
            Ent.nomTr = txtnomTr.Text.Trim();
            Ent.AppTr = txtAppTr.Text.Trim();
            Ent.Hijos = Convert.ToInt32(cboHijos.Text.Trim());
            Ent.FechNacTr = Convert.ToDateTime(txtFechNacTr.Text.Trim());
            Ent.DirTr = txtDirTr.Text.Trim();

            Ent.Cargo = cboCargo.Text.Trim();
            Ent.Categoria = cboCategoria.Text.Trim();
            Ent.PerPago = cboPerPago.Text.Trim();
            Ent.Onp = txtOnp.Text.Trim();
            Ent.Afp = txtAfp.Text.Trim();
            Ent.Cuspp = txtCuspp.Text.Trim();
            Ent.ImportOtro = Convert.ToInt32(txtImportOtro.Text.Trim());

            Ent.FechIngreso = Convert.ToDateTime(dtmFechIngreso.Text.Trim());
            Ent.FechCese = Convert.ToDateTime(dtmFechCese.Text.Trim());
            Ent.InitVac = Convert.ToDateTime(dtmInitVac.Text.Trim());
            Ent.FindVac = Convert.ToDateTime(dtmFindVac.Text.Trim());
            Ent.DiasVac = Convert.ToInt32(txtDiasVac.Text.Trim());
            Ent.DiasLAb = Convert.ToInt32(txtDiasLAb.Text.Trim());
            Ent.HrTrab = Convert.ToInt32(txtHrTrab.Text.Trim());
            Ent.HrExtr = Convert.ToInt32(txtHrExtr.Text.Trim());
            Ent.DiasNoLAb = Convert.ToInt32(txtDiasNoLAb.Text.Trim());
            LogPlanilla.Instancia.InsertaPlanilla(Ent);
            ListarPlanilla();


        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            txtIdPlanilla.Focus();
            string IdPlanilla = txtIdPlanilla.Text.Trim();
            EntPlanilla Veh = LogPlanilla.Instancia.BuscarPlanillaDni(Convert.ToInt32(IdPlanilla));
            if (Veh != null && (Veh.Categoria == "Activo"))
            {
                txtIdPlanilla.Text = Convert.ToString(Veh.IdPlanilla);
                txtRuc.Text = Veh.Ruc.ToString();
                txtRazSocial.Text = Veh.RazSocial.ToString();
                txtRubro.Text = Veh.Rubro.ToString();
                txtDireccion.Text = Veh.Direccion.ToString();

                txtIdTr.Text = Veh.IdTr.ToString();
                txtDniTr.Text = Veh.DniTr.ToString();
                txtnomTr.Text = Veh.nomTr.ToString();
                txtAppTr.Text = Veh.AppTr.ToString();
                cboHijos.Text = Convert.ToString(Veh.Hijos);
                txtFechNacTr.Text = Veh.FechNacTr.ToString();
                txtDirTr.Text = Veh.DirTr.ToString();

                cboCargo.Text = Veh.Cargo.ToString();
                cboCategoria.Text = Veh.Categoria.ToString();
                cboPerPago.Text = Veh.PerPago.ToString();
                txtOnp.Text = Veh.Onp.ToString();
                txtAfp.Text = Veh.Afp.ToString();
                txtCuspp.Text = Veh.Cuspp.ToString();
                txtImportOtro.Text = Convert.ToString(Veh.ImportOtro);

                dtmFechIngreso.Text = Veh.FechIngreso.ToString();
                dtmFechCese.Text = Veh.FechCese.ToString();
                dtmInitVac.Text = Veh.InitVac.ToString();
                dtmFindVac.Text = Veh.FindVac.ToString();
                txtDiasVac.Text = Convert.ToString(Veh.DiasVac);
                txtImportOtro.Text = Convert.ToString(Veh.ImportOtro);
                txtDiasLAb.Text = Convert.ToString(Veh.DiasLAb);
                txtHrTrab.Text = Convert.ToString(Veh.HrTrab);
                txtHrExtr.Text = Convert.ToString(Veh.HrExtr);
                txtDiasNoLAb.Text = Convert.ToString(Veh.DiasNoLAb);
                LogPlanilla.Instancia.InsertaPlanilla(Veh);
                ListarPlanilla();
            }
            else
            {
                MessageBox.Show("La planilla no existe o esta inhabilitado, verifique.", "Vehiculo: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            btnActualizar.Enabled = true;
            btnInhabilitar.Enabled = true;
            btnBuscar.Enabled = true;
            btnAgregar.Enabled = false;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                EntPlanilla Ent = new EntPlanilla();
                Ent.IdPlanilla = Convert.ToInt32(txtIdPlanilla.Text.Trim());
                Ent.Ruc = Convert.ToDouble(txtRuc.Text.Trim());
                Ent.RazSocial = txtRazSocial.Text.Trim();
                Ent.Rubro = txtRubro.Text.Trim();
                Ent.Direccion = txtDireccion.Text.Trim();


                Ent.IdTr = Convert.ToInt32(txtIdTr.Text.Trim());
                Ent.DniTr = Convert.ToDouble(txtDniTr.Text.Trim());
                Ent.nomTr = txtnomTr.Text.Trim();
                Ent.AppTr = txtAppTr.Text.Trim();
                Ent.Hijos = Convert.ToInt32(cboHijos.Text.Trim());
                Ent.FechNacTr = Convert.ToDateTime(txtFechNacTr.Text.Trim());
                Ent.DirTr = txtDirTr.Text.Trim();

                Ent.Cargo = cboCargo.Text.Trim();
                Ent.Categoria = cboCategoria.Text.Trim();
                Ent.PerPago = cboPerPago.Text.Trim();
                Ent.Onp = txtOnp.Text.Trim();
                Ent.Afp = txtAfp.Text.Trim();
                Ent.Cuspp = txtCuspp.Text.Trim();
                Ent.ImportOtro = Convert.ToInt32(txtImportOtro.Text.Trim());

                Ent.FechIngreso = Convert.ToDateTime(dtmFechIngreso.Text.Trim());
                Ent.FechCese = Convert.ToDateTime(dtmFechCese.Text.Trim());
                Ent.InitVac = Convert.ToDateTime(dtmInitVac.Text.Trim());
                Ent.FindVac = Convert.ToDateTime(dtmFindVac.Text.Trim());
                Ent.DiasVac = Convert.ToInt32(txtDiasVac.Text.Trim());
                Ent.DiasLAb = Convert.ToInt32(txtDiasLAb.Text.Trim());
                Ent.HrTrab = Convert.ToInt32(txtHrTrab.Text.Trim());
                Ent.HrExtr = Convert.ToInt32(txtHrExtr.Text.Trim());
                Ent.DiasNoLAb = Convert.ToInt32(txtDiasNoLAb.Text.Trim());

                LogPlanilla.Instancia.ModificarPlanilla(Ent);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex);
            }
            ListarPlanilla();
            LimpiarDatos();
        }

        private void btnInhabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                EntPlanilla PLa = new EntPlanilla();
                PLa.IdPlanilla = Convert.ToInt32(txtIdPlanilla.Text);
                cboCategoria.Text = "INACTIVO";
                PLa.Categoria = cboCategoria.Text;
                LogPlanilla.Instancia.DeshabilitarPlanilla(PLa);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarDatos();
            ListarPlanilla();
        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
