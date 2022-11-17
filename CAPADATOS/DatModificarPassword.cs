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
    public class DatModificarPassword:Conexion
    {
        private static readonly DatModificarPassword _instancia = new DatModificarPassword();
        public static new DatModificarPassword Instancia
        {
            get
            {
                return DatModificarPassword._instancia;
            }
        }

        //Modificar Trabajador
        public Boolean ModificarContraseña(EntTrabajador Tra)
        {
            SqlCommand cmd = null;
            Boolean Edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("modificar_contrasena", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", Tra.Nombres);
                cmd.Parameters.AddWithValue("@usuario", Tra.Usuario);
                cmd.Parameters.AddWithValue("@password", Tra.Password);
                cmd.Parameters.AddWithValue("@passwordnueva", Tra.Password);
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




    }
}
