using Above_Premiere.Controller;
using Above_Premiere.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Above_Premiere
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Controller.Controller c = new Controller.Controller();
            c.start();
        }
    }
}
