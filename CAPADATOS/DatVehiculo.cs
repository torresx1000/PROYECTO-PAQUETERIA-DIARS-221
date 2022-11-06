using CAPAENTIDAD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace CAPADATOS
{
    public class DatVehiculo:Conexion
    {
        private static readonly DatVehiculo _instancia = new DatVehiculo();
        public static new DatVehiculo Instancia
        {
            get
            {
                return DatVehiculo._instancia;
            }
        }
        //Para insertar Vehiculo
        public Boolean InsertaVehiculo(EntVehiculo Veh) {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarVehiculo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@IdVehiculo", Veh.IdVehiculo);
                cmd.Parameters.AddWithValue("@Categoria", Veh.Categoria);
                cmd.Parameters.AddWithValue("@Modelo", Veh.Modelo);
                cmd.Parameters.AddWithValue("@Color", Veh.Color);
                cmd.Parameters.AddWithValue("@Motor", Veh.Motor);
                cmd.Parameters.AddWithValue("@Combustible", Veh.Combustible);
                cmd.Parameters.AddWithValue("@FormRodante", Veh.FormRodante);
                cmd.Parameters.AddWithValue("@AñoFabricacion", Veh.AñoFabricacion);
                cmd.Parameters.AddWithValue("@AñoModelo", Veh.AñoModelo);
                cmd.Parameters.AddWithValue("@Version", Veh.Version);
                cmd.Parameters.AddWithValue("@Ejes", Veh.Ejes);
                cmd.Parameters.AddWithValue("@Asientos", Veh.Asientos);
                cmd.Parameters.AddWithValue("@Pasajeros", Veh.Pasajeros);
                cmd.Parameters.AddWithValue("@Ruedas", Veh.Ruedas);
                cmd.Parameters.AddWithValue("@Carroceria", Veh.Carroceria);
                cmd.Parameters.AddWithValue("@Potencia", Veh.Potencia);
                cmd.Parameters.AddWithValue("@Cilindros", Veh.Cilindros);
                cmd.Parameters.AddWithValue("@Cilindrada", Veh.Cilindrada);
                cmd.Parameters.AddWithValue("@PesoBruto", Veh.PesoBruto);
                cmd.Parameters.AddWithValue("@PesoNeto", Veh.PesoNeto);
                cmd.Parameters.AddWithValue("@CargaUtil", Veh.CargaUtil);
                cmd.Parameters.AddWithValue("@Longitud", Veh.Longitud);
                cmd.Parameters.AddWithValue("@Altura", Veh.Altura);
                cmd.Parameters.AddWithValue("@Ancho", Veh.Ancho);
                cmd.Parameters.AddWithValue("@ZonaRegistro", Veh.ZonaRegistro);
                cmd.Parameters.AddWithValue("@DuaDuam", Veh.DuaDuam);
                cmd.Parameters.AddWithValue("@Titulo", Veh.Titulo);
                cmd.Parameters.AddWithValue("@FechaTitulo", Veh.FechaTitulo);
                cmd.Parameters.AddWithValue("@Condicion", Veh.Condicion);
                cmd.Parameters.AddWithValue("@Placa", Veh.Placa);
                cmd.Parameters.AddWithValue("@PlacaAnterior", Veh.PlacaAnterior);
                cmd.Parameters.AddWithValue("@FotoVehiculo", Veh.FotoVehiculo);
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
        //Lista Vehiculo
        public List<EntVehiculo> ListarVehiculo() {
            SqlCommand cmd = null;
            List<EntVehiculo> Lista=new List<EntVehiculo> ();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarVehiculo",cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr=cmd.ExecuteReader();
                while (dr.Read()) {
                    EntVehiculo Veh = new EntVehiculo();
                    Veh.IdVehiculo = Convert.ToInt32(dr["IdVehiculo"]);
                    Veh.Categoria = dr["Categoria"].ToString();
                    Veh.Modelo = dr["Modelo"].ToString();
                    Veh.Color = dr["Color"].ToString();
                    Veh.Motor = dr["Motor"].ToString();
                    Veh.Combustible = dr["Combustible"].ToString();
                    Veh.FormRodante = dr["FormRodante"].ToString();
                    Veh.AñoFabricacion = dr["AñoFabricacion"].ToString();
                    Veh.AñoModelo = dr["AñoModelo"].ToString();
                    Veh.Version = dr["Version"].ToString();
                    Veh.Ejes = Convert.ToInt32(dr["Ejes"]);
                    Veh.Asientos = Convert.ToInt32(dr["Asientos"]);
                    Veh.Pasajeros = Convert.ToInt32(dr["Pasajeros"]);
                    Veh.Ruedas = Convert.ToInt32(dr["Ruedas"]);
                    Veh.Carroceria = dr["Carroceria"].ToString();
                    Veh.Potencia = dr["Potencia"].ToString();
                    Veh.Cilindros = Convert.ToInt32(dr["Cilindros"]);
                    Veh.Cilindrada = Convert.ToDouble(dr["Cilindrada"]);
                    Veh.PesoBruto = Convert.ToDouble(dr["PesoBruto"]);
                    Veh.PesoNeto = Convert.ToDouble(dr["PesoNeto"]);
                    Veh.CargaUtil = Convert.ToDouble(dr["CargaUtil"]);
                    Veh.Longitud = Convert.ToDouble(dr["Longitud"]);
                    Veh.Altura = Convert.ToDouble(dr["Altura"]);
                    Veh.Ancho = Convert.ToDouble(dr["Ancho"]);
                    Veh.ZonaRegistro = dr["ZonaRegistro"].ToString();
                    Veh.DuaDuam = Convert.ToInt32(dr["DuaDuam"]);
                    Veh.Titulo = Convert.ToInt32(dr["Titulo"]);
                    Veh.FechaTitulo = Convert.ToDateTime(dr["FechaTitulo"]);
                    Veh.Condicion = dr["Condicion"].ToString();
                    Veh.Placa = dr["Placa"].ToString();
                    Veh.PlacaAnterior = dr["PlacaAnterior"].ToString();
                    Veh.FotoVehiculo = (byte[])dr["FotoVehiculo"];
                    Lista.Add(Veh);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return Lista;
        }
        //modificar vehiculo
        public Boolean EditarVehiculo(EntVehiculo Veh) {
            SqlCommand cmd = null;
            Boolean Edita = false;
            try {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spModificarVehiculo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdVehiculo", Veh.IdVehiculo);
                cmd.Parameters.AddWithValue("@Categoria", Veh.Categoria);
                cmd.Parameters.AddWithValue("@Modelo", Veh.Modelo);
                cmd.Parameters.AddWithValue("@Color", Veh.Color);
                cmd.Parameters.AddWithValue("@Motor", Veh.Motor);
                cmd.Parameters.AddWithValue("@Combustible", Veh.Combustible);
                cmd.Parameters.AddWithValue("@FormRodante", Veh.FormRodante);
                cmd.Parameters.AddWithValue("@AñoFabricacion", Veh.AñoFabricacion);
                cmd.Parameters.AddWithValue("@AñoModelo", Veh.AñoModelo);
                cmd.Parameters.AddWithValue("@Version", Veh.Version);
                cmd.Parameters.AddWithValue("@Ejes", Veh.Ejes);
                cmd.Parameters.AddWithValue("@Asientos", Veh.Asientos);
                cmd.Parameters.AddWithValue("@Pasajeros", Veh.Pasajeros);
                cmd.Parameters.AddWithValue("@Ruedas", Veh.Ruedas);
                cmd.Parameters.AddWithValue("@Carroceria", Veh.Carroceria);
                cmd.Parameters.AddWithValue("@Potencia", Veh.Potencia);
                cmd.Parameters.AddWithValue("@Cilindros", Veh.Cilindros);
                cmd.Parameters.AddWithValue("@Cilindrada", Veh.Cilindrada);
                cmd.Parameters.AddWithValue("@PesoBruto", Veh.PesoBruto);
                cmd.Parameters.AddWithValue("@PesoNeto", Veh.PesoNeto);
                cmd.Parameters.AddWithValue("@CargaUtil", Veh.CargaUtil);
                cmd.Parameters.AddWithValue("@Longitud", Veh.Longitud);
                cmd.Parameters.AddWithValue("@Altura", Veh.Altura);
                cmd.Parameters.AddWithValue("@Ancho", Veh.Ancho);
                cmd.Parameters.AddWithValue("@ZonaRegistro", Veh.ZonaRegistro);
                cmd.Parameters.AddWithValue("@DuaDuam", Veh.DuaDuam);
                cmd.Parameters.AddWithValue("@Titulo", Veh.Titulo);
                cmd.Parameters.AddWithValue("@FechaTitulo", Veh.FechaTitulo);
                cmd.Parameters.AddWithValue("@Condicion", Veh.Condicion);
                cmd.Parameters.AddWithValue("@Placa", Veh.Placa);
                cmd.Parameters.AddWithValue("@PlacaAnterior", Veh.PlacaAnterior);
                cmd.Parameters.AddWithValue("@FotoVehiculo", Veh.FotoVehiculo);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    Edita = true;
                }
            }
            catch(Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return Edita;
        }
        //Buscar vehiculo
        public EntVehiculo BuscarVehivulo(string Placa) {
            SqlCommand cmd = null;
            EntVehiculo Veh = new EntVehiculo();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarVehiculo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Placa", Placa);
                cn.Open();
                SqlDataReader dr=cmd.ExecuteReader();
                while (dr.Read()) {
                    Veh.IdVehiculo = Convert.ToInt32(dr["IdVehiculo"]);
                    Veh.Categoria = dr["Categoria"].ToString();
                    Veh.Modelo = dr["Modelo"].ToString();
                    Veh.Color = dr["Color"].ToString();
                    Veh.Motor = dr["Motor"].ToString();
                    Veh.Combustible = dr["Combustible"].ToString();
                    Veh.FormRodante = dr["FormRodante"].ToString();
                    Veh.AñoFabricacion = dr["AñoFabricacion"].ToString();
                    Veh.AñoModelo = dr["AñoModelo"].ToString();
                    Veh.Version = dr["Version"].ToString();
                    Veh.Ejes = Convert.ToInt32(dr["Ejes"]);
                    Veh.Asientos = Convert.ToInt32(dr["Asientos"]);
                    Veh.Pasajeros = Convert.ToInt32(dr["Pasajeros"]);
                    Veh.Ruedas = Convert.ToInt32(dr["Ruedas"]);
                    Veh.Carroceria = dr["Carroceria"].ToString();
                    Veh.Potencia = dr["Potencia"].ToString();
                    Veh.Cilindros = Convert.ToInt32(dr["Cilindros"]);
                    Veh.Cilindrada = Convert.ToDouble(dr["Cilindrada"]);
                    Veh.PesoBruto = Convert.ToDouble(dr["PesoBruto"]);
                    Veh.PesoNeto = Convert.ToDouble(dr["PesoNeto"]);
                    Veh.CargaUtil = Convert.ToDouble(dr["CargaUtil"]);
                    Veh.Longitud = Convert.ToDouble(dr["Longitud"]);
                    Veh.Altura = Convert.ToDouble(dr["Altura"]);
                    Veh.Ancho = Convert.ToDouble(dr["Ancho"]);
                    Veh.ZonaRegistro = dr["ZonaRegistro"].ToString();
                    Veh.DuaDuam = Convert.ToInt32(dr["DuaDuam"]);
                    Veh.Titulo = Convert.ToInt32(dr["Titulo"]);
                    Veh.FechaTitulo = Convert.ToDateTime(dr["FechaTitulo"]);
                    Veh.Condicion = dr["Condicion"].ToString();
                    Veh.Placa = dr["Placa"].ToString();
                    Veh.PlacaAnterior = dr["PlacaAnterior"].ToString();
                    Veh.FotoVehiculo = (byte[])dr["FotoVehiculo"];
                }
            }
            catch (Exception e) {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return Veh;
        }
        //buscar vehiculo para reporte
        public DataTable BuscarVehiculos(string Placa) {
            DataTable dt;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarVehiculoD", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Placa", Placa);
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

        //deshabilitar Vehiculo
        public Boolean DeshabilitarVehiculo(EntVehiculo Veh)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarVehiculo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Placa", Veh.Placa);
                cmd.Parameters.AddWithValue("@Condicion", Veh.Condicion);
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
