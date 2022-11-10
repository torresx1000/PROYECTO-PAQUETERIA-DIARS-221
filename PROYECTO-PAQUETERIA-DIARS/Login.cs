using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CAPADATOS;

namespace PROYECTO_PAQUETERIA_DIARS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            OcultarPassword();
        }

        public void OcultarPassword() {
            textPassword.PasswordChar = '*';
        }

        SqlConnection cn = Conexion.Instancia.Conectar();
        public void InicioSesion(string usuario, string password)
        {
            try
            {
                
                cn.Open();
                SqlCommand cmd = new SqlCommand("select Nombres, Cargo from Trabajadores where Usuario=@usuario and Password=@password", cn);
                cmd.Parameters.AddWithValue("usuario", usuario);
                cmd.Parameters.AddWithValue("password", password);
                SqlDataAdapter datos = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                datos.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    
                    if (dt.Rows[0][1].ToString() == "Gerente")
                    {
                        FrmMenuGerente formMenuGerente = new FrmMenuGerente(dt.Rows[0][1].ToString(), dt.Rows[0][0].ToString());
                        formMenuGerente.ShowDialog();
                    }
                    else if (dt.Rows[0][1].ToString() == "Secretaria")
                    {
                        FrmMenuSecretaria formMenuSecretaria = new FrmMenuSecretaria();
                        formMenuSecretaria.ShowDialog();
                    }
                    else if (dt.Rows[0][1].ToString() == "Jefe de operaciones")
                    {
                        FrmMenuJefeDeOperaciones frmMenuJefeDeOperaciones = new FrmMenuJefeDeOperaciones(); 
                        frmMenuJefeDeOperaciones.ShowDialog();
                    }
                    else if (dt.Rows[0][1].ToString() == "Jefe mantenimiento")
                    {
                        FrmMenuJefeDeMantenimiento frmMenuJefeDeMantenimiento = new FrmMenuJefeDeMantenimiento();   
                        frmMenuJefeDeMantenimiento.ShowDialog();
                    }
                    else if (dt.Rows[0][1].ToString() == "Contador")
                    {
                        FrmMenuContador frmMenuContador = new FrmMenuContador();
                        frmMenuContador.ShowDialog();
                    }
                    else if (dt.Rows[0][1].ToString() == "Conductor")
                    {
                        FrmMenuConductor frmMenuConductor = new FrmMenuConductor();
                        frmMenuConductor.ShowDialog();
                    }
                    else if (dt.Rows[0][1].ToString() == "Cajero")
                    {
                        FrmMenuCajero frmMenuCajero = new FrmMenuCajero();
                        frmMenuCajero.ShowDialog();
                    }
                    else if (dt.Rows[0][1].ToString() == "Almacenero")
                    {
                        FrmMenuAlmacenero frmMenuAlmacenero = new FrmMenuAlmacenero();
                        frmMenuAlmacenero.ShowDialog();
                    }

                }
                else
                {
                    MessageBox.Show("Usuario y/o Contraseña Incorrecta");
                    textUsuario.Clear();
                    textPassword.Clear();
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally {
                cn.Close(); 
            }
        }
        private void SalirVentana_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
             string usu, pas;
             usu = textUsuario.Text.Trim();
             pas = textPassword.Text.Trim();
             if (usu.Length > 0 && pas.Length > 0)
             {
                 InicioSesion(usu, pas);
             }
             else {
                 MessageBox.Show("Debe Ingresar un usuario y contraseña");
             }
            /*
            FrmRemitente_Destinatario rem = new FrmRemitente_Destinatario();
        rem.ShowDialog();*/
            

           

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text= DateTime.Now.ToString("hh:mm:ss");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }

      
    
}
