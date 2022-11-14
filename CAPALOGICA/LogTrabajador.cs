using CAPAENTIDAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPADATOS;
using System.Data;

namespace CAPALOGICA
{
    public class LogTrabajador
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly LogTrabajador _instancia = new LogTrabajador();
        //privado para evitar la instanciación directa
        public static LogTrabajador Instancia
        {
            get
            {
                return LogTrabajador._instancia;
            }
        }
        #endregion singleton

        public Boolean InsertarTrabajador(EntTrabajador Tra)
        {
            return DatTrabajador.Instancia.InsertaTrabajador(Tra);
        }
        public List<EntTrabajador> ListarTrabajador()
        {
            return DatTrabajador.Instancia.ListarTrabajador();
        }
        //Listar conductor
        public List<EntTrabajador> ListarConductor()
        {
            return DatTrabajador.Instancia.ListarConductor();
        }
        public Boolean EditarTrabajador(EntTrabajador Tra)
        {
            return DatTrabajador.Instancia.EditarTrabajador(Tra);
        }
        public Boolean DeshabilitarTrabajador(EntTrabajador Tra)
        {
            return DatTrabajador.Instancia.DeshabilitarTrabajador(Tra);
        }
       
        public EntTrabajador BuscarTrabajadorDni(int Dni)
        {
            return DatTrabajador.Instancia.BuscarTrabajadorDni(Dni);
        }
        public DataTable BuscarTrabajadores(string Nombres)
        {
            return DatTrabajador.Instancia.BuscarTrabajadores(Nombres);
        }
    }
}
