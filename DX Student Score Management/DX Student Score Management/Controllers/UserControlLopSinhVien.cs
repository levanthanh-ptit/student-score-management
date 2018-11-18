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

        }
        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLDSVKhoaDataSet);

        }
        private void UserControlLopSinhVien_Load()
        {
            this.lOPTableAdapter.Fill(this.qLDSVKhoaDataSet.LOP);
        }

        private void lOPGridControl_Click(object sender, EventArgs e)
        {

        }
    }
}
