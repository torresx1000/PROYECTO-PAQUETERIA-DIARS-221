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
    public class LogListarRepuestos
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly LogListarRepuestos _instancia = new LogListarRepuestos();
        //privado para evitar la instanciación directa
        public static LogListarRepuestos Instancia
        {
            get
            {
                return LogListarRepuestos._instancia;
            }

        }
        #endregion singleton
        public Boolean InsertaListaRepuesto(EntListaRespuesto Ped)
        {
            return DatListaRepuestos.Instancia.InsertaListaRepuesto(Ped);

        }
        public List<EntListaRespuesto> ListarRepuesto()
        {
            return DatListaRepuestos.Instancia.ListarRepuestos();
        }
        public Boolean EditarListaRepuesto(EntListaRespuesto Ped)
        {
            return DatListaRepuestos.Instancia.EditarListaRepuesto(Ped);
        }

        public DataTable BuscarListaRepuesto(int idLista)
        {
            return DatListaRepuestos.Instancia.BuscarListaRepuesto(idLista);
        }
        public Boolean Elimminar(EntListaRespuesto id)
        {
            return DatListaRepuestos.Instancia.Eliminar(id);
        }

    }
}
