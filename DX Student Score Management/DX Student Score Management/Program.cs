using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DX_Student_Score_Management.Repositories;
using DX_Student_Score_Management.Components;

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
        private static void InitForm()
        {
            _DXFormMain = new DXFormMain(_dataRepository,
                                         new LayoutTabPage(_dataRepository.GroupId));
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
            if (_dataRepository.Ready)
                InitForm();
            Application.Run(_DXFormMain);
        }
    }
}
