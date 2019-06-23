using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERPGenLicense
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool lOK = true;
            string usuario = "";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (usuario == "")
            {
                WinControl_ELR_NET.ELRFormLogin frmLogin = new WinControl_ELR_NET.ELRFormLogin();
                frmLogin.ShowDialog();
                lOK = frmLogin.loginOK;
                usuario = frmLogin.Nombre_Usuario;
            }

            if (lOK)
            {
                WinControl_ELR_NET.ELRFormPrincipal frmPrincipal = new WinControl_ELR_NET.ELRFormPrincipal();
                frmPrincipal.nombreUsuario = usuario.ToUpper();
                frmPrincipal.loginOK = true;
                frmPrincipal.EnEjecusion = true;

                Application.Run(frmPrincipal);
            }
            //else Application.Exit();
        }
    }
}
