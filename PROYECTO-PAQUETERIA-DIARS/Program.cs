using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_PAQUETERIA_DIARS
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        public static Login inicio;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false); 
            Application.Run(new Pantalla_de_Carga());
            Application.Run(inicio =new Login());
            Application.Run(new Login());
            //Application.Run(new FrmRemitente_Destinatario());
            //Application.Run(new FrmMenuGerente("ADMINISTRADOR","SISTEMAS"));
            //Application.Run(new FrmMenuSecretaria());
            //Application.Run(new FrmMenuJefeDeMantenimiento());
            //Application.Run(new FrmMenuAlmacenero());
            //Application.Run(new FrmMenuContador("este es el cargo", "esteeselnombre"));
           // Application.Run(new FrmMenuCajero("este es el cargo", "esteeselnombre"));
            //Application.Run(new FrmMenuJefeDeOperaciones("este es el cargo","esteeselnombre"));
            //Application.Run(new FrmMenuCajero());
            //Application.Run(new FrmMenuConductor());
            //Application.Run(new FrmPlanilla());
            //Application.Run(new FrmMantRegistroPersonas());
            //Application.Run(new FrmMantVehiculo());
            //Application.Run(new FrmRuta());
            //Application.Run(new FrmFichaDeEstadoVehiculo());
            //Application.Run(new FrmGastosDeViaje());
            //Application.Run(new FrmReporteVehiculo());
            //Application.Run(new FrmReporteRuta());
            //Application.Run(new FrmReporteTrabajadores());
            //Application.Run(new FrmReportePlanilla());
            //Application.Run(new FrmMantendorLote());
            //Application.Run(new FrmDiagnostico());
            //Application.Run(new FrmListaConductores_Trabajadores());
            //Application.Run(new FrmProgramacionSalida());
            //Application.Run(new FrmReporteProgramacionSalida());
            //Application.Run(new FrmReportePlanilla());
            //Application.Run(new FrmPagoUtilidades());
            //Application.Run(new FrmFichaDeEstadoVehiculo());
            //Application.Run(new FrmGastosDeViaje());
            //Application.Run(new FrmPagoUtilidades());
            //Application.Run(new FrmCotizacion());
        }
    }
}
