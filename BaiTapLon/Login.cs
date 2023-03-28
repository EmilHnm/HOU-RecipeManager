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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        string connectionString = @"SERVER=DESKTOP-2CNBG7F\SQLEXPRESS; DATABASE=BaiTapLon;UID=sa;PWD=123";

        int rowCount;

        private void RowCount()
        {
            string query = "SELECT COUNT(*) FROM RememberMe";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    rowCount = (int)cmd.ExecuteScalar();
                }
                cnn.Close();
            }
        }

        private void SaveAccountInfo()
        {
            string proc = "SaveAccountInfo";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(proc, cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter param;
                    RowCount();

                    if (rowCount == 0)
                    {
                        param = cmd.Parameters.Add("@Username", SqlDbType.NVarChar, 50);
                        param.Value = Username.Text;

                        param = cmd.Parameters.Add("@Password", SqlDbType.NVarChar, 50);
                        param.Value = Password.Text;

                        cmd.ExecuteNonQuery();
                    }
                    else if (rowCount >= 1)
                    {
                        DropAccountInfo();

                        param = cmd.Parameters.Add("@Username", SqlDbType.NVarChar, 50);
                        param.Value = Username.Text;

                        param = cmd.Parameters.Add("@Password", SqlDbType.NVarChar, 50);
                        param.Value = Password.Text;

                        cmd.ExecuteNonQuery();
                    }

                }
                cnn.Close();
            }
        }

        public void DropAccountInfo()
        {
            string proc = "DropAccountInfo";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(proc, cnn))
                {
                    cmd.ExecuteNonQuery();
                }
                cnn.Close();
            }
        }

        private void ExitBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginBTN_Click(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM Accounts WHERE sTenTaiKhoan = '{Username.Text}'" +
                $" AND sMatKhau = '{Password.Text}'";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();
                try
                {
                    using (SqlCommand cmd = new SqlCommand(query, cnn))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (SqlDataReader sdr = cmd.ExecuteReader())
                        {
                            if (sdr.Read() == true)
                            {
                                if (RememberMe.Checked == true)
                                {
                                    SaveAccountInfo();
                                }
                                else if (RememberMe.Checked == false)
                                {
                                    DropAccountInfo();
                                }

                                MainForm mf = new MainForm(this);
                                mf.Show();
                                this.Hide();

                                MessageBox.Show("Đăng nhập thành công",
                                    "Đăng nhập",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu",
                                    "Đăng nhập",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Lỗi kết nối",
                            "Đăng nhập",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                cnn.Close();
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            RowCount();
            if (rowCount == 0)
            {
                Username.Text = "";
                Password.Text = "";
            }
            else
            {
                RememberMe.Checked = true;
                string getUsernameQuery = "SELECT sTenTaiKhoan FROM RememberMe";
                string getPasswordQuery = "SELECT sMatKhau FROM RememberMe";
                string username, password;
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    cnn.Open();
                    using (SqlCommand cmd1 = new SqlCommand(getUsernameQuery, cnn))
                    {
                        username = (string)cmd1.ExecuteScalar();
                    }
                    using (SqlCommand cmd2 = new SqlCommand(getPasswordQuery, cnn))
                    {
                        password = (string)cmd2.ExecuteScalar();
                    }
                    cnn.Close();
                }
                Username.Text = username;
                Password.Text = password;
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if(txtTaikhoan.Text == "" || txtMatkhau.Text == "" || txtLaimatkhau.Text == "" || txtEmail.Text == "" || txtSDT.Text == "")
            {
                MessageBox.Show("Bạn cần điền đầy đủ thông tin");
            }
            String procName = "InsertAccount";
            if (txtMatkhau.Text == txtLaimatkhau.Text && txtTaikhoan.Text != "" || txtMatkhau.Text != "" || txtLaimatkhau.Text != "" || txtEmail.Text != "" || txtSDT.Text != "")
            {
                using (SqlConnection Cnn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(procName, Cnn))
                    {
                        Cnn.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@stentaikhoan", txtTaikhoan.Text);
                        cmd.Parameters.AddWithValue("@sMatkhau", txtMatkhau.Text);
                        cmd.Parameters.AddWithValue("@sLaimatkhau", txtLaimatkhau.Text);
                        cmd.Parameters.AddWithValue("@sEmail", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@sSDT", txtSDT.Text);
                        int n = cmd.ExecuteNonQuery();
                        MessageBox.Show("Đăng ký thành công!");
                        if (n > 0 && txtTaikhoan.Text != "" || txtMatkhau.Text != "" || txtLaimatkhau.Text != "" || txtEmail.Text != "" || txtSDT.Text != "")
                        {
                            Login dangnhap = new Login();
                            this.Hide();
                            dangnhap.ShowDialog();
                        }
                        Cnn.Close();
                    }
                }
            }
            else
                MessageBox.Show("Mật khẩu và lại mật khẩu không trùng khớp");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Login dangnhap = new Login();
            this.Hide();
            dangnhap.ShowDialog();
            this.Close();
        }
    }
}
