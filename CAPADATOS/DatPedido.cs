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
    public class DatPedido : Conexion
    {
        private static readonly DatPedido _instancia = new DatPedido();
        public static new DatPedido Instancia
        {
            get
            {
                return DatPedido._instancia;
            }
        }


        //para agregar pedido
        public Boolean InsertaPedido(EntPedido Ped)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spinsertarPedido", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@IdTrabajador", Ped.Id_Trabajador);
                cmd.Parameters.AddWithValue("@IDENCARGADO", Ped.IdEncargado);
                cmd.Parameters.AddWithValue("@ENCARGADO", Ped.Responsable);
                cmd.Parameters.AddWithValue("@DNIR", Ped.DniR);
                cmd.Parameters.AddWithValue("@NOMBRER", Ped.NombreR);
                cmd.Parameters.AddWithValue("@CORREOR", Ped.CorreoR);
                cmd.Parameters.AddWithValue("@TELEFONOR", Ped.TelefonoR);
                cmd.Parameters.AddWithValue("@DIRECCIONR", Ped.DireccionR);
                cmd.Parameters.AddWithValue("@DISTRITOR", Ped.DistritoR);
                cmd.Parameters.AddWithValue("@PROVINCIAR", Ped.ProvinciaR);
                cmd.Parameters.AddWithValue("@DEPARTAMENTOR", Ped.DepartamentoR);
                cmd.Parameters.AddWithValue("@DNID", Ped.DniD);
                cmd.Parameters.AddWithValue("@NOMBRED", Ped.NombreD);
                cmd.Parameters.AddWithValue("@CORREOD", Ped.CorreoD);
                cmd.Parameters.AddWithValue("@TELEFONOD", Ped.TelefonoD);
                cmd.Parameters.AddWithValue("@DIRECCIOND", Ped.DireccionD);
                cmd.Parameters.AddWithValue("@DISTRITOD", Ped.DistritoD);
                cmd.Parameters.AddWithValue("@PROVINCIAD", Ped.ProvinciaD);
                cmd.Parameters.AddWithValue("@DEPARTAMENTOD", Ped.DepartamentoD);
                cmd.Parameters.AddWithValue("@CODIGOPEDIDO", Ped.CodigoPaquete);
                cmd.Parameters.AddWithValue("@CANTIDADPAQUETE", Ped.CantidadPaquete);
                cmd.Parameters.AddWithValue("@CATEGORIAPAQUETE", Ped.CategoriaPedido);
                cmd.Parameters.AddWithValue("@DESCRIPCIONPAQUETE", Ped.DescripcionPedido);
                cmd.Parameters.AddWithValue("@IdLote", Ped.IdLote);
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
        public List<EntPedido> ListarPedido()
        {
            SqlCommand cmd = null;
            List<EntPedido> Lista = new List<EntPedido>();

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarPedido", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntPedido Ped = new EntPedido();

                    Ped.IdPedido = Convert.ToInt32(dr["IdPedido"]);
                    Ped.IdEncargado = Convert.ToInt32(dr["IdEncargado"]);
                    Ped.Responsable = dr["ENCARGADO"].ToString();
                    Ped.DniR = Convert.ToInt32(dr["DniR"]);
                    Ped.NombreR = dr["NombreR"].ToString();
                    Ped.CorreoR = dr["CorreoR"].ToString(); ;
                    Ped.TelefonoR = Convert.ToInt32(dr["TelefonoR"]);
                    Ped.DireccionR = dr["DireccionR"].ToString();
                    Ped.DistritoR = dr["DistritoR"].ToString();
                    Ped.ProvinciaR = dr["ProvinciaR"].ToString();
                    Ped.DepartamentoR = dr["DepartamentoR"].ToString();

                    Ped.DniD = Convert.ToInt32(dr["DniD"]);
                    Ped.NombreD = dr["NombreD"].ToString();
                    Ped.CorreoD = dr["CorreoD"].ToString(); ;
                    Ped.TelefonoD = Convert.ToInt32(dr["TelefonoD"]);
                    Ped.DireccionD = dr["DireccionD"].ToString();
                    Ped.DistritoD = dr["DistritoD"].ToString();
                    Ped.ProvinciaD = dr["ProvinciaD"].ToString();
                    Ped.DepartamentoD = dr["DepartamentoD"].ToString();

                    Ped.CodigoPaquete= Convert.ToInt32(dr["CODIGOPEDIDO"]);
                    Ped.CantidadPaquete= Convert.ToInt32(dr["CANTIDADPAQUETE"]);
                    Ped.CategoriaPedido = dr["CATEGORIAPAQUETE"].ToString();
                    Ped.DescripcionPedido= dr["DESCRIPCIONPAQUETE"].ToString();
                    Ped.IdLote = Convert.ToInt32(dr["IdLote"]);
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

        //Modificar Pedido
        public Boolean EditarPedido(EntPedido Ped)
        {
            SqlCommand cmd = null;
            Boolean Edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spModificarPedido", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("IdPedido", Ped.IdPedido);
                cmd.Parameters.AddWithValue("@@IDENCARGADO", Ped.IdEncargado);
                cmd.Parameters.AddWithValue("@ENCARGADO", Ped.Responsable);
                cmd.Parameters.AddWithValue("@DNIR", Ped.DniR);
                cmd.Parameters.AddWithValue("@NOMBRER", Ped.NombreR);
                cmd.Parameters.AddWithValue("@CORREOR", Ped.CorreoR);
                cmd.Parameters.AddWithValue("@TELEFONOR", Ped.TelefonoR);
                cmd.Parameters.AddWithValue("@DIRECCIONR", Ped.DireccionR);
                cmd.Parameters.AddWithValue("@DISTRITOR", Ped.DistritoR);
                cmd.Parameters.AddWithValue("@PROVINCIAR", Ped.ProvinciaR);
                cmd.Parameters.AddWithValue("@DEPARTAMENTOR", Ped.DepartamentoR);
                cmd.Parameters.AddWithValue("@DNID", Ped.DniD);
                cmd.Parameters.AddWithValue("@NOMBRED", Ped.NombreD);
                cmd.Parameters.AddWithValue("@CORREOD", Ped.CorreoD);
                cmd.Parameters.AddWithValue("@TELEFONOD", Ped.TelefonoD);
                cmd.Parameters.AddWithValue("@DIRECCIOND", Ped.DireccionD);
                cmd.Parameters.AddWithValue("@DISTRITOD", Ped.DistritoD);
                cmd.Parameters.AddWithValue("@PROVINCIAD", Ped.ProvinciaD);
                cmd.Parameters.AddWithValue("@DEPARTAMENTOD", Ped.DepartamentoD);
                cmd.Parameters.AddWithValue("@CODIGOPEDIDO", Ped.CodigoPaquete);
                cmd.Parameters.AddWithValue("@CANTIDADPAQUETE", Ped.CantidadPaquete);
                cmd.Parameters.AddWithValue("@CATEGORIAPAQUETE", Ped.CategoriaPedido);
                cmd.Parameters.AddWithValue("@DESCRIPCIONPAQUETE", Ped.DescripcionPedido);
                cmd.Parameters.AddWithValue("@IdLote", Ped.IdLote);
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

        //para buscar Pedido
        public EntPedido BuscarPedidoId(int IdPedido)
        {
            SqlCommand cmd = null;
            EntPedido Ped = new EntPedido();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarPedido", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdPedido", IdPedido);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Ped.IdPedido = Convert.ToInt32(dr["IdPedido"]);
                    Ped.IdPedido = Convert.ToInt32(dr["IdEncargado"]);
                    Ped.Responsable = dr["ENCARGADO"].ToString();
                    Ped.DniR = Convert.ToInt32(dr["DniR"]);
                    Ped.NombreR = dr["NombreR"].ToString();
                    Ped.CorreoR = dr["CorreoR"].ToString(); ;
                    Ped.TelefonoR = Convert.ToInt32(dr["TelefonoR"]);
                    Ped.DireccionR = dr["DireccionR"].ToString();
                    Ped.DistritoR = dr["DistritoR"].ToString();
                    Ped.ProvinciaR = dr["ProvinciaR"].ToString();
                    Ped.DepartamentoR = dr["DepartamentoR"].ToString();

                    Ped.DniD = Convert.ToInt32(dr["DniD"]);
                    Ped.NombreD = dr["NombreD"].ToString();
                    Ped.CorreoD = dr["CorreoD"].ToString(); ;
                    Ped.TelefonoD = Convert.ToInt32(dr["TelefonoD"]);
                    Ped.DireccionD = dr["DireccionD"].ToString();
                    Ped.DistritoD = dr["DistritoD"].ToString();
                    Ped.ProvinciaD = dr["ProvinciaD"].ToString();
                    Ped.DepartamentoD = dr["DepartamentoD"].ToString();

                    Ped.CodigoPaquete = Convert.ToInt32(dr["CODIGOPEDIDO"]);
                    Ped.CantidadPaquete = Convert.ToInt32(dr["CANTIDADPAQUETE"]);
                    Ped.CategoriaPedido = dr["CATEGORIAPAQUETE"].ToString();
                    Ped.DescripcionPedido = dr["DESCRIPCIONPAQUETE"].ToString();
                    Ped.IdLote = Convert.ToInt32(dr["IdLte"]);
                }

            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return Ped;
        }
        //para eliminar pedido solo con dni(por DNI)
        public Boolean DeshabilitarPedido(EntPedido Ped)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEliminarPedido", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdPedido", Ped.IdPedido);
               
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
