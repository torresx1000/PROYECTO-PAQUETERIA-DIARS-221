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
    public class LogGastosDeViaje
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly LogGastosDeViaje _instancia = new LogGastosDeViaje();
        //privado para evitar la instanciación directa
        public static LogGastosDeViaje Instancia
        {
            get
            {
                return LogGastosDeViaje._instancia;
            }

        }
        #endregion singleton
        public Boolean InsertaGastosDeViaje(EntGastosDeViaje Ped)
        {
            return DatGastosViajes.Instancia.InsertaGastosViaje(Ped);

        }
        public List<EntGastosDeViaje> ListarGastosDeViajes()
        {
            return DatGastosViajes.Instancia.ListarGastosDeViaje();
        }
        public Boolean EditarGastosDeViaje(EntGastosDeViaje Ped)
        {
            return DatGastosViajes.Instancia.EditarGastosDeViaje(Ped);
        }

        public DataTable BuscarGastosDeVaije(int idgastos)
        {
            return DatGastosViajes.Instancia.BuscarGastosdeViaje(idgastos);
        }
        public Boolean Elimminar(EntGastosDeViaje id)
        {
            return DatGastosViajes.Instancia.Eliminar(id);
        }
    }
}
