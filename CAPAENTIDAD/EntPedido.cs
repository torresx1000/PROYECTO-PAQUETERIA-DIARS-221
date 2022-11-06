using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPAENTIDAD
{
    public class EntPedido
    {
        public int  IdPedido { get; set; }
        public int DniR { get; set; }
        public string CorreoR { get; set; } 
        public int TelefonoR { get; set; }
        public string DireccionR    { get; set; }
        public string NombreR { get; set; }
        public string ObservacionesR  { get; set; }
        public int ContactoR { get; set; }
        public string DistritoR { get; set; }
        public string ProvinciaR { get; set; }
        public string DepartamentoR { get; set; }

        public int DniD { get; set; }
        public string CorreoD { get; set; }
        public int TelefonoD { get; set; }
        public string DireccionD { get; set; }
        public string NombreD { get; set; }
        public string ObservacionesD { get; set; }
        public int ContactoD { get; set; }
        public string DistritoD { get; set; }
        public string ProvinciaD { get; set; }
        public string DepartamentoD { get; set; }


    }
}
