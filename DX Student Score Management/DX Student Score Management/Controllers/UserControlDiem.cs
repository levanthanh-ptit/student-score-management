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
        }

        private void dIEMBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dIEMBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLDSVKhoaDataSet);

        }
    }
}
