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
    public partial class UserControlHocPhi : DevExpress.XtraEditors.XtraUserControl
    {
        public UserControlHocPhi()
        {
            InitializeComponent();
        }

        private void sINHVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sINHVIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLDSVKhoaDataSet);

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
    }
}
