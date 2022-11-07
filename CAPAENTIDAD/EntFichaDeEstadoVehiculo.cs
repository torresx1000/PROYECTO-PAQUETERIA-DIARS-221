using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPAENTIDAD
{
    public class EntFichaDeEstadoVehiculo
    {
        public int IdEstadoVehiculo { get; set; }
        public int Conductor         { get; set; }
        public int Vehiculo          { get; set; }
        public DateTime Fecha            { get; set; }
        public string SistemaElectrico        { get; set; }
        public string SistemaMecanico        { get; set; }
        public string LetoneriayPintura         { get; set; }
        public string Otros              { get; set; }
        
    }
}
