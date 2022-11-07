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
    public class LogPagoUtilidades
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly LogPagoUtilidades _instancia = new LogPagoUtilidades();
        //privado para evitar la instanciación directa
        public static LogPagoUtilidades Instancia
        {
            get
            {
                return LogPagoUtilidades._instancia;
            }
        }
        #endregion singleton
        public Boolean InsertaPagoUtilidades(EntPagoUtilidades paut)
        {
            return DatPagoUtilidades.Instancia.InsertaPagoUtilidades(paut);

        }
        public List<EntPagoUtilidades> ListarPagoUtilidades()
        {
            return DatPagoUtilidades.Instancia.ListarPagoUtilidades();
        }
        public Boolean EditarPagoUtilidades(EntPagoUtilidades paut)
        {
            return DatPagoUtilidades.Instancia.EditarPagoUtilidades(paut);
        }

        public DataTable BuscarPagoUtilidadesId(int id)
        {
            return DatPagoUtilidades.Instancia.BuscarPagoUtilidadId(id);
        }
        public Boolean ElimminarPagoUtilidades(EntPagoUtilidades id)
        {
            return DatPagoUtilidades.Instancia.Eliminar(id);
        }
    }
}
