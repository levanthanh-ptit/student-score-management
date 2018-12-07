namespace DX_Student_Score_Management.Controllers
{
    partial class UserControlHocPhi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlHocPhi));
            System.Windows.Forms.Label nIENKHOALabel;
            System.Windows.Forms.Label hOCKYLabel;
            System.Windows.Forms.Label hOCPHILabel;
            System.Windows.Forms.Label sOTIENDADONGLabel;
            this.barManagerTool = new DevExpress.XtraBars.BarManager(this.components);
            this.toolBar = new DevExpress.XtraBars.Bar();
            this.barBtnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnUpload = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnAddHocPhi = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnDeleteHocPhi = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.sINHVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSVHocPhiDataSet = new DX_Student_Score_Management.QLDSVHocPhiDataSet();
            this.fKHOCPHISINHVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hOCPHIGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridViewHocPhi = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNIENKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCPHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIENDADONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sINHVIENTableAdapter = new DX_Student_Score_Management.QLDSVHocPhiDataSetTableAdapters.SINHVIENTableAdapter();
            this.hOCPHITableAdapter = new DX_Student_Score_Management.QLDSVHocPhiDataSetTableAdapters.HOCPHITableAdapter();
            this.tableAdapterManager = new DX_Student_Score_Management.QLDSVHocPhiDataSetTableAdapters.TableAdapterManager();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelHocPhi = new System.Windows.Forms.Panel();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelMaSV = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelHoTen = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelMaLop = new System.Windows.Forms.Label();
            this.btnMaSVSearch = new System.Windows.Forms.Button();
            this.textBoxMaSV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nIENKHOATextEdit = new DevExpress.XtraEditors.TextEdit();
            this.hOCKYSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.hOCPHISpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.sOTIENDADONGSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.btnCancelAddHocPhi = new System.Windows.Forms.Button();
            this.btnEditHocPhiOK = new System.Windows.Forms.Button();
            this.btnAddHocPhi = new System.Windows.Forms.Button();
            nIENKHOALabel = new System.Windows.Forms.Label();
            hOCKYLabel = new System.Windows.Forms.Label();
            hOCPHILabel = new System.Windows.Forms.Label();
            sOTIENDADONGLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerTool)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVHocPhiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKHOCPHISINHVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCPHIGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHocPhi)).BeginInit();
            this.panelMain.SuspendLayout();
            this.panelHocPhi.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nIENKHOATextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCKYSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCPHISpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOTIENDADONGSpinEdit.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.barBtnAddHocPhi,
            this.barBtnDeleteHocPhi,
            this.barBtnRefresh,
            this.barBtnUpload});
            this.barManagerTool.MainMenu = this.toolBar;
            this.barManagerTool.MaxItemId = 4;
            // 
            // toolBar
            // 
            this.toolBar.BarName = "Main menu";
            this.toolBar.DockCol = 0;
            this.toolBar.DockRow = 0;
            this.toolBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.toolBar.FloatLocation = new System.Drawing.Point(358, 119);
            this.toolBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnRefresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnUpload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnAddHocPhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnDeleteHocPhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.toolBar.OptionsBar.MultiLine = true;
            this.toolBar.OptionsBar.UseWholeRow = true;
            this.toolBar.Text = "Main menu";
            // 
            // barBtnRefresh
            // 
            this.barBtnRefresh.Caption = "Refresh";
            this.barBtnRefresh.Id = 2;
            this.barBtnRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnRefresh.ImageOptions.Image")));
            this.barBtnRefresh.Name = "barBtnRefresh";
            this.barBtnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnRefresh_ItemClick);
            // 
            // barBtnUpload
            // 
            this.barBtnUpload.Caption = "Upload";
            this.barBtnUpload.Id = 3;
            this.barBtnUpload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnUpload.ImageOptions.Image")));
            this.barBtnUpload.Name = "barBtnUpload";
            this.barBtnUpload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnUpload_ItemClick);
            // 
            // barBtnAddHocPhi
            // 
            this.barBtnAddHocPhi.Caption = "Add";
            this.barBtnAddHocPhi.Id = 0;
            this.barBtnAddHocPhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnAddHocPhi.ImageOptions.Image")));
            this.barBtnAddHocPhi.Name = "barBtnAddHocPhi";
            this.barBtnAddHocPhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnAddHocPhi_ItemClick);
            // 
            // barBtnDeleteHocPhi
            // 
            this.barBtnDeleteHocPhi.Caption = "Delete";
            this.barBtnDeleteHocPhi.Id = 1;
            this.barBtnDeleteHocPhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnDeleteHocPhi.ImageOptions.Image")));
            this.barBtnDeleteHocPhi.Name = "barBtnDeleteHocPhi";
            this.barBtnDeleteHocPhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnDeleteHocPhi_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManagerTool;
            this.barDockControlTop.Size = new System.Drawing.Size(1330, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 573);
            this.barDockControlBottom.Manager = this.barManagerTool;
            this.barDockControlBottom.Size = new System.Drawing.Size(1330, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManagerTool;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 533);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1330, 40);
            this.barDockControlRight.Manager = this.barManagerTool;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 533);
            // 
            // sINHVIENBindingSource
            // 
            this.sINHVIENBindingSource.DataMember = "SINHVIEN";
            this.sINHVIENBindingSource.DataSource = this.qLDSVHocPhiDataSet;
            // 
            // qLDSVHocPhiDataSet
            // 
            this.qLDSVHocPhiDataSet.DataSetName = "QLDSVHocPhiDataSet";
            this.qLDSVHocPhiDataSet.EnforceConstraints = false;
            this.qLDSVHocPhiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fKHOCPHISINHVIENBindingSource
            // 
            this.fKHOCPHISINHVIENBindingSource.DataMember = "FK_HOCPHI_SINHVIEN";
            this.fKHOCPHISINHVIENBindingSource.DataSource = this.sINHVIENBindingSource;
            // 
            // hOCPHIGridControl
            // 
            this.hOCPHIGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hOCPHIGridControl.DataSource = this.fKHOCPHISINHVIENBindingSource;
            this.hOCPHIGridControl.Location = new System.Drawing.Point(3, 3);
            this.hOCPHIGridControl.MainView = this.gridViewHocPhi;
            this.hOCPHIGridControl.MenuManager = this.barManagerTool;
            this.hOCPHIGridControl.Name = "hOCPHIGridControl";
            this.hOCPHIGridControl.Size = new System.Drawing.Size(1318, 371);
            this.hOCPHIGridControl.TabIndex = 0;
            this.hOCPHIGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewHocPhi});
            // 
            // gridViewHocPhi
            // 
            this.gridViewHocPhi.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNIENKHOA,
            this.colHOCKY,
            this.colHOCPHI,
            this.colSOTIENDADONG});
            this.gridViewHocPhi.GridControl = this.hOCPHIGridControl;
            this.gridViewHocPhi.Name = "gridViewHocPhi";
            this.gridViewHocPhi.OptionsView.ShowGroupPanel = false;
            // 
            // colNIENKHOA
            // 
            this.colNIENKHOA.Caption = "Niên khóa";
            this.colNIENKHOA.FieldName = "NIENKHOA";
            this.colNIENKHOA.Name = "colNIENKHOA";
            this.colNIENKHOA.OptionsColumn.AllowEdit = false;
            this.colNIENKHOA.Visible = true;
            this.colNIENKHOA.VisibleIndex = 0;
            // 
            // colHOCKY
            // 
            this.colHOCKY.Caption = "Học kỳ";
            this.colHOCKY.FieldName = "HOCKY";
            this.colHOCKY.Name = "colHOCKY";
            this.colHOCKY.OptionsColumn.AllowEdit = false;
            this.colHOCKY.Visible = true;
            this.colHOCKY.VisibleIndex = 1;
            // 
            // colHOCPHI
            // 
            this.colHOCPHI.Caption = "Học phí";
            this.colHOCPHI.FieldName = "HOCPHI";
            this.colHOCPHI.Name = "colHOCPHI";
            this.colHOCPHI.OptionsColumn.AllowEdit = false;
            this.colHOCPHI.Visible = true;
            this.colHOCPHI.VisibleIndex = 2;
            // 
            // colSOTIENDADONG
            // 
            this.colSOTIENDADONG.Caption = "Số tiền đã đóng";
            this.colSOTIENDADONG.FieldName = "SOTIENDADONG";
            this.colSOTIENDADONG.Name = "colSOTIENDADONG";
            this.colSOTIENDADONG.OptionsColumn.AllowEdit = false;
            this.colSOTIENDADONG.Visible = true;
            this.colSOTIENDADONG.VisibleIndex = 3;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // hOCPHITableAdapter
            // 
            this.hOCPHITableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.HOCPHITableAdapter = this.hOCPHITableAdapter;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = this.sINHVIENTableAdapter;
            this.tableAdapterManager.UpdateOrder = DX_Student_Score_Management.QLDSVHocPhiDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelHocPhi);
            this.panelMain.Controls.Add(this.panelInfo);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 40);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1330, 533);
            this.panelMain.TabIndex = 10;
            // 
            // panelHocPhi
            // 
            this.panelHocPhi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHocPhi.Controls.Add(this.btnCancelAddHocPhi);
            this.panelHocPhi.Controls.Add(this.btnEditHocPhiOK);
            this.panelHocPhi.Controls.Add(this.btnAddHocPhi);
            this.panelHocPhi.Controls.Add(sOTIENDADONGLabel);
            this.panelHocPhi.Controls.Add(this.sOTIENDADONGSpinEdit);
            this.panelHocPhi.Controls.Add(hOCPHILabel);
            this.panelHocPhi.Controls.Add(this.hOCPHISpinEdit);
            this.panelHocPhi.Controls.Add(hOCKYLabel);
            this.panelHocPhi.Controls.Add(this.hOCKYSpinEdit);
            this.panelHocPhi.Controls.Add(nIENKHOALabel);
            this.panelHocPhi.Controls.Add(this.nIENKHOATextEdit);
            this.panelHocPhi.Controls.Add(this.hOCPHIGridControl);
            this.panelHocPhi.Location = new System.Drawing.Point(3, 114);
            this.panelHocPhi.Name = "panelHocPhi";
            this.panelHocPhi.Size = new System.Drawing.Size(1324, 416);
            this.panelHocPhi.TabIndex = 3;
            this.panelHocPhi.Visible = false;
            // 
            // panelInfo
            // 
            this.panelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInfo.Controls.Add(this.flowLayoutPanel1);
            this.panelInfo.Controls.Add(this.btnMaSVSearch);
            this.panelInfo.Controls.Add(this.textBoxMaSV);
            this.panelInfo.Controls.Add(this.label1);
            this.panelInfo.Location = new System.Drawing.Point(15, 12);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(1297, 96);
            this.panelInfo.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.labelMaSV);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.labelHoTen);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.labelMaLop);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 42);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1171, 40);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(13, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thông tin Sinh Viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(155, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã SV:";
            // 
            // labelMaSV
            // 
            this.labelMaSV.AutoSize = true;
            this.labelMaSV.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaSV.Location = new System.Drawing.Point(214, 10);
            this.labelMaSV.Margin = new System.Windows.Forms.Padding(3, 0, 15, 0);
            this.labelMaSV.MinimumSize = new System.Drawing.Size(40, 16);
            this.labelMaSV.Name = "labelMaSV";
            this.labelMaSV.Size = new System.Drawing.Size(40, 16);
            this.labelMaSV.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(272, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Họ Tên:";
            // 
            // labelHoTen
            // 
            this.labelHoTen.AutoSize = true;
            this.labelHoTen.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHoTen.Location = new System.Drawing.Point(335, 10);
            this.labelHoTen.Margin = new System.Windows.Forms.Padding(3, 0, 15, 0);
            this.labelHoTen.MinimumSize = new System.Drawing.Size(40, 16);
            this.labelHoTen.Name = "labelHoTen";
            this.labelHoTen.Size = new System.Drawing.Size(40, 16);
            this.labelHoTen.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(393, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mã lớp:";
            // 
            // labelMaLop
            // 
            this.labelMaLop.AutoSize = true;
            this.labelMaLop.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaLop.Location = new System.Drawing.Point(454, 10);
            this.labelMaLop.MinimumSize = new System.Drawing.Size(40, 16);
            this.labelMaLop.Name = "labelMaLop";
            this.labelMaLop.Size = new System.Drawing.Size(40, 16);
            this.labelMaLop.TabIndex = 1;
            // 
            // btnMaSVSearch
            // 
            this.btnMaSVSearch.Location = new System.Drawing.Point(316, 11);
            this.btnMaSVSearch.Name = "btnMaSVSearch";
            this.btnMaSVSearch.Size = new System.Drawing.Size(75, 21);
            this.btnMaSVSearch.TabIndex = 4;
            this.btnMaSVSearch.Text = "Tìm kiếm";
            this.btnMaSVSearch.UseVisualStyleBackColor = true;
            this.btnMaSVSearch.Click += new System.EventHandler(this.btnMaSVSearch_Click);
            // 
            // textBoxMaSV
            // 
            this.textBoxMaSV.Location = new System.Drawing.Point(145, 12);
            this.textBoxMaSV.Name = "textBoxMaSV";
            this.textBoxMaSV.Size = new System.Drawing.Size(159, 21);
            this.textBoxMaSV.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập Mã Sinh Viên";
            // 
            // nIENKHOALabel
            // 
            nIENKHOALabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            nIENKHOALabel.AutoSize = true;
            nIENKHOALabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            nIENKHOALabel.Location = new System.Drawing.Point(20, 385);
            nIENKHOALabel.Name = "nIENKHOALabel";
            nIENKHOALabel.Size = new System.Drawing.Size(62, 13);
            nIENKHOALabel.TabIndex = 1;
            nIENKHOALabel.Text = "Niên khóa";
            // 
            // nIENKHOATextEdit
            // 
            this.nIENKHOATextEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nIENKHOATextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.fKHOCPHISINHVIENBindingSource, "NIENKHOA", true));
            this.nIENKHOATextEdit.Location = new System.Drawing.Point(88, 382);
            this.nIENKHOATextEdit.MenuManager = this.barManagerTool;
            this.nIENKHOATextEdit.Name = "nIENKHOATextEdit";
            this.nIENKHOATextEdit.Size = new System.Drawing.Size(142, 20);
            this.nIENKHOATextEdit.TabIndex = 2;
            // 
            // hOCKYLabel
            // 
            hOCKYLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            hOCKYLabel.AutoSize = true;
            hOCKYLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            hOCKYLabel.Location = new System.Drawing.Point(251, 385);
            hOCKYLabel.Name = "hOCKYLabel";
            hOCKYLabel.Size = new System.Drawing.Size(45, 13);
            hOCKYLabel.TabIndex = 3;
            hOCKYLabel.Text = "Học kỳ";
            // 
            // hOCKYSpinEdit
            // 
            this.hOCKYSpinEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.hOCKYSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.fKHOCPHISINHVIENBindingSource, "HOCKY", true));
            this.hOCKYSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.hOCKYSpinEdit.Location = new System.Drawing.Point(302, 382);
            this.hOCKYSpinEdit.MenuManager = this.barManagerTool;
            this.hOCKYSpinEdit.Name = "hOCKYSpinEdit";
            this.hOCKYSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.hOCKYSpinEdit.Properties.IsFloatValue = false;
            this.hOCKYSpinEdit.Properties.Mask.EditMask = "N00";
            this.hOCKYSpinEdit.Size = new System.Drawing.Size(167, 20);
            this.hOCKYSpinEdit.TabIndex = 4;
            // 
            // hOCPHILabel
            // 
            hOCPHILabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            hOCPHILabel.AutoSize = true;
            hOCPHILabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            hOCPHILabel.Location = new System.Drawing.Point(495, 385);
            hOCPHILabel.Name = "hOCPHILabel";
            hOCPHILabel.Size = new System.Drawing.Size(48, 13);
            hOCPHILabel.TabIndex = 5;
            hOCPHILabel.Text = "Học phí";
            // 
            // hOCPHISpinEdit
            // 
            this.hOCPHISpinEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.hOCPHISpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.fKHOCPHISINHVIENBindingSource, "HOCPHI", true));
            this.hOCPHISpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.hOCPHISpinEdit.Location = new System.Drawing.Point(549, 382);
            this.hOCPHISpinEdit.MenuManager = this.barManagerTool;
            this.hOCPHISpinEdit.Name = "hOCPHISpinEdit";
            this.hOCPHISpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.hOCPHISpinEdit.Properties.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.hOCPHISpinEdit.Properties.IsFloatValue = false;
            this.hOCPHISpinEdit.Properties.Mask.EditMask = "N00";
            this.hOCPHISpinEdit.Size = new System.Drawing.Size(166, 20);
            this.hOCPHISpinEdit.TabIndex = 6;
            // 
            // sOTIENDADONGLabel
            // 
            sOTIENDADONGLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            sOTIENDADONGLabel.AutoSize = true;
            sOTIENDADONGLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            sOTIENDADONGLabel.Location = new System.Drawing.Point(742, 385);
            sOTIENDADONGLabel.Name = "sOTIENDADONGLabel";
            sOTIENDADONGLabel.Size = new System.Drawing.Size(94, 13);
            sOTIENDADONGLabel.TabIndex = 7;
            sOTIENDADONGLabel.Text = "Số tiền đã đóng";
            // 
            // sOTIENDADONGSpinEdit
            // 
            this.sOTIENDADONGSpinEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sOTIENDADONGSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.fKHOCPHISINHVIENBindingSource, "SOTIENDADONG", true));
            this.sOTIENDADONGSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.sOTIENDADONGSpinEdit.Location = new System.Drawing.Point(842, 382);
            this.sOTIENDADONGSpinEdit.MenuManager = this.barManagerTool;
            this.sOTIENDADONGSpinEdit.Name = "sOTIENDADONGSpinEdit";
            this.sOTIENDADONGSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sOTIENDADONGSpinEdit.Properties.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.sOTIENDADONGSpinEdit.Properties.IsFloatValue = false;
            this.sOTIENDADONGSpinEdit.Properties.Mask.EditMask = "N00";
            this.sOTIENDADONGSpinEdit.Size = new System.Drawing.Size(166, 20);
            this.sOTIENDADONGSpinEdit.TabIndex = 8;
            // 
            // btnCancelAddHocPhi
            // 
            this.btnCancelAddHocPhi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelAddHocPhi.Location = new System.Drawing.Point(1138, 380);
            this.btnCancelAddHocPhi.Name = "btnCancelAddHocPhi";
            this.btnCancelAddHocPhi.Size = new System.Drawing.Size(75, 23);
            this.btnCancelAddHocPhi.TabIndex = 9;
            this.btnCancelAddHocPhi.Text = "Hủy";
            this.btnCancelAddHocPhi.UseVisualStyleBackColor = true;
            this.btnCancelAddHocPhi.Visible = false;
            this.btnCancelAddHocPhi.Click += new System.EventHandler(this.btnCancelAddHocPhi_Click);
            // 
            // btnEditHocPhiOK
            // 
            this.btnEditHocPhiOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditHocPhiOK.Location = new System.Drawing.Point(1090, 380);
            this.btnEditHocPhiOK.Name = "btnEditHocPhiOK";
            this.btnEditHocPhiOK.Size = new System.Drawing.Size(75, 23);
            this.btnEditHocPhiOK.TabIndex = 10;
            this.btnEditHocPhiOK.Text = "OK";
            this.btnEditHocPhiOK.UseVisualStyleBackColor = true;
            this.btnEditHocPhiOK.Click += new System.EventHandler(this.btnEditHocPhiOK_Click);
            // 
            // btnAddHocPhi
            // 
            this.btnAddHocPhi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddHocPhi.Location = new System.Drawing.Point(1040, 380);
            this.btnAddHocPhi.Name = "btnAddHocPhi";
            this.btnAddHocPhi.Size = new System.Drawing.Size(75, 23);
            this.btnAddHocPhi.TabIndex = 11;
            this.btnAddHocPhi.Text = "Thêm";
            this.btnAddHocPhi.UseVisualStyleBackColor = true;
            this.btnAddHocPhi.Visible = false;
            this.btnAddHocPhi.Click += new System.EventHandler(this.btnAddHocPhi_Click);
            // 
            // UserControlHocPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "UserControlHocPhi";
            this.Size = new System.Drawing.Size(1330, 573);
            ((System.ComponentModel.ISupportInitialize)(this.barManagerTool)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVHocPhiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKHOCPHISINHVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCPHIGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHocPhi)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelHocPhi.ResumeLayout(false);
            this.panelHocPhi.PerformLayout();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nIENKHOATextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCKYSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCPHISpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOTIENDADONGSpinEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManagerTool;
        private DevExpress.XtraBars.Bar toolBar;
        private DevExpress.XtraBars.BarButtonItem barBtnAddHocPhi;
        private DevExpress.XtraBars.BarButtonItem barBtnDeleteHocPhi;
        private DevExpress.XtraBars.BarButtonItem barBtnRefresh;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl hOCPHIGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewHocPhi;
        private DevExpress.XtraGrid.Columns.GridColumn colNIENKHOA;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCKY;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCPHI;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIENDADONG;
        private DevExpress.XtraBars.BarButtonItem barBtnUpload;
        private QLDSVHocPhiDataSet qLDSVHocPhiDataSet;
        private System.Windows.Forms.BindingSource sINHVIENBindingSource;
        private System.Windows.Forms.BindingSource fKHOCPHISINHVIENBindingSource;
        private QLDSVHocPhiDataSetTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private QLDSVHocPhiDataSetTableAdapters.HOCPHITableAdapter hOCPHITableAdapter;
        private QLDSVHocPhiDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Button btnMaSVSearch;
        private System.Windows.Forms.TextBox textBoxMaSV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelMaSV;
        private System.Windows.Forms.Label labelHoTen;
        private System.Windows.Forms.Label labelMaLop;
        private System.Windows.Forms.Panel panelHocPhi;
        private DevExpress.XtraEditors.SpinEdit sOTIENDADONGSpinEdit;
        private DevExpress.XtraEditors.SpinEdit hOCPHISpinEdit;
        private DevExpress.XtraEditors.SpinEdit hOCKYSpinEdit;
        private DevExpress.XtraEditors.TextEdit nIENKHOATextEdit;
        private System.Windows.Forms.Button btnCancelAddHocPhi;
        private System.Windows.Forms.Button btnEditHocPhiOK;
        private System.Windows.Forms.Button btnAddHocPhi;
    }
}
