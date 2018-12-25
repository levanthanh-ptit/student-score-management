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

namespace DX_Student_Score_Management.Controllers.HPTaiKhoanForms
{
    public partial class FormXOALOGIN : Form
    {
        Boolean kemTheo = false;
        string login;
        string MAGV;
        string Hoten;
        public FormXOALOGIN(string login, string MAGV, string HoTen)
        {
            InitializeComponent();
            this.login = login;
            this.MAGV = MAGV;
            this.Hoten = HoTen;
            labelGV.Text += $"\n {Hoten} : {MAGV}\n Login: {login}";
        }

        private void checkBoxKemTheo_CheckedChanged(object sender, EventArgs e)
        {
            kemTheo = !kemTheo;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataReader dataReader = Program._dataRepository
                    .excuteSP($"SP_XOALOGIN @NHOM = '{Program._dataRepository.GroupId}', @LGNAME = '{this.login}', @USRNAME = '{MAGV}'");
                dataReader.Close();
                if(this.kemTheo)
                {
                    Program.KHOA_GIANGVIENTableAdapter.DeleteQuery(MAGV);
                }
            }
            catch (SqlException ex)
            {
                if (ex.Message.Equals("5032"))
                    MessageBox.Show("Không đủ quyền thực hiện Xóa.");
                else
                MessageBox.Show(ex.Message, ex.ErrorCode.ToString());
            }
            MessageBox.Show($"Xóa thành công Login: {login}","Xóa login");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
