﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace oah_v1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new welcome_page());
        }
    }
}
