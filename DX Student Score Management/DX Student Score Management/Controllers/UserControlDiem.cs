using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DX_Student_Score_Management.Controllers
{
    public partial class UserControlDiem : DevExpress.XtraEditors.XtraUserControl
    {
        private bool stateLabelColapse = false;


        public UserControlDiem()
        {
            InitializeComponent();
            InitializeExtendComponent();
            this.lOPBindingSource.DataSource = Program._QLDSVKhoaDataSet;
            this.mONHOCBindingSource.DataSource = Program._QLDSVKhoaDataSet;
            sPPreInsertDIEMSINHVIENBindingSource.DataSource = Program._QLDSVKhoaDataSet;
            UserControlDiem_Load();
        }
        private void InitializeExtendComponent()
        {
            this.sP_PreInsert_DIEM_SINHVIENTableAdapter.Connection = Program._dataRepository.sqlConnection;
        }
        public void UserControlDiem_Load()
        {
            Program.KHOA_LOPTableAdapter.Fill(Program._QLDSVKhoaDataSet.LOP);
            Program.KHOA_SINHVIENTableAdapter.Fill(Program._QLDSVKhoaDataSet.SINHVIEN);
            Program.KHOA_MONHOCTableAdapter.Fill(Program._QLDSVKhoaDataSet.MONHOC);
        }

        private void barBtnUpload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.UseWaitCursor = true;
            this.dIEMGridControl.Enabled = false;
            int n = sPPreInsertDIEMSINHVIENBindingSource.Count;
            sPPreInsertDIEMSINHVIENBindingSource.MoveFirst();
            for (int i = 0; i < n; i++)
            {
                if (((DataRowView)sPPreInsertDIEMSINHVIENBindingSource.Current)["DIEM"].ToString().Equals(""))
                {
                    MessageBox.Show($"Hàng {i + 1}: Điểm không được trống.");
                    this.dIEMGridControl.Enabled = true;
                    this.UseWaitCursor = false;
                    return;
                }
            }
            n = sPPreInsertDIEMSINHVIENBindingSource.Count;
            sPPreInsertDIEMSINHVIENBindingSource.MoveFirst();
            for (int i = 0; i < n; i++)
            {
                try
                {
                    this.sP_PreInsert_DIEM_SINHVIENTableAdapter
                   .InsertDIEMQuery(
                       ((DataRowView)sPPreInsertDIEMSINHVIENBindingSource.Current)["MASV"].ToString(),
                       labelMaMonHoc.Text,
                       Convert.ToInt16(numUpDownLan.Value),
                       double.Parse(((DataRowView)sPPreInsertDIEMSINHVIENBindingSource.Current)["DIEM"].ToString())
                   );
                }
                catch (SqlException ex)
                {
                    this.UseWaitCursor = false;
                    string mess = ex.ErrorCode == -2146232060 ? "Điểm đã tồn tại.\n Bạn có muốn ghi đè?" : ex.Message;
                    DialogResult dialogResult = MessageBox.Show(mess, "Lỗi! Error Code: " + ex.ErrorCode, MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        this.sP_PreInsert_DIEM_SINHVIENTableAdapter
                            .UpdateDIEMQuery(
                                Convert.ToDouble(((DataRowView)sPPreInsertDIEMSINHVIENBindingSource.Current)["DIEM"].ToString()),
                                ((DataRowView)sPPreInsertDIEMSINHVIENBindingSource.Current)["MASV"].ToString(),
                                labelMaMonHoc.Text,
                                Convert.ToInt16(numUpDownLan.Value)
                            );
                    }
                }
                sPPreInsertDIEMSINHVIENBindingSource.MoveNext();
            }
            this.dIEMGridControl.Enabled = true;
            this.UseWaitCursor = false;
            MessageBox.Show("Ghi điểm thành công!");
        }

        private void btnGetFilter_Click(object sender, EventArgs e)
        {
            this.UseWaitCursor = true;
            if (fKSINHVIENLOPBindingSource.Count != 0)
            {
                this.dIEMGridControl.Visible = true;
                // colapse header
                this.labelColapse.Text = "Extend";
                panelInfo.Height = 40;
                // query and generate List of SinhVien in selected Lop into Diem table.
                sP_PreInsert_DIEM_SINHVIENTableAdapter
                    .Fill(Program._QLDSVKhoaDataSet.SP_PreInsert_DIEM_SINHVIEN,
                        this.labelMaLop.Text,
                        this.labelMaMonHoc.Text,
                        Convert.ToInt16(this.numUpDownLan.Value)
                    );

                this.UseWaitCursor = false;
            }
            else
            {
                this.UseWaitCursor = false;
                MessageBox.Show($"Lớp {((DataRowView)this.lOPBindingSource.Current)["MALOP"].ToString()} đã chọn không có bất cứ sinh viên nào.");
            }
        }

        private void labelColapse_Click(object sender, EventArgs e)
        {
            if (!stateLabelColapse)
            {
                this.labelColapse.Text = "Extend";
                panelInfo.Height = 40;
            }
            else
            {
                this.labelColapse.Text = "Colapse";
                panelInfo.Height = 155;
            }
            stateLabelColapse = !stateLabelColapse;
        }

        private void labelColapse_MouseHover(object sender, EventArgs e)
        {
            labelColapse.ForeColor = Color.OrangeRed;
        }

        private void labelColapse_MouseLeave(object sender, EventArgs e)
        {
            labelColapse.ForeColor = Color.White;
        }
    }
}
