using ProyecContable.Asientos.CreacionAsiento;
using ProyecContable.Cuentas.CreacionCuenta;
using ProyecContable.Niveles;
using ProyecContable.Niveles.Nivel4;
using ProyecContable.Niveles.Nivel5;
using ProyecContable.Niveles.Niver3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyecContable
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
            Application.Run(new FrmPrincipal());
        }
    }
}
