using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPADATOS;
using CAPAENTIDAD;

namespace CAPALOGICA
{
    public class LogModificarPaswword
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly LogModificarPaswword _instancia = new LogModificarPaswword();
        //privado para evitar la instanciación directa
        public static LogModificarPaswword Instancia
        {
            get
            {
                return LogModificarPaswword._instancia;
            }
        }
        #endregion singleton

        public Boolean ModificarContraseña(EntTrabajador Tra)
        {
            return 
                DatModificarPassword.Instancia.ModificarContraseña(Tra);
        }
    }
}
