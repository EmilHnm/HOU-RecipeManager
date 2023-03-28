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

namespace BaiTapLon
{
    public partial class DoiMatKhau : Form
    {
        public DoiMatKhau()
        {
            InitializeComponent();
        }

        string connectionString = @"SERVER=LAPTOP-NATTQ2BG\SQLEXPRESS; DATABASE=BaiTapLon; UID=sa; PWD=654321;";

        private void ChangeBTN_Click(object sender, EventArgs e)
        {
            string query = $"UPDATE Accounts SET sMatKhau = '{NewPass.Text}' " +
                $"WHERE sMatKhau = '{OldPass.Text}'";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();
                if (NewPass.Text != ConfirmPass.Text)
                {
                    MessageBox.Show("Mật khẩu xác nhận phải trùng với mật khẩu mới", "Đổi mật khẩu",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (NewPass.Text == OldPass.Text)
                {
                    MessageBox.Show("Mật khẩu mới không thê trùng với mật khẩu cũ", "Đổi mật khẩu",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (OldPass.Text == "" || NewPass.Text == "" || ConfirmPass.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Đổi mật khẩu",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    using (SqlCommand cmd = new SqlCommand(query, cnn))
                    {
                        cmd.ExecuteNonQuery();
                        DialogResult dr = MessageBox.Show("Đổi mật khẩu thành công", "Đổi mật khẩu",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dr == DialogResult.OK)
                        {
                            this.Close();
                        }
                        Login lg = new Login();
                        lg.DropAccountInfo();
                    }
                }
                cnn.Close();
            }
        }
    }
}
