using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace DX_Student_Score_Management.Controllers.ReportForms
{
    public partial class XtraReportBDTK : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReportBDTK(string MALOP, string tenLop)
        {
            InitializeComponent();
            this.sP_Print_BANGDIEM_TONGKET_2TableAdapter.Fill(qldsvKhoaDataSet1.SP_Print_BANGDIEM_TONGKET_2,Program._dataRepository.GroupId, MALOP);
            this.xrLabelLop.Text += tenLop;
            this.ShowPreview();
        }

    }
}
