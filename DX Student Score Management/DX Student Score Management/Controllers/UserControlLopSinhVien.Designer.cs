namespace DX_Student_Score_Management.Controllers
{
    partial class UserControlLopSinhVien
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
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label tENLOPLabel;
            System.Windows.Forms.Label mAKHLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlLopSinhVien));
            this.toolBar = new DevExpress.XtraBars.Bar();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.qLDSVKhoaDataSet = new DX_Student_Score_Management.QLDSVKhoaDataSet();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTableAdapter = new DX_Student_Score_Management.QLDSVKhoaDataSetTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new DX_Student_Score_Management.QLDSVKhoaDataSetTableAdapters.TableAdapterManager();
            this.panelSubContainer = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.mAKHTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tENLOPTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.mALOPTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.barMenuLop = new DevExpress.XtraBars.BarSubItem();
            this.barBtnAddLop = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnDeleteLop = new DevExpress.XtraBars.BarButtonItem();
            this.barMenuSinhVien = new DevExpress.XtraBars.BarSubItem();
            this.barBtnAddSinhVien = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnDeleteSinhVien = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.panelLopForm = new System.Windows.Forms.Panel();
            this.kHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kHOATableAdapter = new DX_Student_Score_Management.QLDSVKhoaDataSetTableAdapters.KHOATableAdapter();
            this.kHOAComboBox = new System.Windows.Forms.ComboBox();
            mALOPLabel = new System.Windows.Forms.Label();
            tENLOPLabel = new System.Windows.Forms.Label();
            mAKHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVKhoaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAKHTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENLOPTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mALOPTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.panelLopForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Location = new System.Drawing.Point(112, 14);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(42, 13);
            mALOPLabel.TabIndex = 0;
            mALOPLabel.Text = "Mã lớp:";
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Location = new System.Drawing.Point(562, 14);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(46, 13);
            tENLOPLabel.TabIndex = 2;
            tENLOPLabel.Text = "Tên lớp:";
            // 
            // mAKHLabel
            // 
            mAKHLabel.AutoSize = true;
            mAKHLabel.Location = new System.Drawing.Point(331, 14);
            mAKHLabel.Name = "mAKHLabel";
            mAKHLabel.Size = new System.Drawing.Size(51, 13);
            mAKHLabel.TabIndex = 4;
            mAKHLabel.Text = "Mã khoa:";
            // 
            // toolBar
            // 
            this.toolBar.BarName = "Main menu";
            this.toolBar.DockCol = 0;
            this.toolBar.DockRow = 0;
            this.toolBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.toolBar.FloatLocation = new System.Drawing.Point(358, 119);
            this.toolBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem3, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barMenuLop, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barMenuSinhVien, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.toolBar.OptionsBar.MultiLine = true;
            this.toolBar.OptionsBar.UseWholeRow = true;
            this.toolBar.Text = "Main menu";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Refresh";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.Name = "barButtonItem3";
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
            this.barButtonItem3,
            this.barMenuLop,
            this.barBtnAddLop,
            this.barBtnDeleteLop,
            this.barMenuSinhVien,
            this.barBtnAddSinhVien,
            this.barBtnDeleteSinhVien,
            this.barButtonItem1});
            this.barManager1.MainMenu = this.toolBar;
            this.barManager1.MaxItemId = 10;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1256, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 645);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1256, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 605);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1256, 40);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 605);
            // 
            // qLDSVKhoaDataSet
            // 
            this.qLDSVKhoaDataSet.DataSetName = "QLDSVKhoaDataSet";
            this.qLDSVKhoaDataSet.EnforceConstraints = false;
            this.qLDSVKhoaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            this.lOPBindingSource.DataSource = this.qLDSVKhoaDataSet;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DIEMTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.HOCPHITableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = this.lOPTableAdapter;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DX_Student_Score_Management.QLDSVKhoaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // panelSubContainer
            // 
            this.panelSubContainer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelSubContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSubContainer.Location = new System.Drawing.Point(0, 0);
            this.panelSubContainer.Name = "panelSubContainer";
            this.panelSubContainer.Size = new System.Drawing.Size(1256, 237);
            this.panelSubContainer.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(17, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Thông tin lớp";
            // 
            // mAKHTextEdit
            // 
            this.mAKHTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lOPBindingSource, "MAKH", true));
            this.mAKHTextEdit.Location = new System.Drawing.Point(388, 11);
            this.mAKHTextEdit.MenuManager = this.barManager1;
            this.mAKHTextEdit.Name = "mAKHTextEdit";
            this.mAKHTextEdit.Size = new System.Drawing.Size(142, 20);
            this.mAKHTextEdit.TabIndex = 5;
            // 
            // tENLOPTextEdit
            // 
            this.tENLOPTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lOPBindingSource, "TENLOP", true));
            this.tENLOPTextEdit.Location = new System.Drawing.Point(617, 11);
            this.tENLOPTextEdit.MenuManager = this.barManager1;
            this.tENLOPTextEdit.Name = "tENLOPTextEdit";
            this.tENLOPTextEdit.Size = new System.Drawing.Size(351, 20);
            this.tENLOPTextEdit.TabIndex = 3;
            // 
            // mALOPTextEdit
            // 
            this.mALOPTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lOPBindingSource, "MALOP", true));
            this.mALOPTextEdit.Location = new System.Drawing.Point(160, 11);
            this.mALOPTextEdit.MenuManager = this.barManager1;
            this.mALOPTextEdit.Name = "mALOPTextEdit";
            this.mALOPTextEdit.Size = new System.Drawing.Size(142, 20);
            this.mALOPTextEdit.TabIndex = 1;
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
            this.splitContainer.Panel1.Controls.Add(this.kHOAComboBox);
            this.splitContainer.Panel1.Controls.Add(this.panelLopForm);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.panelSubContainer);
            this.splitContainer.Size = new System.Drawing.Size(1256, 605);
            this.splitContainer.SplitterDistance = 364;
            this.splitContainer.TabIndex = 20;
            // 
            // barMenuLop
            // 
            this.barMenuLop.Caption = "Lớp";
            this.barMenuLop.Id = 3;
            this.barMenuLop.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barMenuLop.ImageOptions.Image")));
            this.barMenuLop.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnAddLop, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnDeleteLop, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.barMenuLop.Name = "barMenuLop";
            // 
            // barBtnAddLop
            // 
            this.barBtnAddLop.Caption = "Thêm lớp";
            this.barBtnAddLop.Id = 4;
            this.barBtnAddLop.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnAddLop.ImageOptions.Image")));
            this.barBtnAddLop.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnAddLop.ImageOptions.LargeImage")));
            this.barBtnAddLop.Name = "barBtnAddLop";
            // 
            // barBtnDeleteLop
            // 
            this.barBtnDeleteLop.Caption = "Xóa Lớp";
            this.barBtnDeleteLop.Id = 5;
            this.barBtnDeleteLop.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnDeleteLop.ImageOptions.Image")));
            this.barBtnDeleteLop.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnDeleteLop.ImageOptions.LargeImage")));
            this.barBtnDeleteLop.Name = "barBtnDeleteLop";
            // 
            // barMenuSinhVien
            // 
            this.barMenuSinhVien.Caption = "Sinh viên";
            this.barMenuSinhVien.Enabled = false;
            this.barMenuSinhVien.Id = 6;
            this.barMenuSinhVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barMenuSinhVien.ImageOptions.Image")));
            this.barMenuSinhVien.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnAddSinhVien),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnDeleteSinhVien)});
            this.barMenuSinhVien.Name = "barMenuSinhVien";
            // 
            // barBtnAddSinhVien
            // 
            this.barBtnAddSinhVien.Caption = "Thêm Sinh viên";
            this.barBtnAddSinhVien.Id = 7;
            this.barBtnAddSinhVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnAddSinhVien.ImageOptions.Image")));
            this.barBtnAddSinhVien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnAddSinhVien.ImageOptions.LargeImage")));
            this.barBtnAddSinhVien.Name = "barBtnAddSinhVien";
            // 
            // barBtnDeleteSinhVien
            // 
            this.barBtnDeleteSinhVien.Caption = "Xóa Sinh viên";
            this.barBtnDeleteSinhVien.Id = 8;
            this.barBtnDeleteSinhVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnDeleteSinhVien.ImageOptions.Image")));
            this.barBtnDeleteSinhVien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnDeleteSinhVien.ImageOptions.LargeImage")));
            this.barBtnDeleteSinhVien.Name = "barBtnDeleteSinhVien";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Upload";
            this.barButtonItem1.Id = 9;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // panelLopForm
            // 
            this.panelLopForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLopForm.Controls.Add(this.label1);
            this.panelLopForm.Controls.Add(mAKHLabel);
            this.panelLopForm.Controls.Add(this.mALOPTextEdit);
            this.panelLopForm.Controls.Add(this.mAKHTextEdit);
            this.panelLopForm.Controls.Add(mALOPLabel);
            this.panelLopForm.Controls.Add(tENLOPLabel);
            this.panelLopForm.Controls.Add(this.tENLOPTextEdit);
            this.panelLopForm.Location = new System.Drawing.Point(3, 320);
            this.panelLopForm.Name = "panelLopForm";
            this.panelLopForm.Size = new System.Drawing.Size(1250, 41);
            this.panelLopForm.TabIndex = 6;
            // 
            // kHOABindingSource
            // 
            this.kHOABindingSource.DataMember = "KHOA";
            this.kHOABindingSource.DataSource = this.qLDSVKhoaDataSet;
            // 
            // kHOATableAdapter
            // 
            this.kHOATableAdapter.ClearBeforeFill = true;
            // 
            // kHOAComboBox
            // 
            this.kHOAComboBox.DataSource = this.kHOABindingSource;
            this.kHOAComboBox.DisplayMember = "TENKH";
            this.kHOAComboBox.FormattingEnabled = true;
            this.kHOAComboBox.Location = new System.Drawing.Point(5, 5);
            this.kHOAComboBox.Name = "kHOAComboBox";
            this.kHOAComboBox.Size = new System.Drawing.Size(300, 21);
            this.kHOAComboBox.TabIndex = 6;
            this.kHOAComboBox.ValueMember = "MAKH";
            // 
            // UserControlLopSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "UserControlLopSinhVien";
            this.Size = new System.Drawing.Size(1256, 645);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVKhoaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAKHTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENLOPTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mALOPTextEdit.Properties)).EndInit();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.panelLopForm.ResumeLayout(false);
            this.panelLopForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Bar toolBar;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private QLDSVKhoaDataSet qLDSVKhoaDataSet;
        private QLDSVKhoaDataSetTableAdapters.LOPTableAdapter lOPTableAdapter;
        private QLDSVKhoaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panelSubContainer;
        private DevExpress.XtraEditors.TextEdit mAKHTextEdit;
        private DevExpress.XtraEditors.TextEdit tENLOPTextEdit;
        private DevExpress.XtraEditors.TextEdit mALOPTextEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer;
        private DevExpress.XtraBars.BarSubItem barMenuLop;
        private DevExpress.XtraBars.BarButtonItem barBtnAddLop;
        private DevExpress.XtraBars.BarButtonItem barBtnDeleteLop;
        private DevExpress.XtraBars.BarSubItem barMenuSinhVien;
        private DevExpress.XtraBars.BarButtonItem barBtnAddSinhVien;
        private DevExpress.XtraBars.BarButtonItem barBtnDeleteSinhVien;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private System.Windows.Forms.Panel panelLopForm;
        private System.Windows.Forms.ComboBox kHOAComboBox;
        private System.Windows.Forms.BindingSource kHOABindingSource;
        private QLDSVKhoaDataSetTableAdapters.KHOATableAdapter kHOATableAdapter;
    }
}
