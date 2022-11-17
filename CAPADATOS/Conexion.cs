
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CAPADATOS
{
    public class Conexion
    {
        //patron de Diseño Singleton
        private static readonly Conexion _instancia = new Conexion();
        public static Conexion Instancia
        {
            get { return Conexion._instancia; }
        }
        public SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection();
            //yisusnet
          //  cn.ConnectionString = "Data Source=LAPTOP-BNHKM586; Initial Catalog = BDPROYECTODIARS; Integrated Security=true"; //cadena uno
            //Jesus
            //cn.ConnectionString = "Data Source=LAPTOP-BNHKM586; Initial Catalog = PAQUETERIADIARS; Integrated Security=true"; //cadena dos
            //OSNI
            //cn.ConnectionString = "Data Source=DESKTOP-RL2KS61\\SQLEXPRESS; Initial Catalog = BDPROYECTODIARS; Integrated Security=true";
            //Cleiner
            //cn.ConnectionString = "Data Source=DESKTOP-R0RTQRL; Initial Catalog = PAQUETERIADIARS; Integrated Security=true"; //cadena dos
            //Yeyson
            //cn.ConnectionString = "Data Source=DESKTOP-A1OPPUQ\\SQLEXPRESS; Initial Catalog = BDPROYECTODIARS; Integrated Security=true"; //cadena uno            
            return cn;
        }
    }
}
