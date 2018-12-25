using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace DX_Student_Score_Management.Controllers.ReportForms
{
    public partial class XtraReportDSHP : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReportDSHP(string MALOP, string TenLop, string NIENKHOA, int HOCKY)
        {
            InitializeComponent();
            this.xrLabelLop.Text += TenLop;
            this.xrLabelNienKhoa.Text += NIENKHOA;
            this.xrLabelHocKy.Text += HOCKY.ToString();
            this.sP_Print_DS_DONGHOCPHITableAdapter1.Connection = Program._dataRepository.sqlConnection;
            this.sP_Print_DS_DONGHOCPHITableAdapter1.Fill(this.qldsvHocPhiDataSet1.SP_Print_DS_DONGHOCPHI,MALOP,NIENKHOA,HOCKY);
            this.ShowPreview();
        }

    }
}
