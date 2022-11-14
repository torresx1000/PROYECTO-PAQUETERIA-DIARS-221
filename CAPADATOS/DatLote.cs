using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using CAPAENTIDAD;

namespace CAPADATOS
{
    public class DatLote : Conexion
    {
        private static readonly DatLote _instancia = new DatLote();
        public static new DatLote Instancia
        {
            get
            {
                return DatLote._instancia;
            }
        }

        //Listar Lote
        public List<EntLote> ListarLote()
        {
            SqlCommand cmd = null;
            List<EntLote> Lista = new List<EntLote>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarLote", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntLote Lot = new EntLote(); //objetoLote
                    Lot.IdLote = Convert.ToInt32(dr["IdLote"]);
                    Lot.Identificador = dr["Identificador"].ToString();
                    Lot.EstadoLote =Convert.ToBoolean(dr["EstadoLote"]);
                    Lot.Fecha = Convert.ToDateTime(dr["Fecha"]);                    
                    Lista.Add(Lot);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return Lista;
        }

        //Insertar Lote
        public Boolean InsertarLote(EntLote Lot)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarLote", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@IdLote", Lot.IdLote);
                cmd.Parameters.AddWithValue("@Identificador", Lot.Identificador);
                cmd.Parameters.AddWithValue("@EstadoLote", Lot.EstadoLote);
                cmd.Parameters.AddWithValue("@Fecha", Lot.Fecha);                    
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

        //Modificar Lote
        public Boolean EditarLote(EntLote Lot)
        {
            SqlCommand cmd = null;
            Boolean Edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spModificarLote", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdLote", Lot.IdLote);
                cmd.Parameters.AddWithValue("@Identificador", Lot.Identificador);
                cmd.Parameters.AddWithValue("@EstadoLote", Lot.EstadoLote);
                cmd.Parameters.AddWithValue("@Fecha", Lot.Fecha);                        
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

        //Buscar Lote por Codigo      
        public DataTable BuscarLoteCodigo(int IdLote)
        {
            DataTable dt;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarLote", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdLote", IdLote);
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

        //Eliminar Lote
        public Boolean EliminarLote(EntLote Lot)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEliminarLote", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdLote", Lot.IdLote);                            
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
