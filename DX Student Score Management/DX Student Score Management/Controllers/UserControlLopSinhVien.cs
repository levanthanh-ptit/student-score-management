using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using DX_Student_Score_Management.Helper;

namespace DX_Student_Score_Management.Controllers

{
    public partial class UserControlLopSinhVien : DevExpress.XtraEditors.XtraUserControl
    {
        public UserControlLopSinhVien()
        {
            InitializeComponent();
            InitializeExtendComponent();
            kHOABindingSource.DataSource = Program._QLDSVKhoaDataSet;
            UserControlLopSinhVien_Load();
        }
        private void InitializeExtendComponent()
        {

        }

        private void UserControlLopSinhVien_Load()
        {
            Program.KHOA_KHOATableAdapter.Fill(Program._QLDSVKhoaDataSet.KHOA);
            Program.KHOA_LOPTableAdapter.Fill(Program._QLDSVKhoaDataSet.LOP);
            Program.KHOA_SINHVIENTableAdapter.Fill(Program._QLDSVKhoaDataSet.SINHVIEN);
            fKLOPKHOABindingSource.MoveFirst();
            fKSINHVIENLOPBindingSource.MoveFirst();
        }
        private void DeleteCurrentLop()
        {
            DialogResult dr = MessageBox.Show($"Bạn có chắc muốn xóa lớp: {((DataRowView)fKLOPKHOABindingSource.Current)["MALOP"]} ?", "XÓA", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                fKLOPKHOABindingSource.RemoveCurrent();
            }
        }
        private void DeleteCurrentSinhVien()
        {
            DialogResult dr = MessageBox.Show($"Bạn có chắc muốn xóa lớp: {((DataRowView)fKLOPKHOABindingSource.Current)["MALOP"]} ?", "XÓA", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                fKSINHVIENLOPBindingSource.RemoveCurrent();
            }
        }
        private void barBtnUpload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (System.Transactions.TransactionScope updateTransaction = new System.Transactions.TransactionScope())
            {
                Program.KHOA_TableAdapterManager.UpdateAll(Program._QLDSVKhoaDataSet);
                updateTransaction.Complete();
            }
            MessageBox.Show("Upload thành công!");
            Program.KHOA_LOP_Change = false;
            Program.KHOA_SINHVIEN_Change = false;
        }

        private void barBtnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.KHOA_LOP_Change || Program.KHOA_LOP_Change)
            {
                DialogResult dr = MessageBox.Show("Phát hiện thay đổi chưa cập nhật!\nBạn có muốn load lại bảng?", "Phát hiện thay đổi", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    UserControlLopSinhVien_Load();
                }
            }

        }
        // ----- LOP menu ------------------
        private void barBtnAddLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fKLOPKHOABindingSource.AddNew();
            barBtnUpload.Enabled = false;
            barBtnRefresh.Enabled = false;
            barMenuLop.Enabled = false;
            barMenuSinhVien.Enabled = false;
            lOPGridControl.Enabled = false;
            sINHVIENGridControl.Enabled = false;
            groupBoxLOP.Enabled = true;
            btnAddLop.Visible = true;
            btnCancelAddLop.Visible = true;
        }

        private void btnAddLop_Click(object sender, EventArgs e)
        {
            string valid = Validation.validateCode("Mã lớp", mALOPTextEdit.Text);
            if (valid != "")
            {
                MessageBox.Show(valid);
                return;
            }
            valid = Validation.validateCommonText("Tên lớp", tENLOPTextEdit.Text);
            if (valid != "")
            {
                MessageBox.Show(valid);
                return;
            }
            
            fKLOPKHOABindingSource.EndEdit();
            barBtnUpload.Enabled = true;
            barBtnRefresh.Enabled = true;
            barMenuLop.Enabled = true;
            barMenuSinhVien.Enabled = true;
            lOPGridControl.Enabled = true;
            sINHVIENGridControl.Enabled = true;
            groupBoxLOP.Enabled = false;
            btnAddLop.Visible = false;
            btnCancelAddLop.Visible = false;
        }

        private void btnCancelAddLop_Click(object sender, EventArgs e)
        {
            fKLOPKHOABindingSource.CancelEdit();
            //fKLOPKHOABindingSource.RemoveCurrent();
            barBtnUpload.Enabled = true;
            barBtnRefresh.Enabled = true;
            barMenuLop.Enabled = true;
            barMenuSinhVien.Enabled = true;
            lOPGridControl.Enabled = true;
            sINHVIENGridControl.Enabled = true;
            groupBoxLOP.Enabled = false;
            btnAddLop.Visible = false;
            btnCancelAddLop.Visible = false;
        }

        private void barBtnDeleteLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeleteCurrentLop();
        }

        private void barBtnEditLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            barBtnUpload.Enabled = false;
            barBtnRefresh.Enabled = false;
            barMenuLop.Enabled = false;
            barMenuSinhVien.Enabled = false;
            lOPGridControl.Enabled = false;
            sINHVIENGridControl.Enabled = false;
            groupBoxLOP.Enabled = true;
            btnEditLopOK.Visible = true;
        }

        private void btnEditLopOK_Click(object sender, EventArgs e)
        {
            fKLOPKHOABindingSource.EndEdit();
            barBtnUpload.Enabled = true;
            barBtnRefresh.Enabled = true;
            barMenuLop.Enabled = true;
            barMenuSinhVien.Enabled = true;
            lOPGridControl.Enabled = true;
            sINHVIENGridControl.Enabled = true;
            groupBoxLOP.Enabled = false;
            btnEditLopOK.Visible = false;

        }
        private void toolStripMenuAddLop_Click(object sender, EventArgs e)
        {
            fKLOPKHOABindingSource.AddNew();
            barBtnUpload.Enabled = false;
            barBtnRefresh.Enabled = false;
            barMenuLop.Enabled = false;
            barMenuSinhVien.Enabled = false;
            lOPGridControl.Enabled = false;
            sINHVIENGridControl.Enabled = false;
            groupBoxLOP.Enabled = true;
            btnAddLop.Visible = true;
            btnCancelAddLop.Visible = true;
        }
        private void toolStripMenuDeleteLop_Click(object sender, EventArgs e)
        {
            DeleteCurrentLop();
        }
        private void toolStripMenuEditLop_Click(object sender, EventArgs e)
        {
            barBtnUpload.Enabled = false;
            barBtnRefresh.Enabled = false;
            barMenuLop.Enabled = false;
            barMenuSinhVien.Enabled = false;
            lOPGridControl.Enabled = false;
            sINHVIENGridControl.Enabled = false;
            groupBoxLOP.Enabled = true;
            btnEditLopOK.Visible = true;
        }
        // ----- SINHVIEN menu ------------------

        private void barBtnAddSinhVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            fKSINHVIENLOPBindingSource.AddNew();
            barBtnUpload.Enabled = false;
            barBtnRefresh.Enabled = false;
            barMenuLop.Enabled = false;
            barMenuSinhVien.Enabled = false;
            sINHVIENGridControl.Enabled = false;
            lOPGridControl.Enabled = false;
            groupBoxSinhVien.Enabled = true;
            btnAddSinhVien.Visible = true;
            btnCancelAddSinhVien.Visible = true;

        }

        private void btnAddSinhVien_Click(object sender, EventArgs e)
        {
            string valid = Validation.validateCode("Mã lớp", mASVTextEdit.Text);
            if (valid != "")
            {
                MessageBox.Show(valid);
                return;
            }
            valid = Validation.validateCommonText("Tên lớp", tENLOPTextEdit.Text);
            if (valid != "")
            {
                MessageBox.Show(valid);
                return;
            }
            fKSINHVIENLOPBindingSource.EndEdit();
            barBtnUpload.Enabled = true;
            barBtnRefresh.Enabled = true;
            barMenuLop.Enabled = true;
            barMenuSinhVien.Enabled = true;
            sINHVIENGridControl.Enabled = true;
            lOPGridControl.Enabled = true;
            groupBoxSinhVien.Enabled = false;
            btnAddSinhVien.Visible = false;
            btnCancelAddSinhVien.Visible = false;
        }

        private void btnCancelAddSinhVien_Click(object sender, EventArgs e)
        {
            fKSINHVIENLOPBindingSource.CancelEdit();
            barBtnUpload.Enabled = true;
            barBtnRefresh.Enabled = true;
            barMenuLop.Enabled = true;
            barMenuSinhVien.Enabled = true;
            sINHVIENGridControl.Enabled = true;
            lOPGridControl.Enabled = true;
            groupBoxSinhVien.Enabled = false;
            btnAddSinhVien.Visible = false;
            btnCancelAddSinhVien.Visible = false;
        }

        private void barBtnDeleteSinhVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeleteCurrentSinhVien();
        }

        private void barBtnEditSinhVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            barBtnUpload.Enabled = false;
            barBtnRefresh.Enabled = false;
            barMenuLop.Enabled = false;
            barMenuSinhVien.Enabled = false;
            sINHVIENGridControl.Enabled = false;
            lOPGridControl.Enabled = false;
            groupBoxSinhVien.Enabled = true;
            btnEditSinhVienOK.Visible = true;
        }

        private void btnEditSinhVienOK_Click(object sender, EventArgs e)
        {
            fKSINHVIENLOPBindingSource.EndEdit();
            barBtnUpload.Enabled = true;
            barBtnRefresh.Enabled = true;
            barMenuLop.Enabled = true;
            barMenuSinhVien.Enabled = true;
            sINHVIENGridControl.Enabled = true;
            lOPGridControl.Enabled = true;
            groupBoxSinhVien.Enabled = false;
            btnEditSinhVienOK.Visible = false;
        }

        private void toolStripMenuAddSinhVien_Click(object sender, EventArgs e)
        {
            fKSINHVIENLOPBindingSource.AddNew();
            barBtnUpload.Enabled = false;
            barBtnRefresh.Enabled = false;
            barMenuLop.Enabled = false;
            barMenuSinhVien.Enabled = false;
            sINHVIENGridControl.Enabled = false;
            lOPGridControl.Enabled = false;
            groupBoxSinhVien.Enabled = true;
            btnAddSinhVien.Visible = true;
            btnCancelAddSinhVien.Visible = true;
        }

        private void toolStripMenuDeleteSinhVien_Click(object sender, EventArgs e)
        {
            DeleteCurrentSinhVien();
        }

        private void toolStripMenuEditSinhVien_Click(object sender, EventArgs e)
        {
            barBtnUpload.Enabled = false;
            barBtnRefresh.Enabled = false;
            barMenuLop.Enabled = false;
            barMenuSinhVien.Enabled = false;
            sINHVIENGridControl.Enabled = false;
            lOPGridControl.Enabled = false;
            groupBoxSinhVien.Enabled = true;
            btnEditSinhVienOK.Visible = true;
        }

    }
}
