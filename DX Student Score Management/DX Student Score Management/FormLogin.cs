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
using DX_Student_Score_Management.Repositories;

namespace DX_Student_Score_Management
{
    public partial class FormLogin : DevExpress.XtraEditors.XtraForm
    {
        DataRepository _dataRepository;
        public FormLogin(DataRepository dataRepository)
        {
            this._dataRepository = dataRepository;
            InitializeComponent();
           
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSVDataSetMaster.V_DSPM' table. You can move, or remove it, as needed.
            this.v_DSPMTableAdapter.Fill(this.qLDSVDataSetMaster.V_DSPM);

        }


        private void loginLoginButton_Click(object sender, EventArgs e)
        {
            _dataRepository.Server = LoginServerListComboBox.SelectedValue.ToString();
            _dataRepository.DataBase = "QLDSV";
            _dataRepository.UserId = LoginUserTextBox.Text;
            _dataRepository.Password = LoginPasswordTextBox.Text; 
            _dataRepository.NewSqlConnection();
            MessageBox.Show(_dataRepository.ConnectServer());
            if (_dataRepository.Ready) this.Close();
        }
    }
}