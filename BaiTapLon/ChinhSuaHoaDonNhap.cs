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
    public partial class ChinhSuaHoaDonNhap : Form
    {
        string connectionString = @"SERVER=LAPTOP-NATTQ2BG\SQLEXPRESS; DATABASE=BaiTapLon; UID=sa; PWD=654321;";
        // string connectionString = @"SERVER=DESKTOP-40S0GVK; DATABASE=BaiTapLon;UID=amin;PWD=hoangominh";
        int sum = 0;
        DataTable dtTemp = new DataTable();
        DataTable dtMatHang = new DataTable();
        int seletedRow = -1;
        bool isEditing = false;

        
        public ChinhSuaHoaDonNhap()
        {
            InitializeComponent();
        }
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
                sumTemp += Convert.ToInt32(row[5].ToString()) * Convert.ToInt32(row[4].ToString());
            }
            sum = sumTemp;
            lb_thanhTien.Text = string.Format("{0:#,0}", sum) + " đ";
        }
        private void ChinhSuaHoaDonNhap_Load(object sender, EventArgs e)
        {
            int receiptId = this.maHoaDon;
            lb_maHoaDon.Text = receiptId.ToString();
            string sqlcmd_getDonNhapHang = "SELECT * FROM tblHoaDonNhapHang WHERE PK_iMaHoaDon=" + receiptId.ToString();
            string sqlcmd_getDonNhapHangInfo = "EXECUTE dbo.PROC_getImportReceiptInfo " + receiptId.ToString();
            string sqlcmd2 = "SELECT * FROM tblHangHoa";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(sqlcmd_getDonNhapHang, cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        DateTime aDate = Convert.ToDateTime(dt.Rows[0][1].ToString());
                        dTP_ngayLap.Value = aDate;
                        tb_tenKhachHang.Text = dt.Rows[0][3].ToString();
                        tb_nhanVienLap.Text = dt.Rows[0][2].ToString();
                    }

                }
                using (SqlCommand cmd = new SqlCommand(sqlcmd_getDonNhapHangInfo, cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        sda.Fill(dtTemp);
                        dGV_danhSachMatHang.DataSource = dtTemp;
                        dGV_danhSachMatHang.Columns[0].MinimumWidth = 20;
                        dGV_danhSachMatHang.Columns[1].MinimumWidth = 210;
                        dGV_danhSachMatHang.Columns[2].MinimumWidth = 100;
                        dGV_danhSachMatHang.Columns[3].MinimumWidth = 80;
                        dGV_danhSachMatHang.Columns[4].MinimumWidth = 30;
                        dGV_danhSachMatHang.Columns[5].MinimumWidth = 120;
                        dGV_danhSachMatHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        
                    }
                    reRenderThanhTien();

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

        }

        private void dGV_danhSachMatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seletedRow = e.RowIndex;
            if (e.RowIndex != -1)
            {
                seletedRow = Convert.ToInt32(dGV_danhSachMatHang.Rows[e.RowIndex].Cells[0].Value.ToString());

            }
        }

        private void tb_maMatHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkChiThemSoTuNhien(sender, e);
        }

        private void tb_soLuongMatHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkChiThemSoTuNhien(sender, e);
        }

        private void tb_donGiaMatHang_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btn_themMatHang_Click(object sender, EventArgs e)
        {
            if(!isEditing)
            {
                String maMatHangNhap = tb_maMatHang.Text;
                String soLuongMatHangNhap = tb_soLuongMatHang.Text;
                String donGiaMatHangNhap = tb_donGiaMatHang.Text;
                String tenHangHoa = "", nhanHieu = "", mauSac = "";
                //Check isEmpty
                if (String.IsNullOrEmpty(maMatHangNhap) ||
                    String.IsNullOrEmpty(soLuongMatHangNhap) ||
                    String.IsNullOrEmpty(donGiaMatHangNhap))
                {
                    MessageBox.Show("Không được để trường nào trống!",
                            "Chỉnh sửa hóa đơn nhập",
                            MessageBoxButtons.OK);
                    return;
                }
                //Check Integer
                if (maMatHangNhap.Contains('.') ||
                    soLuongMatHangNhap.Contains('.') ||
                    donGiaMatHangNhap.Contains('.'))
                {
                    MessageBox.Show("Các trường phải nhập số tự nhiên!",
                            "Chỉnh sửa hóa đơn nhập",
                            MessageBoxButtons.OK);
                    return;
                }
                //Check if exist in added list
                Boolean ifAddedInList = false;
                foreach (DataRow dataRow in dtTemp.Rows)
                {
                    if (dataRow[0].ToString() == maMatHangNhap)
                    {
                        ifAddedInList = true;
                    }
                }
                if (ifAddedInList)
                {
                    MessageBox.Show("Mặt hàng vừa nhập đã tồn tại trong danh sách.\n" +
                        "Hãy xóa mặt hàng đó trước khi thêm mới hoặc chỉnh sửa mặt hàng đó!",
                            "Chỉnh sửa hóa đơn nhập",
                            MessageBoxButtons.OK);
                    return;
                }

                // check if exist in tblMatHang
                Boolean ifExistInDB = false;
                foreach (DataRow dataRow1 in dtMatHang.Rows)
                {
                    if (dataRow1[0].ToString() == maMatHangNhap)
                    {
                        tenHangHoa = dataRow1[2].ToString();
                        nhanHieu = dataRow1[5].ToString();
                        mauSac = dataRow1[6].ToString();
                        ifExistInDB = true;
                        break;
                    }
                }
                if (!ifExistInDB)
                {
                    MessageBox.Show("Mặt hàng vừa nhập chưa tồn tại trong dữ liệu",
                            "Chỉnh sửa hóa đơn nhập",
                            MessageBoxButtons.OK);
                    return;
                }
                if (Int32.Parse(soLuongMatHangNhap) <= 0)
                {
                    MessageBox.Show("Số lượng mặt hàng phải lớn hơn 0!",
                            "Chỉnh sửa hóa đơn nhập",
                            MessageBoxButtons.OK);
                    return;
                }
                if (Int32.Parse(donGiaMatHangNhap) <= 0)
                {
                    MessageBox.Show("Đơn giá mặt hàng phải lớn hơn 0!",
                            "Chỉnh sửa hóa đơn nhập",
                            MessageBoxButtons.OK);
                    return;
                }


                DataRow dataRowtemp;
                dataRowtemp = dtTemp.NewRow();
                dataRowtemp[0] = Int32.Parse(maMatHangNhap);
                dataRowtemp[1] = tenHangHoa;
                dataRowtemp[2] = nhanHieu;
                dataRowtemp[3] = mauSac;
                dataRowtemp[4] = Int32.Parse(soLuongMatHangNhap);
                dataRowtemp[5] = Int32.Parse(donGiaMatHangNhap);
                dtTemp.Rows.Add(dataRowtemp);
                //Rerender Theme
                reRenderdGV_danhSachMatHang();
                reRenderThanhTien();
                //Reset textbox
                tb_maMatHang.Text = "";
                tb_soLuongMatHang.Text = "";
                tb_donGiaMatHang.Text = "";
            } else
            {
                btn_xoaMatHang.Enabled = !btn_xoaMatHang.Enabled;
                btn_themMatHang.Text = "Thêm mặt hàng";
                btn_suaMatHang.Text = "Sửa mặt hàng";
                tb_maMatHang.Enabled = !tb_maMatHang.Enabled;
                tb_maMatHang.Text = "";
                tb_soLuongMatHang.Text = "";
                tb_donGiaMatHang.Text = "";
                isEditing = !isEditing;
            }
            
        }

        private void btn_suaMatHang_Click(object sender, EventArgs e)
        {
            if(!isEditing)
            {
                if (seletedRow == -1)
                {
                    MessageBox.Show("Hãy chọn 1 trường",
                        "Chỉnh sửa hóa đơn nhập",
                        MessageBoxButtons.OK);
                    return;
                }
                tb_maMatHang.Enabled = !tb_maMatHang.Enabled;
                btn_xoaMatHang.Enabled = !btn_xoaMatHang.Enabled;
                btn_themMatHang.Text = "Hủy";
                btn_suaMatHang.Text = "Xác nhận";
                isEditing = !isEditing;
                foreach(DataRow dataRow in dtTemp.Rows)
                {
                    if(dataRow[0].ToString() == seletedRow.ToString())
                    {
                        tb_maMatHang.Text = dataRow[0].ToString();
                        tb_soLuongMatHang.Text = dataRow[4].ToString();
                        tb_donGiaMatHang.Text = dataRow[5].ToString();
                        break;
                    }
                } 
            } else
            {
                string soLuongMatHang = tb_soLuongMatHang.Text;
                string donGiaMatHang = tb_donGiaMatHang.Text;
                //Check isEmpty
                
                if (String.IsNullOrEmpty(soLuongMatHang) ||
                    String.IsNullOrEmpty(donGiaMatHang))
                {
                    MessageBox.Show("Không được để trường nào trống!",
                            "Chỉnh sửa hóa đơn nhập",
                            MessageBoxButtons.OK);
                    return;
                }
                //Check Integer
                if (soLuongMatHang.Contains('.') ||
                    donGiaMatHang.Contains('.'))
                {
                    MessageBox.Show("Các trường phải nhập số tự nhiên!",
                            "Chỉnh sửa hóa đơn nhập",
                            MessageBoxButtons.OK);
                    return;
                }
                foreach (DataRow dataRow in dtTemp.Rows)
                {
                    if (dataRow[0].ToString() == seletedRow.ToString())
                    {
                        dataRow[4] = Int32.Parse(soLuongMatHang);
                        dataRow[5] = Int32.Parse(donGiaMatHang);
                        reRenderdGV_danhSachMatHang();
                        reRenderThanhTien();
                        btn_xoaMatHang.Enabled = !btn_xoaMatHang.Enabled;
                        btn_themMatHang.Text = "Thêm mặt hàng";
                        btn_suaMatHang.Text = "Sửa mặt hàng";
                        tb_maMatHang.Enabled = !tb_maMatHang.Enabled;
                        tb_maMatHang.Text = "";
                        tb_soLuongMatHang.Text = "";
                        tb_donGiaMatHang.Text = "";
                        isEditing = !isEditing;
                        break;
                    }
                }
            }
        }

        private void btn_xoaMatHang_Click(object sender, EventArgs e)
        {
            if (seletedRow == -1)
            {
                MessageBox.Show("Hãy chọn 1 trường",
                    "Chỉnh sửa hóa đơn nhập",
                    MessageBoxButtons.OK);
                return;
            }
            for (int i = dtTemp.Rows.Count - 1; i >= 0; i--)
            {
                DataRow dr = dtTemp.Rows[i];
                if (Int32.Parse(dr[0].ToString()) == seletedRow)
                    dr.Delete();
            }
            dtTemp.AcceptChanges();
            reRenderdGV_danhSachMatHang();
            reRenderThanhTien();
            seletedRow = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult =  MessageBox.Show("Mọi thay đổi của bạn sẽ không được lưu, bạn có chắc muốn thoát?",
                "Chỉnh sửa hóa đơn nhập",
                MessageBoxButtons.OKCancel);
            if(dialogResult == DialogResult.OK)
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
            string updatetblHoaDonNhapHang = "EXECUTE dbo.PROC_updatetblHoaDonNhapHang " + 
                this.maHoaDon.ToString() + ",'" + 
                ngayLap.ToString("MM/dd/yyyy") + "',N'" + 
                nhanVienLap + "',N'" + 
                tenKhachHang + "'";
            string deleteRowstblHangNhap = "EXECUTE dbo.PROC_deleteRowstblHangNhap " + this.maHoaDon.ToString();
            String instertTotblHangNhap = "EXECUTE dbo.PROC_instertTotblHangNhap  ";
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
            if(dtTemp.Rows.Count < 1)
            {
                MessageBox.Show("Không được để danh sách mặt hàng trống",
                    "Chỉnh sửa hóa đơn nhập");
                return;
            }
            using(SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(updatetblHoaDonNhapHang, cnn))
                {
                    cmd.ExecuteNonQuery();
                }
                using(SqlCommand cmd = new SqlCommand(deleteRowstblHangNhap, cnn))
                {
                    cmd.ExecuteNonQuery();
                }
                foreach(DataRow dataRow in dtTemp.Rows)
                {
                    string insert = instertTotblHangNhap + dataRow[0].ToString() + "," + this.maHoaDon.ToString() + "," + dataRow[4].ToString() + "," + dataRow[5].ToString();
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
