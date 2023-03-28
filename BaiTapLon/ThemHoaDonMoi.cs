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
    public partial class ThemHoaDonMoi : Form
    {
        //string connectionString = @"SERVER=LAPTOP-NATTQ2BG\SQLEXPRESS; DATABASE=BaiTapLon; UID=sa; PWD=654321;";
        string connectionString = @"SERVER=DESKTOP-40S0GVK; DATABASE=BaiTapLon;UID=amin;PWD=hoangominh";
        DataTable dtNhapTemp = new DataTable();
        DataTable dtXuatTemp = new DataTable();
        DataTable dtXuat = new DataTable();
        DataTable dtNhap = new DataTable();
        DataTable dtMatHang = new DataTable();
        private int _currentSelectedRow = -1;
        private bool _isEditing = false;

        public ThemHoaDonMoi()
        {
            InitializeComponent();
        }
        private void ThemHoaDonMoi_Load(object sender, EventArgs e)
        {
            renderQuanLyHoaDon();

        }
        private void renderQuanLyHoaDon()
        {
            

            initTempDataTable();
            //Lấy dữ liệu từ database
            string sqlcmd = "SELECT * FROM tblHoaDonNhapHang";
            string sqlcmd1 = "SELECT * FROM tblHoaDonBanHang";
            string sqlcmd2 = "SELECT * FROM tblHangHoa";
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
                    }
                }
                using (SqlCommand cmd = new SqlCommand(sqlcmd1, cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        dtXuat.Clear();
                        sda.Fill(dtXuat);
                    }
                }
                using (SqlCommand cmd = new SqlCommand(sqlcmd2, cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        dtMatHang.Clear();
                        sda.Fill(dtMatHang);
                    }
                }
                cnn.Close();
            }
            //Đặt mặc định cho combobox là hóa đơn nhập hàng
            cb_loaiHoaDon.Items.Add("Hóa đơn nhập hàng");
            cb_loaiHoaDon.Items.Add("Hóa đơn bán hàng");
            cb_loaiHoaDon.SelectedIndex = 0;
        }

        //Khởi tạo 2 bảng dữ liệu mặ hàng tạm thời
        private void initTempDataTable()
        {
            dtNhapTemp.Columns.Add("Mã Hàng Hóa", typeof(int));
            dtNhapTemp.Columns.Add("Tên Hàng Hóa", typeof(String));
            dtNhapTemp.Columns.Add("Nhãn Hiệu", typeof(String));
            dtNhapTemp.Columns.Add("Số Lượng", typeof(int));
            dtNhapTemp.Columns.Add("Đơn Giá", typeof(int));

            dtXuatTemp.Columns.Add("Mã Hàng Hóa", typeof(int));
            dtXuatTemp.Columns.Add("Tên Hàng Hóa", typeof(String));
            dtXuatTemp.Columns.Add("Ngày Bảo Hành", typeof(DateTime));
            dtXuatTemp.Columns.Add("Số Lượng", typeof(int));
            dtXuatTemp.Columns.Add("Đơn Giá", typeof(int));
        }

        //Render 2 bảng vào data grid view
        private void reRenderdGV_danhSachMatHang()
        {
            if (cb_loaiHoaDon.SelectedIndex == 0)
            {
                dGV_danhSachMatHang.DataSource = dtNhapTemp;
                dGV_danhSachMatHang.Columns[0].MinimumWidth = 20;
                dGV_danhSachMatHang.Columns[1].MinimumWidth = 200;
                dGV_danhSachMatHang.Columns[2].MinimumWidth = 178;
                dGV_danhSachMatHang.Columns[3].MinimumWidth = 100;
                dGV_danhSachMatHang.Columns[4].MinimumWidth = 100;
            }
            else
            {
                dGV_danhSachMatHang.DataSource = dtXuatTemp;
                dGV_danhSachMatHang.Columns[0].MinimumWidth = 20;
                dGV_danhSachMatHang.Columns[1].MinimumWidth = 200;
                dGV_danhSachMatHang.Columns[2].MinimumWidth = 178;
                dGV_danhSachMatHang.Columns[3].MinimumWidth = 100;
                dGV_danhSachMatHang.Columns[4].MinimumWidth = 100;
            }
        }

        //Như tên hàm
        private void checkChiThemSoTuNhien(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                return;
            } else
            {
                e.Handled = false;
                return;
            }
        }

        //Update lại label thành tiền khi thêm mới mặt hàng vào data grid view
        private void updateThanhTien()
        {
            int sum = 0;
            if (cb_loaiHoaDon.SelectedIndex == 0)
            {
                foreach(DataRow dataRow in dtNhapTemp.Rows)
                {
                    sum += (Int32.Parse(dataRow[3].ToString())  * Int32.Parse(dataRow[4].ToString()));
                }
            } else
            {
                foreach (DataRow dataRow in dtXuatTemp.Rows)
                {
                    sum += (Int32.Parse(dataRow[3].ToString()) * Int32.Parse(dataRow[4].ToString()));
                }
            }
            lb_thanhTien.Text = string.Format("{0:#,0}", sum) + " đ";
        }

        //Thay đổi 1 số thuộc tính khi combobox đc cập nhật
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_loaiHoaDon.SelectedIndex == 0)
            {
                pn_themMatHangNhap.Visible = true;
                pn_themMatHangXuat.Visible = false;
                pn_trangThai.Visible = false;
                dtNhapTemp.Clear();
                reRenderdGV_danhSachMatHang();
                updateThanhTien();

            }
            else
            {
                pn_themMatHangNhap.Visible = false;
                pn_themMatHangXuat.Visible = true;
                pn_trangThai.Visible = true;
                dtXuatTemp.Clear();
                reRenderdGV_danhSachMatHang();
                updateThanhTien();
            }
            
        }



        //Đoạn này để áp dụng hàm checkChiThemSoTuNhien vào các textbox cần thiết

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkChiThemSoTuNhien(sender, e);
        }

        private void tb_soLuongMatHangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkChiThemSoTuNhien(sender, e);
        }

        private void tb_donGiaMatHangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkChiThemSoTuNhien(sender, e);
        }

        private void dTP_ngayBaoHanh_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkChiThemSoTuNhien(sender, e);
        }

        private void tb_soLuongMatHangXuat_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkChiThemSoTuNhien(sender, e);
        }

        private void tb_maMatHangXuat_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkChiThemSoTuNhien(sender, e);
        }

        private void btn_themMatHangNhap_Click(object sender, EventArgs e)
        {
            String maMatHangNhap = tb_maMatHangNhap.Text;
            String soLuongMatHangNhap = tb_soLuongMatHangNhap.Text;
            String donGiaMatHangNhap = tb_donGiaMatHangNhap.Text;
            String tenHangHoa = "", nhanHieu = "";
            //Check isEmpty
            if(String.IsNullOrEmpty(maMatHangNhap) || 
                String.IsNullOrEmpty(soLuongMatHangNhap) ||
                String.IsNullOrEmpty(donGiaMatHangNhap))
            {
                MessageBox.Show("Không được để trường nào trống!", 
                        "Thêm mặt hàng nhập",
                        MessageBoxButtons.OK);
                return;
            }
            //Check Integer
            if(maMatHangNhap.Contains('.') || 
                soLuongMatHangNhap.Contains('.') ||
                donGiaMatHangNhap.Contains('.'))
            {
                MessageBox.Show("Các trường phải nhập số tự nhiên!",
                        "Thêm mặt hàng nhập",
                        MessageBoxButtons.OK);
                return;
            }
            //Check if exist in added list
            Boolean ifAddedInList = false;
            foreach(DataRow dataRow in dtNhapTemp.Rows)
            {
                if(dataRow[0].ToString() == maMatHangNhap)
                {
                    ifAddedInList = true;
                }
            }
            if(ifAddedInList)
            {
                MessageBox.Show("Mặt hàng vừa nhập đã tồn tại trong danh sách.\n" +
                    "Hãy xóa mặt hàng đó trước khi thêm mới hoặc chỉnh sửa mặt hàng đó!",
                        "Thêm mặt hàng nhập",
                        MessageBoxButtons.OK);
                return;
            }

            // check if exist in tblMatHang
            Boolean ifExistInDB = false;
            foreach(DataRow dataRow1 in dtMatHang.Rows)
            {
                if(dataRow1[0].ToString() == maMatHangNhap)
                {
                    tenHangHoa = dataRow1[2].ToString();
                    nhanHieu = dataRow1[5].ToString();
                    ifExistInDB = true;
                    break;
                }
            }
            if(!ifExistInDB)
            {
                MessageBox.Show("Mặt hàng vừa nhập chưa tồn tại trong dữ liệu" ,
                        "Thêm mặt hàng nhập",
                        MessageBoxButtons.OK);
                return;
            }
            if(Int32.Parse(soLuongMatHangNhap) <= 0)
            {
                MessageBox.Show("Số lượng mặt hàng phải lớn hơn 0!",
                        "Thêm mặt hàng nhập",
                        MessageBoxButtons.OK);
                return;
            }
            if (Int32.Parse(donGiaMatHangNhap) <= 0)
            {
                MessageBox.Show("Đơn giá mặt hàng phải lớn hơn 0!",
                        "Thêm mặt hàng nhập",
                        MessageBoxButtons.OK);
                return;
            }
            

            DataRow dataRowtemp;
            dataRowtemp = dtNhapTemp.NewRow();
            dataRowtemp[0] = Int32.Parse(maMatHangNhap);
            dataRowtemp[1] = tenHangHoa;
            dataRowtemp[2] = nhanHieu;
            dataRowtemp[3] = Int32.Parse(soLuongMatHangNhap);
            dataRowtemp[4] = Int32.Parse(donGiaMatHangNhap);
            dtNhapTemp.Rows.Add(dataRowtemp);
            //Rerender Theme
            reRenderdGV_danhSachMatHang();
            updateThanhTien();
            //Reset textbox
            tb_maMatHangNhap.Text = "";
            tb_soLuongMatHangNhap.Text = "";
            tb_donGiaMatHangNhap.Text = "";
        }

        private void btn_themMatHangXuat_Click(object sender, EventArgs e)
        {
            String maMatHangXuat = tb_maMatHangXuat.Text;
            String soLuongMatHangXuat = tb_soLuongMatHangXuat.Text;
            DateTime ngayBaoHanh = dTP_ngayBaoHanh.Value;
            String tenHangHoa = "";
            int donGiaMatHangXuat = -1;
            //Check isEmpty
            if (String.IsNullOrEmpty(maMatHangXuat) || String.IsNullOrEmpty(soLuongMatHangXuat) )
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
            if((ngayBaoHanh - dTP_ngayLap.Value).TotalDays <= 30)
            {
                MessageBox.Show("Hạn bảo hành phải sau ngày lập tối thiểu 30 ngày!",
                        "Thêm mặt hàng bán",
                        MessageBoxButtons.OK);
                return;
            }
            //Check if exist in added list
            Boolean ifAddedInList = false;
            foreach (DataRow dataRow in dtXuatTemp.Rows)
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
            
            foreach(DataRow dataRow2 in dtMatHang.Rows)
            {
                if(maMatHangXuat == dataRow2[0].ToString())
                {
                    tenHangHoa = dataRow2[2].ToString();
                    donGiaMatHangXuat = Int32.Parse(dataRow2[4].ToString());
                }
            }


            DataRow dataRowtemp;
            dataRowtemp = dtXuatTemp.NewRow();
            dataRowtemp[0] = Int32.Parse(maMatHangXuat);
            dataRowtemp[1] = tenHangHoa;
            dataRowtemp[2] = ngayBaoHanh;
            dataRowtemp[3] = Int32.Parse(soLuongMatHangXuat);
            dataRowtemp[4] = donGiaMatHangXuat;
            dtXuatTemp.Rows.Add(dataRowtemp);
            reRenderdGV_danhSachMatHang();
            updateThanhTien();

            tb_maMatHangXuat.Text = "";
            tb_soLuongMatHangXuat.Text = "";
            dTP_ngayBaoHanh.Value = DateTime.Now;
        }

        private void btn_xoaMatHang_Click(object sender, EventArgs e)
        {
            if( _currentSelectedRow == -1)
            {
                MessageBox.Show("Hãy chọn một hàng", "Thêm Hóa Đơn Mới", MessageBoxButtons.OK);
                return;
            }
            if(cb_loaiHoaDon.SelectedIndex == 0 )
            {
                
                for(int i = 0; i <= dtNhapTemp.Rows.Count-1; i++)
                {
                    DataRow dataRow = dtNhapTemp.Rows[i];
                    if(Int32.Parse(dataRow[0].ToString()) == _currentSelectedRow)
                    {
                        dataRow.Delete();
                        dtNhapTemp.AcceptChanges();
                        reRenderdGV_danhSachMatHang();
                        updateThanhTien();
                        return;
                    }
                }
            } else
            {
                for (int i = 0; i <= dtXuatTemp.Rows.Count - 1; i++)
                {
                    DataRow dataRow = dtXuatTemp.Rows[i];
                    if (Int32.Parse(dataRow[0].ToString()) == _currentSelectedRow)
                    {
                        dataRow.Delete();
                        dtXuatTemp.AcceptChanges();
                        reRenderdGV_danhSachMatHang();
                        updateThanhTien();
                        return;
                    }
                }
            }
            
        }

        // Lấy id của mặt hàng đang được chọn trong data grid view
        private void dGV_danhSachMatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            _currentSelectedRow = e.RowIndex;
            if (e.RowIndex != -1)
            {
                _currentSelectedRow = Convert.ToInt32(dGV_danhSachMatHang.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }

        //Bật trạng thái chỉnh sửa
        private void btn_chinhSua_Click(object sender, EventArgs e)
        {
            if(!_isEditing)
            {
                //Phần này để lấy dữ liệu từ hàng được chọn lên các trường
                if (_currentSelectedRow == -1)
                {
                    MessageBox.Show("Hãy chọn một hàng trước để chỉnh sửa", "Thêm hóa đơn mới");
                    return;
                }
                //Chỉnh sửa 1 số thuộc tính của các nút và trường
                btn_huyChinhSua.Visible = !btn_huyChinhSua.Visible;
                btn_chinhSua.Text = "Cập nhật";
                _isEditing = !_isEditing;
                btn_themHoaDon.Enabled = !btn_themHoaDon.Enabled;
                
                btn_themMatHangNhap.Enabled = !btn_themMatHangNhap.Enabled;
                btn_themMatHangXuat.Enabled = !btn_themMatHangXuat.Enabled;
                btn_xoaMatHang.Enabled = !btn_xoaMatHang.Enabled;
                if (cb_loaiHoaDon.SelectedIndex == 0)
                {
                    foreach(DataRow dataRow in dtNhapTemp.Rows)
                    {
                        //Lấy dữ liệu hàng được chọn lên các trường để cập nhật
                        if(Int32.Parse(dataRow[0].ToString())== _currentSelectedRow)
                        {
                            tb_maMatHangNhap.Text = dataRow[0].ToString();
                            tb_donGiaMatHangNhap.Text = dataRow[3].ToString();
                            tb_soLuongMatHangNhap.Text = dataRow[4].ToString();
                            break;
                        }
                    }
                    //Disable trường Id để không cập nhật lại trường này
                    tb_maMatHangNhap.Enabled = !tb_maMatHangNhap.Enabled;
                }
                else
                {
                    
                    foreach(DataRow dataRow in dtXuatTemp.Rows)
                    {
                        if(Int32.Parse(dataRow[0].ToString())== _currentSelectedRow)
                        {
                            tb_maMatHangXuat.Text = dataRow[0].ToString();
                            dTP_ngayBaoHanh.Value = DateTime.Parse(dataRow[2].ToString());
                            tb_soLuongMatHangXuat.Text = dataRow[3].ToString();
                            break;
                        }
                        
                    }
                    
                    tb_maMatHangXuat.Enabled = !tb_maMatHangXuat.Enabled;
                }
            } else
            {
                //Phần này để cập nhật hàng được chọn từ các trường
                if(cb_loaiHoaDon.SelectedIndex == 0)
                {
                    String donGiaMatHangNhap = tb_donGiaMatHangNhap.Text;
                    String soLuongMatHangNhap = tb_soLuongMatHangNhap.Text;
                    if (soLuongMatHangNhap.Contains('.') || donGiaMatHangNhap.Contains('.'))
                    {
                        MessageBox.Show("Các trường phải nhập số tự nhiên!",
                                "Thêm mặt hàng nhập",
                                MessageBoxButtons.OK);
                        return;
                    }
                    foreach(DataRow dataRow in dtNhapTemp.Rows)
                    {
                        if(Int32.Parse(dataRow[0].ToString()) == _currentSelectedRow)
                        {
                            dataRow[3] = Int32.Parse(donGiaMatHangNhap);
                            dataRow[4] = Int32.Parse(soLuongMatHangNhap);
                            reRenderdGV_danhSachMatHang();
                            updateThanhTien();
                            btn_huyChinhSua.Visible = !btn_huyChinhSua.Visible;
                            btn_chinhSua.Text = "Chỉnh sửa";
                            _isEditing = !_isEditing;
                            btn_themHoaDon.Enabled = !btn_themHoaDon.Enabled;
                            btn_themMatHangNhap.Enabled = !btn_themMatHangNhap.Enabled;
                            btn_themMatHangXuat.Enabled = !btn_themMatHangXuat.Enabled;
                            btn_xoaMatHang.Enabled = !btn_xoaMatHang.Enabled;
                                //Làm trống lại các trường
                                tb_maMatHangNhap.Text = "";
                                tb_soLuongMatHangNhap.Text = "";
                                tb_donGiaMatHangNhap.Text = "";
                                tb_maMatHangNhap.Enabled = !tb_maMatHangNhap.Enabled;
                            //Reset lại hàng được chọn
                            _currentSelectedRow = -1;


                            break;
                        }
                    }
                } else
                {
                    String soLuongMatHangXuat = tb_soLuongMatHangXuat.Text;
                    DateTime ngayBaoHanh = dTP_ngayBaoHanh.Value;
                    if (String.IsNullOrEmpty(soLuongMatHangXuat))
                    {
                        MessageBox.Show("Không được để trường nào trống!",
                                "Thêm mặt hàng bán",
                                MessageBoxButtons.OK);
                        return;
                    }
                    //Check Integer
                    if (soLuongMatHangXuat.Contains('.'))
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
                    foreach(DataRow dataRow in dtXuatTemp.Rows)
                    {
                        if(Int32.Parse(dataRow[0].ToString())== _currentSelectedRow)
                        {
                            dataRow[2] = ngayBaoHanh;
                            dataRow[3] = Int32.Parse(soLuongMatHangXuat);
                            reRenderdGV_danhSachMatHang();
                            updateThanhTien();
                            btn_huyChinhSua.Visible = !btn_huyChinhSua.Visible;
                            btn_chinhSua.Text = "Chỉnh sửa";
                            _isEditing = !_isEditing;
                            btn_themHoaDon.Enabled = !btn_themHoaDon.Enabled;
                            btn_themMatHangNhap.Enabled = !btn_themMatHangNhap.Enabled;
                            btn_themMatHangXuat.Enabled = !btn_themMatHangXuat.Enabled;
                            btn_xoaMatHang.Enabled = !btn_xoaMatHang.Enabled;
                                tb_maMatHangXuat.Text = "";
                                tb_soLuongMatHangXuat.Text = "";
                                dTP_ngayBaoHanh.Value = DateTime.Today;
                                tb_maMatHangXuat.Enabled = !tb_maMatHangXuat.Enabled;
                            _currentSelectedRow = -1;
                            break;
                        }
                    }
                }
            }

        }
        //Chạy khi không muốn chỉnh sửa
        private void btn_huyChinhSua_Click(object sender, EventArgs e)
        {
            //Reset lại các thuộc tính nếu đang trong trạng thái chỉnh sửa
            if(_isEditing)
            {
                btn_huyChinhSua.Visible = !btn_huyChinhSua.Visible;
                btn_chinhSua.Text = "Chỉnh sửa";
                _isEditing = !_isEditing;
                btn_themHoaDon.Enabled = !btn_themHoaDon.Enabled;
                btn_themMatHangNhap.Enabled = !btn_themMatHangNhap.Enabled;
                btn_themMatHangXuat.Enabled = !btn_themMatHangXuat.Enabled;
                btn_xoaMatHang.Enabled = !btn_xoaMatHang.Enabled;
                _currentSelectedRow = -1;
                if (cb_loaiHoaDon.SelectedIndex == 0)
                {
                    tb_maMatHangNhap.Text = "";
                    tb_soLuongMatHangNhap.Text = "";
                    tb_donGiaMatHangNhap.Text = "";
                    tb_maMatHangNhap.Enabled = !tb_maMatHangNhap.Enabled;
                } else
                {
                    tb_maMatHangXuat.Text = "";
                    tb_soLuongMatHangXuat.Text = "";
                    dTP_ngayBaoHanh.Value = DateTime.Today;
                    tb_maMatHangXuat.Enabled = !tb_maMatHangXuat.Enabled;
                }
            }
        }

        private void btn_themHoaDon_Click(object sender, EventArgs e)
        {
            String nhanVienLap = tb_nhanVienLap.Text;
            String tenKhachHang = tb_tenKhachHang.Text;
            DateTime ngayLap = dTP_ngayLap.Value;
            //Check không được để trường trống
            if (String.IsNullOrEmpty(nhanVienLap)|| String.IsNullOrEmpty(tenKhachHang))
            {
                MessageBox.Show("Không được để trường 'Nhân Viên Lập' hoặc 'Tên Khách Hàng' trống",
                    "Thêm hóa đơn mới");
                return;
            }
            //Check ngày lập
            if(DateTime.Compare(ngayLap,DateTime.Now) > 0)
            {
                MessageBox.Show("Ngày lập không được trong tương lai",
                    "Thêm hóa đơn mới");
                return;
            }
            //Phần thêm vào database
            if(cb_loaiHoaDon.SelectedIndex == 0)
            {
                if (dtNhapTemp.Rows.Count > 0)
                {
                    //Phần hàng nhập
                    String insertTotblHoaDonNhapHang = "EXECUTE dbo.PROC_insertTotblHoaDonNhapHang "
                        + "'" + ngayLap.ToString("MM/dd/yyyy") + "',N'" + nhanVienLap + "',N'" + tenKhachHang +"'";
                    String instertTotblHangNhap = "EXECUTE dbo.PROC_instertTotblHangNhap  ";
                    int _lastIndex = -1;
                    String getLatestInsertedKeyFromtblHoaDonNhapHang = "EXECUTE dbo.PROC_getLatestInsertedKeyFromtblHoaDonNhapHang";
                    using (SqlConnection cnn = new SqlConnection(connectionString))
                    {
                        cnn.Open();
                        //Thêm dữ liệu vào bảng tblHoaDonNhapHang
                        using (SqlCommand cmd = new SqlCommand(insertTotblHoaDonNhapHang, cnn))
                        {
                            cmd.ExecuteNonQuery();
                        }
                        //Lấy Id hóa đơn vừa được nhập
                        using (SqlCommand cmd = new SqlCommand(getLatestInsertedKeyFromtblHoaDonNhapHang, cnn))
                        {
                            decimal lastValue = (decimal)cmd.ExecuteScalar();
                            _lastIndex = Int32.Parse(lastValue.ToString());
                        }
                        //Thêm dữ liệu vào bảng tblHangNhap
                        foreach (DataRow dataRow in dtNhapTemp.Rows)
                        {
                            String insertCmd = instertTotblHangNhap + dataRow[0].ToString() +','+_lastIndex + ',' + dataRow[3].ToString() + ',' + dataRow[4].ToString();
                            using(SqlCommand cmd = new SqlCommand(insertCmd, cnn))
                            {
                                cmd.ExecuteNonQuery();
                            }
                        }
                        cnn.Close();
                        
                    }
                    this.Close();
                    MessageBox.Show("Thêm hóa đơn nhập mới hoàn tất! \n Hóa đơn có mã " + _lastIndex.ToString(), "Thêm Hóa Đơn Mới");
                } else
                {
                    MessageBox.Show("Thêm mặt hàng vào hóa đơn trước khi thêm hóa đơn vào dữ liệu", "Thêm Hóa Đơn Mới");
                }
            } else
            {
               if(dtXuatTemp.Rows.Count >0)
                {
                    String trangThaiTemp = "";
                    //Lấy dữ liệu trạng thái đơn hàng
                    if(rb_daThanhToan.Checked)
                    {
                        trangThaiTemp = "1";
                    } else
                    {
                        trangThaiTemp = "0";
                    }
                    //Phần dưới là xuất tương tư như với nhập
                    String insertTotblHoaDonBanHang = "EXECUTE dbo.PROC_insertTotblHoaDonBanHang " 
                        + "N'" + nhanVienLap + "',N'" + tenKhachHang + "','" + ngayLap.ToString("MM/dd/yyyy") +"'," +trangThaiTemp;

                    String getLatestInsertedKeyFromtblHoaDonBanHang = "EXECUTE dbo.PROC_getLatestInsertedKeyFromtblHoaDonBanHang ";
                    String insertTotblHangDaBan = "EXECUTE dbo.insertTotblHangDaBan ";
                    int _lastIndex = -1;
                    using (SqlConnection cnn = new SqlConnection(connectionString))
                    {
                        cnn.Open();
                        using (SqlCommand cmd = new SqlCommand(insertTotblHoaDonBanHang, cnn))
                        {
                            cmd.ExecuteNonQuery();
                        }
                        using (SqlCommand cmd = new SqlCommand(getLatestInsertedKeyFromtblHoaDonBanHang, cnn))
                        {
                            decimal lastValue = (decimal)cmd.ExecuteScalar();
                            _lastIndex = Int32.Parse(lastValue.ToString());
                        }
                        foreach (DataRow dataRow in dtXuatTemp.Rows)
                        {
                            MessageBox.Show(dataRow[2].ToString());
                            String insertCmd = insertTotblHangDaBan + _lastIndex.ToString() + "," + dataRow[0].ToString() + "," + dataRow[3].ToString() + ",'" + dataRow[2].ToString() + "'";
                            using (SqlCommand cmd = new SqlCommand(insertCmd, cnn))
                            {
                                cmd.ExecuteNonQuery();
                            }
                        }
                        MessageBox.Show("Thêm hóa đơn bán mới hoàn tất! \n Hóa đơn có mã " + _lastIndex.ToString(), "Thêm Hóa Đơn Mới");
                        cnn.Close();
                    }

                } else
                {
                   MessageBox.Show("Thêm mặt hàng vào hóa đơn trước khi thêm hóa đơn vào dữ liệu", "Thêm Hóa Đơn Mới");
                }
            }
        }
    }
}
