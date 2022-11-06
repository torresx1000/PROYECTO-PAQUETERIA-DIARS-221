using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPAENTIDAD;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
namespace CAPADATOS
{
    public class DatDiagnostico: Conexion
    {
        private static readonly DatDiagnostico _instancia = new DatDiagnostico();
        public static new DatDiagnostico Instancia
        {
            get
            {
                return DatDiagnostico._instancia;
            }
        }


        //para agregar diagnostico
        public Boolean InsertaDiagnostico(EntDiagnostico Ped)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarDiagnostico", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@OBSERVACIONES", Ped.Observaciones);
                cmd.Parameters.AddWithValue("@FALLAS", Ped.Fallas);
                cmd.Parameters.AddWithValue("@FECHA", Ped.fecha);
                cmd.Parameters.AddWithValue("@IdVehiculo", Ped.IdVehiculo);
                cmd.Parameters.AddWithValue("@IdConductor", Ped.IdConductor);

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
        //listar diagnostico
        public List<EntDiagnostico> ListarDiagnostico()
        {
            SqlCommand cmd = null;
            List<EntDiagnostico> Lista = new List<EntDiagnostico>();

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarDiagnostico", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntDiagnostico Ped = new EntDiagnostico();
                    Ped.IdDiagnostico = Convert.ToInt32(dr["IdDiagnostico"]);
                    Ped.Observaciones = dr["Observaciones"].ToString(); ;
                    Ped.Fallas = dr["Fallas"].ToString();
                    Ped.fecha = Convert.ToDateTime(dr["fecha"]);
                    Ped.IdVehiculo = Convert.ToInt32(dr["IdVehiculo"]);
                    Ped.IdConductor = Convert.ToInt32(dr["IdConductor"]);

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

        //Modificar Diagnostico
        public Boolean EditarDiagnostico(EntDiagnostico Ped)
        {
            SqlCommand cmd = null;
            Boolean Edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spModificarDiagnostico", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IDdIAGNOSTICO", Ped.IdDiagnostico);
                cmd.Parameters.AddWithValue("@Observaciones", Ped.Observaciones);
                cmd.Parameters.AddWithValue("@Fallas", Ped.Fallas);
                cmd.Parameters.AddWithValue("@fecha", Ped.fecha);
                cmd.Parameters.AddWithValue("@IdVehiculo", Ped.IdVehiculo);
                cmd.Parameters.AddWithValue("@IdConductor", Ped.IdConductor);



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
        public DataTable BuscarDiagnosticoId(int IdDiagnostico)
        {
            DataTable dt;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarDiagnostico", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", IdDiagnostico);
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

        public Boolean Eliminar(EntDiagnostico Id)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEliminarDiagnostico ", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", Id.IdDiagnostico);
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
   
   
