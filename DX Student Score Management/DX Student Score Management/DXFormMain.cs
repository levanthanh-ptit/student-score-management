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
using DX_Student_Score_Management.Repositories;
using DX_Student_Score_Management.Components;
using DX_Student_Score_Management.Controllers;


namespace DX_Student_Score_Management
{
    public partial class DXFormMain : DevExpress.XtraEditors.XtraForm
    {
        DataRepository _dataRepository;
        private LayoutTabPage layoutTabPage;
        private void InitializeExtendComponent()
        {
            //
            // xtraTabControlMain
            //
            foreach (var item in layoutTabPage.TabPages)
            {
                xtraTabControlMain.TabPages.Add(item);
            }
            //
            // userControlLopSinhVien
            //
            //layoutTabPage.TabPages.ElementAt(0).Controls.Add(userControlLopSinhVien);
            //userControlLopSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            //
            // statusBar
            //
            barItemMGV.Caption = $"MGV: {_dataRepository.UserName}";
            barItemTen.Caption = $"Tên: {_dataRepository.FullName}";
            barItemNhom.Caption = $"Nhóm: {_dataRepository.GroupId}";

        }

        public DXFormMain(DataRepository dataRepository, LayoutTabPage layoutTabPage)
        {
            this._dataRepository = dataRepository;
            this.layoutTabPage = layoutTabPage;
            InitializeComponent();
            InitializeExtendComponent();
            Program.FillAllTable();
        }
    }
}