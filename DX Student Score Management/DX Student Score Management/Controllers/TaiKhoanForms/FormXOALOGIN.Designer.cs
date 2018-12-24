namespace DX_Student_Score_Management.Controllers.TaiKhoanForms
{
    partial class FormXOALOGIN
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
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxKemTheo = new System.Windows.Forms.CheckBox();
            this.labelGV = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label1.MaximumSize = new System.Drawing.Size(399, 46);
            this.label1.MinimumSize = new System.Drawing.Size(399, 46);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.label1.Size = new System.Drawing.Size(399, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xóa Tài khoản";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBoxKemTheo
            // 
            this.checkBoxKemTheo.AutoSize = true;
            this.checkBoxKemTheo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxKemTheo.ForeColor = System.Drawing.Color.Red;
            this.checkBoxKemTheo.Location = new System.Drawing.Point(60, 120);
            this.checkBoxKemTheo.Margin = new System.Windows.Forms.Padding(60, 3, 3, 3);
            this.checkBoxKemTheo.Name = "checkBoxKemTheo";
            this.checkBoxKemTheo.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.checkBoxKemTheo.Size = new System.Drawing.Size(185, 32);
            this.checkBoxKemTheo.TabIndex = 1;
            this.checkBoxKemTheo.Text = "Xóa giảng viên của tài khoản này";
            this.checkBoxKemTheo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxKemTheo.UseVisualStyleBackColor = true;
            this.checkBoxKemTheo.CheckedChanged += new System.EventHandler(this.checkBoxKemTheo_CheckedChanged);
            // 
            // labelGV
            // 
            this.labelGV.AutoSize = true;
            this.labelGV.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGV.Location = new System.Drawing.Point(0, 71);
            this.labelGV.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.labelGV.MaximumSize = new System.Drawing.Size(399, 90);
            this.labelGV.MinimumSize = new System.Drawing.Size(399, 46);
            this.labelGV.Name = "labelGV";
            this.labelGV.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.labelGV.Size = new System.Drawing.Size(399, 46);
            this.labelGV.TabIndex = 0;
            this.labelGV.Text = "Bạn có muốn xóa login của";
            this.labelGV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.labelGV);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxKemTheo);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 25, 0, 25);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(388, 282);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(50, 158);
            this.panel1.Margin = new System.Windows.Forms.Padding(50, 3, 3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 51);
            this.panel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkRed;
            this.button1.Location = new System.Drawing.Point(35, 3);
            this.button1.Margin = new System.Windows.Forms.Padding(125, 3, 3, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "XÓA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(149, 3);
            this.button2.Margin = new System.Windows.Forms.Padding(125, 3, 3, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "HỦY";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormXOALOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 282);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "FormXOALOGIN";
            this.Text = "FormXOALOGIN";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxKemTheo;
        private System.Windows.Forms.Label labelGV;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}