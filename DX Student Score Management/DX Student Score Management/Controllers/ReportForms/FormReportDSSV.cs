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

namespace DX_Student_Score_Management.Controllers.ReportForms
{
    public partial class FormReportDSSV : DevExpress.XtraEditors.XtraForm
    {
        public FormReportDSSV()
        {
            InitializeComponent();
            this.lOPBindingSource.DataSource = Program._QLDSVKhoaDataSet;
        }

        private void FormReportDSSV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSVKhoaDataSet.LOP' table. You can move, or remove it, as needed.
            Program.KHOA_LOPTableAdapter.Fill(Program._QLDSVKhoaDataSet.LOP);

        }

        private void btnPrintDSSV_Click(object sender, EventArgs e)
        {
            this.UseWaitCursor = true;
            this.Enabled = false;
            new XtraReportDSSV(Program._dataRepository.GroupId,
                ((DataRowView)lOPBindingSource.Current)["MALOP"].ToString(), 
                ((DataRowView)lOPBindingSource.Current)["TENLOP"].ToString());
            this.UseWaitCursor = false;
            this.Enabled = true;


        }
    }
}