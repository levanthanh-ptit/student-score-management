using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DX_Student_Score_Management.Controllers.ReportForms;

namespace DX_Student_Score_Management.Controllers
{
    public partial class UserControlReport : DevExpress.XtraEditors.XtraUserControl
    {
        public UserControlReport()
        {
            InitializeComponent();
        }

        private void btnDSSV_Click(object sender, EventArgs e)
        {
            new FormReportDSSV().Show();
        }
    }
}
