using CAPADATOS;
using CAPAENTIDAD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPALOGICA
{
    public class LogDiagnostico
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly LogDiagnostico _instancia = new LogDiagnostico();
        //privado para evitar la instanciación directa
        public static LogDiagnostico Instancia
        {
            get
            {
                return LogDiagnostico._instancia;
            }
        }
        #endregion singleton
        public Boolean InsertaDiagnostico(EntDiagnostico Ped)
        {
            return DatDiagnostico.Instancia.InsertaDiagnostico(Ped);

        }
        public List<EntDiagnostico> ListarDiagnostico()
        {
            return DatDiagnostico.Instancia.ListarDiagnostico();
        }
        public Boolean EditarDiagnostico(EntDiagnostico Ped)
        {
            return DatDiagnostico.Instancia.EditarDiagnostico(Ped);
        }
      
        public DataTable BuscarDiagnosticoId(int Dni)
        {
            return DatDiagnostico.Instancia.BuscarDiagnosticoId(Dni);
        }
        public Boolean Elimminar(EntDiagnostico id)
        {
            return DatDiagnostico.Instancia.Eliminar(id);
        }
    }

}
