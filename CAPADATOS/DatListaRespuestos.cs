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
    public  class DatListaRepuestos
    {
        private static readonly DatListaRepuestos _instancia = new DatListaRepuestos();
        public static new DatListaRepuestos Instancia
        {
            get
            {
                return DatListaRepuestos._instancia;
            }
        }
        public Boolean InsertaListaRepuesto(EntListaRespuesto Fdev)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarListaRepuestos", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdDiagnostico", Fdev.idDiagnostico);
                cmd.Parameters.AddWithValue("@Fecha", Fdev.Fecha);
                cmd.Parameters.AddWithValue("@DescripcionRepuestos", Fdev.DescripcionRepuestos);
                

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
        //listar Repuestos
        public List<EntListaRespuesto> ListarRepuestos()
        {
            SqlCommand cmd = null;
            List<EntListaRespuesto> Lista = new List<EntListaRespuesto>();

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarListaRepuestos", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntListaRespuesto Fdev = new EntListaRespuesto();
                    Fdev.Codigo = Convert.ToInt32(dr["Codigo"]);
                    Fdev.idDiagnostico = Convert.ToInt32(dr["IdDiagnostico"]);
                    Fdev.Fecha = Convert.ToDateTime(dr["Fecha"]);
                    Fdev.DescripcionRepuestos = dr["DescripcionRepuestos"].ToString();
                    
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
        //Modificar ListaRepuesto
        public Boolean EditarListaRepuesto(EntListaRespuesto Fdev)
        {
            SqlCommand cmd = null;
            Boolean Edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spModificarListaRepuestos", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Codigo", Fdev.Codigo);
                cmd.Parameters.AddWithValue("@IdDiagnostico", Fdev.idDiagnostico);
                cmd.Parameters.AddWithValue("@Fecha", Fdev.Fecha);
                cmd.Parameters.AddWithValue("@DescripcionRepuestos", Fdev.DescripcionRepuestos);




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
        //para buscar ListaRespuesto
        public DataTable BuscarListaRepuesto(int IdLista)
        {
            DataTable dt;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarListaRepuestoa", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Codigo", IdLista);
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
        public Boolean Eliminar(EntListaRespuesto Id)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEliminarListaRepuestos ", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Codigo", Id.Codigo);
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
