using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CAPAENTIDAD;
using CAPADATOS;
namespace CAPALOGICA
{
    public class LogCotizacion
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly LogCotizacion _instancia = new LogCotizacion();
        //privado para evitar la instanciación directa
        public static LogCotizacion Instancia
        {
            get
            {
                return LogCotizacion._instancia;
            }
        }
        #endregion singleton

        public Boolean InsertaCotizacion(EntCotizacion Ped)
        {
            return DatCotizacion.Instancia.InsertaCotizacion(Ped);

        }
        public List<EntCotizacion> ListarCotizacion()
        {
            return DatCotizacion.Instancia.ListarCotizacion();
        }
        public Boolean EditarCotizacion(EntCotizacion Ped)
        {
            return DatCotizacion.Instancia.EditarCotizacion(Ped);
        }

        public DataTable BuscarCotizacionId(int id)
        {
            return DatCotizacion.Instancia.BuscarCotizacion(id);
        }
        public Boolean Elimminar(EntCotizacion id)
        {
            return DatCotizacion.Instancia.EliminarCotizacion(id);
        }
    }
}
