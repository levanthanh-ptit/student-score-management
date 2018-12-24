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
    public partial class FormReportDSThi : Form
    {
        public FormReportDSThi()
        {
            InitializeComponent();
            try
            {
                Program.KHOA_SP_List_LOPTableAdapter.Fill(Program._QLDSVKhoaDataSet.SP_List_LOP, Program._dataRepository.GroupId);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            this.sP_List_LOPBindingSource.DataSource = Program._QLDSVKhoaDataSet;
            this.MonHocBindingSource.DataSource = Program._QLDSVKhoaDataSet;
        }

        private void FormDSThi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSVKhoaDataSet.MONHOC' table. You can move, or remove it, as needed.

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            new XtraReportDSThi(sP_List_LOPComboBox.Text,labelLop.Text, labelMonHoc.Text, dateTimePicker.Text);
        }
    }
}
