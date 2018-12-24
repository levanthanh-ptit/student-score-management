namespace DX_Student_Score_Management.Controllers.ReportForms
{
    partial class FormReportBDMH
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
            this.btnPrint = new System.Windows.Forms.Button();
            this.spinEditLan = new DevExpress.XtraEditors.SpinEdit();
            this.mONHOCComboBox = new System.Windows.Forms.ComboBox();
            this.MONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSVKhoaDataSet = new DX_Student_Score_Management.QLDSVKhoaDataSet();
            this.labelMonHoc = new System.Windows.Forms.Label();
            this.labelLop = new System.Windows.Forms.Label();
            this.sPListLOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_List_LOPComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.spinEditHK = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditLan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVKhoaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPListLOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditHK.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(228, 331);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(169, 45);
            this.btnPrint.TabIndex = 24;
            this.btnPrint.Text = "IN DANH SÁCH";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // spinEditLan
            // 
            this.spinEditLan.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEditLan.Location = new System.Drawing.Point(332, 259);
            this.spinEditLan.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.spinEditLan.Name = "spinEditLan";
            this.spinEditLan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.spinEditLan.Properties.Appearance.Options.UseFont = true;
            this.spinEditLan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditLan.Properties.MaxValue = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.spinEditLan.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEditLan.Size = new System.Drawing.Size(92, 26);
            this.spinEditLan.TabIndex = 23;
            // 
            // mONHOCComboBox
            // 
            this.mONHOCComboBox.DataSource = this.MONHOCBindingSource;
            this.mONHOCComboBox.DisplayMember = "TENMH";
            this.mONHOCComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mONHOCComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mONHOCComboBox.FormattingEnabled = true;
            this.mONHOCComboBox.Location = new System.Drawing.Point(124, 198);
            this.mONHOCComboBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.mONHOCComboBox.Name = "mONHOCComboBox";
            this.mONHOCComboBox.Size = new System.Drawing.Size(300, 28);
            this.mONHOCComboBox.TabIndex = 20;
            this.mONHOCComboBox.ValueMember = "MAMH";
            // 
            // MONHOCBindingSource
            // 
            this.MONHOCBindingSource.DataMember = "MONHOC";
            this.MONHOCBindingSource.DataSource = this.qLDSVKhoaDataSet;
            // 
            // qLDSVKhoaDataSet
            // 
            this.qLDSVKhoaDataSet.DataSetName = "QLDSVKhoaDataSet";
            this.qLDSVKhoaDataSet.EnforceConstraints = false;
            this.qLDSVKhoaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelMonHoc
            // 
            this.labelMonHoc.AutoSize = true;
            this.labelMonHoc.BackColor = System.Drawing.Color.White;
            this.labelMonHoc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.MONHOCBindingSource, "MAMH", true));
            this.labelMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonHoc.Location = new System.Drawing.Point(453, 198);
            this.labelMonHoc.Name = "labelMonHoc";
            this.labelMonHoc.Size = new System.Drawing.Size(51, 20);
            this.labelMonHoc.TabIndex = 21;
            this.labelMonHoc.Text = "label7";
            // 
            // labelLop
            // 
            this.labelLop.AutoSize = true;
            this.labelLop.BackColor = System.Drawing.Color.White;
            this.labelLop.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sPListLOPBindingSource, "MALOP", true));
            this.labelLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLop.Location = new System.Drawing.Point(453, 141);
            this.labelLop.Name = "labelLop";
            this.labelLop.Size = new System.Drawing.Size(51, 20);
            this.labelLop.TabIndex = 22;
            this.labelLop.Text = "label7";
            // 
            // sPListLOPBindingSource
            // 
            this.sPListLOPBindingSource.DataMember = "SP_List_LOP";
            this.sPListLOPBindingSource.DataSource = this.qLDSVKhoaDataSet;
            // 
            // sP_List_LOPComboBox
            // 
            this.sP_List_LOPComboBox.DataSource = this.sPListLOPBindingSource;
            this.sP_List_LOPComboBox.DisplayMember = "TENLOP";
            this.sP_List_LOPComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sP_List_LOPComboBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sP_List_LOPComboBox.FormattingEnabled = true;
            this.sP_List_LOPComboBox.Location = new System.Drawing.Point(89, 138);
            this.sP_List_LOPComboBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.sP_List_LOPComboBox.Name = "sP_List_LOPComboBox";
            this.sP_List_LOPComboBox.Size = new System.Drawing.Size(335, 27);
            this.sP_List_LOPComboBox.TabIndex = 19;
            this.sP_List_LOPComboBox.ValueMember = "MALOP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(269, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Lần thi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 19);
            this.label6.TabIndex = 17;
            this.label6.Text = "Lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Môn học";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 39);
            this.label1.TabIndex = 16;
            this.label1.Text = "IN BẢNG ĐIỂM MÔN HỌC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Học kỳ";
            // 
            // spinEditHK
            // 
            this.spinEditHK.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEditHK.Location = new System.Drawing.Point(111, 259);
            this.spinEditHK.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
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
            this.spinEditHK.Size = new System.Drawing.Size(92, 26);
            this.spinEditHK.TabIndex = 23;
            // 
            // FormReportBDMH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 414);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.spinEditHK);
            this.Controls.Add(this.spinEditLan);
            this.Controls.Add(this.mONHOCComboBox);
            this.Controls.Add(this.labelMonHoc);
            this.Controls.Add(this.labelLop);
            this.Controls.Add(this.sP_List_LOPComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Name = "FormReportBDMH";
            this.Text = "FormReportBDMH";
            this.Load += new System.EventHandler(this.FormReportBDMH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spinEditLan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVKhoaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPListLOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditHK.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrint;
        private DevExpress.XtraEditors.SpinEdit spinEditLan;
        private System.Windows.Forms.ComboBox mONHOCComboBox;
        private QLDSVKhoaDataSet qLDSVKhoaDataSet;
        private System.Windows.Forms.Label labelMonHoc;
        private System.Windows.Forms.Label labelLop;
        private System.Windows.Forms.BindingSource sPListLOPBindingSource;
        private System.Windows.Forms.ComboBox sP_List_LOPComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource MONHOCBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SpinEdit spinEditHK;
    }
}