﻿namespace DX_Student_Score_Management.Controllers
{
    partial class UserControlDiem
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
            System.Windows.Forms.Label label6;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlDiem));
            this.barManagerTool = new DevExpress.XtraBars.BarManager(this.components);
            this.toolBar = new DevExpress.XtraBars.Bar();
            this.barBtnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnUpload = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.labelColapse = new System.Windows.Forms.Label();
            this.btnGetFilter = new System.Windows.Forms.Button();
            this.lOPComboBox = new System.Windows.Forms.ComboBox();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSVKhoaDataSet = new DX_Student_Score_Management.QLDSVKhoaDataSet();
            this.textEditLan = new DevExpress.XtraEditors.TextEdit();
            this.labelMaLop = new System.Windows.Forms.Label();
            this.labelMaMonHoc = new System.Windows.Forms.Label();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mONHOCComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dIEMGridControl = new DevExpress.XtraGrid.GridControl();
            this.dIEMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIEM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mONHOCTableAdapter = new DX_Student_Score_Management.QLDSVKhoaDataSetTableAdapters.MONHOCTableAdapter();
            this.tableAdapterManager = new DX_Student_Score_Management.QLDSVKhoaDataSetTableAdapters.TableAdapterManager();
            this.lOPTableAdapter = new DX_Student_Score_Management.QLDSVKhoaDataSetTableAdapters.LOPTableAdapter();
            this.sINHVIENTableAdapter = new DX_Student_Score_Management.QLDSVKhoaDataSetTableAdapters.SINHVIENTableAdapter();
            this.fKSINHVIENLOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dIEMTableAdapter = new DX_Student_Score_Management.QLDSVKhoaDataSetTableAdapters.DIEMTableAdapter();
            this.panelMain = new System.Windows.Forms.Panel();
            mAMHLabel = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerTool)).BeginInit();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVKhoaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditLan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIEMGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIEMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKSINHVIENLOPBindingSource)).BeginInit();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Font = new System.Drawing.Font("Tahoma", 10F);
            mAMHLabel.Location = new System.Drawing.Point(569, 80);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(82, 17);
            mAMHLabel.TabIndex = 5;
            mAMHLabel.Text = "Mã Môn học";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Tahoma", 10F);
            label6.Location = new System.Drawing.Point(569, 43);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(52, 17);
            label6.TabIndex = 5;
            label6.Text = "Mã Lớp";
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
            this.toolBar.FloatLocation = new System.Drawing.Point(-22, 101);
            this.toolBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnRefresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnUpload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
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
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManagerTool;
            this.barDockControlTop.Size = new System.Drawing.Size(1217, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 612);
            this.barDockControlBottom.Manager = this.barManagerTool;
            this.barDockControlBottom.Size = new System.Drawing.Size(1217, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManagerTool;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 572);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1217, 40);
            this.barDockControlRight.Manager = this.barManagerTool;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 572);
            // 
            // panelInfo
            // 
            this.panelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInfo.Controls.Add(this.labelColapse);
            this.panelInfo.Controls.Add(this.btnGetFilter);
            this.panelInfo.Controls.Add(this.lOPComboBox);
            this.panelInfo.Controls.Add(this.textEditLan);
            this.panelInfo.Controls.Add(label6);
            this.panelInfo.Controls.Add(this.labelMaLop);
            this.panelInfo.Controls.Add(mAMHLabel);
            this.panelInfo.Controls.Add(this.labelMaMonHoc);
            this.panelInfo.Controls.Add(this.mONHOCComboBox);
            this.panelInfo.Controls.Add(this.label2);
            this.panelInfo.Controls.Add(this.label3);
            this.panelInfo.Controls.Add(this.label4);
            this.panelInfo.Controls.Add(this.label1);
            this.panelInfo.Location = new System.Drawing.Point(10, 10);
            this.panelInfo.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(1197, 155);
            this.panelInfo.TabIndex = 0;
            // 
            // labelColapse
            // 
            this.labelColapse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelColapse.AutoSize = true;
            this.labelColapse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelColapse.Location = new System.Drawing.Point(1136, 134);
            this.labelColapse.MaximumSize = new System.Drawing.Size(60, 20);
            this.labelColapse.MinimumSize = new System.Drawing.Size(60, 20);
            this.labelColapse.Name = "labelColapse";
            this.labelColapse.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelColapse.Size = new System.Drawing.Size(60, 20);
            this.labelColapse.TabIndex = 9;
            this.labelColapse.Text = "Colapse";
            this.labelColapse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelColapse.Click += new System.EventHandler(this.labelColapse_Click);
            // 
            // btnGetFilter
            // 
            this.btnGetFilter.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnGetFilter.Location = new System.Drawing.Point(527, 114);
            this.btnGetFilter.Name = "btnGetFilter";
            this.btnGetFilter.Size = new System.Drawing.Size(123, 28);
            this.btnGetFilter.TabIndex = 8;
            this.btnGetFilter.Text = "Lọc danh sách";
            this.btnGetFilter.UseVisualStyleBackColor = true;
            this.btnGetFilter.Click += new System.EventHandler(this.btnGetFilter_Click);
            // 
            // lOPComboBox
            // 
            this.lOPComboBox.DataSource = this.lOPBindingSource;
            this.lOPComboBox.DisplayMember = "TENLOP";
            this.lOPComboBox.FormattingEnabled = true;
            this.lOPComboBox.Location = new System.Drawing.Point(192, 42);
            this.lOPComboBox.Name = "lOPComboBox";
            this.lOPComboBox.Size = new System.Drawing.Size(354, 21);
            this.lOPComboBox.TabIndex = 7;
            this.lOPComboBox.ValueMember = "MALOP";
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            this.lOPBindingSource.DataSource = this.qLDSVKhoaDataSet;
            // 
            // qLDSVKhoaDataSet
            // 
            this.qLDSVKhoaDataSet.DataSetName = "QLDSVKhoaDataSet";
            this.qLDSVKhoaDataSet.EnforceConstraints = false;
            this.qLDSVKhoaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textEditLan
            // 
            this.textEditLan.EditValue = "1";
            this.textEditLan.Location = new System.Drawing.Point(879, 77);
            this.textEditLan.MenuManager = this.barManagerTool;
            this.textEditLan.Name = "textEditLan";
            this.textEditLan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.textEditLan.Properties.Appearance.Options.UseFont = true;
            this.textEditLan.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textEditLan.Size = new System.Drawing.Size(100, 22);
            this.textEditLan.TabIndex = 7;
            // 
            // labelMaLop
            // 
            this.labelMaLop.BackColor = System.Drawing.Color.White;
            this.labelMaLop.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOPBindingSource, "MALOP", true));
            this.labelMaLop.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelMaLop.Location = new System.Drawing.Point(657, 40);
            this.labelMaLop.Margin = new System.Windows.Forms.Padding(3, 0, 20, 0);
            this.labelMaLop.Name = "labelMaLop";
            this.labelMaLop.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelMaLop.Size = new System.Drawing.Size(132, 23);
            this.labelMaLop.TabIndex = 6;
            this.labelMaLop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMaMonHoc
            // 
            this.labelMaMonHoc.BackColor = System.Drawing.Color.White;
            this.labelMaMonHoc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mONHOCBindingSource, "MAMH", true));
            this.labelMaMonHoc.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelMaMonHoc.Location = new System.Drawing.Point(657, 77);
            this.labelMaMonHoc.Margin = new System.Windows.Forms.Padding(3, 0, 20, 0);
            this.labelMaMonHoc.Name = "labelMaMonHoc";
            this.labelMaMonHoc.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelMaMonHoc.Size = new System.Drawing.Size(132, 23);
            this.labelMaMonHoc.TabIndex = 6;
            this.labelMaMonHoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.qLDSVKhoaDataSet;
            // 
            // mONHOCComboBox
            // 
            this.mONHOCComboBox.DataSource = this.mONHOCBindingSource;
            this.mONHOCComboBox.DisplayMember = "TENMH";
            this.mONHOCComboBox.FormattingEnabled = true;
            this.mONHOCComboBox.Location = new System.Drawing.Point(192, 79);
            this.mONHOCComboBox.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.mONHOCComboBox.Name = "mONHOCComboBox";
            this.mONHOCComboBox.Size = new System.Drawing.Size(354, 21);
            this.mONHOCComboBox.TabIndex = 4;
            this.mONHOCComboBox.ValueMember = "MAMH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.Location = new System.Drawing.Point(824, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lần thi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(510, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Thông tin chung";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.Location = new System.Drawing.Point(125, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Lớp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(125, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Môn học";
            // 
            // dIEMGridControl
            // 
            this.dIEMGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dIEMGridControl.DataSource = this.dIEMBindingSource;
            this.dIEMGridControl.Location = new System.Drawing.Point(10, 60);
            this.dIEMGridControl.MainView = this.gridView1;
            this.dIEMGridControl.Margin = new System.Windows.Forms.Padding(0);
            this.dIEMGridControl.MenuManager = this.barManagerTool;
            this.dIEMGridControl.MinimumSize = new System.Drawing.Size(50, 50);
            this.dIEMGridControl.Name = "dIEMGridControl";
            this.dIEMGridControl.Size = new System.Drawing.Size(1197, 478);
            this.dIEMGridControl.TabIndex = 1;
            this.dIEMGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.dIEMGridControl.Visible = false;
            // 
            // dIEMBindingSource
            // 
            this.dIEMBindingSource.DataMember = "DIEM";
            this.dIEMBindingSource.DataSource = this.qLDSVKhoaDataSet;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASV,
            this.colMAMH,
            this.colLAN,
            this.colDIEM});
            this.gridView1.GridControl = this.dIEMGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMASV
            // 
            this.colMASV.FieldName = "MASV";
            this.colMASV.Name = "colMASV";
            this.colMASV.OptionsColumn.AllowEdit = false;
            this.colMASV.Visible = true;
            this.colMASV.VisibleIndex = 0;
            // 
            // colMAMH
            // 
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.OptionsColumn.AllowEdit = false;
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 1;
            // 
            // colLAN
            // 
            this.colLAN.FieldName = "LAN";
            this.colLAN.Name = "colLAN";
            this.colLAN.OptionsColumn.AllowEdit = false;
            this.colLAN.Visible = true;
            this.colLAN.VisibleIndex = 2;
            // 
            // colDIEM
            // 
            this.colDIEM.FieldName = "DIEM";
            this.colDIEM.Name = "colDIEM";
            this.colDIEM.Visible = true;
            this.colDIEM.VisibleIndex = 3;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DIEMTableAdapter = this.dIEMTableAdapter;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.HOCPHITableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = this.lOPTableAdapter;
            this.tableAdapterManager.MONHOCTableAdapter = this.mONHOCTableAdapter;
            this.tableAdapterManager.SINHVIENTableAdapter = this.sINHVIENTableAdapter;
            this.tableAdapterManager.UpdateOrder = DX_Student_Score_Management.QLDSVKhoaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // fKSINHVIENLOPBindingSource
            // 
            this.fKSINHVIENLOPBindingSource.DataMember = "FK_SINHVIEN_LOP";
            this.fKSINHVIENLOPBindingSource.DataSource = this.lOPBindingSource;
            // 
            // dIEMTableAdapter
            // 
            this.dIEMTableAdapter.ClearBeforeFill = true;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelInfo);
            this.panelMain.Controls.Add(this.dIEMGridControl);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 40);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(10);
            this.panelMain.Size = new System.Drawing.Size(1217, 572);
            this.panelMain.TabIndex = 14;
            // 
            // UserControlDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "UserControlDiem";
            this.Size = new System.Drawing.Size(1217, 612);
            ((System.ComponentModel.ISupportInitialize)(this.barManagerTool)).EndInit();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVKhoaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditLan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIEMGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIEMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKSINHVIENLOPBindingSource)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManagerTool;
        private DevExpress.XtraBars.Bar toolBar;
        private DevExpress.XtraBars.BarButtonItem barBtnRefresh;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barBtnUpload;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private QLDSVKhoaDataSet qLDSVKhoaDataSet;
        private QLDSVKhoaDataSetTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private QLDSVKhoaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label labelMaMonHoc;
        private System.Windows.Forms.ComboBox mONHOCComboBox;
        private DevExpress.XtraEditors.TextEdit textEditLan;
        private System.Windows.Forms.ComboBox lOPComboBox;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private System.Windows.Forms.Label labelMaLop;
        private System.Windows.Forms.Label label4;
        private QLDSVKhoaDataSetTableAdapters.LOPTableAdapter lOPTableAdapter;
        private System.Windows.Forms.Button btnGetFilter;
        private QLDSVKhoaDataSetTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private System.Windows.Forms.BindingSource fKSINHVIENLOPBindingSource;
        private DevExpress.XtraGrid.GridControl dIEMGridControl;
        private System.Windows.Forms.BindingSource dIEMBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private QLDSVKhoaDataSetTableAdapters.DIEMTableAdapter dIEMTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colLAN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIEM;
        private System.Windows.Forms.Label labelColapse;
        private System.Windows.Forms.Panel panelMain;
    }
}
