using CAPAENTIDAD;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CAPADATOS
{
    public class DatPlanilla : Conexion
    {
        private static readonly DatPlanilla _instancia = new DatPlanilla();
        public static new DatPlanilla Instancia
        {
            get
            {
                return DatPlanilla._instancia;
            }
        }
        //Para agregar a planilla 
        public Boolean InsertaPlanilla(EntPlanilla Pla)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spIngresarPlanilla", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@IdTrabajador", Pla.Id_Trabajador);
                cmd.Parameters.AddWithValue("@Ruc", Pla.Ruc);
                cmd.Parameters.AddWithValue("@RazSocial", Pla.RazSocial);
                cmd.Parameters.AddWithValue("@Rubro", Pla.Rubro);
                cmd.Parameters.AddWithValue("@Direccion", Pla.Direccion);

                cmd.Parameters.AddWithValue("@IdTr", Pla.IdTr);
                cmd.Parameters.AddWithValue("@DniTr", Pla.DniTr);
                cmd.Parameters.AddWithValue("@nomTr", Pla.nomTr);
                cmd.Parameters.AddWithValue("@AppTr", Pla.AppTr);
                cmd.Parameters.AddWithValue("@Hijos", Pla.Hijos);
                cmd.Parameters.AddWithValue("@FechNacTr", Pla.FechNacTr);
                cmd.Parameters.AddWithValue("@DirTr", Pla.DirTr);

                cmd.Parameters.AddWithValue("@Cargo", Pla.Cargo);
                cmd.Parameters.AddWithValue("@Categoria", Pla.Categoria);
                cmd.Parameters.AddWithValue("@PerPago", Pla.PerPago);
                cmd.Parameters.AddWithValue("@Onp", Pla.Onp);
                cmd.Parameters.AddWithValue("@Afp", Pla.Afp);
                cmd.Parameters.AddWithValue("@Cuspp", Pla.Cuspp);
                cmd.Parameters.AddWithValue("@ImportOtro", Pla.ImportOtro);

                cmd.Parameters.AddWithValue("@FechIngreso", Pla.FechIngreso);
                cmd.Parameters.AddWithValue("@FechCese", Pla.FechCese);
                cmd.Parameters.AddWithValue("@InitVac", Pla.InitVac);
                cmd.Parameters.AddWithValue("@FindVac", Pla.FindVac);
                cmd.Parameters.AddWithValue("@DiasVac", Pla.DiasVac);
                cmd.Parameters.AddWithValue("@DiasLAb", Pla.DiasLAb);
                cmd.Parameters.AddWithValue("@HrTrab", Pla.HrTrab);
                cmd.Parameters.AddWithValue("@HrExtr", Pla.HrExtr);
                cmd.Parameters.AddWithValue("@DiasNoLAb", Pla.DiasNoLAb);           
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

        //listar Planilla
        public List<EntPlanilla> ListarPlanilla()
        {
            SqlCommand cmd = null;
            List<EntPlanilla> Lista = new List<EntPlanilla>();

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarPlanilla", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntPlanilla Pla = new EntPlanilla();
                    Pla.IdPlanilla = Convert.ToInt32(dr["IdPlanilla"]);
                    Pla.Ruc = Convert.ToDouble(dr["Ruc"]);
                    Pla.RazSocial = dr["RazSocial"].ToString(); ;
                    Pla.Rubro = dr["Rubro"].ToString();
                    Pla.Direccion = dr["Direccion"].ToString();

                    Pla.IdTr = Convert.ToInt32(dr["IdTr"]);
                    Pla.DniTr = Convert.ToDouble(dr["DniTr"]);
                    Pla.nomTr = dr["nomTr"].ToString();
                    Pla.AppTr = dr["AppTr"].ToString();
                    Pla.Hijos = Convert.ToInt32(dr["Hijos"]);
                    Pla.FechNacTr = Convert.ToDateTime(dr["FechNacTr"]);
                    Pla.DirTr = dr["DirTr"].ToString();

                    Pla.Cargo = dr["Cargo"].ToString();
                    Pla.Categoria = dr["Categoria"].ToString();
                    Pla.PerPago = dr["PerPago"].ToString();
                    Pla.Onp = dr["Onp"].ToString();
                    Pla.Afp = dr["Afp"].ToString();
                    Pla.Cuspp = dr["Cuspp"].ToString();
                    Pla.ImportOtro = Convert.ToDouble(dr["ImportOtro"]);

                    Pla.FechIngreso = Convert.ToDateTime(dr["FechIngreso"]);
                    Pla.FechCese = Convert.ToDateTime(dr["FechCese"]);
                    Pla.InitVac = Convert.ToDateTime(dr["InitVac"]);
                    Pla.FindVac = Convert.ToDateTime(dr["FindVac"]);
                    Pla.DiasVac = Convert.ToInt32(dr["DiasVac"]);
                    Pla.DiasLAb = Convert.ToInt32(dr["DiasLAb"]);
                    Pla.HrTrab = Convert.ToInt32(dr["HrTrab"]);
                    Pla.HrExtr = Convert.ToInt32(dr["HrExtr"]);
                    Pla.DiasNoLAb = Convert.ToInt32(dr["DiasNoLAb"]);
                    Lista.Add(Pla);
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

        //Modificar Planilla
        public Boolean ModificarPlanilla(EntPlanilla Pla)
        {
            SqlCommand cmd = null;
            Boolean Edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spModificarPlanilla", cn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdPlanilla", Pla.IdPlanilla);
                cmd.Parameters.AddWithValue("@Ruc", Pla.Ruc);
                cmd.Parameters.AddWithValue("@RazSocial", Pla.RazSocial);
                cmd.Parameters.AddWithValue("@Rubro", Pla.Rubro);
                cmd.Parameters.AddWithValue("@Direccion", Pla.Direccion);

                cmd.Parameters.AddWithValue("@IdTr", Pla.IdTr);
                cmd.Parameters.AddWithValue("@DniTr", Pla.DniTr);
                cmd.Parameters.AddWithValue("@nomTr", Pla.nomTr);
                cmd.Parameters.AddWithValue("@AppTr", Pla.AppTr);
                cmd.Parameters.AddWithValue("@Hijos", Pla.Hijos);
                cmd.Parameters.AddWithValue("@FechNacTr", Pla.FechNacTr);
                cmd.Parameters.AddWithValue("@DirTr", Pla.DirTr);

                cmd.Parameters.AddWithValue("@Cargo", Pla.Cargo);
                cmd.Parameters.AddWithValue("@Categoria", Pla.Categoria);
                cmd.Parameters.AddWithValue("@PerPago", Pla.PerPago);
                cmd.Parameters.AddWithValue("@Onp", Pla.Onp);
                cmd.Parameters.AddWithValue("@Afp", Pla.Afp);
                cmd.Parameters.AddWithValue("@Cuspp", Pla.Cuspp);
                cmd.Parameters.AddWithValue("@ImportOtro", Pla.ImportOtro);

                cmd.Parameters.AddWithValue("@FechIngreso", Pla.FechIngreso);
                cmd.Parameters.AddWithValue("@FechCese", Pla.FechCese);
                cmd.Parameters.AddWithValue("@InitVac", Pla.InitVac);
                cmd.Parameters.AddWithValue("@FindVac", Pla.FindVac);
                cmd.Parameters.AddWithValue("@DiasVac", Pla.DiasVac);
                cmd.Parameters.AddWithValue("@DiasLAb", Pla.DiasLAb);
                cmd.Parameters.AddWithValue("@HrTrab", Pla.HrTrab);
                cmd.Parameters.AddWithValue("@HrExtr", Pla.HrExtr);
                cmd.Parameters.AddWithValue("@DiasNoLAb", Pla.DiasNoLAb);

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

        //para buscar Trabajador
        public EntPlanilla BuscarPlanillaDni(int IdPlanilla)
        {
            SqlCommand cmd = null;
            EntPlanilla Pla = new EntPlanilla();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarPLanilla", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdPlanilla", IdPlanilla);
              ;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Pla.IdPlanilla = Convert.ToInt32(dr["IdPlanilla"]);
                    Pla.Ruc = Convert.ToDouble(dr["Ruc"]);
                    Pla.RazSocial = dr["RazSocial"].ToString(); ;
                    Pla.Rubro = dr["Rubro"].ToString();
                    Pla.Direccion = dr["Direccion"].ToString();

                    Pla.IdTr = Convert.ToInt32(dr["IdTr"]);
                    Pla.DniTr = Convert.ToDouble(dr["DniTr"]);
                    Pla.nomTr = dr["nomTr"].ToString();
                    Pla.AppTr = dr["AppTr"].ToString();
                    Pla.Hijos = Convert.ToInt32(dr["Hijos"]);
                    Pla.FechNacTr = Convert.ToDateTime(dr["FechNacTr"]);
                    Pla.DirTr = dr["DirTr"].ToString();

                    Pla.Cargo = dr["Cargo"].ToString();
                    Pla.Categoria = dr["Categoria"].ToString();
                    Pla.PerPago = dr["PerPago"].ToString();
                    Pla.Onp = dr["Onp"].ToString();
                    Pla.Afp = dr["Afp"].ToString();
                    Pla.Cuspp = dr["Cuspp"].ToString();
                    Pla.ImportOtro = Convert.ToDouble(dr["ImportOtro"]);

                    Pla.FechIngreso = Convert.ToDateTime(dr["FechIngreso"]);
                    Pla.FechCese = Convert.ToDateTime(dr["FechCese"]);
                    Pla.InitVac = Convert.ToDateTime(dr["InitVac"]);
                    Pla.FindVac = Convert.ToDateTime(dr["FindVac"]);
                    Pla.DiasVac = Convert.ToInt32(dr["DiasVac"]);
                    Pla.DiasLAb = Convert.ToInt32(dr["DiasLAb"]);
                    Pla.HrTrab = Convert.ToInt32(dr["HrTrab"]);
                    Pla.HrExtr = Convert.ToInt32(dr["HrExtr"]);
                    Pla.DiasNoLAb = Convert.ToInt32(dr["DiasNoLAb"]);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return Pla;
        }
        
        //para deshabilitar Trabajador(por DNI)
        public Boolean DeshabilitarPlanilla(EntPlanilla Pla)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInabilitaRPlanilla", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdPlanilla", Pla.IdPlanilla);
                cmd.Parameters.AddWithValue("@Categoria", Pla.Categoria);
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
