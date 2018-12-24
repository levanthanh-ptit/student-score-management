using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace DX_Student_Score_Management.Controllers.ReportForms
{
    public partial class XtraReportDSThi : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReportDSThi(string tenlop,string MALOP, string MonHoc, string NgayThi)
        {
            InitializeComponent();
            this.xrLabelLop.Text += tenlop;
            this.xrLabelMon.Text += MonHoc;
            this.xrLabelNgay.Text += NgayThi;
            this.sP_Print_PHIEUDIEMTHITableAdapter.Connection = Program._dataRepository.sqlConnection;
            sP_Print_PHIEUDIEMTHITableAdapter.Fill(this.qldsvKhoaDataSet.SP_Print_PHIEUDIEMTHI, Program._dataRepository.GroupId,MALOP);
            this.ShowPreview();
        }

    }
}
