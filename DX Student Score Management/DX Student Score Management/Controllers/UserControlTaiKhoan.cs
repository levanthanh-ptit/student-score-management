using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DX_Student_Score_Management.Controllers.TaiKhoanForms;

namespace DX_Student_Score_Management.Controllers
{
    public partial class UserControlTaiKhoan : DevExpress.XtraEditors.XtraUserControl
    {
        public UserControlTaiKhoan()
        {
            InitializeComponent();
            InitializeExtendComponent();
            UserControlTaiKhoan_Load();
        }
        private void InitializeExtendComponent()
        {
            sP_List_LOGINBindingSource.DataSource = Program._QLDSVKhoaDataSet;
            sP_List_LOGINTableAdapter.Connection = Program._dataRepository.sqlConnection;
        }
        public void UserControlTaiKhoan_Load()
        {
            sP_List_LOGINTableAdapter.Fill(Program._QLDSVKhoaDataSet.SP_List_LOGIN);
        }

        private void barBtnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UserControlTaiKhoan_Load();
        }

        private void barBtnDeleteGiangVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new FormXOALOGIN(
                ((DataRowView)sP_List_LOGINBindingSource.Current)["LOGINNAME"].ToString(),
                ((DataRowView)sP_List_LOGINBindingSource.Current)["MAGV"].ToString(),
                ((DataRowView)sP_List_LOGINBindingSource.Current)["HO"].ToString() + " " + ((DataRowView)sP_List_LOGINBindingSource.Current)["TEN"].ToString()
                ).Show();
            UserControlTaiKhoan_Load();
        }

        private void barBtnNewLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new FormTAOLOGIN().Show();
            UserControlTaiKhoan_Load();
        }
    }
}
