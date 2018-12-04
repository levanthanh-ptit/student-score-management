using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using DevExpress.XtraEditors;

namespace DX_Student_Score_Management.Controllers

{
    public partial class UserControlLopSinhVien : DevExpress.XtraEditors.XtraUserControl
    {
        public UserControlLopSinhVien()
        {
            InitializeComponent();
            InitializeExtendComponent();
            UserControlLopSinhVien_Load();
        }
        private void InitializeExtendComponent()
        {
            this.tableAdapterManager.Connection = Program._dataRepository.sqlConnection;
            this.kHOATableAdapter.Connection = Program._dataRepository.sqlConnection;
            this.lOPTableAdapter.Connection = Program._dataRepository.sqlConnection;
            this.sINHVIENTableAdapter.Connection = Program._dataRepository.sqlConnection;
        }
        
        private void UserControlLopSinhVien_Load()
        {
            kHOATableAdapter.Fill(qLDSVKhoaDataSet.KHOA);
            lOPTableAdapter.Fill(qLDSVKhoaDataSet.LOP);
            sINHVIENTableAdapter.Fill(qLDSVKhoaDataSet.SINHVIEN);
        }

        private void barBtnAddLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fKLOPKHOABindingSource.AddNew();
            btnEditLopOK.Visible = false;
            btnAddLop.Visible = true;
            btnCancelAddLop.Visible = true;
        }

        private void barBtnDeleteLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fKLOPKHOABindingSource.RemoveCurrent();
        }

        private void btnAddLop_Click(object sender, EventArgs e)
        {
            fKLOPKHOABindingSource.EndEdit();
            btnAddLop.Visible = false;
            btnCancelAddLop.Visible = false;
            btnEditLopOK.Visible = true;
        }

        private void btnCancelAddLop_Click(object sender, EventArgs e)
        {
            fKLOPKHOABindingSource.CancelEdit();
            fKLOPKHOABindingSource.RemoveCurrent();
            btnAddLop.Visible = false;
            btnCancelAddLop.Visible = false;
            btnEditLopOK.Visible = true;
        }

        private void btnAddSinhVien_Click(object sender, EventArgs e)
        {
            fKSINHVIENLOPBindingSource.EndEdit();
            btnAddSinhVien.Visible = false;
            btnCancelAddSinhVien.Visible = false;
            btnEditSinhVienOK.Visible = true;
        }

        private void btnCancelAddSinhVien_Click(object sender, EventArgs e)
        {
            fKSINHVIENLOPBindingSource.CancelEdit();
            fKSINHVIENLOPBindingSource.RemoveCurrent();
            btnAddSinhVien.Visible = false;
            btnCancelAddSinhVien.Visible = false;
            btnEditSinhVienOK.Visible = true;
        }

        private void barBtnAddSinhVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fKSINHVIENLOPBindingSource.AddNew();
            btnEditSinhVienOK.Visible = false;
            btnAddSinhVien.Visible = true;
            btnCancelAddSinhVien.Visible = true;

        }

        private void barBtnDeleteSinhVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fKSINHVIENLOPBindingSource.RemoveCurrent();
        }

        private void barBtnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.UserControlLopSinhVien_Load();
        }

        private void barBtnUpload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tableAdapterManager.UpdateAll(qLDSVKhoaDataSet);
        }
    }
}
