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
        DataRepository dataRepository;
        public FormLogin(DataRepository dataRepository)
        {
            InitializeComponent();
            this.dataRepository = dataRepository;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSVDataSetMaster.V_DSPM' table. You can move, or remove it, as needed.
            this.v_DSPMTableAdapter.Fill(this.qLDSVDataSetMaster.V_DSPM);

        }


        private void loginLoginButton_Click(object sender, EventArgs e)
        {
            dataRepository.Server = LoginServerListComboBox.SelectedValue.ToString();
            dataRepository.DataBase = "QLDSV";
            dataRepository.UserId = LoginUserTextBox.Text;
            dataRepository.Password = LoginPasswordTextBox.Text; 
            dataRepository.NewSqlConnection();
            try
            {
                dataRepository.Open();
                dataRepository.GetLoginInfomation();
                dataRepository.Ready = true;
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