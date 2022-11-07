using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPAENTIDAD
{
    public class EntPagoUtilidades
    {
        public int IdPagoUtilidades { get; set; }
        public int IdPlanilla { get; set; }
        public int IdTrabajador { get; set; }
        public Double TotalRemuneraciones { get; set; }
        public Double TotalDescuentos { get; set; }
        public Double TotalAportes { get; set; }
        public int CtaAhorros { get; set; }
        public DateTime FechaPago { get; set; }
        public Double NetoAPagar { get; set; }
    }
}
