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
        public UserControlMon()
        {
            InitializeComponent();
            this.mONHOCBindingSource.DataSource = Program._QLDSVKhoaDataSet;
            UserControlMon_Load();
        }
        private void UserControlMon_Load()
        {
            Program.KHOA_MONHOCTableAdapter.Fill(Program._QLDSVKhoaDataSet.MONHOC);
            Program.KHOA_MONHOC_Change = false;
        }


        private void barBtnUpload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (System.Transactions.TransactionScope updateTransaction = new System.Transactions.TransactionScope())
            {
                Program.KHOA_TableAdapterManager.UpdateAll(Program._QLDSVKhoaDataSet);
                updateTransaction.Complete();
            }
            MessageBox.Show("Upload thành công!");
            Program.KHOA_MONHOC_Change = false;
            UserControlMon_Load();
        }

        private void barBtnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.KHOA_MONHOC_Change)
            {
                DialogResult dr = MessageBox.Show("Phát hiện thay đổi chưa cập nhật!\nBạn có muốn load lại bảng?", "Phát hiện thay đổi", MessageBoxButtons.YesNo);
                if(dr == DialogResult.Yes)
                {
                    this.UserControlMon_Load();
                }
            }           
        }

        private void barBtnAddMonHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.mONHOCBindingSource.AddNew();
            this.MONHOCGridControl.Enabled = false;
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
            this.MONHOCGridControl.Enabled = true;
            this.btnAddMonHoc.Visible = false;
            this.btnCancelAddMonHoc.Visible = false;
            this.btnEditMonHocOK.Visible = true;
        }

        private void btnCancelAddMonHoc_Click(object sender, EventArgs e)
        {
            this.mONHOCBindingSource.CancelEdit();
            this.MONHOCGridControl.Enabled = true;
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
