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
    public partial class UserControlMon : DevExpress.XtraEditors.XtraUserControl
    {
        private QLDSVKhoaDataSet _QLDSVKhoaDataSet;
        public UserControlMon(QLDSVKhoaDataSet _QLDSVKhoaDataSet)
        {
            this._QLDSVKhoaDataSet = _QLDSVKhoaDataSet;
            InitializeComponent();
            this.mONHOCBindingSource.DataSource = _QLDSVKhoaDataSet;
            UserControlMon_Load();
        }
        private void UserControlMon_Load()
        {
            this.mONHOCTableAdapter.Fill(this._QLDSVKhoaDataSet.MONHOC);
        }
        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mONHOCBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._QLDSVKhoaDataSet);

        }

        private void barBtnUpload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.tableAdapterManager.UpdateAll(this._QLDSVKhoaDataSet);
        }

        private void barBtnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.UserControlMon_Load();
        }

        private void barBtnAddMonHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.mONHOCBindingSource.AddNew();
            this.btnEditMonHocOK.Visible = false;
            this.btnAddMonHoc.Visible = true;
            this.btnCancelAddMonHoc.Visible = true;
        }

        private void barBtnDeleteMonHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.mONHOCBindingSource.RemoveCurrent();
        }

        private void btnAddMonHoc_Click(object sender, EventArgs e)
        {
            this.mONHOCBindingSource.EndEdit();
            this.btnAddMonHoc.Visible = false;
            this.btnCancelAddMonHoc.Visible = false;
            this.btnEditMonHocOK.Visible = true;
        }

        private void btnCancelAddMonHoc_Click(object sender, EventArgs e)
        {
            this.mONHOCBindingSource.CancelEdit();
            this.btnAddMonHoc.Visible = false;
            this.btnCancelAddMonHoc.Visible = false;
            this.btnEditMonHocOK.Visible = true;
        }

        private void btnEditMonHocOK_Click(object sender, EventArgs e)
        {
            this.mONHOCBindingSource.EndEdit();
        }
    }
}
