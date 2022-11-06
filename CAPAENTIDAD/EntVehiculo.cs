using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPAENTIDAD
{
    public class EntVehiculo
    {
        public int IdVehiculo { get; set; }
        public string Categoria { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public string Motor { get; set; }
        public string Combustible { get; set; }
        public string FormRodante { get; set; }
        public string AñoFabricacion { get; set; }
        public string AñoModelo { get; set; }
        public string Version { get; set; }
        public int Ejes { get; set; }
        public int Asientos { get; set; }
        public int Pasajeros { get; set; }
        public int Ruedas { get; set; }
        public string Carroceria { get; set; }
        public string Potencia { get; set; }
        public int Cilindros { get; set; }
        public double Cilindrada { get; set; }
        public double PesoBruto { get; set; }
        public double PesoNeto { get; set; }
        public double CargaUtil { get; set; }
        public double Longitud { get; set; }
        public double Altura { get; set; }
        public double Ancho { get; set; }
        public string ZonaRegistro { get; set; }
        public int DuaDuam { get; set; }
        public int Titulo { get; set; }
        public DateTime FechaTitulo { get; set; }
        public string Condicion { get; set; }
        public string Placa { get; set; }
        public string PlacaAnterior { get; set; }
        public byte[] FotoVehiculo { get; set; }
    }
}
