using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPAENTIDAD
{
    public class EntGastosDeViaje
    {
        public int IdGastosdeViaje        { get; set; }
        public int IdProgramaciondesalida { get; set; }
        public DateTime Fecha             { get; set; }
        public string Viaticos            { get; set; }
        public Double preciosviaticos { get; set; }
        public string Combustible         { get; set; }
        public Double precioscombustible  { get; set; }
        public string Otros               { get; set; }
        public Double preciosotros        { get; set; }
        public Double Total { get; set; }
    }
}
