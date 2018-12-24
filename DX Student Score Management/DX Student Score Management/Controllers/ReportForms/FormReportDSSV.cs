using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace DX_Student_Score_Management.Controllers.ReportForms
{
    public partial class FormReportDSSV : DevExpress.XtraEditors.XtraForm
    {
        public FormReportDSSV()
        {
            InitializeComponent();
            this.sP_List_LOPBindingSource.DataSource = Program._QLDSVKhoaDataSet;
        }

        private void FormReportDSSV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSVKhoaDataSet.LOP' table. You can move, or remove it, as needed.
            try
            {
                Program.KHOA_SP_List_LOPTableAdapter.Fill(Program._QLDSVKhoaDataSet.SP_List_LOP, Program._dataRepository.GroupId);
            }
            catch (SqlException ex)
            {
            }
        }

        private void btnPrintDSSV_Click(object sender, EventArgs e)
        {
            this.UseWaitCursor = true;
            this.Enabled = false;
            new XtraReportDSSV(Program._dataRepository.GroupId, mALOPLabel.Text, sP_List_LOPComboBox.Text);
            this.UseWaitCursor = false;
            this.Enabled = true;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Program.KHOA_SP_List_LOPTableAdapter.Fill(Program._QLDSVKhoaDataSet.SP_List_LOP, Program._dataRepository.GroupId);
            }
            catch (SqlException ex)
            {
            }
        }
    }
}