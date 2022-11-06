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
    public class LogVehiculo
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly LogVehiculo _instancia = new LogVehiculo();
        //privado para evitar la instanciación directa
        public static LogVehiculo Instancia
        {
            get
            {
                return LogVehiculo._instancia;
            }
        }
        #endregion singleton
        public Boolean InsertarVehiculo(EntVehiculo Veh)
        {
            return DatVehiculo.Instancia.InsertaVehiculo(Veh);
        }
        public List<EntVehiculo> ListarVehiculo()
        {
            return DatVehiculo.Instancia.ListarVehiculo();
        }
        public Boolean EditarVehiculo(EntVehiculo Veh)
        {
            return DatVehiculo.Instancia.EditarVehiculo(Veh);
        }
        public Boolean DeshabilitarVehiculo(EntVehiculo Veh)
        {
            return DatVehiculo.Instancia.DeshabilitarVehiculo(Veh);
        }
        public EntVehiculo BuscarVehiculo(string Placa)
        {
            return DatVehiculo.Instancia.BuscarVehivulo(Placa);
        }
        public DataTable BuscarVehiculos(string Placa) {
            return DatVehiculo.Instancia.BuscarVehiculos(Placa);
        }
    }
}
