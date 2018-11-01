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
        public static DataRepository dataRepository;

        [STAThread]
        static void Main()
        {
            dataRepository = new DataRepository();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            //Application.Run(new FormLogin(dataRepository));
            //if (dataRepository.Ready)
            //{
                Application.Run(new FormMain());
            //}

        }
    }
}
