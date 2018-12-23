using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace DX_Student_Score_Management.Controllers.ReportForms
{
    public partial class XtraReportDSSV : DevExpress.XtraReports.UI.XtraReport
    {
        String MaLop;
        public XtraReportDSSV(String Nhom, String MaLop, String Tenlop)
        {
            InitializeComponent();
            this.MaLop = MaLop;
            this.xrLabelTenLop.Text = Tenlop;
            this.sP_Print_SINHVIENTableAdapter.Fill(Program._QLDSVKhoaDataSet.SP_Print_SINHVIEN,Nhom,MaLop);   
            this.ShowPreview();
            
        }

    }
}
