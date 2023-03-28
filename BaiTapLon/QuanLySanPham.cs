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
    public partial class MainForm : Form
    {
        Login lg;
        public MainForm(Login log)
        {
            InitializeComponent();
            this.lg = log;
        }

        // Thông số kết nối đến Database
        string connectionString = @"SERVER=DESKTOP-40S0GVK; DATABASE=BaiTapLon;UID=amin;PWD=hoangominh;";
        //string connectionString = @"SERVER=LAPTOP-NATTQ2BG\SQLEXPRESS; DATABASE=BaiTapLon; UID=sa; PWD=654321;";
        DataTable dtXuat = new DataTable();
        DataTable dtNhap = new DataTable();
        private int seletedRow = 1;
        private bool isSearching = false;
        #region

        public void ShowProduct() // Hiện danh sách sản phẩm
        {
            string proc = "ShowProduct";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(proc, cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        DGV.AutoGenerateColumns = false;
                        DGV.DataSource = dt;
                        DGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    }
                }
                cnn.Close();
            }
        }

        int id; // Biến dùng để lưu trữ mã nhóm hàng người dùng chọn

        public void SelectCategory() // Lấy mã nhóm hàng người dùng chọn
        {
            string query = $"SELECT PK_iMaNhomHang FROM tblNhomHang WHERE sTenNhomHang = N'{ProdCatList.Text}'";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    id = (int)cmd.ExecuteScalar();
                }
                cnn.Close();
            }
        }

        private void XemBTN_Click(object sender, EventArgs e) // Nạp dữ liệu vào DataGridView
        {
            ShowProduct();
        }

        private void MainForm_Load(object sender, EventArgs e) // Nạp dữ liệu vào trường Loại Hàng
        {
            string query = "SELECT * FROM tblNhomHang";
            string getAccountID = "getAccountID";
            string getAccountName = "getAccountName";
            string getAccountEmail = "getAccountEmail";
            string getAccountPhoneNumber = "getAccountPhoneNumber";
            string id, name, email, phone, username;
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();
                using (SqlCommand Cmd = new SqlCommand(query, cnn))
                {
                    Cmd.CommandType = CommandType.Text;
                    using (SqlDataReader rd = Cmd.ExecuteReader())
                    {
                        if (rd.HasRows)
                        {
                            while (rd.Read())
                            {
                                ProdCatList.Items.Add(rd["sTenNhomHang"]);
                            }
                        }
                    }
                }
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        DGV2.AutoGenerateColumns = false;
                        DGV2.DataSource = dt;
                        DGV2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    }
                }
                username = lg.Username.Text;
                using (SqlCommand cmd = new SqlCommand(getAccountID, cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter param;

                    param = cmd.Parameters.Add("@username", SqlDbType.NVarChar, 50);
                    param.Value = username;

                    id = cmd.ExecuteScalar().ToString();
                }
                using (SqlCommand cmd = new SqlCommand(getAccountName, cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter param;

                    param = cmd.Parameters.Add("@username", SqlDbType.NVarChar, 50);
                    param.Value = username;

                    name = (string)cmd.ExecuteScalar();
                }
                using (SqlCommand cmd = new SqlCommand(getAccountEmail, cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter param;

                    param = cmd.Parameters.Add("@username", SqlDbType.NVarChar, 50);
                    param.Value = username;

                    email = (string)cmd.ExecuteScalar();
                }
                using (SqlCommand cmd = new SqlCommand(getAccountPhoneNumber, cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter param;

                    param = cmd.Parameters.Add("@username", SqlDbType.NVarChar, 50);
                    param.Value = username;

                    phone = (string)cmd.ExecuteScalar();
                }
                AccName.Text = name;
                AccID.Text = id;
                AccPhoneNumber.Text = phone;
                AccEmail.Text = email;
                cnn.Close();
            }
            //Trang quản lý hóa đơn
            renderQuanLyHoaDon();
        }

        // Chỉ cho phép người dùng nhập số vào trường giá bán
        private void Pricing_KeyPress(object sender, KeyPressEventArgs e) 
        {
            // Nhập Số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            //Số thập phân
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void SearchBTN_Click(object sender, EventArgs e) // Tìm kiếm sản phẩm
        {
            string query = "SELECT tblNhomHang.sTenNhomHang, tblHangHoa.* FROM tblNhomHang RIGHT JOIN " +
                "tblHangHoa ON tblNhomHang.PK_iMaNhomHang = tblHangHoa.FK_iMaNhomHang " +
                "WHERE PK_iMaHangHoa > 0";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();
                try
                {
                    if (ProdAttributes.Text == "" && ProdCatList.Text == "" &&
                            ProdColor.Text == "" && ProdLabel.Text == "" && ProdName.Text == ""
                            && ProdPricing.Text == "" && ProdQuantity.Text == "-1")
                    {
                        MessageBox.Show("Vui lòng nhập ít nhất 1 trường để tìm kiếm",
                        "Tìm kiếm thông tin",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        if (ProdAttributes.Text != "")
                        {
                            query += $" AND sDacTinhKiThuat LIKE '%{ProdAttributes.Text}%'";
                        }
                        if (ProdCatList.Text != "")
                        {
                            SelectCategory();
                            query += $" AND FK_iMaNhomHang = {id}";
                        }
                        if (ProdColor.Text != "")
                        {
                            query += $" AND sMauSac LIKE '%{ProdColor.Text}%'";
                        }
                        if (ProdLabel.Text != "")
                        {
                            query += $" AND sNhanHieu LIKE '%{ProdLabel.Text}%'";
                        }
                        if (ProdName.Text != "")
                        {
                            query += $" AND sTenHangHoa LIKE '%{ProdName.Text}%'";
                        }
                        if (ProdPricing.Text != "")
                        {
                            query += $" AND iGiaBan = {ProdPricing.Text}";
                        }
                        if (Convert.ToInt32(ProdQuantity.Text) > -1)
                        {
                            query += $" AND iSoLuong = {ProdQuantity.Text}";
                        }
                        using (SqlCommand cmd = new SqlCommand(query, cnn))
                        {
                            cmd.CommandType = CommandType.Text;
                            using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                            {
                                DataTable dt = new DataTable();
                                sda.Fill(dt);
                                DGV.AutoGenerateColumns = false;
                                DGV.DataSource = dt;
                                DGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                            }
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Lỗi dữ liệu đầu vào",
                        "Tìm kiếm thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                cnn.Close();
            }
        }
        
        private void DeleteBTN_Click(object sender, EventArgs e) // Xóa sản phẩm
        {
            string proc = "DeleteProduct";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();
                try
                {
                    using (SqlCommand cmd = new SqlCommand(proc, cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlParameter param;

                        if (DGV.GetCellCount(DataGridViewElementStates.Selected) == 0)
                        {
                            MessageBox.Show("Vui lòng chọn một dòng để xóa",
                            "Xóa thông tin",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            param = cmd.Parameters.Add("@Id", SqlDbType.Int);
                            param.Value = DGV.SelectedRows[0].Cells[1].Value.ToString();

                            DialogResult res = MessageBox.Show("Bạn có thực sự muốn xóa dòng này không ?",
                            "Xóa thông tin",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (res == DialogResult.Yes)
                            {
                                cmd.ExecuteNonQuery();
                                ShowProduct();
                                MessageBox.Show("Xóa thành công",
                                "Xóa thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Không thể xóa sản phẩm này vì có thông tin liên quan",
                        "Xóa thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                cnn.Close();
            }
        }

        private void UpdateBTN_Click(object sender, EventArgs e) // Cập nhật thông tin sản phẩm
        {
            string proc = "UpdateProduct";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();
                try
                {
                    using (SqlCommand cmd = new SqlCommand(proc, cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlParameter param;

                        if (DGV.GetCellCount(DataGridViewElementStates.Selected) == 0)
                        {
                            MessageBox.Show("Vui lòng chọn một dòng để cập nhật",
                            "Sửa thông tin",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else if (ProdAttributes.Text == "" || ProdCatList.Text == "" ||
                            ProdColor.Text == "" || ProdLabel.Text == "" || ProdName.Text == ""
                            || ProdPricing.Text == "" || ProdQuantity.Text == "")
                        {
                            MessageBox.Show("Vui lòng nhập đầy đủ thông tin",
                            "Sửa thông tin",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }    
                        else
                        {
                            SelectCategory();

                            param = cmd.Parameters.Add("@Id", SqlDbType.Int);
                            param.Value = DGV.SelectedRows[0].Cells[1].Value.ToString();

                            param = cmd.Parameters.Add("@CategoryId", SqlDbType.Int);
                            param.Value = id;

                            param = cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 50);
                            param.Value = ProdName.Text;

                            param = cmd.Parameters.Add("@Quantity", SqlDbType.Int);
                            param.Value = ProdQuantity.Value;

                            param = cmd.Parameters.Add("@Price", SqlDbType.Int);
                            param.Value = Convert.ToInt32(ProdPricing.Text);

                            param = cmd.Parameters.Add("@Label", SqlDbType.NVarChar, 50);
                            param.Value = ProdLabel.Text;

                            param = cmd.Parameters.Add("@Color", SqlDbType.NVarChar, 50);
                            param.Value = ProdColor.Text;

                            param = cmd.Parameters.Add("@Attributes", SqlDbType.NText);
                            param.Value = ProdAttributes.Text;

                            DialogResult res = MessageBox.Show("Bạn có thực sự muốn cập nhật dòng này không ?",
                            "Sửa thông tin",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (res == DialogResult.Yes)
                            {
                                cmd.ExecuteNonQuery();
                                ShowProduct();
                                MessageBox.Show("Cập nhật thành công",
                                "Sửa thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Lỗi dữ liệu đầu vào",
                        "Sửa thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                cnn.Close();
            }
        }

        private void AddBTN_Click(object sender, EventArgs e)
        {
            string proc = "InsertProduct";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(proc, cnn))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlParameter param;

                        if (ProdAttributes.Text == "" || ProdCatList.Text == "" ||
                            ProdColor.Text == "" || ProdLabel.Text == "" || ProdName.Text == ""
                            || ProdPricing.Text == "" || ProdQuantity.Text == "")
                        {
                            MessageBox.Show("Vui lòng nhập đầy đủ thông tin",
                            "Thêm thông tin",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            SelectCategory();

                            param = cmd.Parameters.Add("@CategoryId", SqlDbType.Int);
                            param.Value = id;

                            param = cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 50);
                            param.Value = ProdName.Text;

                            param = cmd.Parameters.Add("@Quantity", SqlDbType.Int);
                            param.Value = ProdQuantity.Value;

                            param = cmd.Parameters.Add("@Price", SqlDbType.Int);
                            param.Value = Convert.ToInt32(ProdPricing.Text);

                            param = cmd.Parameters.Add("@Label", SqlDbType.NVarChar, 50);
                            param.Value = ProdLabel.Text;

                            param = cmd.Parameters.Add("@Color", SqlDbType.NVarChar, 50);
                            param.Value = ProdColor.Text;

                            param = cmd.Parameters.Add("@Attributes", SqlDbType.NText);
                            param.Value = ProdAttributes.Text;

                            cmd.ExecuteNonQuery();
                            ShowProduct();
                            MessageBox.Show("Thêm thông tin thành công",
                            "Thêm thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                    catch
                    {
                        MessageBox.Show("Lỗi dữ liệu đầu vào",
                        "Thêm thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                cnn.Close();
            }
        }

        private void PrintBTN_Click(object sender, EventArgs e)
        {
            string proc = "ShowProduct";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(proc, cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        BaoCaoHangHoa pr = new BaoCaoHangHoa();
                        pr.SetDataSource(dt);
                        FormBCHH ht = new FormBCHH();
                        ht.CRV1.ReportSource = pr;
                        ht.ShowDialog();
                    }
                }
                cnn.Close();
            }
        }

        #endregion

        #region

        
        private void renderQuanLyHoaDon()
        {
            // Thêm biến và đặt mạc định cho combobox
            cb_loaiHoaDon.Items.Add("Hóa đơn nhập hàng");
            cb_loaiHoaDon.Items.Add("Hóa đơn bán hàng");
            cb_loaiHoaDon.SelectedIndex = 0;
        }

        //Render lại datagridview mỗi khi combobox thay đổi
        // Mặc định chạy 1 lần khi load trang do đặtmặc định cho combobox
        private void cb_loaiHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_loaiHoaDon.SelectedIndex == 0)
            {
                showHoaDonNhap();
            }
            else
            {
                showHoaDonXuat();
            }
        }

        //Render lại data gridview theo bảng nhập
        private void showHoaDonNhap()
        {
            string sqlcmd = "SELECT * FROM tblHoaDonNhapHang";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(sqlcmd, cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        dtNhap.Clear();
                        sda.Fill(dtNhap);
                        dGV_DanhSachHoaDon.DataSource = dtNhap;
                        dGV_DanhSachHoaDon.Columns[0].MinimumWidth = 50;
                        dGV_DanhSachHoaDon.Columns[1].MinimumWidth = 120;
                        dGV_DanhSachHoaDon.Columns[2].MinimumWidth = 149;
                        dGV_DanhSachHoaDon.Columns[3].MinimumWidth = 400;
                        dGV_DanhSachHoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                    }
                }
                cnn.Close();
            }
        }

        //Render lại datagridview theo bảng Xuất
        private void showHoaDonXuat()
        {
            string sqlcmd = "SELECT * FROM tblHoaDonBanHang";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(sqlcmd, cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        dtXuat.Clear();
                        sda.Fill(dtXuat);
                        dGV_DanhSachHoaDon.DataSource = dtXuat;
                        dGV_DanhSachHoaDon.Columns[0].MinimumWidth = 20;
                        dGV_DanhSachHoaDon.Columns[1].MinimumWidth = 200;
                        dGV_DanhSachHoaDon.Columns[2].MinimumWidth = 200;
                        dGV_DanhSachHoaDon.Columns[3].MinimumWidth = 168;
                        dGV_DanhSachHoaDon.Columns[3].MinimumWidth = 100;
                        dGV_DanhSachHoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    }
                }
                cnn.Close();
            }
        }


        // Trigger khi ấn nút xem chi tiết 1 hóa đơn
        private void btn_xemChiTiet_Click(object sender, EventArgs e)
        {
            if(cb_loaiHoaDon.SelectedIndex == 0)
            {
                XemChiTietHoaDonNhap xemChiTietHoaDonNhap = new XemChiTietHoaDonNhap();
                xemChiTietHoaDonNhap.Value = seletedRow;
                xemChiTietHoaDonNhap.ShowDialog();
            }   else
            {
                XemChiTietHoaDonXuat xemChiTietHoaDonXuat = new XemChiTietHoaDonXuat();
                xemChiTietHoaDonXuat.Value = seletedRow;
                xemChiTietHoaDonXuat.ShowDialog();
            }
            
        }

        //Check chọn hóa đơn
        private void dGV_DanhSachHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            seletedRow = e.RowIndex;
            if(e.RowIndex != -1)
            {
                seletedRow = Convert.ToInt32(dGV_DanhSachHoaDon.Rows[e.RowIndex].Cells[0].Value.ToString());
                
            }
            
        }

        //Render lại datagridview
        private void btn_lamMoi_Click(object sender, EventArgs e)
        {
            if (cb_loaiHoaDon.SelectedIndex == 0)
            {
                showHoaDonNhap();
            }
            else
            {
                showHoaDonXuat();
            }
        }

        //Mở phẩn tìm theo Id và render kết quả xuống datagridview
        private void btn_searchById_Click(object sender, EventArgs e)
        {
            if(!isSearching)
            {
                tb_searchById.Visible = true;
                btn_searchById.Location = new System.Drawing.Point(564, 143);
                lb_searchById.Visible = true;
                btn_cancelSearching.Visible = true;
                isSearching = true;
            } else
            {

                if(tb_searchById.Text == "")
                {
                    MessageBox.Show("Hãy nhập mã hóa đơn!");
                    return;
                }
                if (cb_loaiHoaDon.SelectedIndex == 0)
                {
                    string sqlcmd = "SELECT * FROM tblHoaDonNhapHang WHERE PK_iMaHoaDon = " + tb_searchById.Text;
                    using (SqlConnection cnn = new SqlConnection(connectionString))
                    {
                        cnn.Open();
                        using (SqlCommand cmd = new SqlCommand(sqlcmd, cnn))
                        {
                            cmd.CommandType = CommandType.Text;
                            using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                            {
                                dtNhap.Clear();
                                sda.Fill(dtNhap);
                                dGV_DanhSachHoaDon.DataSource = dtNhap;
                                dGV_DanhSachHoaDon.Columns[0].MinimumWidth = 50;
                                dGV_DanhSachHoaDon.Columns[1].MinimumWidth = 120;
                                dGV_DanhSachHoaDon.Columns[2].MinimumWidth = 149;
                                dGV_DanhSachHoaDon.Columns[3].MinimumWidth = 400;
                                dGV_DanhSachHoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                            }
                        }
                        cnn.Close();
                    }
                }
                else
                {
                    string sqlcmd = "SELECT * FROM tblHoaDonBanHang WHERE PK_iMaHoaDon=" + tb_searchById.Text;
                    using (SqlConnection cnn = new SqlConnection(connectionString))
                    {
                        cnn.Open();
                        using (SqlCommand cmd = new SqlCommand(sqlcmd, cnn))
                        {
                            cmd.CommandType = CommandType.Text;
                            using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                            {
                                dtXuat.Clear();
                                sda.Fill(dtXuat);
                                dGV_DanhSachHoaDon.DataSource = dtXuat;
                                dGV_DanhSachHoaDon.Columns[0].MinimumWidth = 20;
                                dGV_DanhSachHoaDon.Columns[1].MinimumWidth = 200;
                                dGV_DanhSachHoaDon.Columns[2].MinimumWidth = 200;
                                dGV_DanhSachHoaDon.Columns[3].MinimumWidth = 168;
                                dGV_DanhSachHoaDon.Columns[3].MinimumWidth = 100;
                                dGV_DanhSachHoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                            }
                        }
                        cnn.Close();
                    }
                }
            }
        }

        //Đóng phần tìm theo Id
        private void btn_cancelSearching_Click(object sender, EventArgs e)
        {
            if (isSearching){
                tb_searchById.Visible = false;
                btn_searchById.Location = new System.Drawing.Point(364, 143);
                lb_searchById.Visible = false;
                btn_cancelSearching.Visible = false;
                isSearching = false;
                if (cb_loaiHoaDon.SelectedIndex == 0)
                {
                    showHoaDonNhap();
                }
                else
                {
                    showHoaDonXuat();
                }
            }
        }

        //Trigger thêm hóa đơn
        private void btn_themHoaDon_Click(object sender, EventArgs e)
        {
            ThemHoaDonMoi themHoaDonMoi = new ThemHoaDonMoi();
            themHoaDonMoi.ShowDialog();
        }
        private void btn_xoaHoaDon_Click(object sender, EventArgs e)
        {
            if(cb_loaiHoaDon.SelectedIndex == 0)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa hóa đơn nhập có mã " + seletedRow,
                    "Quản lý sản phẩm",
                    MessageBoxButtons.OKCancel);
                if(dialogResult == DialogResult.OK)
                {
                    string deleteRowtblHoaDonNhapHang = "EXECUTE dbo.PROC_deleteRowtblHoaDonNhapHang " + seletedRow;
                    string deleteRowstblHangNhap = "EXECUTE dbo.PROC_deleteRowstblHangNhap " + seletedRow;
                    using(SqlConnection cnn = new SqlConnection(connectionString))
                    {
                        cnn.Open();
                        //Xóa trong blHangNhap trước
                        using(SqlCommand cmd = new SqlCommand(deleteRowstblHangNhap, cnn))
                        {
                            cmd.ExecuteNonQuery();
                        }
                        //Rồi xóa trong blHoaDonNhapHang
                        using(SqlCommand cmd = new SqlCommand(deleteRowtblHoaDonNhapHang,cnn))
                        {
                            cmd.ExecuteNonQuery();
                        }
                        cnn.Close();
                    }
                    showHoaDonNhap();
                    MessageBox.Show("Xóa thành công!", "Xóa hóa đơn nhập");
                } 
            } else
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa hóa đơn bán có mã " + seletedRow,
                    "Quản lý sản phẩm",
                    MessageBoxButtons.OKCancel);
                if(dialogResult == DialogResult.OK)
                {
                    string deleteRowstblHangDaBan = "EXECUTE PROC_deleteRowstblHangDaBan " + seletedRow;
                    string deleteRowstblHoaDonBanHang = "EXECUTE PROC_deleteRowstblHoaDonBanHang " + seletedRow;
                    using(SqlConnection cnn = new SqlConnection(connectionString))
                    {
                        cnn.Open();
                        // Xóa trong bẳng tblHangCanBan trước
                        using (SqlCommand cmd = new SqlCommand(deleteRowstblHangDaBan,cnn))
                        {
                            cmd.ExecuteNonQuery();
                        }
                        //rồi xóa trong bảng tblHoaDonBanHang
                        using (SqlCommand cmd = new SqlCommand(deleteRowstblHoaDonBanHang,cnn))
                        {
                            cmd.ExecuteNonQuery();
                        }
                        cnn.Close();
                    }
                    showHoaDonXuat();
                    MessageBox.Show("Xóa thành công!", "Xóa hóa đơn bán");
                }
            }
        }


        private void btn_suaHoaDon_Click(object sender, EventArgs e)
        {
            if(cb_loaiHoaDon.SelectedIndex == 0)
            {
                ChinhSuaHoaDonNhap chinhSuaHoaDonNhap = new ChinhSuaHoaDonNhap();
                chinhSuaHoaDonNhap.maHoaDon = seletedRow;
                chinhSuaHoaDonNhap.ShowDialog();
            } else
            {
                ChinhSuaHoaDonXuat chinhSuaHoaDonXuat = new ChinhSuaHoaDonXuat();
                chinhSuaHoaDonXuat.maHoaDon = seletedRow;
                chinhSuaHoaDonXuat.ShowDialog();
            }
        }
        #endregion

        #region

        bool isExit = true;

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isExit == true)
            {
                Application.Exit();
            }
        }

        private void LogoutBTN_Click(object sender, EventArgs e)
        {
            string proc = "DropAccountInfo";
            DialogResult rs = MessageBox.Show("Bạn thực sự muốn đăng xuất ?",
                "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand(proc, cnn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    cnn.Close();
                }
                isExit = false;
                this.Close();
                Login lg = new Login();
                lg.Show();
                MessageBox.Show("Đăng xuất thành công",
                "Đăng xuất", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ChangePassword_Click_1(object sender, EventArgs e)
        {
            DoiMatKhau dmk = new DoiMatKhau();
            dmk.ShowDialog();
        }

        #endregion

        
    }
}
