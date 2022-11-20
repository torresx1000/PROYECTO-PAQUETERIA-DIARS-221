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
    public class DatOrdenDeCompra
    {
        private static readonly DatOrdenDeCompra _instancia = new DatOrdenDeCompra();
        public static new DatOrdenDeCompra Instancia
        {
            get
            {
                return DatOrdenDeCompra._instancia;
            }
        }

        //Para agregar ruta
        public Boolean InsertaOrdenCompra(EntOrdenDeCompra orcom)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarOrdenDeCompra", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@Codigo", orcom.Codigo);
                cmd.Parameters.AddWithValue("@IdLista", orcom.IdLista);
                cmd.Parameters.AddWithValue("@FirmaNom", orcom.FirmaNom);
                cmd.Parameters.AddWithValue("@Descripcion", orcom.Descripcion);
                cmd.Parameters.AddWithValue("@Fecha", orcom.Fecha);
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

        //Modificar Orden compra
        public Boolean EditarOrdenCompra(EntOrdenDeCompra orcom)
        {
            SqlCommand cmd = null;
            Boolean Edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spModificarOrdenDeCompra", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Codigo", orcom.Codigo);
                cmd.Parameters.AddWithValue("@IdLista", orcom.IdLista);
                cmd.Parameters.AddWithValue("@FirmaNom", orcom.FirmaNom);
                cmd.Parameters.AddWithValue("@Descripcion", orcom.Descripcion);
                cmd.Parameters.AddWithValue("@Fecha", orcom.Fecha);
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

        //listar Orden compra
        public List<EntOrdenDeCompra> ListarOrdenCompra()
        {
            SqlCommand cmd = null;
            List<EntOrdenDeCompra> Lista = new List<EntOrdenDeCompra>();

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarListarOrdenDeCompra", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntOrdenDeCompra Rut = new EntOrdenDeCompra();
                    Rut.Codigo = Convert.ToInt32(dr["Codigo"]);
                    Rut.IdLista = Convert.ToInt32(dr["IdLista"]);
                    Rut.FirmaNom = dr["FirmaNom"].ToString();
                    Rut.Descripcion = dr["Descripcion"].ToString();
                    Rut.Fecha = Convert.ToDateTime(dr["Fecha"]);
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

        //para buscar ordencompra
        public EntOrdenDeCompra BuscarCompraId(int Id)
        {
            SqlCommand cmd = null;
            EntOrdenDeCompra Rut = new EntOrdenDeCompra();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarOrdenCompra", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Codigo", Id);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Rut.Codigo = Convert.ToInt32(dr["Codigo"]);
                    Rut.IdLista = Convert.ToInt32(dr["IdLista"]);
                    Rut.FirmaNom = dr["FirmaNom"].ToString();
                    Rut.Descripcion = dr["Descripcion"].ToString();
                    Rut.Fecha = Convert.ToDateTime(dr["Fecha"]);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return Rut;
        }
       
        public Boolean EliminarOrdenCompra(EntOrdenDeCompra Rut)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEliminarOrdenCompra", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Codigo", Rut.Codigo);
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
