using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace DX_Student_Score_Management.Controllers.ReportForms
{
    public partial class XtraReportBDMH : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReportBDMH(string tenlop,string MALOP, string tenMon, string MAMON, string hocky, short lan)
        {
            InitializeComponent();
            xrLabelLop.Text += tenlop;
            xrLabelMon.Text += tenMon;
            xrLabelHocKy.Text += hocky;
            xrLabelLan.Text += lan;
            sP_Print_BANGDIEM_MONHOCTableAdapter1.Connection = Program._dataRepository.sqlConnection;
            try
            {
                sP_Print_BANGDIEM_MONHOCTableAdapter1.Fill(this.qldsvKhoaDataSet.SP_Print_BANGDIEM_MONHOC,Program._dataRepository.GroupId,MALOP, MAMON, lan);
            }
            catch (Exception)
            {

                
            }
            this.ShowPreview();

        }

    }
}
