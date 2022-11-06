using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPAENTIDAD;
using System.Data;
using System.Data.SqlClient;

namespace CAPADATOS
{
    public class DatCheckLista : Conexion
    {
        private static readonly DatCheckLista _instancia = new DatCheckLista();
        public static new DatCheckLista Instancia
        {
            get
            {
                return DatCheckLista._instancia;
            }
        }


        //para agregar CheckList
        public Boolean InsertaCheckList(EntCheckList Ped)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarCheckList", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FechaCheck", Ped.FechaCheck);
                cmd.Parameters.AddWithValue("@Combustible", Ped.Combustible);
                cmd.Parameters.AddWithValue("@Horometro", Ped.Horometro);
                cmd.Parameters.AddWithValue("@Inspeccion", Ped.Inspeccion);
                cmd.Parameters.AddWithValue("@Kilometraje", Ped.Kilometraje);
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
        public List<EntCheckList> ListarCheck()
        {
            SqlCommand cmd = null;
            List<EntCheckList> Lista = new List<EntCheckList>();

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarCheckList", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntCheckList Ped = new EntCheckList();
                    Ped.IdCheck= Convert.ToInt32(dr["IdCheck"]);
                    Ped.FechaCheck= Convert.ToDateTime(dr["FechaCheck"]);
                    Ped.Combustible = dr["Combustible"].ToString();
                    Ped.Horometro = dr["Horometro"].ToString(); ;
                    Ped.Inspeccion= dr["Inspeccion"].ToString();
                    Ped.Kilometraje = dr["Kilometraje"].ToString();
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

        //Modificar CheckLista
        public Boolean EditarCheck(EntCheckList Ped)
        {
            SqlCommand cmd = null;
            Boolean Edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spModificarCheclLis", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdCheck", Ped.IdCheck);
                cmd.Parameters.AddWithValue("@FechaCheck", Ped.FechaCheck);
                cmd.Parameters.AddWithValue("@Combustible", Ped.Combustible);
                cmd.Parameters.AddWithValue("@Horometro", Ped.Horometro);
                cmd.Parameters.AddWithValue("@Inspeccion", Ped.Inspeccion);
                cmd.Parameters.AddWithValue("@Kilometraje", Ped.Kilometraje);
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
        public DataTable BuscarCheckId(int IdCheck)
        {
            DataTable dt;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarCheckList", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", IdCheck);
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

        public Boolean Eliminar(EntCheckList Id)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEliminarCheckList ", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", Id.IdCheck);
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
