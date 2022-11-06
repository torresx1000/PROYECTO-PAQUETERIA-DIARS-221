using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPADATOS;
using CAPAENTIDAD;

namespace CAPALOGICA
{
    public class LogRuta
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly LogRuta _instancia = new LogRuta();
        //privado para evitar la instanciación directa
        public static LogRuta Instancia
        {
            get
            {
                return LogRuta._instancia;
            }
        }
        #endregion singleton

        public Boolean InsertarRuta(EntRuta Rut)
        {
            return DatRuta.Instancia.InsertaRuta(Rut);
        }
        public List<EntRuta> ListarRuta()
        {
            return DatRuta.Instancia.ListarRuta();
        }
        public Boolean EditarRuta(EntRuta Rut)
        {
            return DatRuta.Instancia.EditarRuta(Rut) ;
        }
        public Boolean DeshabilitarRuta(EntRuta Rut)
        {
            return DatRuta.Instancia.DeshabilitarRuta(Rut);
        }

        public EntRuta BuscarRutaId(int Id)
        {
            return DatRuta.Instancia.BuscarRutaId(Id);
        }
        public DataTable BuscarRutas(string  puntopar)
        {
            return DatRuta.Instancia.BuscarRutas(puntopar);
        }
    }
}
