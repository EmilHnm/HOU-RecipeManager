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
    public partial class XemChiTietHoaDonXuat : Form
    {
        string connectionString = @"SERVER=LAPTOP-NATTQ2BG\SQLEXPRESS; DATABASE=BaiTapLon; UID=sa; PWD=654321;";
        // string connectionString = @"SERVER=DESKTOP-40S0GVK; DATABASE=BaiTapLon;UID=amin;PWD=hoangominh";
        int receiptId;
        int sum = 0;
        int tinhTrang = 0;

        public XemChiTietHoaDonXuat()
        {
            InitializeComponent();
        }

        public int Value { get; set; }

        private void XemChiTietHoaDonXuat_Load(object sender, EventArgs e)
        {
            receiptId = Value;
            lb_maHoaDon.Text = receiptId.ToString();
            receiptId = Convert.ToInt32(Value.ToString());
            lb_maHoaDon.Text = receiptId.ToString();
            string sqlcmd_getDonXuatHang = "SELECT * FROM tblHoaDonBanHang WHERE PK_iMaHoaDon=" + receiptId.ToString();
            string sqlcmd_getDonXuatHangInfo = "EXECUTE dbo.PROC_getExportDetailInfo " + receiptId.ToString();
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
                        lb_ngayLap.Text = aDate.ToString("MM/dd/yyyy");
                        lb_tenKhachHang.Text = dt.Rows[0][2].ToString();
                        lb_tenNguoiLap.Text = dt.Rows[0][1].ToString();
                        if (Convert.ToBoolean(dt.Rows[0][4]) == true)
                        {
                            lb_tinhTrang.Text = "Đã thanh toán";
                            lb_tinhTrang.ForeColor = Color.LimeGreen;
                            tinhTrang = 1;
                        } else
                        {
                            lb_tinhTrang.Text = "Chưa thanh toán";
                            lb_tinhTrang.ForeColor = Color.Red;
                            tinhTrang = 0;
                        }


                    }
                }
                using (SqlCommand cmd = new SqlCommand(sqlcmd_getDonXuatHangInfo, cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dGV_danhSachMatHang.DataSource = dt;
                        dGV_danhSachMatHang.Columns[0].MinimumWidth = 20;
                        dGV_danhSachMatHang.Columns[1].MinimumWidth = 210;
                        dGV_danhSachMatHang.Columns[2].MinimumWidth = 100;
                        dGV_danhSachMatHang.Columns[3].MinimumWidth = 100;
                        dGV_danhSachMatHang.Columns[4].MinimumWidth = 30;
                        dGV_danhSachMatHang.Columns[5].MinimumWidth = 120;
                        dGV_danhSachMatHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        foreach (DataRow row in dt.Rows)
                        {
                            sum += Convert.ToInt32(row[5].ToString()) * Convert.ToInt32(row[3].ToString());
                        }
                        lb_thanhTien.Text = string.Format("{0:#,0}", sum) + " đ";
                    }
                }
                cnn.Close();
            }
        }

        private void btn_printReceipt_Click(object sender, EventArgs e)
        {
            InHoaDonXuat inHoaDonXuat = new InHoaDonXuat();
            inHoaDonXuat.maHoaDon = Value;
            inHoaDonXuat.tinhTrang = tinhTrang;
            inHoaDonXuat.Show();
        }
    }
}
