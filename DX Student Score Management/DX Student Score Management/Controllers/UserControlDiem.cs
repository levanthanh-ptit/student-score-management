using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace DX_Student_Score_Management.Controllers
{
    public partial class UserControlDiem : DevExpress.XtraEditors.XtraUserControl
    {
        private QLDSVKhoaDataSet _QLDSVKhoaDataSet;
        private bool stateLabelColapse = false;


        public UserControlDiem(QLDSVKhoaDataSet _QLDSVKhoaDataSet)
        {
            this._QLDSVKhoaDataSet = _QLDSVKhoaDataSet;
            InitializeComponent();
            InitializeExtendComponent();
            this.lOPBindingSource.DataSource = _QLDSVKhoaDataSet;
            this.mONHOCBindingSource.DataSource = _QLDSVKhoaDataSet;
            this.dIEMBindingSource.DataSource = _QLDSVKhoaDataSet;
            UserControlDiem_Load();
        }
        private void InitializeExtendComponent()
        {
            this.tableAdapterManager.Connection = Program._dataRepository.sqlConnection;
            this.lOPTableAdapter.Connection = Program._dataRepository.sqlConnection;
            this.sINHVIENTableAdapter.Connection = Program._dataRepository.sqlConnection;
            this.dIEMTableAdapter.Connection = Program._dataRepository.sqlConnection;
            this.mONHOCTableAdapter.Connection = Program._dataRepository.sqlConnection;
        }
        public void UserControlDiem_Load()
        {
            this.lOPTableAdapter.Fill(_QLDSVKhoaDataSet.LOP);
            this.sINHVIENTableAdapter.Fill(_QLDSVKhoaDataSet.SINHVIEN);
            this.mONHOCTableAdapter.Fill(_QLDSVKhoaDataSet.MONHOC);
            this.dIEMTableAdapter.Fill(_QLDSVKhoaDataSet.DIEM);
        }

        private void barBtnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.dIEMBindingSource.EndEdit();
            this.UserControlDiem_Load();
            
        }

        private void barBtnUpload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.dIEMBindingSource.EndEdit();
            try
            {
                this.dIEMTableAdapter.Update(_QLDSVKhoaDataSet.DIEM);
            }
            catch (SqlException sqlExc)
            {
                MessageBox.Show(sqlExc.Message);
            }

            this.dIEMBindingSource.EndEdit();
        }

        private void btnGetFilter_Click(object sender, EventArgs e)
        {
            if (fKSINHVIENLOPBindingSource.Count != 0)
            {
                this.dIEMGridControl.Visible = true;
                // colapse header
                this.labelColapse.Text = "Extend";
                panelInfo.Height = 40;
                // query and generate List of SinhVien in selected Lop into Diem table.
                int DiemTablePosition = dIEMBindingSource.Count;
                fKSINHVIENLOPBindingSource.MoveFirst();
                for (int i = 0; i < fKSINHVIENLOPBindingSource.Count; i++)
                {
                    dIEMBindingSource.AddNew();
                    ((DataRowView)dIEMBindingSource.Current)["MASV"] = ((DataRowView)fKSINHVIENLOPBindingSource.Current)["MASV"];
                    ((DataRowView)dIEMBindingSource.Current)["MAMH"] = this.labelMaMonHoc.Text;
                    ((DataRowView)dIEMBindingSource.Current)["LAN"] = Convert.ToInt32(this.textEditLan.Text);
                    fKSINHVIENLOPBindingSource.MoveNext();
                }
                dIEMBindingSource.Position = DiemTablePosition;
            }
            else
            {
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
    }
}
