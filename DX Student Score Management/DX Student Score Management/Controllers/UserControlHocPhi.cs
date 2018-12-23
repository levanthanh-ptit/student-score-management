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
using DX_Student_Score_Management.Helper;

namespace DX_Student_Score_Management.Controllers
{
    public partial class UserControlHocPhi : DevExpress.XtraEditors.XtraUserControl
    {
        public UserControlHocPhi()
        {
            InitializeComponent();
            sINHVIENBindingSource.DataSource = Program._QLDSVHocPhiDataSet;
            InitializeExtendComponent();
            UserControlHocPhi_Load();
        }
        private void InitializeExtendComponent()
        {
            Program.HOCPHI_TableAdapterManager.Connection = Program._dataRepository.sqlConnection;
            Program.HOCPHI_SINHVIENTableAdapter.Connection = Program._dataRepository.sqlConnection;
            Program.HOCPHI_HOCPHITableAdapter.Connection = Program._dataRepository.sqlConnection;
        }
        public void UserControlHocPhi_Load()
        {
            Program.HOCPHI_HOCPHITableAdapter.Fill(Program._QLDSVHocPhiDataSet.HOCPHI);
            Program.HOCPHI_SINHVIENTableAdapter.Fill(Program._QLDSVHocPhiDataSet.SINHVIEN);
        }

       
        private void barBtnUpload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                using (System.Transactions.TransactionScope updateTransaction = new System.Transactions.TransactionScope())
                {
                    Program.HOCPHI_TableAdapterManager.UpdateAll(Program._QLDSVHocPhiDataSet);
                    updateTransaction.Complete();
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.Message);
            }
            MessageBox.Show("Upload thành công!");
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
            string valid = Validation.validateCommonText("Niên khóa",this.nIENKHOATextEdit.Text);
            if (valid != "")
            {
                MessageBox.Show(valid);
                return;
            }
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
            string valid = Validation.validateCode("Mã Sinh viên", this.textBoxMaSV.ToString());
            if (valid != "")
            {
                MessageBox.Show(valid);
                return;
            }
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
