using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace CAPAENTIDAD
{
    public class EntPlanilla
    {
        public int IdPlanilla { get; set; } 
        public double Ruc { get; set; }
        public string RazSocial { get; set; }
        public string Rubro { get; set; }
        public string Direccion { get; set; }

        public int IdTr { get; set; }
        public double DniTr { get; set; }
        public string nomTr { get; set; }
        public string AppTr { get; set; }
        public int Hijos { get; set; }
        public DateTime FechNacTr { get; set; }
        public string DirTr { get; set; }

        public string Cargo { get; set; }
        public string Categoria { get; set; }
        public string PerPago { get; set; }
        public string Onp { get; set; }
        public string Afp { get; set; }
        public string Cuspp { get; set; }
        public double ImportOtro { get; set; }

        public DateTime FechIngreso { get; set; }
        public DateTime FechCese { get; set; }
        public DateTime InitVac { get; set; }
        public DateTime FindVac { get; set; }
        public int DiasVac { get; set; }
        public int DiasLAb { get; set; }
        public int HrTrab { get; set; }
        public int HrExtr { get; set; }
        public int DiasNoLAb { get; set; }
    
    }

}
  

