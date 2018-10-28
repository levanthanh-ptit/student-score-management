namespace DX_Student_Score_Management
{
    partial class FormLogin
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
            this.qLDSVDataSetMaster = new DX_Student_Score_Management.QLDSVDataSetMaster();
            this.v_DSPMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_DSPMTableAdapter = new DX_Student_Score_Management.QLDSVDataSetMasterTableAdapters.V_DSPMTableAdapter();
            this.tableAdapterManager = new DX_Student_Score_Management.QLDSVDataSetMasterTableAdapters.TableAdapterManager();
            this.v_DSPMBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.v_DSPMBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.loginServerListComboBox = new System.Windows.Forms.ComboBox();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginUserTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.loginPasswordTextBox = new System.Windows.Forms.TextBox();
            this.loginLoginButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSetMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DSPMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DSPMBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DSPMBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // qLDSVDataSetMaster
            // 
            this.qLDSVDataSetMaster.DataSetName = "QLDSVDataSetMaster";
            this.qLDSVDataSetMaster.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_DSPMBindingSource
            // 
            this.v_DSPMBindingSource.DataMember = "V_DSPM";
            this.v_DSPMBindingSource.DataSource = this.qLDSVDataSetMaster;
            // 
            // v_DSPMTableAdapter
            // 
            this.v_DSPMTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = DX_Student_Score_Management.QLDSVDataSetMasterTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // v_DSPMBindingSource1
            // 
            this.v_DSPMBindingSource1.DataMember = "V_DSPM";
            this.v_DSPMBindingSource1.DataSource = this.qLDSVDataSetMaster;
            // 
            // v_DSPMBindingSource2
            // 
            this.v_DSPMBindingSource2.DataMember = "V_DSPM";
            this.v_DSPMBindingSource2.DataSource = this.qLDSVDataSetMaster;
            // 
            // loginServerListComboBox
            // 
            this.loginServerListComboBox.DataSource = this.v_DSPMBindingSource2;
            this.loginServerListComboBox.DisplayMember = "description";
            this.loginServerListComboBox.FormattingEnabled = true;
            this.loginServerListComboBox.Location = new System.Drawing.Point(115, 41);
            this.loginServerListComboBox.Name = "loginServerListComboBox";
            this.loginServerListComboBox.Size = new System.Drawing.Size(222, 21);
            this.loginServerListComboBox.TabIndex = 0;
            this.loginServerListComboBox.ValueMember = "subscriber_server";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(41, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Phòng ban";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(74, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "User";
            // 
            // loginUserTextBox
            // 
            this.loginUserTextBox.Location = new System.Drawing.Point(115, 89);
            this.loginUserTextBox.Name = "loginUserTextBox";
            this.loginUserTextBox.Size = new System.Drawing.Size(222, 21);
            this.loginUserTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(50, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // loginPasswordTextBox
            // 
            this.loginPasswordTextBox.Location = new System.Drawing.Point(115, 116);
            this.loginPasswordTextBox.Name = "loginPasswordTextBox";
            this.loginPasswordTextBox.Size = new System.Drawing.Size(222, 21);
            this.loginPasswordTextBox.TabIndex = 3;
            this.loginPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // loginLoginButton
            // 
            this.loginLoginButton.Location = new System.Drawing.Point(169, 163);
            this.loginLoginButton.Name = "loginLoginButton";
            this.loginLoginButton.Size = new System.Drawing.Size(65, 30);
            this.loginLoginButton.TabIndex = 4;
            this.loginLoginButton.Text = "LOGIN";
            this.loginLoginButton.UseVisualStyleBackColor = true;
            this.loginLoginButton.Click += new System.EventHandler(this.loginLoginButton_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 216);
            this.Controls.Add(this.loginLoginButton);
            this.Controls.Add(this.loginPasswordTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.loginUserTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginServerListComboBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(417, 277);
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSetMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DSPMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DSPMBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DSPMBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QLDSVDataSetMaster qLDSVDataSetMaster;
        private System.Windows.Forms.BindingSource v_DSPMBindingSource;
        private QLDSVDataSetMasterTableAdapters.V_DSPMTableAdapter v_DSPMTableAdapter;
        private QLDSVDataSetMasterTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource v_DSPMBindingSource1;
        private System.Windows.Forms.BindingSource v_DSPMBindingSource2;
        private System.Windows.Forms.ComboBox loginServerListComboBox;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox loginUserTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox loginPasswordTextBox;
        private System.Windows.Forms.Button loginLoginButton;
    }
}