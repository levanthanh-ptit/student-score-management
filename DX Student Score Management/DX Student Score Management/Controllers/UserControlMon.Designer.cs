namespace DX_Student_Score_Management.Controllers
{
    partial class UserControlMon
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
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label tENMHLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlMon));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.toolBar = new DevExpress.XtraBars.Bar();
            this.barBtnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnUpload = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnAddMonHoc = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnDeleteMonHoc = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.MONHOCGridControl = new DevExpress.XtraGrid.GridControl();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSVKhoaDataSet = new DX_Student_Score_Management.QLDSVKhoaDataSet();
            this.gridViewMon = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxTTMon = new System.Windows.Forms.GroupBox();
            this.btnCancelAddMonHoc = new System.Windows.Forms.Button();
            this.btnEditMonHocOK = new System.Windows.Forms.Button();
            this.btnAddMonHoc = new System.Windows.Forms.Button();
            this.mAMHTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tENMHTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.mONHOCTableAdapter = new DX_Student_Score_Management.QLDSVKhoaDataSetTableAdapters.MONHOCTableAdapter();
            this.tableAdapterManager = new DX_Student_Score_Management.QLDSVKhoaDataSetTableAdapters.TableAdapterManager();
            mAMHLabel = new System.Windows.Forms.Label();
            tENMHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MONHOCGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVKhoaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMon)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBoxTTMon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mAMHTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENMHTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(44, 28);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(75, 13);
            mAMHLabel.TabIndex = 0;
            mAMHLabel.Text = "Mã môn học";
            // 
            // tENMHLabel
            // 
            tENMHLabel.AutoSize = true;
            tENMHLabel.Location = new System.Drawing.Point(40, 64);
            tENMHLabel.Name = "tENMHLabel";
            tENMHLabel.Size = new System.Drawing.Size(79, 13);
            tENMHLabel.TabIndex = 2;
            tENMHLabel.Text = "Tên môn học";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.toolBar});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barBtnAddMonHoc,
            this.barBtnDeleteMonHoc,
            this.barBtnRefresh,
            this.barBtnUpload});
            this.barManager1.MainMenu = this.toolBar;
            this.barManager1.MaxItemId = 4;
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnAddMonHoc, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnDeleteMonHoc, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
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
            // barBtnAddMonHoc
            // 
            this.barBtnAddMonHoc.Caption = "Add";
            this.barBtnAddMonHoc.Id = 0;
            this.barBtnAddMonHoc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnAddMonHoc.ImageOptions.Image")));
            this.barBtnAddMonHoc.Name = "barBtnAddMonHoc";
            this.barBtnAddMonHoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnAddMonHoc_ItemClick);
            // 
            // barBtnDeleteMonHoc
            // 
            this.barBtnDeleteMonHoc.Caption = "Delete";
            this.barBtnDeleteMonHoc.Id = 1;
            this.barBtnDeleteMonHoc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnDeleteMonHoc.ImageOptions.Image")));
            this.barBtnDeleteMonHoc.Name = "barBtnDeleteMonHoc";
            this.barBtnDeleteMonHoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnDeleteMonHoc_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1270, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 575);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1270, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 535);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1270, 40);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 535);
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 40);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.AutoScroll = true;
            this.splitContainer.Panel1.Controls.Add(this.MONHOCGridControl);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.panel1);
            this.splitContainer.Size = new System.Drawing.Size(1270, 535);
            this.splitContainer.SplitterDistance = 341;
            this.splitContainer.TabIndex = 4;
            // 
            // MONHOCGridControl
            // 
            this.MONHOCGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MONHOCGridControl.DataSource = this.mONHOCBindingSource;
            this.MONHOCGridControl.Location = new System.Drawing.Point(3, 6);
            this.MONHOCGridControl.MainView = this.gridViewMon;
            this.MONHOCGridControl.MenuManager = this.barManager1;
            this.MONHOCGridControl.Name = "MONHOCGridControl";
            this.MONHOCGridControl.ShowOnlyPredefinedDetails = true;
            this.MONHOCGridControl.Size = new System.Drawing.Size(1264, 332);
            this.MONHOCGridControl.TabIndex = 0;
            this.MONHOCGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMon});
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.qLDSVKhoaDataSet;
            // 
            // qLDSVKhoaDataSet
            // 
            this.qLDSVKhoaDataSet.DataSetName = "QLDSVKhoaDataSet";
            this.qLDSVKhoaDataSet.EnforceConstraints = false;
            this.qLDSVKhoaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewMon
            // 
            this.gridViewMon.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAMH,
            this.colTENMH});
            this.gridViewMon.GridControl = this.MONHOCGridControl;
            this.gridViewMon.Name = "gridViewMon";
            this.gridViewMon.OptionsView.ShowGroupPanel = false;
            // 
            // colMAMH
            // 
            this.colMAMH.Caption = "Mã môn học";
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 0;
            // 
            // colTENMH
            // 
            this.colTENMH.Caption = "Tên Môn học";
            this.colTENMH.FieldName = "TENMH";
            this.colTENMH.Name = "colTENMH";
            this.colTENMH.Visible = true;
            this.colTENMH.VisibleIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBoxTTMon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1270, 190);
            this.panel1.TabIndex = 0;
            // 
            // groupBoxTTMon
            // 
            this.groupBoxTTMon.Controls.Add(this.btnCancelAddMonHoc);
            this.groupBoxTTMon.Controls.Add(this.btnEditMonHocOK);
            this.groupBoxTTMon.Controls.Add(this.btnAddMonHoc);
            this.groupBoxTTMon.Controls.Add(mAMHLabel);
            this.groupBoxTTMon.Controls.Add(tENMHLabel);
            this.groupBoxTTMon.Controls.Add(this.mAMHTextEdit);
            this.groupBoxTTMon.Controls.Add(this.tENMHTextEdit);
            this.groupBoxTTMon.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBoxTTMon.Location = new System.Drawing.Point(13, 13);
            this.groupBoxTTMon.Name = "groupBoxTTMon";
            this.groupBoxTTMon.Size = new System.Drawing.Size(342, 157);
            this.groupBoxTTMon.TabIndex = 4;
            this.groupBoxTTMon.TabStop = false;
            this.groupBoxTTMon.Text = "Thông tin Môn học";
            // 
            // btnCancelAddMonHoc
            // 
            this.btnCancelAddMonHoc.Location = new System.Drawing.Point(168, 108);
            this.btnCancelAddMonHoc.Name = "btnCancelAddMonHoc";
            this.btnCancelAddMonHoc.Size = new System.Drawing.Size(75, 23);
            this.btnCancelAddMonHoc.TabIndex = 4;
            this.btnCancelAddMonHoc.Text = "Hủy";
            this.btnCancelAddMonHoc.UseVisualStyleBackColor = true;
            this.btnCancelAddMonHoc.Visible = false;
            this.btnCancelAddMonHoc.Click += new System.EventHandler(this.btnCancelAddMonHoc_Click);
            // 
            // btnEditMonHocOK
            // 
            this.btnEditMonHocOK.Location = new System.Drawing.Point(125, 108);
            this.btnEditMonHocOK.Name = "btnEditMonHocOK";
            this.btnEditMonHocOK.Size = new System.Drawing.Size(75, 23);
            this.btnEditMonHocOK.TabIndex = 4;
            this.btnEditMonHocOK.Text = "OK";
            this.btnEditMonHocOK.UseVisualStyleBackColor = true;
            this.btnEditMonHocOK.Click += new System.EventHandler(this.btnEditMonHocOK_Click);
            // 
            // btnAddMonHoc
            // 
            this.btnAddMonHoc.Location = new System.Drawing.Point(71, 108);
            this.btnAddMonHoc.Name = "btnAddMonHoc";
            this.btnAddMonHoc.Size = new System.Drawing.Size(75, 23);
            this.btnAddMonHoc.TabIndex = 4;
            this.btnAddMonHoc.Text = "Thêm";
            this.btnAddMonHoc.UseVisualStyleBackColor = true;
            this.btnAddMonHoc.Visible = false;
            this.btnAddMonHoc.Click += new System.EventHandler(this.btnAddMonHoc_Click);
            // 
            // mAMHTextEdit
            // 
            this.mAMHTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mONHOCBindingSource, "MAMH", true));
            this.mAMHTextEdit.Location = new System.Drawing.Point(128, 25);
            this.mAMHTextEdit.MenuManager = this.barManager1;
            this.mAMHTextEdit.Name = "mAMHTextEdit";
            this.mAMHTextEdit.Size = new System.Drawing.Size(181, 20);
            this.mAMHTextEdit.TabIndex = 1;
            // 
            // tENMHTextEdit
            // 
            this.tENMHTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mONHOCBindingSource, "TENMH", true));
            this.tENMHTextEdit.Location = new System.Drawing.Point(128, 61);
            this.tENMHTextEdit.MenuManager = this.barManager1;
            this.tENMHTextEdit.Name = "tENMHTextEdit";
            this.tENMHTextEdit.Size = new System.Drawing.Size(181, 20);
            this.tENMHTextEdit.TabIndex = 3;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DIEMTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.HOCPHITableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = this.mONHOCTableAdapter;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DX_Student_Score_Management.QLDSVKhoaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // UserControlMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "UserControlMon";
            this.Size = new System.Drawing.Size(1270, 575);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MONHOCGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVKhoaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBoxTTMon.ResumeLayout(false);
            this.groupBoxTTMon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mAMHTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENMHTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar toolBar;
        private DevExpress.XtraBars.BarButtonItem barBtnAddMonHoc;
        private DevExpress.XtraBars.BarButtonItem barBtnDeleteMonHoc;
        private DevExpress.XtraBars.BarButtonItem barBtnRefresh;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private QLDSVKhoaDataSet qLDSVKhoaDataSet;
        private QLDSVKhoaDataSetTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private QLDSVKhoaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl MONHOCGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMon;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.TextEdit tENMHTextEdit;
        private DevExpress.XtraEditors.TextEdit mAMHTextEdit;
        private System.Windows.Forms.GroupBox groupBoxTTMon;
        private DevExpress.XtraBars.BarButtonItem barBtnUpload;
        private System.Windows.Forms.Button btnCancelAddMonHoc;
        private System.Windows.Forms.Button btnEditMonHocOK;
        private System.Windows.Forms.Button btnAddMonHoc;
    }
}
