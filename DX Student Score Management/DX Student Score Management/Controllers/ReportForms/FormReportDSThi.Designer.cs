namespace DX_Student_Score_Management.Controllers.ReportForms
{
    partial class FormReportDSThi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sP_List_LOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSVKhoaDataSet = new DX_Student_Score_Management.QLDSVKhoaDataSet();
            this.sP_List_LOPComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MonHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelLop = new System.Windows.Forms.Label();
            this.mONHOCComboBox = new System.Windows.Forms.ComboBox();
            this.labelMonHoc = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.spinEdit1 = new DevExpress.XtraEditors.SpinEdit();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sP_List_LOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVKhoaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonHocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "In danh sách thi hết môn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Môn học";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(426, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Lần thi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày thi";
            // 
            // sP_List_LOPBindingSource
            // 
            this.sP_List_LOPBindingSource.DataMember = "SP_List_LOP";
            this.sP_List_LOPBindingSource.DataSource = this.qLDSVKhoaDataSet;
            // 
            // qLDSVKhoaDataSet
            // 
            this.qLDSVKhoaDataSet.DataSetName = "QLDSVKhoaDataSet";
            this.qLDSVKhoaDataSet.EnforceConstraints = false;
            this.qLDSVKhoaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sP_List_LOPComboBox
            // 
            this.sP_List_LOPComboBox.DataSource = this.sP_List_LOPBindingSource;
            this.sP_List_LOPComboBox.DisplayMember = "TENLOP";
            this.sP_List_LOPComboBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sP_List_LOPComboBox.FormattingEnabled = true;
            this.sP_List_LOPComboBox.Location = new System.Drawing.Point(83, 101);
            this.sP_List_LOPComboBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.sP_List_LOPComboBox.Name = "sP_List_LOPComboBox";
            this.sP_List_LOPComboBox.Size = new System.Drawing.Size(429, 27);
            this.sP_List_LOPComboBox.TabIndex = 11;
            this.sP_List_LOPComboBox.ValueMember = "MALOP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Lớp";
            // 
            // MonHocBindingSource
            // 
            this.MonHocBindingSource.DataMember = "MONHOC";
            this.MonHocBindingSource.DataSource = this.qLDSVKhoaDataSet;
            // 
            // labelLop
            // 
            this.labelLop.AutoSize = true;
            this.labelLop.BackColor = System.Drawing.Color.White;
            this.labelLop.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sP_List_LOPBindingSource, "MALOP", true));
            this.labelLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLop.Location = new System.Drawing.Point(518, 107);
            this.labelLop.Name = "labelLop";
            this.labelLop.Size = new System.Drawing.Size(51, 20);
            this.labelLop.TabIndex = 12;
            this.labelLop.Text = "label7";
            // 
            // mONHOCComboBox
            // 
            this.mONHOCComboBox.DataSource = this.MonHocBindingSource;
            this.mONHOCComboBox.DisplayMember = "TENMH";
            this.mONHOCComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mONHOCComboBox.FormattingEnabled = true;
            this.mONHOCComboBox.Location = new System.Drawing.Point(118, 161);
            this.mONHOCComboBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.mONHOCComboBox.Name = "mONHOCComboBox";
            this.mONHOCComboBox.Size = new System.Drawing.Size(394, 28);
            this.mONHOCComboBox.TabIndex = 12;
            this.mONHOCComboBox.ValueMember = "MAMH";
            // 
            // labelMonHoc
            // 
            this.labelMonHoc.AutoSize = true;
            this.labelMonHoc.BackColor = System.Drawing.Color.White;
            this.labelMonHoc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.MonHocBindingSource, "MAMH", true));
            this.labelMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonHoc.Location = new System.Drawing.Point(518, 164);
            this.labelMonHoc.Name = "labelMonHoc";
            this.labelMonHoc.Size = new System.Drawing.Size(51, 20);
            this.labelMonHoc.TabIndex = 12;
            this.labelMonHoc.Text = "label7";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(114, 222);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(244, 26);
            this.dateTimePicker.TabIndex = 13;
            // 
            // spinEdit1
            // 
            this.spinEdit1.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEdit1.Location = new System.Drawing.Point(489, 225);
            this.spinEdit1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.spinEdit1.Name = "spinEdit1";
            this.spinEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.spinEdit1.Properties.Appearance.Options.UseFont = true;
            this.spinEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEdit1.Properties.MaxValue = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.spinEdit1.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEdit1.Size = new System.Drawing.Size(92, 26);
            this.spinEdit1.TabIndex = 14;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(297, 291);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(169, 45);
            this.btnPrint.TabIndex = 15;
            this.btnPrint.Text = "IN DANH SÁCH";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // FormReportDSThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 367);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.spinEdit1);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.mONHOCComboBox);
            this.Controls.Add(this.labelMonHoc);
            this.Controls.Add(this.labelLop);
            this.Controls.Add(this.sP_List_LOPComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormReportDSThi";
            this.Text = "FormDSThi";
            this.Load += new System.EventHandler(this.FormDSThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sP_List_LOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVKhoaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonHocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource sP_List_LOPBindingSource;
        private QLDSVKhoaDataSet qLDSVKhoaDataSet;
        private System.Windows.Forms.ComboBox sP_List_LOPComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource MonHocBindingSource;
        private System.Windows.Forms.Label labelLop;
        private System.Windows.Forms.ComboBox mONHOCComboBox;
        private System.Windows.Forms.Label labelMonHoc;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private DevExpress.XtraEditors.SpinEdit spinEdit1;
        private System.Windows.Forms.Button btnPrint;
    }
}