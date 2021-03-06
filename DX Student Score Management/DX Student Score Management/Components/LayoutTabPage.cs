﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraTab;
using DX_Student_Score_Management.Controllers;
namespace DX_Student_Score_Management.Components
{

    public class LayoutTabPage
    {

        private readonly PageInfo[] pageInfo = { new PageInfo("Lop","Lớp - Sinh viên"),
                                        new PageInfo("Mon","Môn học"),
                                        new PageInfo("Diem", "Nhập Điểm"),
                                        new PageInfo("HocPhi","Học phí"),
                                        new PageInfo("TaiKhoan","Tài khoản"),
                                        new PageInfo("SinhVien","Sinh Viên")};
        // Mapper Role
        private Dictionary<string, int[]> pageMap;
        // Main collection 
        public List<XtraTabPage> TabPages { get; }

        public LayoutTabPage(string grounpId)
        {
            pageMap = new Dictionary<string, int[]>();
            TabPages = new List<XtraTabPage>();
            pageMap.Add("PGV", new int[] { 0, 1, 2, 3 });
            pageMap.Add("KHOA", new int[] { 0, 1, 2, 4 });
            pageMap.Add("KETOAN", new int[] { 3 });
            pageMap.Add("USER", new int[] { 5 });
            pageMap.Add("db_owner", new int[] { 0, 1, 2, 3, 4 });
            int[] tryGet;
            if (pageMap.TryGetValue(grounpId, out tryGet))
            {
                foreach (int el in pageMap[grounpId])
                {
                    TabPages.Add(pageInfo[el].CreateTabPage());
                    switch (el)
                    {
                        case 0:
                            {
                                pageInfo[el].UserControl = new UserControlLopSinhVien();
                                TabPages.Last().Controls.Add(pageInfo[el].UserControl);
                                pageInfo[el].UserControl.Dock = System.Windows.Forms.DockStyle.Fill;
                                break;
                            }
                        case 1:
                            {
                                pageInfo[el].UserControl = new UserControlMon();
                                TabPages.Last().Controls.Add(pageInfo[el].UserControl);
                                pageInfo[el].UserControl.Dock = System.Windows.Forms.DockStyle.Fill;
                                break;
                            }
                        case 2:
                            {
                                pageInfo[el].UserControl = new UserControlDiem();
                                TabPages.Last().Controls.Add(pageInfo[el].UserControl);
                                pageInfo[el].UserControl.Dock = System.Windows.Forms.DockStyle.Fill;
                                break;
                            }
                        case 3:
                            {
                                pageInfo[el].UserControl = new UserControlHocPhi();
                                TabPages.Last().Controls.Add(pageInfo[el].UserControl);
                                pageInfo[el].UserControl.Dock = System.Windows.Forms.DockStyle.Fill;
                                break;
                            }
                        case 4:
                            {
                                pageInfo[el].UserControl = new UserControlTaiKhoan();
                                TabPages.Last().Controls.Add(pageInfo[el].UserControl);
                                pageInfo[el].UserControl.Dock = System.Windows.Forms.DockStyle.Fill;
                                break;
                            }
                        case 5:
                            {
                                pageInfo[el].UserControl = new UserControlSinhVien();
                                TabPages.Last().Controls.Add(pageInfo[el].UserControl);
                                pageInfo[el].UserControl.Dock = System.Windows.Forms.DockStyle.Fill;
                                break;
                            }
                    }
                }
            }
        }
    }
    class PageInfo
    {
        public string Name { get; set; }
        public string Text { get; set; }
        public DevExpress.XtraEditors.XtraUserControl UserControl { get; set; }
        public PageInfo(string name, string text)
        {
            this.Name = $"xtraTabPage{name}";
            this.Text = text;
        }
        public XtraTabPage CreateTabPage()
        {
            XtraTabPage tabPage = new XtraTabPage();
            tabPage.Name = this.Name;
            tabPage.Text = this.Text;
            return tabPage;
        }
    }
}
