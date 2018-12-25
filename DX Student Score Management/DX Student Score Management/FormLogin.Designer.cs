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
            this.LoginServerListComboBox = new System.Windows.Forms.ComboBox();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginUserTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LoginPasswordTextBox = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
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
            // LoginServerListComboBox
            // 
            this.LoginServerListComboBox.DataSource = this.v_DSPMBindingSource2;
            this.LoginServerListComboBox.DisplayMember = "description";
            this.LoginServerListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LoginServerListComboBox.FormattingEnabled = true;
            this.LoginServerListComboBox.Location = new System.Drawing.Point(197, 151);
            this.LoginServerListComboBox.Name = "LoginServerListComboBox";
            this.LoginServerListComboBox.Size = new System.Drawing.Size(222, 21);
            this.LoginServerListComboBox.TabIndex = 0;
            this.LoginServerListComboBox.ValueMember = "subscriber_server";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(123, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Phòng ban";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(156, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "User";
            // 
            // LoginUserTextBox
            // 
            this.LoginUserTextBox.Location = new System.Drawing.Point(197, 199);
            this.LoginUserTextBox.Name = "LoginUserTextBox";
            this.LoginUserTextBox.Size = new System.Drawing.Size(222, 21);
            this.LoginUserTextBox.TabIndex = 3;
            this.LoginUserTextBox.Text = "huy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(132, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // LoginPasswordTextBox
            // 
            this.LoginPasswordTextBox.Location = new System.Drawing.Point(197, 226);
            this.LoginPasswordTextBox.Name = "LoginPasswordTextBox";
            this.LoginPasswordTextBox.Size = new System.Drawing.Size(222, 21);
            this.LoginPasswordTextBox.TabIndex = 3;
            this.LoginPasswordTextBox.Text = "123";
            this.LoginPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(251, 273);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(65, 30);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "LOGIN";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.loginLoginButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(190, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 38);
            this.label4.TabIndex = 1;
            this.label4.Text = "ĐĂNG NHẬP";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = global::DX_Student_Score_Management.Properties.Resources.Diamond_Pattern_Backgrounds;
            this.ClientSize = new System.Drawing.Size(606, 351);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.LoginPasswordTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LoginUserTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginServerListComboBox);
            this.MaximizeBox = false;
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
        private System.Windows.Forms.ComboBox LoginServerListComboBox;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LoginUserTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LoginPasswordTextBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label label4;
    }
}