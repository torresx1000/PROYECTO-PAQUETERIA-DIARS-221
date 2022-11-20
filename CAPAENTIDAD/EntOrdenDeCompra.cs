using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPAENTIDAD
{
    public class EntOrdenDeCompra
    {
        public int Codigo { get; set; }
        public int IdLista { get; set; }
        public string FirmaNom { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
    }
}
