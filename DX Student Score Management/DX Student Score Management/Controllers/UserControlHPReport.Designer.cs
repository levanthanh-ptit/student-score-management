namespace DX_Student_Score_Management.Controllers
{
    partial class UserControlHPReport
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
            this.sP_List_LOPComboBox = new System.Windows.Forms.ComboBox();
            this.sPListLOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSVHocPhiDataSet = new DX_Student_Score_Management.QLDSVHocPhiDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelLop = new System.Windows.Forms.Label();
            this.sP_List_LOPTableAdapter = new DX_Student_Score_Management.QLDSVHocPhiDataSetTableAdapters.SP_List_LOPTableAdapter();
            this.sP_List_NIENKHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_List_NIENKHOATableAdapter = new DX_Student_Score_Management.QLDSVHocPhiDataSetTableAdapters.SP_List_NIENKHOATableAdapter();
            this.tableAdapterManager = new DX_Student_Score_Management.QLDSVHocPhiDataSetTableAdapters.TableAdapterManager();
            this.NIENKHOAComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.spinEditHK = new DevExpress.XtraEditors.SpinEdit();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sPListLOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVHocPhiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_List_NIENKHOABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditHK.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sP_List_LOPComboBox
            // 
            this.sP_List_LOPComboBox.DataSource = this.sPListLOPBindingSource;
            this.sP_List_LOPComboBox.DisplayMember = "TENLOP";
            this.sP_List_LOPComboBox.Font = new System.Drawing.Font("Tahoma", 12F);
            this.sP_List_LOPComboBox.FormattingEnabled = true;
            this.sP_List_LOPComboBox.Location = new System.Drawing.Point(101, 119);
            this.sP_List_LOPComboBox.Name = "sP_List_LOPComboBox";
            this.sP_List_LOPComboBox.Size = new System.Drawing.Size(496, 27);
            this.sP_List_LOPComboBox.TabIndex = 2;
            this.sP_List_LOPComboBox.ValueMember = "MALOP";
            // 
            // sPListLOPBindingSource
            // 
            this.sPListLOPBindingSource.DataMember = "SP_List_LOP";
            this.sPListLOPBindingSource.DataSource = this.qLDSVHocPhiDataSet;
            // 
            // qLDSVHocPhiDataSet
            // 
            this.qLDSVHocPhiDataSet.DataSetName = "QLDSVHocPhiDataSet";
            this.qLDSVHocPhiDataSet.EnforceConstraints = false;
            this.qLDSVHocPhiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25F);
            this.label1.Location = new System.Drawing.Point(172, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "IN DANH SÁCH HỌC PHÍ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.Location = new System.Drawing.Point(49, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lớp: ";
            // 
            // labelLop
            // 
            this.labelLop.AutoSize = true;
            this.labelLop.BackColor = System.Drawing.Color.White;
            this.labelLop.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sPListLOPBindingSource, "MALOP", true));
            this.labelLop.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelLop.Location = new System.Drawing.Point(613, 122);
            this.labelLop.Name = "labelLop";
            this.labelLop.Size = new System.Drawing.Size(51, 19);
            this.labelLop.TabIndex = 3;
            this.labelLop.Text = "label1";
            // 
            // sP_List_LOPTableAdapter
            // 
            this.sP_List_LOPTableAdapter.ClearBeforeFill = true;
            // 
            // sP_List_NIENKHOABindingSource
            // 
            this.sP_List_NIENKHOABindingSource.DataMember = "SP_List_NIENKHOA";
            this.sP_List_NIENKHOABindingSource.DataSource = this.qLDSVHocPhiDataSet;
            // 
            // sP_List_NIENKHOATableAdapter
            // 
            this.sP_List_NIENKHOATableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.HOCPHITableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DX_Student_Score_Management.QLDSVHocPhiDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // NIENKHOAComboBox
            // 
            this.NIENKHOAComboBox.DataSource = this.sP_List_NIENKHOABindingSource;
            this.NIENKHOAComboBox.DisplayMember = "NIENKHOA";
            this.NIENKHOAComboBox.Font = new System.Drawing.Font("Tahoma", 12F);
            this.NIENKHOAComboBox.FormattingEnabled = true;
            this.NIENKHOAComboBox.Location = new System.Drawing.Point(146, 174);
            this.NIENKHOAComboBox.Name = "NIENKHOAComboBox";
            this.NIENKHOAComboBox.Size = new System.Drawing.Size(189, 27);
            this.NIENKHOAComboBox.TabIndex = 4;
            this.NIENKHOAComboBox.ValueMember = "NIENKHOA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.Location = new System.Drawing.Point(49, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Niên khóa: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label4.Location = new System.Drawing.Point(402, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Học kỳ: ";
            // 
            // spinEditHK
            // 
            this.spinEditHK.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEditHK.Location = new System.Drawing.Point(483, 174);
            this.spinEditHK.Name = "spinEditHK";
            this.spinEditHK.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.spinEditHK.Properties.Appearance.Options.UseFont = true;
            this.spinEditHK.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditHK.Properties.MaxValue = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.spinEditHK.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEditHK.Size = new System.Drawing.Size(114, 26);
            this.spinEditHK.TabIndex = 5;
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnPrint.Location = new System.Drawing.Point(306, 274);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(164, 55);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Text = "IN HỌC PHÍ";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // UserControlHPReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.spinEditHK);
            this.Controls.Add(this.NIENKHOAComboBox);
            this.Controls.Add(this.labelLop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sP_List_LOPComboBox);
            this.Name = "UserControlHPReport";
            this.Size = new System.Drawing.Size(797, 400);
            ((System.ComponentModel.ISupportInitialize)(this.sPListLOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVHocPhiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_List_NIENKHOABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditHK.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox sP_List_LOPComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelLop;
        private System.Windows.Forms.BindingSource sPListLOPBindingSource;
        private QLDSVHocPhiDataSet qLDSVHocPhiDataSet;
        private QLDSVHocPhiDataSetTableAdapters.SP_List_LOPTableAdapter sP_List_LOPTableAdapter;
        private System.Windows.Forms.BindingSource sP_List_NIENKHOABindingSource;
        private QLDSVHocPhiDataSetTableAdapters.SP_List_NIENKHOATableAdapter sP_List_NIENKHOATableAdapter;
        private QLDSVHocPhiDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox NIENKHOAComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SpinEdit spinEditHK;
        private System.Windows.Forms.Button btnPrint;
    }
}
