using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DX_Student_Score_Management.Controllers.TaiKhoanForms
{
    public partial class FormTAOLOGIN : Form
    {
        BindingSource khoaBS = new BindingSource();
        BindingSource listLogin = new BindingSource();
        public FormTAOLOGIN()
        {
            InitializeComponent();
            InitializeExtendComponent();
            khoaBS.DataSource = Program._QLDSVKhoaDataSet;
            khoaBS.DataMember = "KHOA";
            listLogin.DataSource = Program._QLDSVKhoaDataSet.SP_List_LOGIN;
        }

        private void InitializeExtendComponent()
        {
            this.sP_List_NHOMBindingSource.DataSource = Program._QLDSVKhoaDataSet;
        }

        private void FormTAOLOGIN_Load(object sender, EventArgs e)
        {
            Program.KHOA_SP_List_NHOMTableAdapter.Fill(Program._QLDSVKhoaDataSet.SP_List_NHOM);
        }

        private void btnTAO_Click(object sender, EventArgs e)
        {
            try
            {
                listLogin.Filter = $"MAGV = '{textEditMAGV.Text}'";
                int check;
                SqlDataReader dataReader = Program._dataRepository.excuteSP($"SP_Check_GIANGVIEN @MAGV = '{textEditMAGV.Text}'");
                check = dataReader.GetInt32(0);
                dataReader.Close();
                MessageBox.Show(check.ToString());
                if (check > 0)
                {
                    DialogResult result = MessageBox.Show("Tạo Login cho tài khoản?", "Giảng viên đã tồn tại.", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        SqlDataReader dataReaderSP_TAOLOGIN = Program._dataRepository
                            .excuteSP($"SP_TAOLOGIN @LGNAME = '{textEditUserName.Text}'," +
                            $" @PASS = '{textEditPassword.Text}'," +
                            $" @USERNAME = '{textEditMAGV.Text}'," +
                            $" @ROLE = '{sP_List_NHOMComboBox.SelectedValue.ToString()}'");
                        int error = dataReaderSP_TAOLOGIN.GetInt32(0);
                        dataReaderSP_TAOLOGIN.Close();
                        switch (error)
                        {
                            case 0:
                                MessageBox.Show("Tạo Login thành công!");
                                break;
                            case 1:
                                MessageBox.Show("Login name đã tồn tại.");
                                break;
                            case 2:
                                MessageBox.Show("Tài khoản đã sẵn có Login.");
                                break;
                        }
                    }
                }
                else
                {

                    SqlDataReader dataReaderSP_TAOLOGIN = Program._dataRepository
                            .excuteSP($"SP_TAOLOGIN @LGNAME = '{textEditUserName.Text}'," +
                            $" @PASS = '{textEditPassword.Text}'," +
                            $" @USERNAME = '{textEditMAGV.Text}'," +
                            $" @ROLE = '{sP_List_NHOMComboBox.SelectedValue.ToString()}'");
                    int error = dataReaderSP_TAOLOGIN.GetInt32(0);
                    dataReaderSP_TAOLOGIN.Close();
                    switch (error)
                    {
                        case 0:
                            MessageBox.Show("Tạo Login thành công!");
                            break;
                        case 1:
                            MessageBox.Show("Login name đã tồn tại.");
                            break;
                        case 2:
                            MessageBox.Show("Tài khoản đã sẵn có Login.");
                            break;
                    }
                }

            } catch (SqlException ex)
            {
                MessageBox.Show(ex.Message,ex.ErrorCode.ToString());
            }

        }

        private void checkBoxSwitch_CheckedChanged(object sender, EventArgs e)
        {
            textEditHO.Enabled = !textEditHO.Enabled;
            textEditTEN.Enabled = !textEditTEN.Enabled;
        }
    }
}
