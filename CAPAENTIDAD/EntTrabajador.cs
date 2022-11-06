using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPAENTIDAD
{
    public class EntTrabajador
    {
        public int Id_Trabajador { get; set; }
        public int Dni { get; set; }
        public string Nombres { get; set; }
        public string ApPaterno { get; set; }
        public string ApMaterno { get; set; }
        public DateTime FechaNac { get; set; }
        public string Sexo { get; set; }
        public string EstCivil { get; set; }
        public int Ubigeo { get; set; }
        public string Direccion { get; set; }
        public string Distrito { get; set; }
        public string Provincia { get; set; }
        public string Departamento { get; set; }
        public DateTime FechaContrato { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
        public string Cargo { get; set; }
        public Boolean EstadoTrabajador{ get; set; }
        public byte[] PerfilTrabajador { get; set; }
    }
}
