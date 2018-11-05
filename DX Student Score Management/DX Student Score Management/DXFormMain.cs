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

namespace DX_Student_Score_Management
{
    public partial class DXFormMain : DevExpress.XtraEditors.XtraForm
    {
        DataRepository _dataRepository;
        private UserControlLopSinhVien userControlLopSinhVien;

        private void InitializeExtendComponent()
        {
            //
            // userControlLopSinhVien
            //
            userControlLopSinhVien = new UserControlLopSinhVien();
            xtraTabPageLop.Controls.Add(userControlLopSinhVien);
            userControlLopSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            //
            // statusBar
            //
            barItemMGV.Caption = $"MGV: {_dataRepository.UserName}";
            barItemTen.Caption = $"Tên: {_dataRepository.FullName}";
            barItemNhom.Caption = $"Nhóm: {_dataRepository.GroupId}";
        }

        public DXFormMain(DataRepository dataRepository)
        {
            this._dataRepository = dataRepository;
            InitializeComponent();
            InitializeExtendComponent();

        }
    }
}