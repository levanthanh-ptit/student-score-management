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
using System.Data.SqlClient;

namespace DX_Student_Score_Management.Controllers
{
    public partial class UserControlHocPhi : DevExpress.XtraEditors.XtraUserControl
    {
        private QLDSVHocPhiDataSet _QLDSVHocPhiDataSet;
        public UserControlHocPhi(QLDSVHocPhiDataSet _QLDSVHocPhiDataSet)
        {
            this._QLDSVHocPhiDataSet = _QLDSVHocPhiDataSet;
            InitializeComponent();
            sINHVIENBindingSource.DataSource = _QLDSVHocPhiDataSet;
            InitializeExtendComponent();
            UserControlHocPhi_Load();
        }
        private void InitializeExtendComponent()
        {
            this.tableAdapterManager.Connection = Program._dataRepository.sqlConnection;
            this.sINHVIENTableAdapter.Connection = Program._dataRepository.sqlConnection;
            this.hOCPHITableAdapter.Connection = Program._dataRepository.sqlConnection;
        }
        public void UserControlHocPhi_Load()
        {
            this.hOCPHITableAdapter.Fill(this._QLDSVHocPhiDataSet.HOCPHI);
            this.sINHVIENTableAdapter.Fill(this._QLDSVHocPhiDataSet.SINHVIEN);
        }

        private void sINHVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sINHVIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._QLDSVHocPhiDataSet);
        }

        private void barBtnAddHocPhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.fKHOCPHISINHVIENBindingSource.AddNew();
            this.btnEditHocPhiOK.Visible = false;
            this.btnAddHocPhi.Visible = true;
            this.btnCancelAddHocPhi.Visible = true;
        }

        private void btnAddHocPhi_Click(object sender, EventArgs e)
        {
            this.fKHOCPHISINHVIENBindingSource.EndEdit();
            this.btnEditHocPhiOK.Visible = true;
            this.btnAddHocPhi.Visible = false;
            this.btnCancelAddHocPhi.Visible = false;
        }

        private void btnCancelAddHocPhi_Click(object sender, EventArgs e)
        {
            this.fKHOCPHISINHVIENBindingSource.CancelEdit();
            this.fKHOCPHISINHVIENBindingSource.RemoveCurrent();
            this.btnEditHocPhiOK.Visible = true;
            this.btnAddHocPhi.Visible = false;
            this.btnCancelAddHocPhi.Visible = false;

        }
        private void btnEditHocPhiOK_Click(object sender, EventArgs e)
        {
            this.fKHOCPHISINHVIENBindingSource.EndEdit();
        }

        private void barBtnUpload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.tableAdapterManager.UpdateAll(this._QLDSVHocPhiDataSet);
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.Message);
            }
            
        }

        private void barBtnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UserControlHocPhi_Load();
        }

        private void barBtnDeleteHocPhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.fKHOCPHISINHVIENBindingSource.RemoveCurrent();
        }

        private void btnMaSVSearch_Click(object sender, EventArgs e)
        {
            this.sINHVIENBindingSource.Filter = $"MASV = '{this.textBoxMaSV.Text}'";
            if (this.sINHVIENBindingSource.Count == 0)
            {
                MessageBox.Show("Không tìm thấy sinh viên. Xin thử lại.");
            }
            else
            {
                this.labelMaSV.Text = ((DataRowView)sINHVIENBindingSource.Current)["MASV"].ToString();
                this.labelHoTen.Text = ((DataRowView)sINHVIENBindingSource.Current)["HO"].ToString()
                                        + " " + ((DataRowView)sINHVIENBindingSource.Current)["TEN"].ToString();
                this.labelMaLop.Text = ((DataRowView)sINHVIENBindingSource.Current)["MALOP"].ToString();
                this.panelHocPhi.Visible = true;
            }

        }


    }
}
