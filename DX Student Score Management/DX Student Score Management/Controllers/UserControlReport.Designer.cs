namespace DX_Student_Score_Management.Controllers
{
    partial class UserControlReport
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
            this.flowLayoutPanelMain = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDSSV = new System.Windows.Forms.Button();
            this.btnDSTHM = new System.Windows.Forms.Button();
            this.btnPrintBDMH = new System.Windows.Forms.Button();
            this.btnPrintBDTK = new System.Windows.Forms.Button();
            this.flowLayoutPanelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelMain
            // 
            this.flowLayoutPanelMain.Controls.Add(this.btnDSSV);
            this.flowLayoutPanelMain.Controls.Add(this.btnDSTHM);
            this.flowLayoutPanelMain.Controls.Add(this.btnPrintBDMH);
            this.flowLayoutPanelMain.Controls.Add(this.btnPrintBDTK);
            this.flowLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelMain.Name = "flowLayoutPanelMain";
            this.flowLayoutPanelMain.Padding = new System.Windows.Forms.Padding(50);
            this.flowLayoutPanelMain.Size = new System.Drawing.Size(1101, 515);
            this.flowLayoutPanelMain.TabIndex = 0;
            // 
            // btnDSSV
            // 
            this.btnDSSV.Font = new System.Drawing.Font("Tahoma", 15F);
            this.btnDSSV.Location = new System.Drawing.Point(70, 70);
            this.btnDSSV.Margin = new System.Windows.Forms.Padding(20);
            this.btnDSSV.Name = "btnDSSV";
            this.btnDSSV.Size = new System.Drawing.Size(261, 68);
            this.btnDSSV.TabIndex = 0;
            this.btnDSSV.Text = "In danh sách sinh viên";
            this.btnDSSV.UseVisualStyleBackColor = true;
            this.btnDSSV.Click += new System.EventHandler(this.btnDSSV_Click);
            // 
            // btnDSTHM
            // 
            this.btnDSTHM.Font = new System.Drawing.Font("Tahoma", 15F);
            this.btnDSTHM.Location = new System.Drawing.Point(371, 70);
            this.btnDSTHM.Margin = new System.Windows.Forms.Padding(20);
            this.btnDSTHM.Name = "btnDSTHM";
            this.btnDSTHM.Size = new System.Drawing.Size(261, 68);
            this.btnDSTHM.TabIndex = 1;
            this.btnDSTHM.Text = "In danh sách thi hết môn";
            this.btnDSTHM.UseVisualStyleBackColor = true;
            this.btnDSTHM.Click += new System.EventHandler(this.btnDSTHM_Click);
            // 
            // btnPrintBDMH
            // 
            this.btnPrintBDMH.Font = new System.Drawing.Font("Tahoma", 15F);
            this.btnPrintBDMH.Location = new System.Drawing.Point(672, 70);
            this.btnPrintBDMH.Margin = new System.Windows.Forms.Padding(20);
            this.btnPrintBDMH.Name = "btnPrintBDMH";
            this.btnPrintBDMH.Size = new System.Drawing.Size(261, 68);
            this.btnPrintBDMH.TabIndex = 1;
            this.btnPrintBDMH.Text = "In bảng điểm môn học";
            this.btnPrintBDMH.UseVisualStyleBackColor = true;
            this.btnPrintBDMH.Click += new System.EventHandler(this.btnPrintBDMH_Click);
            // 
            // btnPrintBDTK
            // 
            this.btnPrintBDTK.Font = new System.Drawing.Font("Tahoma", 15F);
            this.btnPrintBDTK.Location = new System.Drawing.Point(70, 178);
            this.btnPrintBDTK.Margin = new System.Windows.Forms.Padding(20);
            this.btnPrintBDTK.Name = "btnPrintBDTK";
            this.btnPrintBDTK.Size = new System.Drawing.Size(261, 68);
            this.btnPrintBDTK.TabIndex = 1;
            this.btnPrintBDTK.Text = "In bảng điểm tổng kết";
            this.btnPrintBDTK.UseVisualStyleBackColor = true;
            this.btnPrintBDTK.Click += new System.EventHandler(this.btnPrintBDTK_Click);
            // 
            // UserControlReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanelMain);
            this.Name = "UserControlReport";
            this.Size = new System.Drawing.Size(1101, 515);
            this.flowLayoutPanelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMain;
        private System.Windows.Forms.Button btnDSSV;
        private System.Windows.Forms.Button btnDSTHM;
        private System.Windows.Forms.Button btnPrintBDMH;
        private System.Windows.Forms.Button btnPrintBDTK;
    }
}
