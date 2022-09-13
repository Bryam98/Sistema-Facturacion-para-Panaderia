using DevExpress.Xpo;
using SFPanaderia.PanaderiaBD;
using SFPanaderia.Reportes;
using SFPanaderia.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SFPanaderia
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            XpoDefault.DataLayer = XpoDefault.GetDataLayer(
            ConnectionHelper.ConnectionString,
            DevExpress.Xpo.DB.AutoCreateOption.DatabaseAndSchema);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmVenta());
        }
    }
}
