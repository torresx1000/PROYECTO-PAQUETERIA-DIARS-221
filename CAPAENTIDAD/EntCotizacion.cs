using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPAENTIDAD
{
    public class EntCotizacion
    {
        public int IdCotizacion { get; set; }
        public string Descripcion { get; set; }
        public Double precio { get; set; }
        public int IDPEDIDO { get; set; }
    }
}
