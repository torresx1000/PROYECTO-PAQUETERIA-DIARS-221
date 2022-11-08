using CAPAENTIDAD;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPADATOS
{
   public class DatGastosViajes
    {
        private static readonly DatGastosViajes _instancia = new DatGastosViajes();
        public static new DatGastosViajes Instancia
        {
            get
            {
                return DatGastosViajes._instancia;
            }
        }
        public Boolean InsertaGastosViaje(EntGastosDeViaje Fdev)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarGastosViaje", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdProgramaciondesalida", Fdev.IdProgramaciondesalida);
                cmd.Parameters.AddWithValue("@Fecha", Fdev.Fecha);
                cmd.Parameters.AddWithValue("@Viaticos", Fdev.Viaticos);
                cmd.Parameters.AddWithValue("@preciosviaticos", Fdev.preciosviaticos);
                cmd.Parameters.AddWithValue("@Combustible", Fdev.Combustible);
                cmd.Parameters.AddWithValue("@precioscombustible", Fdev.precioscombustible);
                cmd.Parameters.AddWithValue("@Otros", Fdev.Otros);
                cmd.Parameters.AddWithValue("@preciosotros", Fdev.preciosotros);

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
        //listar fichadegastosviajes
        public List<EntGastosDeViaje> ListarGastosDeViaje()
        {
            SqlCommand cmd = null;
            List<EntGastosDeViaje> Lista = new List<EntGastosDeViaje>();

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarGastosViaje", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntGastosDeViaje Fdev = new EntGastosDeViaje();
                    Fdev.IdGastosdeViaje = Convert.ToInt32(dr["IdGastosViaje"]);
                    Fdev.IdProgramaciondesalida = Convert.ToInt32(dr["IdProgramaciondesalida"]);
                    Fdev.Fecha = Convert.ToDateTime(dr["Fecha"]);
                    Fdev.Viaticos = dr["Viaticos"].ToString();
                    Fdev.preciosviaticos = Convert.ToDouble(dr["preciosviaticos"]);
                    Fdev.Combustible = dr["Combustible"].ToString();
                    Fdev.precioscombustible = Convert.ToDouble(dr["precioscombustible"]);
                    Fdev.Otros = dr["Otros"].ToString();
                    Fdev.preciosotros = Convert.ToDouble(dr["preciosotros"]);

                    Lista.Add(Fdev);
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
        //Modificar Diagnostico
        public Boolean EditarGastosDeViaje(EntGastosDeViaje Fdev)
        {
            SqlCommand cmd = null;
            Boolean Edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spModificarGastosViaje", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdIdGastosViaje", Fdev.IdGastosdeViaje);
                cmd.Parameters.AddWithValue("@IdProgramaciondesalida", Fdev.IdProgramaciondesalida);
                cmd.Parameters.AddWithValue("@Fecha", Fdev.Fecha);
                cmd.Parameters.AddWithValue("@Viaticos", Fdev.Viaticos);
                cmd.Parameters.AddWithValue("@preciosviaticos", Fdev.preciosviaticos);
                cmd.Parameters.AddWithValue("@Combustible", Fdev.Combustible);
                cmd.Parameters.AddWithValue("@precioscombustible", Fdev.precioscombustible);
                cmd.Parameters.AddWithValue("@Otros", Fdev.Otros);
                cmd.Parameters.AddWithValue("@preciosotros", Fdev.preciosotros);



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
        public DataTable BuscarGastosdeViaje(int IdGastos)
        {
            DataTable dt;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarGastosViaje", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdGastosViaje", IdGastos);
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

        //Eliminar GastosdeViaje
        public Boolean Eliminar(EntGastosDeViaje Id)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEliminarGastosViaje ", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdGastosViaje", Id.IdGastosdeViaje);
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
