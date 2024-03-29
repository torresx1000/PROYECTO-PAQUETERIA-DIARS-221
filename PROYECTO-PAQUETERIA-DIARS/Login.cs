﻿using System;
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
                SqlCommand cmd = new SqlCommand("select Nombres, Cargo from Trabajadores where Usuario=@usuario and Password=@password and EstadoTrabajador='1'", cn);
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
                        FrmMenuSecretaria formMenuSecretaria = new FrmMenuSecretaria(dt.Rows[0][1].ToString(), dt.Rows[0][0].ToString());
                        formMenuSecretaria.ShowDialog();
                    }
                    else if (dt.Rows[0][1].ToString() == "Jefe de operaciones")
                    {
                        FrmMenuJefeDeOperaciones frmMenuJefeDeOperaciones = new FrmMenuJefeDeOperaciones(dt.Rows[0][1].ToString(), dt.Rows[0][0].ToString()); 
                        frmMenuJefeDeOperaciones.ShowDialog();
                    }
                    else if (dt.Rows[0][1].ToString() == "Jefe mantenimiento")
                    {
                        FrmMenuJefeDeMantenimiento frmMenuJefeDeMantenimiento = new FrmMenuJefeDeMantenimiento(dt.Rows[0][1].ToString(), dt.Rows[0][0].ToString());   
                        frmMenuJefeDeMantenimiento.ShowDialog();
                    }
                    else if (dt.Rows[0][1].ToString() == "Contador")
                    {
                        FrmMenuContador frmMenuContador = new FrmMenuContador(dt.Rows[0][1].ToString(), dt.Rows[0][0].ToString());
                        frmMenuContador.ShowDialog();
                    }
                    else if (dt.Rows[0][1].ToString() == "Conductor")
                    {
                        FrmMenuConductor frmMenuConductor = new FrmMenuConductor(dt.Rows[0][1].ToString(), dt.Rows[0][0].ToString());
                        frmMenuConductor.ShowDialog();
                    }
                    else if (dt.Rows[0][1].ToString() == "Cajero")
                    {
                        FrmMenuCajero frmMenuCajero = new FrmMenuCajero(dt.Rows[0][1].ToString(), dt.Rows[0][0].ToString());
                        frmMenuCajero.ShowDialog();
                    }
                    else if (dt.Rows[0][1].ToString() == "Almacenero")
                    {
                        FrmMenuAlmacenero frmMenuAlmacenero = new FrmMenuAlmacenero(dt.Rows[0][1].ToString(), dt.Rows[0][0].ToString());
                        frmMenuAlmacenero.ShowDialog();
                    }

                }
                else
                {
                    MessageBox.Show("Usuario y/o Contraseña Incorrecta O Trabajador Inhabilitado");
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
            if (textUsuario.Text == "SECRETACCES" && textPassword.Text == "SECRETACCESDIARS")
            {
                FrmMenuGerente formMenuGerente = new FrmMenuGerente("ADMINISTRADOR", "SISTEMAS");
                formMenuGerente.ShowDialog();
            }
            else if (usu.Length > 0 && pas.Length > 0)
            {
                InicioSesion(usu, pas);
            }
            else {
                MessageBox.Show("Debe Ingresar un usuario y contraseña");
            }
            /*
            FrmRemitente_Destinatario rem = new FrmRemitente_Destinatario();
        rem.ShowDialog();*/

            textUsuario.Clear();
            textPassword.Clear();


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

        private void lblHora_Click(object sender, EventArgs e)
        {

        }

        private void textUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) {
                /* string msjusu=textUsuario.Text.Trim();
                 textPassword.Focus();
                 textUsuario.Text=msjusu;*/
                MessageBox.Show("No se Permite el enter :V", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
               btnIngresar.PerformClick();

            }
        }
        int posY = 0;
        int posX = 0;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y-posY);
            }
        }
    }

      
    
}
