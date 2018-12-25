namespace DX_Student_Score_Management.Controllers
{
    partial class UserControlHPTaiKhoan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlHPTaiKhoan));
            this.toolBar = new DevExpress.XtraBars.Bar();
            this.barBtnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnDeleteGiangVien = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnNewLogin = new DevExpress.XtraBars.BarButtonItem();
            this.barManagerTool = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.qLDSVHocPhiDataSet = new DX_Student_Score_Management.QLDSVHocPhiDataSet();
            this.sP_List_LOGINBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_List_LOGINGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colLOGINNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKH = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerTool)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVHocPhiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_List_LOGINBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_List_LOGINGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolBar
            // 
            this.toolBar.BarName = "Main menu";
            this.toolBar.DockCol = 0;
            this.toolBar.DockRow = 0;
            this.toolBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.toolBar.FloatLocation = new System.Drawing.Point(231, 119);
            this.toolBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnRefresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnDeleteGiangVien, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnNewLogin, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.toolBar.OptionsBar.MultiLine = true;
            this.toolBar.OptionsBar.UseWholeRow = true;
            this.toolBar.Text = "Main menu";
            // 
            // barBtnRefresh
            // 
            this.barBtnRefresh.Caption = "Refresh";
            this.barBtnRefresh.Id = 0;
            this.barBtnRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnRefresh.ImageOptions.Image")));
            this.barBtnRefresh.Name = "barBtnRefresh";
            this.barBtnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnRefresh_ItemClick);
            // 
            // barBtnDeleteGiangVien
            // 
            this.barBtnDeleteGiangVien.Caption = "Delete";
            this.barBtnDeleteGiangVien.Id = 3;
            this.barBtnDeleteGiangVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnDeleteGiangVien.ImageOptions.Image")));
            this.barBtnDeleteGiangVien.Name = "barBtnDeleteGiangVien";
            this.barBtnDeleteGiangVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnDeleteGiangVien_ItemClick);
            // 
            // barBtnNewLogin
            // 
            this.barBtnNewLogin.Caption = "Tạo Login";
            this.barBtnNewLogin.Id = 4;
            this.barBtnNewLogin.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnNewLogin.ImageOptions.Image")));
            this.barBtnNewLogin.Name = "barBtnNewLogin";
            this.barBtnNewLogin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnNewLogin_ItemClick);
            // 
            // barManagerTool
            // 
            this.barManagerTool.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.toolBar});
            this.barManagerTool.DockControls.Add(this.barDockControlTop);
            this.barManagerTool.DockControls.Add(this.barDockControlBottom);
            this.barManagerTool.DockControls.Add(this.barDockControlLeft);
            this.barManagerTool.DockControls.Add(this.barDockControlRight);
            this.barManagerTool.Form = this;
            this.barManagerTool.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barBtnRefresh,
            this.barBtnDeleteGiangVien,
            this.barBtnNewLogin});
            this.barManagerTool.MainMenu = this.toolBar;
            this.barManagerTool.MaxItemId = 5;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManagerTool;
            this.barDockControlTop.Size = new System.Drawing.Size(988, 42);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 475);
            this.barDockControlBottom.Manager = this.barManagerTool;
            this.barDockControlBottom.Size = new System.Drawing.Size(988, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 42);
            this.barDockControlLeft.Manager = this.barManagerTool;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 433);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(988, 42);
            this.barDockControlRight.Manager = this.barManagerTool;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 433);
            // 
            // qLDSVHocPhiDataSet
            // 
            this.qLDSVHocPhiDataSet.DataSetName = "QLDSVHocPhiDataSet";
            this.qLDSVHocPhiDataSet.EnforceConstraints = false;
            this.qLDSVHocPhiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sP_List_LOGINBindingSource
            // 
            this.sP_List_LOGINBindingSource.DataMember = "SP_List_LOGIN";
            this.sP_List_LOGINBindingSource.DataSource = this.qLDSVHocPhiDataSet;
            // 
            // sP_List_LOGINGridControl
            // 
            this.sP_List_LOGINGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sP_List_LOGINGridControl.DataSource = this.sP_List_LOGINBindingSource;
            this.sP_List_LOGINGridControl.Location = new System.Drawing.Point(0, 48);
            this.sP_List_LOGINGridControl.MainView = this.gridView1;
            this.sP_List_LOGINGridControl.MenuManager = this.barManagerTool;
            this.sP_List_LOGINGridControl.Name = "sP_List_LOGINGridControl";
            this.sP_List_LOGINGridControl.Size = new System.Drawing.Size(985, 354);
            this.sP_List_LOGINGridControl.TabIndex = 5;
            this.sP_List_LOGINGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colLOGINNAME,
            this.colMAGV,
            this.colHO,
            this.colTEN,
            this.colMAKH});
            this.gridView1.GridControl = this.sP_List_LOGINGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colLOGINNAME
            // 
            this.colLOGINNAME.Caption = "Login";
            this.colLOGINNAME.FieldName = "LOGINNAME";
            this.colLOGINNAME.Name = "colLOGINNAME";
            this.colLOGINNAME.OptionsColumn.AllowEdit = false;
            this.colLOGINNAME.OptionsColumn.AllowFocus = false;
            this.colLOGINNAME.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colLOGINNAME.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colLOGINNAME.OptionsColumn.AllowMove = false;
            this.colLOGINNAME.OptionsColumn.ReadOnly = true;
            this.colLOGINNAME.Visible = true;
            this.colLOGINNAME.VisibleIndex = 0;
            // 
            // colMAGV
            // 
            this.colMAGV.Caption = "Mã GV";
            this.colMAGV.FieldName = "MAGV";
            this.colMAGV.Name = "colMAGV";
            this.colMAGV.OptionsColumn.AllowEdit = false;
            this.colMAGV.OptionsColumn.AllowFocus = false;
            this.colMAGV.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colMAGV.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colMAGV.OptionsColumn.AllowMove = false;
            this.colMAGV.OptionsColumn.ReadOnly = true;
            this.colMAGV.Visible = true;
            this.colMAGV.VisibleIndex = 1;
            // 
            // colHO
            // 
            this.colHO.Caption = "Họ";
            this.colHO.FieldName = "HO";
            this.colHO.Name = "colHO";
            this.colHO.OptionsColumn.AllowEdit = false;
            this.colHO.OptionsColumn.AllowFocus = false;
            this.colHO.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colHO.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colHO.OptionsColumn.AllowMove = false;
            this.colHO.OptionsColumn.ReadOnly = true;
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 2;
            // 
            // colTEN
            // 
            this.colTEN.Caption = "Tên";
            this.colTEN.FieldName = "TEN";
            this.colTEN.Name = "colTEN";
            this.colTEN.OptionsColumn.AllowEdit = false;
            this.colTEN.OptionsColumn.AllowFocus = false;
            this.colTEN.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colTEN.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colTEN.OptionsColumn.AllowMove = false;
            this.colTEN.OptionsColumn.ReadOnly = true;
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 3;
            // 
            // colMAKH
            // 
            this.colMAKH.Caption = "Mã khoa";
            this.colMAKH.FieldName = "MAKH";
            this.colMAKH.Name = "colMAKH";
            this.colMAKH.OptionsColumn.AllowEdit = false;
            this.colMAKH.OptionsColumn.AllowFocus = false;
            this.colMAKH.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colMAKH.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colMAKH.OptionsColumn.AllowMove = false;
            this.colMAKH.OptionsColumn.ReadOnly = true;
            this.colMAKH.Visible = true;
            this.colMAKH.VisibleIndex = 4;
            // 
            // UserControlHPTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sP_List_LOGINGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "UserControlHPTaiKhoan";
            this.Size = new System.Drawing.Size(988, 475);
            ((System.ComponentModel.ISupportInitialize)(this.barManagerTool)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVHocPhiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_List_LOGINBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_List_LOGINGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Bar toolBar;
        private DevExpress.XtraBars.BarButtonItem barBtnRefresh;
        private DevExpress.XtraBars.BarButtonItem barBtnDeleteGiangVien;
        private DevExpress.XtraBars.BarButtonItem barBtnNewLogin;
        private DevExpress.XtraBars.BarManager barManagerTool;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl sP_List_LOGINGridControl;
        private System.Windows.Forms.BindingSource sP_List_LOGINBindingSource;
        private QLDSVHocPhiDataSet qLDSVHocPhiDataSet;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colLOGINNAME;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH;
    }
}
