using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DX_Student_Score_Management.Repositories;
using DX_Student_Score_Management.Components;
using System.Data.SqlClient;
using System.Data;

namespace DX_Student_Score_Management
{
    static class Program
    {
        public static QLDSVKhoaDataSet _QLDSVKhoaDataSet = new QLDSVKhoaDataSet();
        public static QLDSVHocPhiDataSet _QLDSVHocPhiDataSet = new QLDSVHocPhiDataSet();
        public static DataRepository _dataRepository;
        public static FormLogin _formLogin;
        public static DXFormMain _DXFormMain;
        public static LoadingForm _LoadingForm = new LoadingForm();
        public static QLDSVKhoaDataSetTableAdapters.TableAdapterManager KHOA_TableAdapterManager = new QLDSVKhoaDataSetTableAdapters.TableAdapterManager();
        public static QLDSVKhoaDataSetTableAdapters.KHOATableAdapter KHOA_KHOATableAdapter = new QLDSVKhoaDataSetTableAdapters.KHOATableAdapter();
        public static QLDSVKhoaDataSetTableAdapters.GIANGVIENTableAdapter KHOA_GIANGVIENTableAdapter = new QLDSVKhoaDataSetTableAdapters.GIANGVIENTableAdapter();
        public static QLDSVKhoaDataSetTableAdapters.LOPTableAdapter KHOA_LOPTableAdapter = new QLDSVKhoaDataSetTableAdapters.LOPTableAdapter();
        public static QLDSVKhoaDataSetTableAdapters.SINHVIENTableAdapter KHOA_SINHVIENTableAdapter = new QLDSVKhoaDataSetTableAdapters.SINHVIENTableAdapter();
        public static QLDSVKhoaDataSetTableAdapters.DIEMTableAdapter KHOA_DIEMTableAdapter = new QLDSVKhoaDataSetTableAdapters.DIEMTableAdapter();
        public static QLDSVKhoaDataSetTableAdapters.HOCPHITableAdapter KHOA_HOCPHITableAdapter = new QLDSVKhoaDataSetTableAdapters.HOCPHITableAdapter();
        public static QLDSVKhoaDataSetTableAdapters.MONHOCTableAdapter KHOA_MONHOCTableAdapter = new QLDSVKhoaDataSetTableAdapters.MONHOCTableAdapter();
        public static QLDSVKhoaDataSetTableAdapters.SP_List_LOGINTableAdapter KHOA_SP_List_LOGINTableAdapter = new QLDSVKhoaDataSetTableAdapters.SP_List_LOGINTableAdapter();
        public static QLDSVKhoaDataSetTableAdapters.SP_List_NHOMTableAdapter KHOA_SP_List_NHOMTableAdapter = new QLDSVKhoaDataSetTableAdapters.SP_List_NHOMTableAdapter();
        //---Site Hoc Phi-------------------
        public static QLDSVHocPhiDataSetTableAdapters.TableAdapterManager HOCPHI_TableAdapterManager = new QLDSVHocPhiDataSetTableAdapters.TableAdapterManager();
        public static QLDSVHocPhiDataSetTableAdapters.KHOATableAdapter HOCPHI_KHOATableAdapter = new QLDSVHocPhiDataSetTableAdapters.KHOATableAdapter();
        public static QLDSVHocPhiDataSetTableAdapters.GIANGVIENTableAdapter HOCPHI_GIANGVIENTableAdapter = new QLDSVHocPhiDataSetTableAdapters.GIANGVIENTableAdapter();
        public static QLDSVHocPhiDataSetTableAdapters.LOPTableAdapter HOCPHI_LOPTableAdapter = new QLDSVHocPhiDataSetTableAdapters.LOPTableAdapter();
        public static QLDSVHocPhiDataSetTableAdapters.SINHVIENTableAdapter HOCPHI_SINHVIENTableAdapter = new QLDSVHocPhiDataSetTableAdapters.SINHVIENTableAdapter();
        public static QLDSVHocPhiDataSetTableAdapters.HOCPHITableAdapter HOCPHI_HOCPHITableAdapter = new QLDSVHocPhiDataSetTableAdapters.HOCPHITableAdapter();

        public static bool KHOA_LOP_Change = true;
        public static bool KHOA_MONHOC_Change = true;
        public static bool KHOA_SINHVIEN_Change = true;

        private static void ChangeConnection(SqlConnection sqlConnection)
        {
            KHOA_KHOATableAdapter.Connection = sqlConnection;
            KHOA_GIANGVIENTableAdapter.Connection = sqlConnection;
            KHOA_LOPTableAdapter.Connection = sqlConnection;
            KHOA_SINHVIENTableAdapter.Connection = sqlConnection;
            KHOA_DIEMTableAdapter.Connection = sqlConnection;
            KHOA_HOCPHITableAdapter.Connection = sqlConnection;
            KHOA_MONHOCTableAdapter.Connection = sqlConnection;
            KHOA_TableAdapterManager.Connection = sqlConnection;
            KHOA_SP_List_LOGINTableAdapter.Connection = sqlConnection;
            KHOA_SP_List_NHOMTableAdapter.Connection = sqlConnection;
            //---------------------------------------------------
            HOCPHI_KHOATableAdapter.Connection = sqlConnection;
            HOCPHI_GIANGVIENTableAdapter.Connection = sqlConnection;
            HOCPHI_LOPTableAdapter.Connection = sqlConnection;
            HOCPHI_SINHVIENTableAdapter.Connection = sqlConnection;
            HOCPHI_HOCPHITableAdapter.Connection = sqlConnection;
            HOCPHI_TableAdapterManager.Connection = sqlConnection;
        }
        //--Handler rows change---
        private static void KHOA_LOP_Row_Changed(object sender, DataRowChangeEventArgs e)
        {
            Program.KHOA_LOP_Change = true;
        }
        private static void KHOA_SINHVIEN_Row_Changed(object sender, DataRowChangeEventArgs e)
        {
            Program.KHOA_SINHVIEN_Change = true;
        }
        private static void KHOA_MONHOC_Row_Changed(object sender, DataRowChangeEventArgs e)
        {
            Program.KHOA_MONHOC_Change = true;
        }
        //--Handler tables cleared---
        private static void KHOA_LOP_Table_Cleared(object sender, DataTableClearEventArgs e)
        {
            Program.KHOA_LOP_Change = false;
        }
        private static void KHOA_SINHVIEN_Table_Cleared(object sender, DataTableClearEventArgs e)
        {
            Program.KHOA_SINHVIEN_Change = false;
        }
        private static void KHOA_MONHOC_Table_Cleared(object sender, DataTableClearEventArgs e)
        {
            Program.KHOA_MONHOC_Change = false;
        }

        private static void InitServices()
        {
            //--QLDSVKhoaDataSet--
            _QLDSVKhoaDataSet.MONHOC.RowChanged += new DataRowChangeEventHandler(KHOA_MONHOC_Row_Changed);
            _QLDSVKhoaDataSet.LOP.RowChanged += new DataRowChangeEventHandler(KHOA_LOP_Row_Changed);
            _QLDSVKhoaDataSet.SINHVIEN.RowChanged += new DataRowChangeEventHandler(KHOA_SINHVIEN_Row_Changed);
           //--TableAdapters config--
           KHOA_KHOATableAdapter.ClearBeforeFill = true;
            KHOA_GIANGVIENTableAdapter.ClearBeforeFill = true;
            KHOA_LOPTableAdapter.ClearBeforeFill = true;
            KHOA_SINHVIENTableAdapter.ClearBeforeFill = true;
            KHOA_DIEMTableAdapter.ClearBeforeFill = true;
            KHOA_HOCPHITableAdapter.ClearBeforeFill = true;
            KHOA_MONHOCTableAdapter.ClearBeforeFill = true;
            KHOA_SP_List_LOGINTableAdapter.ClearBeforeFill = true;
            //--TableAdapterManager config--
            KHOA_TableAdapterManager.KHOATableAdapter = KHOA_KHOATableAdapter;
            KHOA_TableAdapterManager.GIANGVIENTableAdapter = KHOA_GIANGVIENTableAdapter;
            KHOA_TableAdapterManager.LOPTableAdapter = KHOA_LOPTableAdapter;
            KHOA_TableAdapterManager.SINHVIENTableAdapter = KHOA_SINHVIENTableAdapter;
            KHOA_TableAdapterManager.DIEMTableAdapter = KHOA_DIEMTableAdapter;
            KHOA_TableAdapterManager.HOCPHITableAdapter = KHOA_HOCPHITableAdapter;
            KHOA_TableAdapterManager.MONHOCTableAdapter = KHOA_MONHOCTableAdapter;
            //--QLDSVHocPhiDataSet TableAdapters config--
            HOCPHI_KHOATableAdapter.ClearBeforeFill = true;
            HOCPHI_GIANGVIENTableAdapter.ClearBeforeFill = true;
            HOCPHI_LOPTableAdapter.ClearBeforeFill = true;
            HOCPHI_SINHVIENTableAdapter.ClearBeforeFill = true;
            HOCPHI_HOCPHITableAdapter.ClearBeforeFill = true;
            //--TableAdapterManager config--
            HOCPHI_TableAdapterManager.KHOATableAdapter = HOCPHI_KHOATableAdapter;
            HOCPHI_TableAdapterManager.GIANGVIENTableAdapter = HOCPHI_GIANGVIENTableAdapter;
            HOCPHI_TableAdapterManager.LOPTableAdapter = HOCPHI_LOPTableAdapter;
            HOCPHI_TableAdapterManager.SINHVIENTableAdapter = HOCPHI_SINHVIENTableAdapter;
            HOCPHI_TableAdapterManager.HOCPHITableAdapter = HOCPHI_HOCPHITableAdapter;
            //--Asignment Form--
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
            //  Application.SetCompatibleTextRenderingDefault(false);
            BonusSkins.Register();
            SkinManager.EnableFormSkins();

            InitServices();

            Application.Run(_formLogin);
            if (_dataRepository.Ready)
            {
                ChangeConnection(_dataRepository.sqlConnection);
                _LoadingForm.Show();
                InitForm();
                _LoadingForm.Hide();
                Application.Run(_DXFormMain);
            }

        }
    }
}
