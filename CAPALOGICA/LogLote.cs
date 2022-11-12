using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPAENTIDAD;
using CAPADATOS;

namespace CAPALOGICA
{
    public class LogLote
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly LogLote _instancia = new LogLote();
        //privado para evitar la instanciación directa
        public static LogLote Instancia
        {
            get
            {
                return LogLote._instancia;
            }
        }
        #endregion singleton
        public List<EntLote> ListarLote()
        {
            return DatLote.Instancia.ListarLote();
        }
        public void InsertarLote(EntLote Lot)
        {
            DatLote.Instancia.InsertarLote(Lot);
        }
        //edita
        public void EditarLote(EntLote Lot)
        {
            DatLote.Instancia.EditarLote(Lot);
        }
        public EntLote BuscarLoteCodigo(int IdLote)
        {
            return DatLote.Instancia.BuscarLoteCodigo(IdLote);
        }
        public void EliminarLote(EntLote Lot)
        {
            DatLote.Instancia.EliminarLote(Lot);
        }
       
    }
}
