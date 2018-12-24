using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DX_Student_Score_Management.Controllers.ReportForms
{
    public partial class FormReportBDTK : Form
    {
        public FormReportBDTK()
        {
            InitializeComponent();
            ListLOPBindingSource.DataSource = Program._QLDSVKhoaDataSet;
            FormReportBDTK_Load();
        }
        public void FormReportBDTK_Load()
        {
            try
            {
                Program.KHOA_SP_List_LOPTableAdapter.Fill(Program._QLDSVKhoaDataSet.SP_List_LOP,Program._dataRepository.GroupId);
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Load dữ liệu thất bại.\n{ex.Message}");
            }
        }

        private void btnPrintBDTK_Click(object sender, EventArgs e)
        {
            new XtraReportBDTK(mALOPLabel.Text, sP_List_LOPComboBox.Text);
        }
    }
}
