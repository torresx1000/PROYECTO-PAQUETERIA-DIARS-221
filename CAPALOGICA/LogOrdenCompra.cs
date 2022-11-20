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
    public class LogOrdenCompra
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly LogOrdenCompra _instancia = new LogOrdenCompra();
        //privado para evitar la instanciación directa
        public static LogOrdenCompra Instancia
        {
            get
            {
                return LogOrdenCompra._instancia;
            }
        }
        #endregion singleton

        public Boolean InsertarOrdenCompra(EntOrdenDeCompra Rut)
        {
            return DatOrdenDeCompra.Instancia.InsertaOrdenCompra(Rut);
        }
        public List<EntOrdenDeCompra> ListarOrdenCompra()
        {
            return DatOrdenDeCompra.Instancia.ListarOrdenCompra();
        }
        public Boolean EditarOrdenCompra(EntOrdenDeCompra Rut)
        {
            return DatOrdenDeCompra.Instancia.EditarOrdenCompra(Rut);
        }
        public Boolean EliminarOrdenCompra(EntOrdenDeCompra Rut)
        {
            return DatOrdenDeCompra.Instancia.EliminarOrdenCompra(Rut);
        }

        public EntOrdenDeCompra BuscarOrdenCompraId(int Id)
        {
            return DatOrdenDeCompra.Instancia.BuscarCompraId(Id);
        }
    }
}
