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

namespace DX_Student_Score_Management.Controllers
{
    public partial class UserControlTaiKhoan : DevExpress.XtraEditors.XtraUserControl
    {
        private QLDSVKhoaDataSet _QLDSVKhoaDataSet;
        public UserControlTaiKhoan(QLDSVKhoaDataSet _QLDSVKhoaDataSet)
        {
            this._QLDSVKhoaDataSet = _QLDSVKhoaDataSet;
            InitializeComponent();
            InitializeExtendComponent();
            KhoaBindingSource.DataSource = this._QLDSVKhoaDataSet;
            UserControlTaiKhoan_Load();
        }
        private void InitializeExtendComponent()
        {
            this.tableAdapterManager.Connection = Program._dataRepository.sqlConnection;
            this.kHOATableAdapter.Connection = Program._dataRepository.sqlConnection;
            this.gIANGVIENTableAdapter.Connection = Program._dataRepository.sqlConnection;
        }
        public void UserControlTaiKhoan_Load()
        {
            this.kHOATableAdapter.Fill(_QLDSVKhoaDataSet.KHOA);
            this.gIANGVIENTableAdapter.Fill(_QLDSVKhoaDataSet.GIANGVIEN);
        }
        private void gIANGVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fKGIANGVIENKHOABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._QLDSVKhoaDataSet);

        }

        
        private void barBtnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UserControlTaiKhoan_Load();
        }

        private void barBtnUpload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.tableAdapterManager.UpdateAll(this._QLDSVKhoaDataSet);
        }

        private void barBtnDeleteGiangVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.fKGIANGVIENKHOABindingSource.RemoveCurrent();
        }
    }
}
