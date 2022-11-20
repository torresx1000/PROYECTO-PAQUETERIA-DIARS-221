using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPADATOS;
using CAPAENTIDAD;
using System.Data;
namespace CAPALOGICA
{
    public class LogPedido
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly LogPedido _instancia = new LogPedido();
        //privado para evitar la instanciación directa
        public static LogPedido Instancia
        {
            get
            {
                return LogPedido._instancia;
            }
        }
        #endregion singleton
        public Boolean InsertarPedido(EntPedido Ped)
        {
            return DatPedido.Instancia.InsertaPedido(Ped);

        }
        public List<EntPedido> ListarPedido()
        {
            return DatPedido.Instancia.ListarPedido();
        }
        public Boolean EditarPedido(EntPedido Ped)
        {
            return DatPedido.Instancia.EditarPedido(Ped);
        }
        public Boolean DeshabilitarPedido(EntPedido Ped)
        {
            return DatPedido.Instancia.DeshabilitarPedido(Ped);
        }
        /* public DataTable BuscarCliente(string Cliente)
         {
             return DatCliente.Instancia.BuscarCliente(Cliente);
         }*/
        public EntPedido BuscarPedidoId(int Dni)
        {
            return DatPedido.Instancia.BuscarPedidoId(Dni);
        }
    }
}
