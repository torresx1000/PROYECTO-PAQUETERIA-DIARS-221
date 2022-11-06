using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPAENTIDAD
{
    public class EntCheckList
    {
        public int IdCheck { get; set; }
        public DateTime FechaCheck { get; set; }
        public string Combustible { get; set; }
        public string Horometro { get; set; }
        public string Inspeccion { get; set; }
        public string Kilometraje { get; set; }
        public int IdVehiculo { get; set; }
        public int IdConductor { get; set; }
    }
}
