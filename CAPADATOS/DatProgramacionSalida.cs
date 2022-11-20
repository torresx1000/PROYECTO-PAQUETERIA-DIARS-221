using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using CAPAENTIDAD;

namespace CAPADATOS
{
    public class DatProgramacionSalida : Conexion
    {
        private static readonly DatProgramacionSalida _instancia = new DatProgramacionSalida();
        public static new DatProgramacionSalida Instancia
        {
            get
            {
                return DatProgramacionSalida._instancia;
            }
        }

        //para insertar datos en programacion de salida 
        public Boolean InsertarProgramacionSalida(EntProgramacionSalida Pro) {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarProgramacionSalida", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@IdProgramacionSalida", Pro.IdProgramacionSalida);
                cmd.Parameters.AddWithValue("@FechaInicio", Pro.FechaInicio);
                cmd.Parameters.AddWithValue("@FechaFin", Pro.FechaFin);
                cmd.Parameters.AddWithValue("@IdRuta", Pro.IdRuta);
                cmd.Parameters.AddWithValue("@IdConductor", Pro.IdConductor);
                cmd.Parameters.AddWithValue("@IdVehiculo", Pro.IdVehiculo);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0) {
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

        //para modificar programacion de salida 
        public Boolean EditarProgramacionSalida(EntProgramacionSalida Pro) {
            SqlCommand cmd = null;
            Boolean Edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spModificarProgramacionSalida", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdProgramacionSalida", Pro.IdProgramacionSalida);
                cmd.Parameters.AddWithValue("@FechaInicio", Pro.FechaInicio);
                cmd.Parameters.AddWithValue("@FechaFin", Pro.FechaFin);
                cmd.Parameters.AddWithValue("@IdRuta", Pro.IdRuta);
                cmd.Parameters.AddWithValue("@IdConductor", Pro.IdConductor);
                cmd.Parameters.AddWithValue("@IdVehiculo", Pro.IdVehiculo);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    Edita = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return Edita;
        }
        //para buscar programacion de salida por el Id 
        public EntProgramacionSalida BuscarProgamacionSalida(int id) {
            SqlCommand cmd = null;
            EntProgramacionSalida pro = new EntProgramacionSalida();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarProgramacionSalida", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdProgramacionSalida", id);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read()) {
                    pro.IdProgramacionSalida = Convert.ToInt32(dr["IdProgramacionSalida"].ToString());
                    pro.FechaInicio = Convert.ToDateTime(dr["FechaInicio"]);
                    pro.FechaFin = Convert.ToDateTime(dr["FechaFin"]);
                    pro.IdRuta = Convert.ToInt32(dr["IdRuta"].ToString());
                    pro.IdConductor = Convert.ToInt32(dr["IdConductor"].ToString());
                    pro.IdVehiculo = Convert.ToInt32(dr["IdVehiculo"].ToString());
                }
            } catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return pro;
        }
        public DataTable BuscarProgramacion(int id)
        {
            DataTable dt;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarProgramacionSalida", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdProgramacionSalida", id);
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
        //para buscar conductor de programacion de salida lo intamos
        /* public EntProgramacionSalida BuscarConPro(int id) {
             SqlCommand cmd = null;
             EntProgramacionSalida pro = new EntProgramacionSalida();
             EntTrabajador tra = new EntTrabajador();
             try
             {
                 SqlConnection cn = Conexion.Instancia.Conectar();
                 cmd = new SqlCommand("spBuscarConductorPro", cn);
                 cmd.CommandType = CommandType.StoredProcedure;
                 cmd.Parameters.AddWithValue("@IdProgramacionSalida", id);
                 cn.Open();
                 SqlDataReader dr = cmd.ExecuteReader();
                 while (dr.Read())
                 {
                     pro.IdConductor = Convert.ToInt32(dr["Nombres"].ToString());
                     //tra.Nombres = dr["Nombres"].ToString();
                 }
             }
             catch (Exception e)
             {
                 throw e;
             }
             finally { cmd.Connection.Close(); }
             return pro;
         }*/

        //para listar programacion de salida
        public List<EntProgramacionSalida> ListarProgramacionSalida() {
            SqlCommand cmd = null;
            List<EntProgramacionSalida> Lista = new List<EntProgramacionSalida>();

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarProgramacionSalida", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntProgramacionSalida pro = new EntProgramacionSalida();
                    pro.IdProgramacionSalida = Convert.ToInt32(dr["IdProgramacionSalida"].ToString());
                    pro.FechaInicio = Convert.ToDateTime(dr["FechaInicio"]);
                    pro.FechaFin = Convert.ToDateTime(dr["FechaFin"]);
                    pro.IdRuta = Convert.ToInt32(dr["IdRuta"].ToString());
                    pro.IdConductor = Convert.ToInt32(dr["IdConductor"].ToString());
                    pro.IdVehiculo = Convert.ToInt32(dr["IdVehiculo"].ToString());
                    Lista.Add(pro);
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
        //para eliminar programacion de salida 
        public Boolean EliminarProgramacionSalida(EntProgramacionSalida pro) {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEliminarProgramacionSalida", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdProgramacionSalida", pro.IdProgramacionSalida);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    delete = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return delete;
        }
    }
}
