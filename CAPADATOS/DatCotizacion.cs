using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CAPAENTIDAD;

namespace CAPADATOS
{
    public class DatCotizacion : Conexion
    {
        private static readonly DatCotizacion _instancia = new DatCotizacion();
        public static new DatCotizacion Instancia
        {
            get
            {
                return DatCotizacion._instancia;
            }
        }

        //para agregar Cotizacion
        public Boolean InsertaCotizacion(EntCotizacion Ped)
        {

            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarCotizacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Descripcion", Ped.Descripcion);
                cmd.Parameters.AddWithValue("@precio", Ped.precio);
                cmd.Parameters.AddWithValue("@IDPEDIDO", Ped.IDPEDIDO);


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

        //listar Cotizacion
        public List<EntCotizacion> ListarCotizacion()
        {
            SqlCommand cmd = null;
            List<EntCotizacion> Lista = new List<EntCotizacion>();

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarCotizacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntCotizacion Ped = new EntCotizacion();
                    Ped.IdCotizacion = Convert.ToInt32(dr["IdCotizacion"]);
                    Ped.Descripcion = dr["Descripcion"].ToString();
                    Ped.precio = Convert.ToDouble(dr["precio"]);
                    Ped.IDPEDIDO = Convert.ToInt32(dr["IDPEDIDO"]); ;
                 

                    Lista.Add(Ped);
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

        //Modificar Cotizacion
        public Boolean EditarCotizacion(EntCotizacion Ped)
        {
            SqlCommand cmd = null;
            Boolean Edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spModificarCotizacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdCotizacion", Ped.IdCotizacion);
                cmd.Parameters.AddWithValue("@Descripcion", Ped.Descripcion);
                cmd.Parameters.AddWithValue("@precio", Ped.precio);
                cmd.Parameters.AddWithValue("@IDPEDIDO", Ped.IDPEDIDO);
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

        //para buscar 
        public DataTable BuscarCotizacion(int idCotizacion)
        {
            DataTable dt;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarCotizacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", idCotizacion);
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

        public Boolean EliminarCotizacion(EntCotizacion Id)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEliminarCotizacion ", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", Id.IdCotizacion);
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
