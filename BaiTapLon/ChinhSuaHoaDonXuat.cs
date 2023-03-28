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
    public partial class ChinhSuaHoaDonXuat : Form
    {
        public ChinhSuaHoaDonXuat()
        {
            InitializeComponent();
        }

        string connectionString = @"SERVER=LAPTOP-NATTQ2BG\SQLEXPRESS; DATABASE=BaiTapLon; UID=sa; PWD=654321;";
        // string connectionString = @"SERVER=DESKTOP-40S0GVK; DATABASE=BaiTapLon;UID=amin;PWD=hoangominh";
        private DataTable dtTemp = new DataTable();
        private DataTable dtMatHang = new DataTable();
        private int _sum = 0;
        private bool _isEditing = false;
        private int _seletedRow = -1;
        public int maHoaDon { get; set; }

        private void checkChiThemSoTuNhien(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                return;
            }
            else
            {
                e.Handled = false;
                return;
            }
        }

        private void reRenderThanhTien()
        {
            int sumTemp = 0;
            foreach (DataRow row in dtTemp.Rows)
            {
                sumTemp += Convert.ToInt32(row[5].ToString()) * Convert.ToInt32(row[3].ToString());
            }
            _sum = sumTemp;
            lb_thanhTien.Text = string.Format("{0:#,0}", _sum) + " đ";
        }
        private void ChinhSuaHoaDonXuat_Load(object sender, EventArgs e)
        {
            lb_maHoaDon.Text = this.maHoaDon.ToString();
            int receiptId = this.maHoaDon;
            lb_maHoaDon.Text = receiptId.ToString();
            string sqlcmd_getDonXuatHang = "SELECT * FROM tblHoaDonBanHang WHERE PK_iMaHoaDon=" + receiptId.ToString();
            string sqlcmd_getDonXuatHangInfo = "EXECUTE dbo.PROC_getExportDetailInfo " + receiptId.ToString();
            string sqlcmd2 = "SELECT * FROM tblHangHoa";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(sqlcmd_getDonXuatHang, cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        DateTime aDate = Convert.ToDateTime(dt.Rows[0][3].ToString());
                        dTP_ngayLap.Value = aDate;
                        tb_tenKhachHang.Text = dt.Rows[0][2].ToString();
                        tb_nhanVienLap.Text = dt.Rows[0][1].ToString();
                        if (Convert.ToBoolean(dt.Rows[0][4]) == true)
                        {
                            rb_daThanhToan.Checked = true;
                        }
                        else
                        {
                            rb_chuaThanhToan.Checked = true;
                        }
                    }
                }
                using (SqlCommand cmd = new SqlCommand(sqlcmd_getDonXuatHangInfo, cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        sda.Fill(dtTemp);
                        dGV_danhSachMatHang.DataSource = dtTemp;
                        dGV_danhSachMatHang.Columns[0].MinimumWidth = 20;
                        dGV_danhSachMatHang.Columns[1].MinimumWidth = 210;
                        dGV_danhSachMatHang.Columns[2].MinimumWidth = 100;
                        dGV_danhSachMatHang.Columns[3].MinimumWidth = 100;
                        dGV_danhSachMatHang.Columns[4].MinimumWidth = 30;
                        dGV_danhSachMatHang.Columns[5].MinimumWidth = 120;
                        dGV_danhSachMatHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        foreach (DataRow row in dtTemp.Rows)
                        {
                            _sum += Convert.ToInt32(row[5].ToString()) * Convert.ToInt32(row[3].ToString());
                        }
                        lb_thanhTien.Text = string.Format("{0:#,0}", _sum) + " đ";
                    }
                }
                using (SqlCommand cmd = new SqlCommand(sqlcmd2, cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        this.dtMatHang.Clear();
                        sda.Fill(this.dtMatHang);

                    }
                }
                cnn.Close();
            }
        }
        private void tb_maMatHangXuat_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkChiThemSoTuNhien(sender, e);
        }
        private void tb_soLuongMatHangXuat_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkChiThemSoTuNhien(sender, e);
        }
        private void reRenderdGV_danhSachMatHang()
        {
            dGV_danhSachMatHang.DataSource = dtTemp;
            dGV_danhSachMatHang.Columns[0].MinimumWidth = 20;
            dGV_danhSachMatHang.Columns[1].MinimumWidth = 210;
            dGV_danhSachMatHang.Columns[2].MinimumWidth = 100;
            dGV_danhSachMatHang.Columns[3].MinimumWidth = 80;
            dGV_danhSachMatHang.Columns[4].MinimumWidth = 30;
            dGV_danhSachMatHang.Columns[5].MinimumWidth = 120;
        }
        private void dGV_danhSachMatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _seletedRow = e.RowIndex;
            if (e.RowIndex != -1)
            {
                _seletedRow = Convert.ToInt32(dGV_danhSachMatHang.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }

        private void btn_themMatHangXuat_Click(object sender, EventArgs e)
        {
            if(!_isEditing)
            {
                String maMatHangXuat = tb_maMatHangXuat.Text;
                String soLuongMatHangXuat = tb_soLuongMatHangXuat.Text;
                DateTime ngayBaoHanh = dTP_ngayBaoHanh.Value;
                String tenHangHoa = "", nhanHieu = "",  mauSac = "";
                int donGiaMatHangXuat = -1;
                //Check isEmpty
                if (String.IsNullOrEmpty(maMatHangXuat) || String.IsNullOrEmpty(soLuongMatHangXuat))
                {
                    MessageBox.Show("Không được để trường nào trống!",
                            "Thêm mặt hàng bán",
                            MessageBoxButtons.OK);
                    return;
                }
                //Check Integer
                if (maMatHangXuat.Contains('.') || soLuongMatHangXuat.Contains('.'))
                {
                    MessageBox.Show("Các trường phải nhập số tự nhiên!",
                            "Thêm mặt hàng bán",
                            MessageBoxButtons.OK);
                    return;
                }
                //Check ngayBaoHanh phải sau ngày tạo tói thiểu 30 ngày
                if ((ngayBaoHanh - dTP_ngayLap.Value).TotalDays <= 30)
                {
                    MessageBox.Show("Hạn bảo hành phải sau ngày lập tối thiểu 30 ngày!",
                            "Thêm mặt hàng bán",
                            MessageBoxButtons.OK);
                    return;
                }
                //Check if exist in added list
                Boolean ifAddedInList = false;
                foreach (DataRow dataRow in dtTemp.Rows)
                {
                    if (dataRow[0].ToString() == maMatHangXuat)
                    {
                        ifAddedInList = true;
                    }
                }
                if (ifAddedInList)
                {
                    MessageBox.Show("Mặt hàng vừa nhập đã tồn tại trong danh sách.\n" +
                        "Hãy xóa mặt hàng đó trước khi thêm mới hoặc chỉnh sửa mặt hàng đó!",
                            "Thêm mặt hàng bán",
                            MessageBoxButtons.OK);
                    return;
                }

                // check if exist in tblMatHang
                Boolean ifExistInDB = false;
                foreach (DataRow dataRow1 in dtMatHang.Rows)
                {
                    if (dataRow1[0].ToString() == maMatHangXuat)
                    {
                        tenHangHoa = dataRow1[2].ToString();
                        ifExistInDB = true;
                        break;
                    }
                }
                if (!ifExistInDB)
                {
                    MessageBox.Show("Mặt hàng vừa nhập chưa tồn tại trong dữ liệu",
                            "Thêm mặt hàng bán",
                            MessageBoxButtons.OK);
                    return;
                }
                if (Int32.Parse(soLuongMatHangXuat) <= 0)
                {
                    MessageBox.Show("Số lượng mặt hàng phải lớn hơn 0!",
                            "Thêm mặt hàng bán",
                            MessageBoxButtons.OK);
                    return;
                }

                foreach (DataRow dataRow2 in dtMatHang.Rows)
                {
                    if (maMatHangXuat == dataRow2[0].ToString())
                    {
                        tenHangHoa = dataRow2[2].ToString();
                        donGiaMatHangXuat = Int32.Parse(dataRow2[4].ToString());
                        nhanHieu = dataRow2[5].ToString();
                        mauSac = dataRow2[6].ToString();
                    }
                }


                DataRow dataRowtemp;
                dataRowtemp = dtTemp.NewRow();
                dataRowtemp[0] = Int32.Parse(maMatHangXuat);
                dataRowtemp[1] = tenHangHoa;
                dataRowtemp[2] = nhanHieu;
                dataRowtemp[3] = donGiaMatHangXuat;
                dataRowtemp[4] = ngayBaoHanh.ToString("MM/dd/yyyy");
                dataRowtemp[5] = Int32.Parse(soLuongMatHangXuat);
                dtTemp.Rows.Add(dataRowtemp);
                reRenderdGV_danhSachMatHang();
                reRenderThanhTien();

                tb_maMatHangXuat.Text = "";
                tb_soLuongMatHangXuat.Text = "";
                dTP_ngayBaoHanh.Value = DateTime.Now;
            } else
            {
                tb_maMatHangXuat.Enabled = !tb_maMatHangXuat.Enabled;
                btn_xoaMatHang.Enabled = !btn_xoaMatHang.Enabled;
                btn_themMatHangXuat.Text = "Thêm mặt hàng";
                btn_suaMatHang.Text = "Sửa mặt hàng";
                _isEditing = !_isEditing;
                _seletedRow = -1;
                tb_maMatHangXuat.Text = "";
                tb_soLuongMatHangXuat.Text = "";
                dTP_ngayBaoHanh.Value = DateTime.Now;
            }
        }
        private void btn_suaMatHang_Click(object sender, EventArgs e)
        {
            if(!_isEditing)
            {
                if (_seletedRow == -1)
                {
                    MessageBox.Show("Hãy chọn 1 trường",
                        "Chỉnh sửa hóa đơn nhập",
                        MessageBoxButtons.OK);
                    return;
                }
                tb_maMatHangXuat.Enabled = !tb_maMatHangXuat.Enabled;
                btn_xoaMatHang.Enabled = !btn_xoaMatHang.Enabled;
                btn_themMatHangXuat.Text = "Hủy";
                btn_suaMatHang.Text = "Xác nhận";
                _isEditing = !_isEditing;
                foreach(DataRow dataRow in dtTemp.Rows)
                {
                    if(_seletedRow == Int32.Parse(dataRow[0].ToString()))
                    {
                        tb_maMatHangXuat.Text = dataRow[0].ToString();
                        tb_soLuongMatHangXuat.Text = dataRow[5].ToString();
                        dTP_ngayBaoHanh.Value = DateTime.Parse(dataRow[4].ToString());
                    }
                }
            } else
            {
                string maMatHangXuat = tb_maMatHangXuat.Text;
                string soLuongMatHangXuat = tb_soLuongMatHangXuat.Text;
                DateTime ngayBaoHanh = dTP_ngayBaoHanh.Value;
                //Check isEmpty
                if (String.IsNullOrEmpty(maMatHangXuat) || String.IsNullOrEmpty(soLuongMatHangXuat))
                {
                    MessageBox.Show("Không được để trường nào trống!",
                            "Thêm mặt hàng bán",
                            MessageBoxButtons.OK);
                    return;
                }
                //Check Integer
                if (maMatHangXuat.Contains('.') || soLuongMatHangXuat.Contains('.'))
                {
                    MessageBox.Show("Các trường phải nhập số tự nhiên!",
                            "Thêm mặt hàng bán",
                            MessageBoxButtons.OK);
                    return;
                }
                //Check ngayBaoHanh phải sau ngày tạo tói thiểu 30 ngày
                if ((ngayBaoHanh - dTP_ngayLap.Value).TotalDays <= 30)
                {
                    MessageBox.Show("Hạn bảo hành phải sau ngày lập tối thiểu 30 ngày!",
                            "Thêm mặt hàng bán",
                            MessageBoxButtons.OK);
                    return;
                }

                foreach(DataRow dataRow in dtTemp.Rows)
                {
                    if(dataRow[0].ToString() == maMatHangXuat)
                    {
                        dataRow[5] = soLuongMatHangXuat;
                        dataRow[4] = ngayBaoHanh.ToString("MM/dd/yyyy");
                    }
                }
                reRenderdGV_danhSachMatHang();
                reRenderThanhTien();

                tb_maMatHangXuat.Enabled = !tb_maMatHangXuat.Enabled;
                btn_xoaMatHang.Enabled = !btn_xoaMatHang.Enabled;
                btn_themMatHangXuat.Text = "Thêm mặt hàng";
                btn_suaMatHang.Text = "Sửa mặt hàng";
                _isEditing = !_isEditing;
                _seletedRow = -1;
                tb_maMatHangXuat.Text = "";
                tb_soLuongMatHangXuat.Text = "";
                dTP_ngayBaoHanh.Value = DateTime.Now;
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Mọi thay đổi của bạn sẽ không được lưu, bạn có chắc muốn thoát?",
                "Chỉnh sửa hóa đơn nhập",
                MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                this.Close();
                return;
            }
            return;
        }

        private void btn_xacNhan_Click(object sender, EventArgs e)
        {
            string nhanVienLap = tb_nhanVienLap.Text;
            DateTime ngayLap = dTP_ngayLap.Value;
            string tenKhachHang = tb_tenKhachHang.Text;
            int tinhTrang = 0;
            if (rb_daThanhToan.Checked) tinhTrang = 1;
            string updatetblHoaDonBanHang = "EXECUTE dbo.PROC_updatetblHoaDonBanHang " +
                this.maHoaDon.ToString() + ",N'" +
                nhanVienLap + "',N'" +
                tenKhachHang + "','" +
                ngayLap.ToString("MM/dd/yyyy") + "'," +
                tinhTrang.ToString();
            string deleteRowstblHangDaBan = "EXECUTE dbo.PROC_deleteRowstblHangDaBan " + this.maHoaDon.ToString();
            String insertTotblHangDaBan = "EXECUTE dbo.insertTotblHangDaBan  ";
            if (String.IsNullOrEmpty(nhanVienLap) || String.IsNullOrEmpty(tenKhachHang))
            {
                MessageBox.Show("Không được để trường nào trống!",
                            "Chỉnh sửa hóa đơn nhập",
                            MessageBoxButtons.OK);
                return;
            }
            if (DateTime.Compare(ngayLap, DateTime.Now) > 0)
            {
                MessageBox.Show("Ngày lập không được trong tương lai",
                    "Chỉnh sửa hóa đơn nhập");
                return;
            }
            if (dtTemp.Rows.Count < 1)
            {
                MessageBox.Show("Không được để danh sách mặt hàng trống",
                    "Chỉnh sửa hóa đơn nhập");
                return;
            }
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(updatetblHoaDonBanHang, cnn))
                {
                    cmd.ExecuteNonQuery();
                }
                using (SqlCommand cmd = new SqlCommand(deleteRowstblHangDaBan, cnn))
                {
                    cmd.ExecuteNonQuery();
                }
                foreach (DataRow dataRow in dtTemp.Rows)
                {
                    string insert = insertTotblHangDaBan + this.maHoaDon.ToString() + "," + dataRow[0].ToString() + "," + dataRow[5].ToString() + ",'" + dataRow[4].ToString() + "'";
                    using (SqlCommand cmd = new SqlCommand(insert, cnn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
                cnn.Close();
                this.Close();
            }
        }
    }
}
