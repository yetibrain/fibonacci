// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Siemens AG" file="Program.cs">
//   Copyright © Siemens AG 2008-2018. All rights reserved. Confidential.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Windows.Forms;

namespace Fibonacci
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
            Application.Run(new FormMain());
        }
    }
}
