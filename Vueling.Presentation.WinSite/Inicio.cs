﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vueling.Presentation.WinSite
{
    static class Inicio
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.aaa
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AlumnoForm());
        }
    }
}
