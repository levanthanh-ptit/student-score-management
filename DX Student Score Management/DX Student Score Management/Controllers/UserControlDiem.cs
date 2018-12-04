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
    public partial class UserControlDiem : DevExpress.XtraEditors.XtraUserControl
    {
        public UserControlDiem()
        {
            InitializeComponent();
            UserControlDiem_Load();
        }
        private void InitializeExtendComponent()
        {
            this.tableAdapterManager.Connection = Program._dataRepository.sqlConnection;
            this.lOPTableAdapter.Connection = Program._dataRepository.sqlConnection;
            this.sINHVIENTableAdapter.Connection = Program._dataRepository.sqlConnection;
            this.dIEMTableAdapter.Connection = Program._dataRepository.sqlConnection;
            this.mONHOCTableAdapter.Connection = Program._dataRepository.sqlConnection;
        }
        public void UserControlDiem_Load()
        {
            this.lOPTableAdapter.Fill(qLDSVKhoaDataSet.LOP);
            this.sINHVIENTableAdapter.Fill(qLDSVKhoaDataSet.SINHVIEN);
            this.dIEMTableAdapter.Fill(qLDSVKhoaDataSet.DIEM);
            this.mONHOCTableAdapter.Fill(qLDSVKhoaDataSet.MONHOC);
        }

        private void barBtnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.UserControlDiem_Load();
        }

        private void barBtnAddDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.fKDIEMSINHVIENBindingSource.AddNew();
            this.btnEditDiemOK.Visible = false;
            this.btnAddDien.Visible = true;
            this.btnCancelAddDiem.Visible = true;
            
        }

        private void barBtnDeleteDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.fKDIEMSINHVIENBindingSource.RemoveCurrent();
        }

        private void barBtnUpload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.tableAdapterManager.UpdateAll(qLDSVKhoaDataSet);
        }

        private void btnAddDien_Click(object sender, EventArgs e)
        {
            ((DataRowView)this.fKDIEMSINHVIENBindingSource.Current)["MAMH"] = this.mONHOCComboBox.SelectedValue;
            this.fKDIEMSINHVIENBindingSource.EndEdit();
            this.btnAddDien.Visible = false;
            this.btnCancelAddDiem.Visible = false;
            this.btnEditDiemOK.Visible = true;

        }

        private void btnCancelAddDiem_Click(object sender, EventArgs e)
        {
            this.fKDIEMSINHVIENBindingSource.CancelEdit();
            this.fKDIEMSINHVIENBindingSource.RemoveCurrent();
            this.btnAddDien.Visible = false;
            this.btnCancelAddDiem.Visible = false;
            this.btnEditDiemOK.Visible = true;
        }

        private void gridViewDiem_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            this.barBtnDeleteDiem.Enabled = true;
            this.mONHOCBindingSource.MoveFirst();
            for (int i = 0; i < this.mONHOCBindingSource.Count; i++)
            {
                if (((DataRowView)this.fKDIEMSINHVIENBindingSource.Current)["MAMH"].ToString() == ((DataRowView)this.mONHOCBindingSource.Current)["MAMH"].ToString())
                {
                    break;
                }
                this.mONHOCBindingSource.MoveNext();
            }
        }

        private void btnEditDiemOK_Click(object sender, EventArgs e)
        {
            this.fKDIEMSINHVIENBindingSource.EndEdit();
        }
    }
}
