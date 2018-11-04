namespace DX_Student_Score_Management
{
    partial class DXFormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.statusBar = new DevExpress.XtraBars.Bar();
            this.barItemMGV = new DevExpress.XtraBars.BarStaticItem();
            this.barItemTen = new DevExpress.XtraBars.BarStaticItem();
            this.barItemNhom = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPageLop = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPageMonHoc = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPageDiem = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPageHocPhi = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPageTaiKhoan = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.statusBar});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barItemMGV,
            this.barHeaderItem1,
            this.barItemTen,
            this.barItemNhom});
            this.barManager1.MaxItemId = 4;
            this.barManager1.StatusBar = this.statusBar;
            // 
            // statusBar
            // 
            this.statusBar.BarName = "Status bar";
            this.statusBar.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.statusBar.DockCol = 0;
            this.statusBar.DockRow = 0;
            this.statusBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.statusBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barItemMGV),
            new DevExpress.XtraBars.LinkPersistInfo(this.barItemTen),
            new DevExpress.XtraBars.LinkPersistInfo(this.barItemNhom)});
            this.statusBar.OptionsBar.AllowQuickCustomization = false;
            this.statusBar.OptionsBar.DrawDragBorder = false;
            this.statusBar.OptionsBar.UseWholeRow = true;
            this.statusBar.Text = "Status bar";
            // 
            // barItemMGV
            // 
            this.barItemMGV.Caption = "MGV";
            this.barItemMGV.Id = 0;
            this.barItemMGV.Name = "barItemMGV";
            // 
            // barItemTen
            // 
            this.barItemTen.Caption = "TEN";
            this.barItemTen.Id = 2;
            this.barItemTen.Name = "barItemTen";
            // 
            // barItemNhom
            // 
            this.barItemNhom.Caption = "NHOM";
            this.barItemNhom.Id = 3;
            this.barItemNhom.Name = "barItemNhom";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(872, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 475);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(872, 22);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 475);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(872, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 475);
            // 
            // barHeaderItem1
            // 
            this.barHeaderItem1.Caption = "TEN";
            this.barHeaderItem1.Id = 1;
            this.barHeaderItem1.Name = "barHeaderItem1";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.xtraTabControl1.Appearance.Options.UseFont = true;
            this.xtraTabControl1.AppearancePage.Header.Font = new System.Drawing.Font("Tahoma", 12F);
            this.xtraTabControl1.AppearancePage.Header.Options.UseFont = true;
            this.xtraTabControl1.AppearancePage.Header.Options.UseTextOptions = true;
            this.xtraTabControl1.AppearancePage.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.xtraTabControl1.AppearancePage.HeaderActive.Font = new System.Drawing.Font("Tahoma", 12F);
            this.xtraTabControl1.AppearancePage.HeaderActive.ForeColor = System.Drawing.Color.Firebrick;
            this.xtraTabControl1.AppearancePage.HeaderActive.Options.UseFont = true;
            this.xtraTabControl1.AppearancePage.HeaderActive.Options.UseForeColor = true;
            this.xtraTabControl1.AppearancePage.HeaderDisabled.Font = new System.Drawing.Font("Tahoma", 12F);
            this.xtraTabControl1.AppearancePage.HeaderDisabled.Options.UseFont = true;
            this.xtraTabControl1.AppearancePage.HeaderHotTracked.Font = new System.Drawing.Font("Tahoma", 12F);
            this.xtraTabControl1.AppearancePage.HeaderHotTracked.Options.UseFont = true;
            this.xtraTabControl1.Location = new System.Drawing.Point(3, 12);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPageLop;
            this.xtraTabControl1.Size = new System.Drawing.Size(866, 462);
            this.xtraTabControl1.TabIndex = 5;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPageLop,
            this.xtraTabPageMonHoc,
            this.xtraTabPageDiem,
            this.xtraTabPageHocPhi,
            this.xtraTabPageTaiKhoan});
            // 
            // xtraTabPageLop
            // 
            this.xtraTabPageLop.Name = "xtraTabPageLop";
            this.xtraTabPageLop.Size = new System.Drawing.Size(864, 431);
            this.xtraTabPageLop.Text = "Lớp - Sinh Viên";
            // 
            // xtraTabPageMonHoc
            // 
            this.xtraTabPageMonHoc.Name = "xtraTabPageMonHoc";
            this.xtraTabPageMonHoc.Size = new System.Drawing.Size(864, 431);
            this.xtraTabPageMonHoc.Text = "Môn học";
            // 
            // xtraTabPageDiem
            // 
            this.xtraTabPageDiem.Name = "xtraTabPageDiem";
            this.xtraTabPageDiem.Size = new System.Drawing.Size(864, 431);
            this.xtraTabPageDiem.Text = "Nhập điểm";
            // 
            // xtraTabPageHocPhi
            // 
            this.xtraTabPageHocPhi.Name = "xtraTabPageHocPhi";
            this.xtraTabPageHocPhi.Size = new System.Drawing.Size(864, 431);
            this.xtraTabPageHocPhi.Text = "Học phí";
            // 
            // xtraTabPageTaiKhoan
            // 
            this.xtraTabPageTaiKhoan.Name = "xtraTabPageTaiKhoan";
            this.xtraTabPageTaiKhoan.Size = new System.Drawing.Size(864, 431);
            this.xtraTabPageTaiKhoan.Text = "Tài khoản";
            // 
            // DXFormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 497);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "DXFormMain";
            this.Text = "Quản lý điểm sinh viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar statusBar;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageLop;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageMonHoc;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageDiem;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageHocPhi;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageTaiKhoan;
        private DevExpress.XtraBars.BarStaticItem barItemMGV;
        private DevExpress.XtraBars.BarStaticItem barItemTen;
        private DevExpress.XtraBars.BarStaticItem barItemNhom;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem1;
    }
}