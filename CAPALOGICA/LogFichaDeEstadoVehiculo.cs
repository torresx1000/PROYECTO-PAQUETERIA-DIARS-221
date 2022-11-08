using CAPADATOS;
using CAPAENTIDAD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPALOGICA
{
    public class LogFichaDeEstadoVehiculo
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly LogFichaDeEstadoVehiculo _instancia = new LogFichaDeEstadoVehiculo();
        //privado para evitar la instanciación directa
        public static LogFichaDeEstadoVehiculo Instancia
        {
            get
            {
                return LogFichaDeEstadoVehiculo._instancia;
            }

        }
        #endregion singleton
        public Boolean InsertaFichaDeEstadoVehiculo(EntFichaDeEstadoVehiculo Ped)
        {
            return DatFichaEstadoVehiculo.Instancia.InsertaFichaEstadoVehiculo(Ped);

        }
        public List<EntFichaDeEstadoVehiculo> ListarFichaDeViaje()
        {
            return DatFichaEstadoVehiculo.Instancia.ListarFichaDeEstadoVehiculo();
        }
        public Boolean EditarFichaDeEstadoVehicular(EntFichaDeEstadoVehiculo Ped)
        {
            return DatFichaEstadoVehiculo.Instancia.EditarFichaDeEstadoVehiculo(Ped);
        }

        public DataTable BuscarFichaDeEstadoVehicular(int idficha)
        {
            return DatFichaEstadoVehiculo.Instancia.BuscarFichaDeEstadoVehiculo(idficha);
        }
        public Boolean Elimminar(EntFichaDeEstadoVehiculo id)
        {
            return DatFichaEstadoVehiculo.Instancia.Eliminar(id);
        }
    }
}
