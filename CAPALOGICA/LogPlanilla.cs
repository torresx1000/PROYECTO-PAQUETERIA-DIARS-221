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
    public class LogPlanilla
    {

        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly LogPlanilla _instancia = new LogPlanilla();
        //privado para evitar la instanciación directa
        public static LogPlanilla Instancia
        {
            get
            {
                return LogPlanilla._instancia;
            }
        }
        #endregion singleton

        public Boolean InsertaPlanilla(EntPlanilla Tra)
        {
            return DatPlanilla.Instancia.InsertaPlanilla(Tra);
        }
        public List<EntPlanilla> ListarPlanilla()
        {
            return DatPlanilla.Instancia.ListarPlanilla();
        }
        public Boolean ModificarPlanilla(EntPlanilla Tra)
        {
            return DatPlanilla.Instancia.ModificarPlanilla(Tra);
        }
        public Boolean DeshabilitarPlanilla(EntPlanilla Tra)
        {
            return DatPlanilla.Instancia.DeshabilitarPlanilla(Tra);
        }
        /* public DataTable BuscarCliente(string Cliente)
         {
             return DatCliente.Instancia.BuscarCliente(Cliente);
         }*/
        public EntPlanilla BuscarPlanillaDni(int IdPlanilla)
        {
            return DatPlanilla.Instancia.BuscarPlanillaDni(IdPlanilla);
        }
        
    }
}
