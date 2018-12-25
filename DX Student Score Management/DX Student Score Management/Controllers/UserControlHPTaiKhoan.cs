﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DX_Student_Score_Management.Controllers.HPTaiKhoanForms;

namespace DX_Student_Score_Management.Controllers
{
    public partial class UserControlHPTaiKhoan : DevExpress.XtraEditors.XtraUserControl
    {
        public UserControlHPTaiKhoan()
        {
            InitializeComponent();
            if (Program._dataRepository.GroupId.Equals("KETOAN")) barBtnDeleteGiangVien.Enabled = false;
            this.sP_List_LOGINBindingSource.DataSource = Program._QLDSVHocPhiDataSet;
            UserControlTaiKhoan_Load();
        }
        
        private void UserControlTaiKhoan_Load()
        {
            Program.HOCPHI_SP_List_LOGINTableAdapter.Fill(Program._QLDSVHocPhiDataSet.SP_List_LOGIN);
        }
        private void barBtnNewLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new FormTAOLOGIN().Show();
            UserControlTaiKhoan_Load();
        }

        private void barBtnDeleteGiangVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new FormXOALOGIN(
                ((DataRowView)sP_List_LOGINBindingSource.Current)["LOGINNAME"].ToString(),
                ((DataRowView)sP_List_LOGINBindingSource.Current)["MAGV"].ToString(),
                ((DataRowView)sP_List_LOGINBindingSource.Current)["HO"].ToString() + " " + ((DataRowView)sP_List_LOGINBindingSource.Current)["TEN"].ToString()
                ).Show();
            UserControlTaiKhoan_Load();
        }

        private void barBtnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.HOCPHI_SP_List_LOGINTableAdapter.Fill(Program._QLDSVHocPhiDataSet.SP_List_LOGIN);

        }
    }
}