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
            this.xtraTabControlMain = new DevExpress.XtraTab.XtraTabControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlMain)).BeginInit();
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
            // xtraTabControlMain
            // 
            this.xtraTabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControlMain.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.xtraTabControlMain.Appearance.Options.UseFont = true;
            this.xtraTabControlMain.AppearancePage.Header.Font = new System.Drawing.Font("Tahoma", 12F);
            this.xtraTabControlMain.AppearancePage.Header.Options.UseFont = true;
            this.xtraTabControlMain.AppearancePage.Header.Options.UseTextOptions = true;
            this.xtraTabControlMain.AppearancePage.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.xtraTabControlMain.AppearancePage.HeaderActive.Font = new System.Drawing.Font("Tahoma", 12F);
            this.xtraTabControlMain.AppearancePage.HeaderActive.ForeColor = System.Drawing.Color.Firebrick;
            this.xtraTabControlMain.AppearancePage.HeaderActive.Options.UseFont = true;
            this.xtraTabControlMain.AppearancePage.HeaderActive.Options.UseForeColor = true;
            this.xtraTabControlMain.AppearancePage.HeaderDisabled.Font = new System.Drawing.Font("Tahoma", 12F);
            this.xtraTabControlMain.AppearancePage.HeaderDisabled.Options.UseFont = true;
            this.xtraTabControlMain.AppearancePage.HeaderHotTracked.Font = new System.Drawing.Font("Tahoma", 12F);
            this.xtraTabControlMain.AppearancePage.HeaderHotTracked.Options.UseFont = true;
            this.xtraTabControlMain.Location = new System.Drawing.Point(3, 12);
            this.xtraTabControlMain.Name = "xtraTabControlMain";
            this.xtraTabControlMain.Size = new System.Drawing.Size(866, 462);
            this.xtraTabControlMain.TabIndex = 5;
            // 
            // DXFormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 497);
            this.Controls.Add(this.xtraTabControlMain);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "DXFormMain";
            this.Text = "Quản lý điểm sinh viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlMain)).EndInit();
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
        private DevExpress.XtraTab.XtraTabControl xtraTabControlMain;
        private DevExpress.XtraBars.BarStaticItem barItemMGV;
        private DevExpress.XtraBars.BarStaticItem barItemTen;
        private DevExpress.XtraBars.BarStaticItem barItemNhom;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem1;
    }
}