using CAPAENTIDAD;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CAPADATOS
{
    public class DatPagoUtilidades
    {
        private static readonly DatPagoUtilidades _instancia = new DatPagoUtilidades();
        public static new DatPagoUtilidades Instancia
        {
            get
            {
                return DatPagoUtilidades._instancia;
            }
        }

        //para agregar Pago de utilidades
        public Boolean InsertaPagoUtilidades(EntPagoUtilidades Paut)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarPagoDeUtilidades", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdPlanilla", Paut.IdPlanilla);
                cmd.Parameters.AddWithValue("@IdTrabajador", Paut.IdTrabajador);
                cmd.Parameters.AddWithValue("@TotalRemuneraciones", Paut.TotalRemuneraciones);
                cmd.Parameters.AddWithValue("@TotalDescuentos", Paut.TotalDescuentos);
                cmd.Parameters.AddWithValue("@TotalAportes", Paut.TotalAportes);
                cmd.Parameters.AddWithValue("@CtaAhorros", Paut.CtaAhorros);
                cmd.Parameters.AddWithValue("@FechaPago", Paut.FechaPago);
                cmd.Parameters.AddWithValue("@NetoAPagar", Paut.NetoAPagar);

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

        //Modificar Pago Utilidades
        public Boolean EditarPagoUtilidades(EntPagoUtilidades Paut)
        {
            SqlCommand cmd = null;
            Boolean Edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarPagoUtilidades", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdPagoUtilidades", Paut.IdPagoUtilidades);
                cmd.Parameters.AddWithValue("@IdPlanilla", Paut.IdPlanilla);
                cmd.Parameters.AddWithValue("@IdTrabajador", Paut.IdTrabajador);
                cmd.Parameters.AddWithValue("@TotalRemuneraciones", Paut.TotalRemuneraciones);
                cmd.Parameters.AddWithValue("@TotalDescuentos", Paut.TotalDescuentos);
                cmd.Parameters.AddWithValue("@TotalAportes", Paut.TotalAportes);
                cmd.Parameters.AddWithValue("@CtaAhorros", Paut.CtaAhorros);
                cmd.Parameters.AddWithValue("@FechaPago", Paut.FechaPago);
                cmd.Parameters.AddWithValue("@NetoAPagar", Paut.NetoAPagar);



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

        //listar pago utilidades 
        public List<EntPagoUtilidades> ListarPagoUtilidades()
        {
            SqlCommand cmd = null;
            List<EntPagoUtilidades> Lista = new List<EntPagoUtilidades>();

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarPagoUtilidades", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntPagoUtilidades paut = new EntPagoUtilidades();
                    paut.IdPagoUtilidades = Convert.ToInt32(dr["IdPagoUtilidades"]);
                    paut.IdPlanilla = Convert.ToInt32(dr["IdPlanilla"]);
                    paut.IdTrabajador = Convert.ToInt32(dr["IdTrabajador"]);
                    paut.TotalRemuneraciones = Convert.ToDouble(dr["TotalRemuneraciones"]);
                    paut.TotalDescuentos = Convert.ToDouble(dr["TotalDescuentos"]);
                    paut.TotalAportes = Convert.ToDouble(dr["TotalAportes"]);
                    paut.CtaAhorros = Convert.ToInt32(dr["CtaAhorros"]);
                    paut.FechaPago = Convert.ToDateTime(dr["FechaPago"]);
                    paut.NetoAPagar = Convert.ToDouble(dr["NetoAPagar"]);
                    Lista.Add(paut);
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

        //para buscar pago de utilidad 
        public DataTable BuscarPagoUtilidadId(int IdPagoUtiidad)
        {
            DataTable dt;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarPagoUtilidades", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdPagoUtilidades", IdPagoUtiidad);
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

        //para eliminar un pago -- revisar
        public Boolean Eliminar(EntPagoUtilidades Id)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEliminarPagoUtilidad ", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdPagoUtilidades", Id.IdPagoUtilidades);
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
