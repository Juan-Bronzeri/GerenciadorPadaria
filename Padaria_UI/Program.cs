using System;
using System.Windows.Forms;

namespace Padaria_UI
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
            Application.Run(new Login());
            if (Altenticar.EstaAutenticado())
            {
                Altenticar.Desautenticar();
                Application.Run(new MDIParent());
            }
        }
    }
}
