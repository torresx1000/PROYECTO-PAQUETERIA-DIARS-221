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
                cmd.Parameters.AddWithValue("@DniR", Ped.DniR);
                cmd.Parameters.AddWithValue("@CorreoR", Ped.CorreoR);
                cmd.Parameters.AddWithValue("@TelefonoR", Ped.TelefonoR);
                cmd.Parameters.AddWithValue("@DireccionR", Ped.DireccionR);
                cmd.Parameters.AddWithValue("@NombreR", Ped.NombreR);
                cmd.Parameters.AddWithValue("@ObservacionesR", Ped.ObservacionesR);
                cmd.Parameters.AddWithValue("@ContactoR", Ped.ContactoR);
                cmd.Parameters.AddWithValue("@DistritoR", Ped.DistritoR);
                cmd.Parameters.AddWithValue("@ProvinciaR", Ped.ProvinciaR);
                cmd.Parameters.AddWithValue("@DepartamentoR", Ped.DepartamentoR);
                cmd.Parameters.AddWithValue("@DniD", Ped.DniD);
                cmd.Parameters.AddWithValue("@CorreoD", Ped.CorreoD);
                cmd.Parameters.AddWithValue("@TelefonoD", Ped.TelefonoD);
                cmd.Parameters.AddWithValue("@DireccionD", Ped.DireccionD);
                cmd.Parameters.AddWithValue("@NombreD", Ped.NombreD);
                cmd.Parameters.AddWithValue("@ObservacionesD", Ped.ObservacionesD);
                cmd.Parameters.AddWithValue("@ContactoD", Ped.ContactoD);
                cmd.Parameters.AddWithValue("@DistritoD", Ped.DistritoD);
                cmd.Parameters.AddWithValue("@ProvinciaD", Ped.ProvinciaD);
                cmd.Parameters.AddWithValue("@DepartamentoD", Ped.DepartamentoD);
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
                    Ped.DniR = Convert.ToInt32(dr["DniR"]);
                    Ped.CorreoR = dr["CorreoR"].ToString(); ;
                    Ped.TelefonoR = Convert.ToInt32(dr["TelefonoR"]);
                    Ped.DireccionR = dr["DireccionR"].ToString();
                    Ped.NombreR = dr["NombreR"].ToString();
                    Ped.ObservacionesR = dr["ObservacionesR"].ToString();
                    Ped.ContactoR = Convert.ToInt32(dr["ContactoR"]);
                    Ped.DistritoR = dr["DistritoR"].ToString();
                    Ped.ProvinciaR = dr["ProvinciaR"].ToString();
                    Ped.DepartamentoR = dr["DepartamentoR"].ToString();

                    Ped.DniD = Convert.ToInt32(dr["DniD"]);
                    Ped.CorreoD = dr["CorreoD"].ToString(); ;
                    Ped.TelefonoD = Convert.ToInt32(dr["TelefonoD"]);
                    Ped.DireccionD = dr["DireccionD"].ToString();
                    Ped.NombreD = dr["NombreD"].ToString();
                    Ped.ObservacionesD = dr["ObservacionesD"].ToString();
                    Ped.ContactoD = Convert.ToInt32(dr["ContactoD"]);
                    Ped.DistritoD = dr["DistritoD"].ToString();
                    Ped.ProvinciaD = dr["ProvinciaD"].ToString();
                    Ped.DepartamentoD = dr["DepartamentoD"].ToString();
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
                cmd.Parameters.AddWithValue("@IdPedido", Ped.IdPedido);
                cmd.Parameters.AddWithValue("@DniR", Ped.DniR);
                cmd.Parameters.AddWithValue("@CorreoR", Ped.CorreoR);
                cmd.Parameters.AddWithValue("@TelefonoR", Ped.TelefonoR);
                cmd.Parameters.AddWithValue("@DireccionR", Ped.DireccionR);
                cmd.Parameters.AddWithValue("@NombreR", Ped.NombreR);
                cmd.Parameters.AddWithValue("@ObservacionesR", Ped.ObservacionesR);
                cmd.Parameters.AddWithValue("@ContactoR", Ped.ContactoR);
                cmd.Parameters.AddWithValue("@DistritoR", Ped.DistritoR);
                cmd.Parameters.AddWithValue("@ProvinciaR", Ped.ProvinciaR);
                cmd.Parameters.AddWithValue("@DepartamentoR", Ped.DepartamentoR);
                
                cmd.Parameters.AddWithValue("@DniD", Ped.DniD);
                cmd.Parameters.AddWithValue("@CorreoD", Ped.CorreoD);
                cmd.Parameters.AddWithValue("@TelefonoD", Ped.TelefonoD);
                cmd.Parameters.AddWithValue("@DireccionD", Ped.DireccionD);
                cmd.Parameters.AddWithValue("@NombreD", Ped.NombreD);
                cmd.Parameters.AddWithValue("@ObservacionesD", Ped.ObservacionesD);
                cmd.Parameters.AddWithValue("@ContactoD", Ped.ContactoD);
                cmd.Parameters.AddWithValue("@DistritoD", Ped.DistritoD);
                cmd.Parameters.AddWithValue("@ProvinciaD", Ped.ProvinciaD);
                cmd.Parameters.AddWithValue("@DepartamentoD", Ped.DepartamentoD);

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
                    Ped.DniR = Convert.ToInt32(dr["DniR"]);
                    Ped.CorreoR = dr["CorreoR"].ToString(); ;
                    Ped.TelefonoR = Convert.ToInt32(dr["TelefonoR"]);
                    Ped.DireccionR = dr["DireccionR"].ToString();
                    Ped.NombreR = dr["NombreR"].ToString();
                    Ped.ObservacionesR = dr["ObservacionesR"].ToString();
                    Ped.ContactoR = Convert.ToInt32(dr["ContactoR"]);
                    Ped.DistritoR = dr["DistritoR"].ToString();
                    Ped.ProvinciaR = dr["ProvinciaR"].ToString();
                    Ped.DepartamentoR = dr["DepartamentoR"].ToString();
       
                    Ped.DniD = Convert.ToInt32(dr["DniD"]);
                    Ped.CorreoD = dr["CorreoD"].ToString(); ;
                    Ped.TelefonoD = Convert.ToInt32(dr["TelefonoD"]);
                    Ped.DireccionD = dr["DireccionD"].ToString();
                    Ped.NombreD = dr["NombreD"].ToString();
                    Ped.ObservacionesD = dr["ObservacionesD"].ToString();
                    Ped.ContactoD = Convert.ToInt32(dr["ContactoD"]);
                    Ped.DistritoD = dr["DistritoD"].ToString();
                    Ped.ProvinciaD = dr["ProvinciaD"].ToString();
                    Ped.DepartamentoD = dr["DepartamentoD"].ToString();
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
