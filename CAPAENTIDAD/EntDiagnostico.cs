using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPAENTIDAD
{
    public class EntDiagnostico
    {
        public int IdDiagnostico { get; set; }
        public string Observaciones { get; set; }
        public string Fallas { get; set; }
        public DateTime fecha { get; set; }
        public int IdVehiculo { get; set; }
        public int IdConductor { get; set; }
       
    }
}
