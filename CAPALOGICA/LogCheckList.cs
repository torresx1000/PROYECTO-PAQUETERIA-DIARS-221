using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPAENTIDAD;
using CAPADATOS;
using System.Data;

namespace CAPALOGICA
{
    public class LogCheckList
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly LogCheckList _instancia = new LogCheckList();
        //privado para evitar la instanciación directa
        public static LogCheckList Instancia
        {
            get
            {
                return LogCheckList._instancia;
            }
        }
        #endregion singleton
        public Boolean InsertaCheckList(EntCheckList Ped)
        {
            return DatCheckLista.Instancia.InsertaCheckList(Ped);

        }
        public List<EntCheckList> ListarCheckLista()
        {
            return DatCheckLista.Instancia.ListarCheck();
        }
        public Boolean EditarCheckLista(EntCheckList Ped)
        {
            return DatCheckLista.Instancia.EditarCheck(Ped);
        }

        public DataTable BuscarCheckId(int id)
        {
            return DatCheckLista.Instancia.BuscarCheckId(id);       
        }
        public Boolean Elimminar(EntCheckList id)
        {
            return DatCheckLista.Instancia.Eliminar(id);
        }
    }
}
