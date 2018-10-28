using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;

namespace DX_Student_Score_Management
{
    static class Program
    {
        public static ConnectionData connectionData;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            connectionData = new ConnectionData();
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            Application.Run(new FormLogin(connectionData));
            Application.Run(new FormMain(connectionData));
        }
    }
}
