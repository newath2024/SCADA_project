using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picturebox
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
            FrmLogin frm = new FrmLogin();
            if (frm.ShowDialog() == DialogResult.OK) {
                if (check.is_admin == true)
                {
                    Application.Run(new FrmMenu());

                }
                if(check.is_admin == false)
                {
                    Application.Run(new FrmNormal());
                }
            }
        }
    }
}
