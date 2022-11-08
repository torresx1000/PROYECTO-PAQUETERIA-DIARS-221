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
    public class DatFichaEstadoVehiculo
    {
        private static readonly DatFichaEstadoVehiculo _instancia = new DatFichaEstadoVehiculo();
        public static new DatFichaEstadoVehiculo Instancia
        {
            get
            {
                return DatFichaEstadoVehiculo._instancia;
            }
        }
        public Boolean InsertaFichaEstadoVehiculo(EntFichaDeEstadoVehiculo Fdev)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarFichaEstadoVehiculo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdConductor", Fdev.Conductor);
                cmd.Parameters.AddWithValue("@IdVehiculo", Fdev.Vehiculo);
                cmd.Parameters.AddWithValue("@Fecha", Fdev.Fecha);
                cmd.Parameters.AddWithValue("@SistemaElectrico", Fdev.SistemaElectrico);
                cmd.Parameters.AddWithValue("@SistemeMecanico", Fdev.SistemaMecanico);
                cmd.Parameters.AddWithValue("@LetoneriayPintura", Fdev.LetoneriayPintura);
                cmd.Parameters.AddWithValue("@Otros", Fdev.Otros);

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
        //listar fichadeestadovehiculo
        public List<EntFichaDeEstadoVehiculo> ListarFichaDeEstadoVehiculo()
        {
            SqlCommand cmd = null;
            List<EntFichaDeEstadoVehiculo> Lista = new List<EntFichaDeEstadoVehiculo>();

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarFichaEstado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntFichaDeEstadoVehiculo Fdev = new EntFichaDeEstadoVehiculo();
                    Fdev.IdEstadoVehiculo = Convert.ToInt32(dr["IdEstadoVehiculo"]);
                    Fdev.Conductor = Convert.ToInt32(dr["IdConductor"]);
                    Fdev.Vehiculo = Convert.ToInt32(dr["IdVehiculo"]);
                    Fdev.Fecha = Convert.ToDateTime(dr["Fecha"]);
                    Fdev.SistemaElectrico = dr["SistemaElectrico"].ToString();
                    Fdev.SistemaMecanico = dr["SistemeMecanico"].ToString();
                    Fdev.LetoneriayPintura =dr["LetoneriayPintura"].ToString();
                    Fdev.Otros = dr["Otros"].ToString();

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
        public Boolean EditarFichaDeEstadoVehiculo(EntFichaDeEstadoVehiculo Fdev)
        {
            SqlCommand cmd = null;
            Boolean Edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spModificarFichaEstadoVehiculo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdEstadoVehiculo", Fdev.IdEstadoVehiculo);
                cmd.Parameters.AddWithValue("@IdConductor", Fdev.Conductor);
                cmd.Parameters.AddWithValue("@IdVehiculo", Fdev.Vehiculo);
                cmd.Parameters.AddWithValue("@Fecha", Fdev.Fecha);
                cmd.Parameters.AddWithValue("@SistemaElectrico", Fdev.SistemaElectrico);
                cmd.Parameters.AddWithValue("@SistemeMecanico", Fdev.SistemaMecanico);
                cmd.Parameters.AddWithValue("@LetoneriayPintura", Fdev.LetoneriayPintura);
                cmd.Parameters.AddWithValue("@Otros", Fdev.Otros);



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
        public DataTable BuscarFichaDeEstadoVehiculo(int IdFicha)
        {
            DataTable dt;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarFichaEstado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdEstadoVehiculo",IdFicha);
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
        public Boolean Eliminar(EntFichaDeEstadoVehiculo Id)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEliminarFichaEstadoVehiculo ", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdEstadoVehiculo", Id.IdEstadoVehiculo);
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
