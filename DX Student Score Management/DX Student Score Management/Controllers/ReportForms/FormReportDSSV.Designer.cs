namespace DX_Student_Score_Management.Controllers.ReportForms
{
    partial class FormReportDSSV
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
            this.btnPrintDSSV = new System.Windows.Forms.Button();
            this.mALOPLabel = new System.Windows.Forms.Label();
            this.qLDSVKhoaDataSet = new DX_Student_Score_Management.QLDSVKhoaDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.lOPComboBox = new System.Windows.Forms.ComboBox();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lOPTableAdapter = new DX_Student_Score_Management.QLDSVKhoaDataSetTableAdapters.LOPTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVKhoaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrintDSSV
            // 
            this.btnPrintDSSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintDSSV.Location = new System.Drawing.Point(180, 264);
            this.btnPrintDSSV.Name = "btnPrintDSSV";
            this.btnPrintDSSV.Size = new System.Drawing.Size(116, 35);
            this.btnPrintDSSV.TabIndex = 10;
            this.btnPrintDSSV.Text = "In danh sách";
            this.btnPrintDSSV.UseVisualStyleBackColor = true;
            this.btnPrintDSSV.Click += new System.EventHandler(this.btnPrintDSSV_Click);
            // 
            // mALOPLabel
            // 
            this.mALOPLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mALOPLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOPBindingSource, "MALOP", true));
            this.mALOPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mALOPLabel.ForeColor = System.Drawing.Color.Red;
            this.mALOPLabel.Location = new System.Drawing.Point(86, 187);
            this.mALOPLabel.Name = "mALOPLabel";
            this.mALOPLabel.Size = new System.Drawing.Size(332, 23);
            this.mALOPLabel.TabIndex = 9;
            // 
            // qLDSVKhoaDataSet
            // 
            this.qLDSVKhoaDataSet.DataSetName = "QLDSVKhoaDataSet";
            this.qLDSVKhoaDataSet.EnforceConstraints = false;
            this.qLDSVKhoaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Lớp";
            // 
            // lOPComboBox
            // 
            this.lOPComboBox.DataSource = this.lOPBindingSource;
            this.lOPComboBox.DisplayMember = "TENLOP";
            this.lOPComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lOPComboBox.FormattingEnabled = true;
            this.lOPComboBox.Location = new System.Drawing.Point(89, 140);
            this.lOPComboBox.Name = "lOPComboBox";
            this.lOPComboBox.Size = new System.Drawing.Size(329, 28);
            this.lOPComboBox.TabIndex = 7;
            this.lOPComboBox.ValueMember = "MALOP";
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            this.lOPBindingSource.DataSource = this.qLDSVKhoaDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 62);
            this.label1.TabIndex = 6;
            this.label1.Text = "IN DANH SÁCH \r\nSINH VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // FormReportDSSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 366);
            this.Controls.Add(this.btnPrintDSSV);
            this.Controls.Add(this.mALOPLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lOPComboBox);
            this.Controls.Add(this.label1);
            this.Name = "FormReportDSSV";
            this.Text = "FormReportDSSV";
            this.Load += new System.EventHandler(this.FormReportDSSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVKhoaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrintDSSV;
        private System.Windows.Forms.Label mALOPLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox lOPComboBox;
        private System.Windows.Forms.Label label1;
        private QLDSVKhoaDataSet qLDSVKhoaDataSet;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private QLDSVKhoaDataSetTableAdapters.LOPTableAdapter lOPTableAdapter;
    }
}