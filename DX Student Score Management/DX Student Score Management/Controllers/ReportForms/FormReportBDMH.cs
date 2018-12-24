using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DX_Student_Score_Management.Controllers.ReportForms
{
    public partial class FormReportBDMH : Form
    {
        public FormReportBDMH()
        {
            InitializeComponent();
            sPListLOPBindingSource.DataSource = Program._QLDSVKhoaDataSet;
            MONHOCBindingSource.DataSource = Program._QLDSVKhoaDataSet;
        }

        private void FormReportBDMH_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSVKhoaDataSet.MONHOC' table. You can move, or remove it, as needed.
            Program.KHOA_SP_List_LOPTableAdapter.Fill(Program._QLDSVKhoaDataSet.SP_List_LOP,Program._dataRepository.GroupId);

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            new XtraReportBDMH(sP_List_LOPComboBox.Text,labelLop.Text,mONHOCComboBox.Text,labelMonHoc.Text,spinEditHK.Text, Convert.ToInt16(spinEditLan.Value));
        }
    }
}
