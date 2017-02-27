using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appProyectoLaura
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
            frmSplashScreen sp = new frmSplashScreen();
            frmLogin p = new frmLogin();
            
            if (sp.ShowDialog() == DialogResult.OK)
            {
                if (p.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new frmPrincipal());
                }
            }
        }
    }
}
