namespace DX_Student_Score_Management.Controllers
{
    partial class UserControlTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlTaiKhoan));
            this.qLDSVKhoaDataSet = new DX_Student_Score_Management.QLDSVKhoaDataSet();
            this.fKGIANGVIENKHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.KhoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gIANGVIENTableAdapter = new DX_Student_Score_Management.QLDSVKhoaDataSetTableAdapters.GIANGVIENTableAdapter();
            this.tableAdapterManager = new DX_Student_Score_Management.QLDSVKhoaDataSetTableAdapters.TableAdapterManager();
            this.kHOATableAdapter = new DX_Student_Score_Management.QLDSVKhoaDataSetTableAdapters.KHOATableAdapter();
            this.gIANGVIENGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridViewGiangVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManagerTool = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.toolBar = new DevExpress.XtraBars.Bar();
            this.barBtnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnUpload = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnAddGiangVien = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnDeleteGiangVien = new DevExpress.XtraBars.BarButtonItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.barBtnNewLogin = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVKhoaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKGIANGVIENKHOABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KhoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIANGVIENGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGiangVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerTool)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // qLDSVKhoaDataSet
            // 
            this.qLDSVKhoaDataSet.DataSetName = "QLDSVKhoaDataSet";
            this.qLDSVKhoaDataSet.EnforceConstraints = false;
            this.qLDSVKhoaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fKGIANGVIENKHOABindingSource
            // 
            this.fKGIANGVIENKHOABindingSource.DataMember = "FK_GIANGVIEN_KHOA";
            this.fKGIANGVIENKHOABindingSource.DataSource = this.KhoaBindingSource;
            // 
            // KhoaBindingSource
            // 
            this.KhoaBindingSource.DataMember = "KHOA";
            this.KhoaBindingSource.DataSource = this.qLDSVKhoaDataSet;
            // 
            // gIANGVIENTableAdapter
            // 
            this.gIANGVIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DIEMTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = this.gIANGVIENTableAdapter;
            this.tableAdapterManager.HOCPHITableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = this.kHOATableAdapter;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DX_Student_Score_Management.QLDSVKhoaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // kHOATableAdapter
            // 
            this.kHOATableAdapter.ClearBeforeFill = true;
            // 
            // gIANGVIENGridControl
            // 
            this.gIANGVIENGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gIANGVIENGridControl.DataSource = this.fKGIANGVIENKHOABindingSource;
            this.gIANGVIENGridControl.Location = new System.Drawing.Point(3, 6);
            this.gIANGVIENGridControl.MainView = this.gridViewGiangVien;
            this.gIANGVIENGridControl.Name = "gIANGVIENGridControl";
            this.gIANGVIENGridControl.Size = new System.Drawing.Size(1253, 145);
            this.gIANGVIENGridControl.TabIndex = 1;
            this.gIANGVIENGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewGiangVien});
            // 
            // gridViewGiangVien
            // 
            this.gridViewGiangVien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAGV,
            this.colHO,
            this.colTEN,
            this.colMAKH});
            this.gridViewGiangVien.GridControl = this.gIANGVIENGridControl;
            this.gridViewGiangVien.Name = "gridViewGiangVien";
            this.gridViewGiangVien.OptionsView.ShowGroupPanel = false;
            // 
            // colMAGV
            // 
            this.colMAGV.Caption = "Mã GV";
            this.colMAGV.FieldName = "MAGV";
            this.colMAGV.Name = "colMAGV";
            this.colMAGV.Visible = true;
            this.colMAGV.VisibleIndex = 0;
            // 
            // colHO
            // 
            this.colHO.Caption = "Họ";
            this.colHO.FieldName = "HO";
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            // 
            // colTEN
            // 
            this.colTEN.Caption = "Tên";
            this.colTEN.FieldName = "TEN";
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            // 
            // colMAKH
            // 
            this.colMAKH.Caption = "Mã Khoa";
            this.colMAKH.FieldName = "MAKH";
            this.colMAKH.Name = "colMAKH";
            this.colMAKH.Visible = true;
            this.colMAKH.VisibleIndex = 3;
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
            this.barBtnUpload,
            this.barBtnAddGiangVien,
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
            this.barDockControlTop.Size = new System.Drawing.Size(1259, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 532);
            this.barDockControlBottom.Manager = this.barManagerTool;
            this.barDockControlBottom.Size = new System.Drawing.Size(1259, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManagerTool;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 492);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1259, 40);
            this.barDockControlRight.Manager = this.barManagerTool;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 492);
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnUpload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnAddGiangVien, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
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
            this.barBtnRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barBtnRefresh.Name = "barBtnRefresh";
            this.barBtnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnRefresh_ItemClick);
            // 
            // barBtnUpload
            // 
            this.barBtnUpload.Caption = "Upload";
            this.barBtnUpload.Id = 1;
            this.barBtnUpload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barBtnUpload.Name = "barBtnUpload";
            this.barBtnUpload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnUpload_ItemClick);
            // 
            // barBtnAddGiangVien
            // 
            this.barBtnAddGiangVien.Caption = "Add";
            this.barBtnAddGiangVien.Id = 2;
            this.barBtnAddGiangVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barBtnAddGiangVien.Name = "barBtnAddGiangVien";
            // 
            // barBtnDeleteGiangVien
            // 
            this.barBtnDeleteGiangVien.Caption = "Delete";
            this.barBtnDeleteGiangVien.Id = 3;
            this.barBtnDeleteGiangVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.barBtnDeleteGiangVien.Name = "barBtnDeleteGiangVien";
            this.barBtnDeleteGiangVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnDeleteGiangVien_ItemClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gIANGVIENGridControl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1259, 492);
            this.panel1.TabIndex = 6;
            // 
            // barBtnNewLogin
            // 
            this.barBtnNewLogin.Caption = "Tạo Login";
            this.barBtnNewLogin.Id = 4;
            this.barBtnNewLogin.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image1")));
            this.barBtnNewLogin.Name = "barBtnNewLogin";
            // 
            // UserControlTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "UserControlTaiKhoan";
            this.Size = new System.Drawing.Size(1259, 532);
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVKhoaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKGIANGVIENKHOABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KhoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIANGVIENGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGiangVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerTool)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QLDSVKhoaDataSet qLDSVKhoaDataSet;
        private System.Windows.Forms.BindingSource fKGIANGVIENKHOABindingSource;
        private QLDSVKhoaDataSetTableAdapters.GIANGVIENTableAdapter gIANGVIENTableAdapter;
        private QLDSVKhoaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource KhoaBindingSource;
        private QLDSVKhoaDataSetTableAdapters.KHOATableAdapter kHOATableAdapter;
        private DevExpress.XtraGrid.GridControl gIANGVIENGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewGiangVien;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH;
        private DevExpress.XtraBars.BarManager barManagerTool;
        private DevExpress.XtraBars.Bar toolBar;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barBtnRefresh;
        private DevExpress.XtraBars.BarButtonItem barBtnUpload;
        private DevExpress.XtraBars.BarButtonItem barBtnAddGiangVien;
        private DevExpress.XtraBars.BarButtonItem barBtnDeleteGiangVien;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraBars.BarButtonItem barBtnNewLogin;
    }
}
