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
    public class LogProgramacionSalida
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly LogProgramacionSalida _instancia = new LogProgramacionSalida();
        //privado para evitar la instanciación directa
        public static LogProgramacionSalida Instancia
        {
            get
            {
                return LogProgramacionSalida._instancia;
            }
        }
        #endregion singleton

        public Boolean InsertarProgramacioSalida(EntProgramacionSalida pro) {
            return DatProgramacionSalida.Instancia.InsertarProgramacionSalida(pro);
        }
        public Boolean EditarProgramacionSalida(EntProgramacionSalida pro) {
            return DatProgramacionSalida.Instancia.EditarProgramacionSalida(pro);
        }
        public EntProgramacionSalida BuscarProgramacionSalidaId(int id) {
            return DatProgramacionSalida.Instancia.BuscarProgamacionSalida(id);
        }
        public DataTable BuscarProgramacion(int id)
        {
            return DatProgramacionSalida.Instancia.BuscarProgramacion(id);
        }
        /* public EntProgramacionSalida BuscarProgramacionSalidaCon(int id)
         {
             return DatProgramacionSalida.Instancia.BuscarConPro(id);
         }*/
        public List<EntProgramacionSalida> ListarProgrmacionSalida() {
            return DatProgramacionSalida.Instancia.ListarProgramacionSalida();
        }
        public Boolean ElimminarProgramacionSalida(EntProgramacionSalida pro) {
            return DatProgramacionSalida.Instancia.EliminarProgramacionSalida(pro);//en observacion
        }
    }
}
