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
        public static DataRepository _dataRepository;
        public static FormLogin _formLogin;
        public static DXFormMain _DXFormMain;

        private static void InitServices()
        {
            _dataRepository = new DataRepository();
            _formLogin = new FormLogin(_dataRepository);
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();

            InitServices();

            Application.Run(_formLogin);
            if (_dataRepository.Ready) Application.Run(_DXFormMain = new DXFormMain(_dataRepository));
            

        }
    }
}
