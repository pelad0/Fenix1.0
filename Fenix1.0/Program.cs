using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Fenix1._0
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmABMME());
            //Application.Run(new frmABMOS());
            //Application.Run(new frmABMUsuario());
            Application.Run(new frmABMPaciente());
            //Application.Run(new frmABMTurnos());
        }
    }
}
