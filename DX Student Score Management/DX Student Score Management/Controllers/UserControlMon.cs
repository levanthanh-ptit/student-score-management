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
            UserControlLopSinhVien_Load();
        }
        private void UserControlLopSinhVien_Load()
        {
            this.mONHOCTableAdapter.Fill(this.qLDSVKhoaDataSet.MONHOC);
        }
        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mONHOCBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLDSVKhoaDataSet);

        }
    }
}
