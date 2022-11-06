using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPAENTIDAD
{
    public class EntRuta
    {
        public int IdRuta { get; set; }
        public string PuntoPartida { get; set; }
        public string PuntoLlegada { get; set; }
        public string Observaciones { get; set; }
        public Boolean EstadoRuta { get; set; }
    }
}
