using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace DX_Student_Score_Management
{
    public partial class FormLogin : DevExpress.XtraEditors.XtraForm
    {
        ConnectionData connectionData;
        public FormLogin(ConnectionData connectionData)
        {
            InitializeComponent();
            this.connectionData = connectionData;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSVDataSetMaster.V_DSPM' table. You can move, or remove it, as needed.
            this.v_DSPMTableAdapter.Fill(this.qLDSVDataSetMaster.V_DSPM);

        }


        private void loginLoginButton_Click(object sender, EventArgs e)
        {
            connectionData.SetServer(loginServerListComboBox.SelectedValue.ToString());
            connectionData.SetDataBase("QLDSV");
            connectionData.SetUserId(loginUserTextBox.Text);
            connectionData.SetPassword(loginPasswordTextBox.Text);
            SqlConnection sqlConnection = new SqlConnection(connectionData.GetConnectionString());
            try
            {
                sqlConnection.Open();
                MessageBox.Show("Kết nối thành công!");
                this.Close();
            }
            catch (SqlException SqlE)
            {
                MessageBox.Show(SqlE.Message);
            }
        }
    }
}