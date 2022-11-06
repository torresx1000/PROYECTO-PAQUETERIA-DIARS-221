using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPAENTIDAD;

namespace CAPADATOS
{
    public class DatRuta:Conexion
    {
        private static readonly DatRuta _instancia = new DatRuta();
        public static new DatRuta Instancia
        {
            get
            {
                return DatRuta._instancia;
            }
        }

        //Para agregar ruta
        public Boolean InsertaRuta(EntRuta Rut)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarRuta", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@IdRuta", Rut.IdRuta);
                cmd.Parameters.AddWithValue("@PuntoPartida", Rut.PuntoPartida);
                cmd.Parameters.AddWithValue("@PuntoLlegada", Rut.PuntoLlegada);
                cmd.Parameters.AddWithValue("@Observaciones", Rut.Observaciones);
                cmd.Parameters.AddWithValue("@EstadoRuta", Rut.EstadoRuta);
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

        //Modificar Ruta
        public Boolean EditarRuta(EntRuta Rut)
        {
            SqlCommand cmd = null;
            Boolean Edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spModificarRuta", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdRuta", Rut.IdRuta);
                cmd.Parameters.AddWithValue("@PuntoPartida", Rut.PuntoPartida);
                cmd.Parameters.AddWithValue("@PuntoLlegada", Rut.PuntoLlegada);
                cmd.Parameters.AddWithValue("@Observaciones", Rut.Observaciones);
                cmd.Parameters.AddWithValue("@EstadoRuta", Rut.EstadoRuta);
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

        //listar Ruta
        public List<EntRuta> ListarRuta()
        {
            SqlCommand cmd = null;
            List<EntRuta> Lista = new List<EntRuta>();

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarRuta", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntRuta Rut = new EntRuta();
                    Rut.IdRuta = Convert.ToInt32(dr["IdRuta"]);
                    Rut.PuntoPartida = dr["PuntoPartida"].ToString();
                    Rut.PuntoLlegada = dr["PuntoLlegada"].ToString();
                    Rut.Observaciones = dr["Observaciones"].ToString();
                    Rut.EstadoRuta = Convert.ToBoolean(dr["EstadoRuta"]);
                    Lista.Add(Rut);
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

        //para buscar Ruta
        public EntRuta BuscarRutaId(int Id)
        {
            SqlCommand cmd = null;
            EntRuta Rut = new EntRuta();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarRuta", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdRuta", Id);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Rut.IdRuta = Convert.ToInt32(dr["IdRuta"]);
                    Rut.PuntoPartida = dr["PuntoPartida"].ToString();
                    Rut.PuntoLlegada = dr["PuntoLlegada"].ToString();
                    Rut.Observaciones = dr["Observaciones"].ToString();
                    Rut.EstadoRuta = Convert.ToBoolean(dr["EstadoRuta"]);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return Rut;
        }
        //buscar ruta para reporte
        public DataTable BuscarRutas(string Puntopar)
        {
            DataTable dt;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarRutaPunPar", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PuntoPartida", Puntopar);
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
        //para deshabilitar Ruta(por Id)
        public Boolean DeshabilitarRuta(EntRuta Rut)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarRuta", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdRuta", Rut.IdRuta);
                cmd.Parameters.AddWithValue("@EstadoRuta", Rut.EstadoRuta);
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
            return delete = true;
        }
    }
}
