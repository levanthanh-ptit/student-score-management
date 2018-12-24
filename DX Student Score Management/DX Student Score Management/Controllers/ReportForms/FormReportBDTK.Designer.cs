namespace DX_Student_Score_Management.Controllers.ReportForms
{
    partial class FormReportBDTK
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
            this.button1 = new System.Windows.Forms.Button();
            this.sP_List_LOPComboBox = new System.Windows.Forms.ComboBox();
            this.ListLOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSVKhoaDataSet = new DX_Student_Score_Management.QLDSVKhoaDataSet();
            this.btnPrintBDTK = new System.Windows.Forms.Button();
            this.mALOPLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sP_List_LOPTableAdapter = new DX_Student_Score_Management.QLDSVKhoaDataSetTableAdapters.SP_List_LOPTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ListLOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVKhoaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(438, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 22);
            this.button1.TabIndex = 18;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // sP_List_LOPComboBox
            // 
            this.sP_List_LOPComboBox.DataSource = this.ListLOPBindingSource;
            this.sP_List_LOPComboBox.DisplayMember = "TENLOP";
            this.sP_List_LOPComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sP_List_LOPComboBox.FormattingEnabled = true;
            this.sP_List_LOPComboBox.Location = new System.Drawing.Point(103, 145);
            this.sP_List_LOPComboBox.Name = "sP_List_LOPComboBox";
            this.sP_List_LOPComboBox.Size = new System.Drawing.Size(329, 21);
            this.sP_List_LOPComboBox.TabIndex = 17;
            this.sP_List_LOPComboBox.ValueMember = "MALOP";
            // 
            // ListLOPBindingSource
            // 
            this.ListLOPBindingSource.DataMember = "SP_List_LOP";
            this.ListLOPBindingSource.DataSource = this.qLDSVKhoaDataSet;
            // 
            // qLDSVKhoaDataSet
            // 
            this.qLDSVKhoaDataSet.DataSetName = "QLDSVKhoaDataSet";
            this.qLDSVKhoaDataSet.EnforceConstraints = false;
            this.qLDSVKhoaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnPrintBDTK
            // 
            this.btnPrintBDTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintBDTK.Location = new System.Drawing.Point(206, 267);
            this.btnPrintBDTK.Name = "btnPrintBDTK";
            this.btnPrintBDTK.Size = new System.Drawing.Size(116, 35);
            this.btnPrintBDTK.TabIndex = 16;
            this.btnPrintBDTK.Text = "In danh sách";
            this.btnPrintBDTK.UseVisualStyleBackColor = true;
            this.btnPrintBDTK.Click += new System.EventHandler(this.btnPrintBDTK_Click);
            // 
            // mALOPLabel
            // 
            this.mALOPLabel.BackColor = System.Drawing.Color.White;
            this.mALOPLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ListLOPBindingSource, "MALOP", true));
            this.mALOPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mALOPLabel.ForeColor = System.Drawing.Color.Red;
            this.mALOPLabel.Location = new System.Drawing.Point(100, 187);
            this.mALOPLabel.Name = "mALOPLabel";
            this.mALOPLabel.Size = new System.Drawing.Size(332, 23);
            this.mALOPLabel.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Lớp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "IN BẢNG ĐIỂM TỔNG KẾT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sP_List_LOPTableAdapter
            // 
            this.sP_List_LOPTableAdapter.ClearBeforeFill = true;
            // 
            // FormReportBDTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 351);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sP_List_LOPComboBox);
            this.Controls.Add(this.btnPrintBDTK);
            this.Controls.Add(this.mALOPLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormReportBDTK";
            this.Text = "FormReportBDTK";
            ((System.ComponentModel.ISupportInitialize)(this.ListLOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVKhoaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox sP_List_LOPComboBox;
        private System.Windows.Forms.Button btnPrintBDTK;
        private System.Windows.Forms.Label mALOPLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource ListLOPBindingSource;
        private QLDSVKhoaDataSet qLDSVKhoaDataSet;
        private QLDSVKhoaDataSetTableAdapters.SP_List_LOPTableAdapter sP_List_LOPTableAdapter;
    }
}