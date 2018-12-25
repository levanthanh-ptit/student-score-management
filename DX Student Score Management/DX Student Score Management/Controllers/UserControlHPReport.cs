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
using DX_Student_Score_Management.Controllers.ReportForms;

namespace DX_Student_Score_Management.Controllers
{
    public partial class UserControlHPReport : DevExpress.XtraEditors.XtraUserControl
    {
        public UserControlHPReport()
        {
            InitializeComponent();
            this.sP_List_LOPTableAdapter.Connection = Program._dataRepository.sqlConnection;
            this.sP_List_NIENKHOATableAdapter.Connection = Program._dataRepository.sqlConnection;
            this.sP_List_LOPTableAdapter.Fill(this.qLDSVHocPhiDataSet.SP_List_LOP, Program._dataRepository.GroupId);
            this.sP_List_NIENKHOATableAdapter.Fill(this.qLDSVHocPhiDataSet.SP_List_NIENKHOA);
        }


       
        private void btnPrint_Click(object sender, EventArgs e)
        {
             new XtraReportDSHP(this.labelLop.Text, sP_List_LOPComboBox.Text, NIENKHOAComboBox.Text,Convert.ToInt32(this.spinEditHK.Value));
        }
    }
}
