using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using CAPAENTIDAD;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace CAPADATOS
{
    public class DatTrabajador:Conexion
    {
        private static readonly DatTrabajador _instancia = new DatTrabajador();
        public static new DatTrabajador Instancia
        {
            get
            {
                return DatTrabajador._instancia;
            }
        }
        //Para agregar trabajador
        public Boolean InsertaTrabajador(EntTrabajador Tra) {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarTrabajador",cn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@IdTrabajador", Tra.Id_Trabajador);
                cmd.Parameters.AddWithValue("@Dni",Tra.Dni);
                cmd.Parameters.AddWithValue("@Nombres", Tra.Nombres);
                cmd.Parameters.AddWithValue("@ApPaterno", Tra.ApPaterno);
                cmd.Parameters.AddWithValue("@ApMaterno", Tra.ApMaterno);
                cmd.Parameters.AddWithValue("@FechaNac", Tra.FechaNac);
                cmd.Parameters.AddWithValue("@Sexo", Tra.Sexo);
                cmd.Parameters.AddWithValue("@EstCivil", Tra.EstCivil);
                cmd.Parameters.AddWithValue("@Ubigeo", Tra.Ubigeo);
                cmd.Parameters.AddWithValue("@Direccion", Tra.Direccion);
                cmd.Parameters.AddWithValue("@Distrito", Tra.Distrito);
                cmd.Parameters.AddWithValue("@Provincia", Tra.Provincia);
                cmd.Parameters.AddWithValue("@Departamento", Tra.Departamento);
                cmd.Parameters.AddWithValue("@FechaContrato", Tra.FechaContrato);
                cmd.Parameters.AddWithValue("@Usuario", Tra.Usuario);
                cmd.Parameters.AddWithValue("@Password", Tra.Password);
                cmd.Parameters.AddWithValue("@Cargo", Tra.Cargo);
                cmd.Parameters.AddWithValue("@EstadoTrabajador", Tra.EstadoTrabajador);
                cmd.Parameters.AddWithValue("@PerfilTrabajador", Tra.PerfilTrabajador);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                } 
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return inserta;
        }

        //listar Trabajadores
        public List<EntTrabajador> ListarTrabajador() {
            SqlCommand cmd = null;
            List<EntTrabajador> Lista=new List<EntTrabajador> ();

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarTrabajador", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read()) { 
                    EntTrabajador Tra = new EntTrabajador();
                    Tra.Id_Trabajador = Convert.ToInt32(dr["IdTrabajador"]);
                    Tra.Dni = Convert.ToInt32(dr["Dni"]);
                    Tra.Nombres = dr["Nombres"].ToString(); ;
                    Tra.ApPaterno = dr["ApPaterno"].ToString();
                    Tra.ApMaterno = dr["ApMaterno"].ToString();
                    Tra.FechaNac = Convert.ToDateTime(dr["FechaNac"]);
                    Tra.Sexo = dr["Sexo"].ToString();
                    Tra.EstCivil = dr["EstCivil"].ToString();
                    Tra.Ubigeo = Convert.ToInt32(dr["Ubigeo"]);
                    Tra.Direccion = dr["Direccion"].ToString();
                    Tra.Distrito = dr["Distrito"].ToString();
                    Tra.Provincia = dr["Provincia"].ToString();
                    Tra.Departamento = dr["Departamento"].ToString(); ;
                    Tra.FechaContrato = Convert.ToDateTime(dr["FechaContrato"]);
                    Tra.Usuario = dr["Usuario"].ToString();
                    Tra.Password = dr["Password"].ToString();
                    Tra.Cargo = dr["Cargo"].ToString();
                    Tra.EstadoTrabajador = Convert.ToBoolean(dr["EstadoTrabajador"]);
                    Tra.PerfilTrabajador = (byte[])dr["PerfilTrabajador"];
                    Lista.Add(Tra);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { 
                cmd.Connection.Close();
            }
            return Lista;
        }

        //Modificar Trabajador
        public Boolean EditarTrabajador(EntTrabajador Tra) {
            SqlCommand cmd = null;
            Boolean Edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spModificarTrabajador",cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdTrabajador", Tra.Id_Trabajador);
                cmd.Parameters.AddWithValue("@Dni", Tra.Dni);
                cmd.Parameters.AddWithValue("@Nombres", Tra.Nombres);
                cmd.Parameters.AddWithValue("@ApPaterno", Tra.ApPaterno);
                cmd.Parameters.AddWithValue("@ApMaterno", Tra.ApMaterno);
                cmd.Parameters.AddWithValue("@FechaNac", Tra.FechaNac);
                cmd.Parameters.AddWithValue("@Sexo", Tra.Sexo);
                cmd.Parameters.AddWithValue("@EstCivil", Tra.EstCivil);
                cmd.Parameters.AddWithValue("@Ubigeo", Tra.Ubigeo);
                cmd.Parameters.AddWithValue("@Direccion", Tra.Direccion);
                cmd.Parameters.AddWithValue("@Distrito", Tra.Distrito);
                cmd.Parameters.AddWithValue("@Provincia", Tra.Provincia);
                cmd.Parameters.AddWithValue("@Departamento", Tra.Departamento);
                cmd.Parameters.AddWithValue("@FechaContrato", Tra.FechaContrato);
                cmd.Parameters.AddWithValue("@Usuario", Tra.Usuario);
                cmd.Parameters.AddWithValue("@Password", Tra.Password);
                cmd.Parameters.AddWithValue("@Cargo", Tra.Cargo);
                cmd.Parameters.AddWithValue("@EstadoTrabajador", Tra.EstadoTrabajador);
                cmd.Parameters.AddWithValue("@PerfilTrabajador", Tra.PerfilTrabajador);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    Edita = true;
                }
            }
            catch (Exception e) {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return Edita;
        }

        //para buscar Trabajador por dni
        public EntTrabajador BuscarTrabajadorDni(int Dni) {
            SqlCommand cmd = null;
            EntTrabajador Tra = new EntTrabajador();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarTrabajador",cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Dni", Dni);
                cn.Open();
                SqlDataReader dr=cmd.ExecuteReader();
                while (dr.Read()) {
                    Tra.Id_Trabajador = Convert.ToInt32(dr["IdTrabajador"]);
                    Tra.Dni = Convert.ToInt32(dr["Dni"]);
                    Tra.Nombres = dr["Nombres"].ToString(); ;
                    Tra.ApPaterno = dr["ApPaterno"].ToString();
                    Tra.ApMaterno = dr["ApMaterno"].ToString();
                    Tra.FechaNac = Convert.ToDateTime(dr["FechaNac"]);
                    Tra.Sexo = dr["Sexo"].ToString();
                    Tra.EstCivil = dr["EstCivil"].ToString();
                    Tra.Ubigeo = Convert.ToInt32(dr["Ubigeo"]);
                    Tra.Direccion = dr["Direccion"].ToString();
                    Tra.Distrito = dr["Distrito"].ToString();
                    Tra.Provincia = dr["Provincia"].ToString();
                    Tra.Departamento = dr["Departamento"].ToString(); ;
                    Tra.FechaContrato = Convert.ToDateTime(dr["FechaContrato"]);
                    Tra.Usuario = dr["Usuario"].ToString();
                    Tra.Password = dr["Password"].ToString();
                    Tra.Cargo = dr["Cargo"].ToString();
                    Tra.EstadoTrabajador = Convert.ToBoolean(dr["EstadoTrabajador"]);
                    Tra.PerfilTrabajador = (byte[])dr["PerfilTrabajador"];
                }
            }
            catch (Exception e) {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return Tra;
        }
        //buscar trabajador para reporte
        public DataTable BuscarTrabajadores(string Nombre)
        {
            DataTable dt;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarTrabajadorN", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombres", Nombre);
                cn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                da.Dispose();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return dt;
        }
        //para deshabilitar Trabajador(por DNI)
        public Boolean DeshabilitarTrabajador(EntTrabajador Tra) { 
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarTrabajador", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Dni", Tra.Dni);
                cmd.Parameters.AddWithValue("@EstadoTrabajador", Tra.EstadoTrabajador);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0) {
                    delete = true;
                }
            }
            catch (Exception e) {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return delete = true;
        }
        //listar Trabajadores
        public List<EntTrabajador> ListarConductor()
        {
            SqlCommand cmd = null;
            List<EntTrabajador> Lista = new List<EntTrabajador>();

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarTrabajadorConductores", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntTrabajador Tra = new EntTrabajador();
                    Tra.Id_Trabajador = Convert.ToInt32(dr["IdTrabajador"]);
                    Tra.Dni = Convert.ToInt32(dr["Dni"]);
                    Tra.Nombres = dr["Nombres"].ToString(); ;
                    Tra.ApPaterno = dr["ApPaterno"].ToString();
                    Tra.ApMaterno = dr["ApMaterno"].ToString();
                    Tra.FechaNac = Convert.ToDateTime(dr["FechaNac"]);
                    Tra.Sexo = dr["Sexo"].ToString();
                    Tra.EstCivil = dr["EstCivil"].ToString();
                    Tra.Ubigeo = Convert.ToInt32(dr["Ubigeo"]);
                    Tra.Direccion = dr["Direccion"].ToString();
                    Tra.Distrito = dr["Distrito"].ToString();
                    Tra.Provincia = dr["Provincia"].ToString();
                    Tra.Departamento = dr["Departamento"].ToString(); ;
                    Tra.FechaContrato = Convert.ToDateTime(dr["FechaContrato"]);
                    Tra.Usuario = dr["Usuario"].ToString();
                    Tra.Password = dr["Password"].ToString();
                    Tra.Cargo = dr["Cargo"].ToString();
                    Tra.EstadoTrabajador = Convert.ToBoolean(dr["EstadoTrabajador"]);
                    Tra.PerfilTrabajador = (byte[])dr["PerfilTrabajador"];
                    Lista.Add(Tra);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return Lista;
        }

        public List<EntTrabajador> ListarScretaria()
        {
            SqlCommand cmd = null;
            List<EntTrabajador> Lista = new List<EntTrabajador>();

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarTrabajadorSecretarias", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntTrabajador Tra = new EntTrabajador();
                    Tra.Id_Trabajador = Convert.ToInt32(dr["IdTrabajador"]);
                    Tra.Dni = Convert.ToInt32(dr["Dni"]);
                    Tra.Nombres = dr["Nombres"].ToString(); ;
                    Tra.ApPaterno = dr["ApPaterno"].ToString();
                    Tra.ApMaterno = dr["ApMaterno"].ToString();
                    Tra.FechaNac = Convert.ToDateTime(dr["FechaNac"]);
                    Tra.Sexo = dr["Sexo"].ToString();
                    Tra.EstCivil = dr["EstCivil"].ToString();
                    Tra.Ubigeo = Convert.ToInt32(dr["Ubigeo"]);
                    Tra.Direccion = dr["Direccion"].ToString();
                    Tra.Distrito = dr["Distrito"].ToString();
                    Tra.Provincia = dr["Provincia"].ToString();
                    Tra.Departamento = dr["Departamento"].ToString(); ;
                    Tra.FechaContrato = Convert.ToDateTime(dr["FechaContrato"]);
                    Tra.Usuario = dr["Usuario"].ToString();
                    Tra.Password = dr["Password"].ToString();
                    Tra.Cargo = dr["Cargo"].ToString();
                    Tra.EstadoTrabajador = Convert.ToBoolean(dr["EstadoTrabajador"]);
                    Tra.PerfilTrabajador = (byte[])dr["PerfilTrabajador"];
                    Lista.Add(Tra);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return Lista;
        }
    }
}
