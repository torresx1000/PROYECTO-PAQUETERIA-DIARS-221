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
                    Lot.Nombres = dr["Nombres"].ToString();
                    Lot.Producto = dr["Producto"].ToString();
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
                cmd.Parameters.AddWithValue("@Nombres", Lot.Nombres);
                cmd.Parameters.AddWithValue("@Producto", Lot.Producto);
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
                cmd.Parameters.AddWithValue("@Nombres", Lot.Nombres);
                cmd.Parameters.AddWithValue("@Producto", Lot.Producto);
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
        public EntLote BuscarLoteCodigo(int IdLote)
        {
            SqlCommand cmd = null;
            EntLote Lot = new EntLote();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarLote", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdLote", IdLote);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {                    
                    Lot.IdLote = Convert.ToInt32(dr["IdLote"]);
                    Lot.Nombres = dr["Nombres"].ToString();
                    Lot.Producto = dr["Producto"].ToString();
                    Lot.Fecha = Convert.ToDateTime(dr["Fecha"]);                    
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return Lot;
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
                cmd.Parameters.AddWithValue("@Nombres", Lot.Nombres);
                cmd.Parameters.AddWithValue("@Producto", Lot.Producto);
                cmd.Parameters.AddWithValue("@Fecha", Lot.Fecha);                
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
