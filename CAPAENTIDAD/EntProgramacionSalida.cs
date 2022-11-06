using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPAENTIDAD
{
    public class EntProgramacionSalida
    {
        public int IdProgramacionSalida { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int IdRuta { get; set; }
        public int IdConductor { get; set; }
        public int IdVehiculo { get; set; }
    }
}
