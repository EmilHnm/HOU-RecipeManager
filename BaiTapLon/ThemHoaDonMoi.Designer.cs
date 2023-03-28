
namespace BaiTapLon
{
    partial class ThemHoaDonMoi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cb_loaiHoaDon = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_nhanVienLap = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dTP_ngayLap = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_tenKhachHang = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pn_trangThai = new System.Windows.Forms.Panel();
            this.rb_chuaThanhToan = new System.Windows.Forms.RadioButton();
            this.rb_daThanhToan = new System.Windows.Forms.RadioButton();
            this.dGV_danhSachMatHang = new System.Windows.Forms.DataGridView();
            this.pn_themMatHangNhap = new System.Windows.Forms.Panel();
            this.btn_themMatHangNhap = new System.Windows.Forms.Button();
            this.tb_donGiaMatHangNhap = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_soLuongMatHangNhap = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_maMatHangNhap = new System.Windows.Forms.TextBox();
            this.pn_themMatHangXuat = new System.Windows.Forms.Panel();
            this.dTP_ngayBaoHanh = new System.Windows.Forms.DateTimePicker();
            this.btn_themMatHangXuat = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_soLuongMatHangXuat = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_maMatHangXuat = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_themHoaDon = new System.Windows.Forms.Button();
            this.btn_xoaMatHang = new System.Windows.Forms.Button();
            this.btn_chinhSua = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.lb_thanhTien = new System.Windows.Forms.Label();
            this.btn_huyChinhSua = new System.Windows.Forms.Button();
            this.pn_trangThai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_danhSachMatHang)).BeginInit();
            this.pn_themMatHangNhap.SuspendLayout();
            this.pn_themMatHangXuat.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm Hóa Đơn Mới";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb_loaiHoaDon
            // 
            this.cb_loaiHoaDon.FormattingEnabled = true;
            this.cb_loaiHoaDon.Location = new System.Drawing.Point(379, 67);
            this.cb_loaiHoaDon.Name = "cb_loaiHoaDon";
            this.cb_loaiHoaDon.Size = new System.Drawing.Size(192, 21);
            this.cb_loaiHoaDon.TabIndex = 1;
            this.cb_loaiHoaDon.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(228, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Loại hóa đơn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(43, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nhân Viên Lập";
            // 
            // tb_nhanVienLap
            // 
            this.tb_nhanVienLap.Location = new System.Drawing.Point(196, 114);
            this.tb_nhanVienLap.Name = "tb_nhanVienLap";
            this.tb_nhanVienLap.Size = new System.Drawing.Size(196, 20);
            this.tb_nhanVienLap.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(485, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ngày Lập";
            // 
            // dTP_ngayLap
            // 
            this.dTP_ngayLap.Location = new System.Drawing.Point(567, 114);
            this.dTP_ngayLap.Name = "dTP_ngayLap";
            this.dTP_ngayLap.Size = new System.Drawing.Size(200, 20);
            this.dTP_ngayLap.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(43, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tên Khách Hàng";
            // 
            // tb_tenKhachHang
            // 
            this.tb_tenKhachHang.Location = new System.Drawing.Point(196, 153);
            this.tb_tenKhachHang.Name = "tb_tenKhachHang";
            this.tb_tenKhachHang.Size = new System.Drawing.Size(571, 20);
            this.tb_tenKhachHang.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(-3, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Trạng thái";
            // 
            // pn_trangThai
            // 
            this.pn_trangThai.Controls.Add(this.rb_chuaThanhToan);
            this.pn_trangThai.Controls.Add(this.rb_daThanhToan);
            this.pn_trangThai.Controls.Add(this.label6);
            this.pn_trangThai.Location = new System.Drawing.Point(46, 188);
            this.pn_trangThai.Name = "pn_trangThai";
            this.pn_trangThai.Size = new System.Drawing.Size(721, 24);
            this.pn_trangThai.TabIndex = 10;
            this.pn_trangThai.Visible = false;
            // 
            // rb_chuaThanhToan
            // 
            this.rb_chuaThanhToan.AutoSize = true;
            this.rb_chuaThanhToan.Checked = true;
            this.rb_chuaThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rb_chuaThanhToan.ForeColor = System.Drawing.Color.Red;
            this.rb_chuaThanhToan.Location = new System.Drawing.Point(288, 3);
            this.rb_chuaThanhToan.Name = "rb_chuaThanhToan";
            this.rb_chuaThanhToan.Size = new System.Drawing.Size(141, 21);
            this.rb_chuaThanhToan.TabIndex = 11;
            this.rb_chuaThanhToan.TabStop = true;
            this.rb_chuaThanhToan.Text = "Chưa Thanh Toán";
            this.rb_chuaThanhToan.UseVisualStyleBackColor = true;
            // 
            // rb_daThanhToan
            // 
            this.rb_daThanhToan.AutoSize = true;
            this.rb_daThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rb_daThanhToan.ForeColor = System.Drawing.Color.LimeGreen;
            this.rb_daThanhToan.Location = new System.Drawing.Point(150, 3);
            this.rb_daThanhToan.Name = "rb_daThanhToan";
            this.rb_daThanhToan.Size = new System.Drawing.Size(126, 21);
            this.rb_daThanhToan.TabIndex = 10;
            this.rb_daThanhToan.Text = "Đã Thanh Toán";
            this.rb_daThanhToan.UseVisualStyleBackColor = true;
            // 
            // dGV_danhSachMatHang
            // 
            this.dGV_danhSachMatHang.AllowUserToAddRows = false;
            this.dGV_danhSachMatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_danhSachMatHang.Location = new System.Drawing.Point(46, 334);
            this.dGV_danhSachMatHang.Name = "dGV_danhSachMatHang";
            this.dGV_danhSachMatHang.ReadOnly = true;
            this.dGV_danhSachMatHang.Size = new System.Drawing.Size(721, 241);
            this.dGV_danhSachMatHang.TabIndex = 11;
            this.dGV_danhSachMatHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_danhSachMatHang_CellClick);
            // 
            // pn_themMatHangNhap
            // 
            this.pn_themMatHangNhap.Controls.Add(this.btn_themMatHangNhap);
            this.pn_themMatHangNhap.Controls.Add(this.tb_donGiaMatHangNhap);
            this.pn_themMatHangNhap.Controls.Add(this.label10);
            this.pn_themMatHangNhap.Controls.Add(this.tb_soLuongMatHangNhap);
            this.pn_themMatHangNhap.Controls.Add(this.label9);
            this.pn_themMatHangNhap.Controls.Add(this.tb_maMatHangNhap);
            this.pn_themMatHangNhap.Controls.Add(this.label8);
            this.pn_themMatHangNhap.Controls.Add(this.label7);
            this.pn_themMatHangNhap.Location = new System.Drawing.Point(46, 230);
            this.pn_themMatHangNhap.Name = "pn_themMatHangNhap";
            this.pn_themMatHangNhap.Size = new System.Drawing.Size(721, 68);
            this.pn_themMatHangNhap.TabIndex = 12;
            this.pn_themMatHangNhap.Visible = false;
            // 
            // btn_themMatHangNhap
            // 
            this.btn_themMatHangNhap.Location = new System.Drawing.Point(642, 28);
            this.btn_themMatHangNhap.Name = "btn_themMatHangNhap";
            this.btn_themMatHangNhap.Size = new System.Drawing.Size(75, 23);
            this.btn_themMatHangNhap.TabIndex = 7;
            this.btn_themMatHangNhap.Text = "Thêm";
            this.btn_themMatHangNhap.UseVisualStyleBackColor = true;
            this.btn_themMatHangNhap.Click += new System.EventHandler(this.btn_themMatHangNhap_Click);
            // 
            // tb_donGiaMatHangNhap
            // 
            this.tb_donGiaMatHangNhap.Location = new System.Drawing.Point(442, 30);
            this.tb_donGiaMatHangNhap.Name = "tb_donGiaMatHangNhap";
            this.tb_donGiaMatHangNhap.Size = new System.Drawing.Size(127, 20);
            this.tb_donGiaMatHangNhap.TabIndex = 6;
            this.tb_donGiaMatHangNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_donGiaMatHangNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_donGiaMatHangNhap_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label10.Location = new System.Drawing.Point(368, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 17);
            this.label10.TabIndex = 5;
            this.label10.Text = "Đơn Giá";
            // 
            // tb_soLuongMatHangNhap
            // 
            this.tb_soLuongMatHangNhap.Location = new System.Drawing.Point(278, 30);
            this.tb_soLuongMatHangNhap.Name = "tb_soLuongMatHangNhap";
            this.tb_soLuongMatHangNhap.Size = new System.Drawing.Size(44, 20);
            this.tb_soLuongMatHangNhap.TabIndex = 4;
            this.tb_soLuongMatHangNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_soLuongMatHangNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_soLuongMatHangNhap_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label9.Location = new System.Drawing.Point(203, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "Số Lượng";
            // 
            // tb_maMatHangNhap
            // 
            this.tb_maMatHangNhap.Location = new System.Drawing.Point(101, 30);
            this.tb_maMatHangNhap.Name = "tb_maMatHangNhap";
            this.tb_maMatHangNhap.Size = new System.Drawing.Size(44, 20);
            this.tb_maMatHangNhap.TabIndex = 2;
            this.tb_maMatHangNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_maMatHangNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // pn_themMatHangXuat
            // 
            this.pn_themMatHangXuat.Controls.Add(this.dTP_ngayBaoHanh);
            this.pn_themMatHangXuat.Controls.Add(this.btn_themMatHangXuat);
            this.pn_themMatHangXuat.Controls.Add(this.label11);
            this.pn_themMatHangXuat.Controls.Add(this.tb_soLuongMatHangXuat);
            this.pn_themMatHangXuat.Controls.Add(this.label12);
            this.pn_themMatHangXuat.Controls.Add(this.tb_maMatHangXuat);
            this.pn_themMatHangXuat.Controls.Add(this.label13);
            this.pn_themMatHangXuat.Controls.Add(this.label14);
            this.pn_themMatHangXuat.Location = new System.Drawing.Point(46, 231);
            this.pn_themMatHangXuat.Name = "pn_themMatHangXuat";
            this.pn_themMatHangXuat.Size = new System.Drawing.Size(721, 68);
            this.pn_themMatHangXuat.TabIndex = 13;
            this.pn_themMatHangXuat.Visible = false;
            // 
            // dTP_ngayBaoHanh
            // 
            this.dTP_ngayBaoHanh.Location = new System.Drawing.Point(442, 31);
            this.dTP_ngayBaoHanh.Name = "dTP_ngayBaoHanh";
            this.dTP_ngayBaoHanh.Size = new System.Drawing.Size(180, 20);
            this.dTP_ngayBaoHanh.TabIndex = 8;
            this.dTP_ngayBaoHanh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dTP_ngayBaoHanh_KeyPress);
            // 
            // btn_themMatHangXuat
            // 
            this.btn_themMatHangXuat.Location = new System.Drawing.Point(642, 28);
            this.btn_themMatHangXuat.Name = "btn_themMatHangXuat";
            this.btn_themMatHangXuat.Size = new System.Drawing.Size(75, 23);
            this.btn_themMatHangXuat.TabIndex = 7;
            this.btn_themMatHangXuat.Text = "Thêm";
            this.btn_themMatHangXuat.UseVisualStyleBackColor = true;
            this.btn_themMatHangXuat.Click += new System.EventHandler(this.btn_themMatHangXuat_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label11.Location = new System.Drawing.Point(368, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 17);
            this.label11.TabIndex = 5;
            this.label11.Text = "Bảo hành";
            // 
            // tb_soLuongMatHangXuat
            // 
            this.tb_soLuongMatHangXuat.Location = new System.Drawing.Point(278, 30);
            this.tb_soLuongMatHangXuat.Name = "tb_soLuongMatHangXuat";
            this.tb_soLuongMatHangXuat.Size = new System.Drawing.Size(44, 20);
            this.tb_soLuongMatHangXuat.TabIndex = 4;
            this.tb_soLuongMatHangXuat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_soLuongMatHangXuat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_soLuongMatHangXuat_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label12.Location = new System.Drawing.Point(203, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 17);
            this.label12.TabIndex = 3;
            this.label12.Text = "Số Lượng";
            // 
            // tb_maMatHangXuat
            // 
            this.tb_maMatHangXuat.Location = new System.Drawing.Point(101, 30);
            this.tb_maMatHangXuat.Name = "tb_maMatHangXuat";
            this.tb_maMatHangXuat.Size = new System.Drawing.Size(44, 20);
            this.tb_maMatHangXuat.TabIndex = 2;
            this.tb_maMatHangXuat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_maMatHangXuat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_maMatHangXuat_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label13.Location = new System.Drawing.Point(3, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 17);
            this.label13.TabIndex = 1;
            this.label13.Text = "Mã Mặt Hàng";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label14.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label14.Location = new System.Drawing.Point(3, 4);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(142, 17);
            this.label14.TabIndex = 0;
            this.label14.Text = "Thêm Mặt Hàng Xuất";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label8.Location = new System.Drawing.Point(3, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Mã Mặt Hàng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label7.Location = new System.Drawing.Point(4, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Thêm Mặt Hàng Nhập";
            // 
            // btn_themHoaDon
            // 
            this.btn_themHoaDon.Location = new System.Drawing.Point(650, 625);
            this.btn_themHoaDon.Name = "btn_themHoaDon";
            this.btn_themHoaDon.Size = new System.Drawing.Size(117, 35);
            this.btn_themHoaDon.TabIndex = 14;
            this.btn_themHoaDon.Text = "Thêm Hóa Đơn";
            this.btn_themHoaDon.UseVisualStyleBackColor = true;
            this.btn_themHoaDon.Click += new System.EventHandler(this.btn_themHoaDon_Click);
            // 
            // btn_xoaMatHang
            // 
            this.btn_xoaMatHang.Location = new System.Drawing.Point(654, 304);
            this.btn_xoaMatHang.Name = "btn_xoaMatHang";
            this.btn_xoaMatHang.Size = new System.Drawing.Size(113, 23);
            this.btn_xoaMatHang.TabIndex = 15;
            this.btn_xoaMatHang.Text = "Xóa Mặt Hàng";
            this.btn_xoaMatHang.UseVisualStyleBackColor = true;
            this.btn_xoaMatHang.Click += new System.EventHandler(this.btn_xoaMatHang_Click);
            // 
            // btn_chinhSua
            // 
            this.btn_chinhSua.Location = new System.Drawing.Point(46, 305);
            this.btn_chinhSua.Name = "btn_chinhSua";
            this.btn_chinhSua.Size = new System.Drawing.Size(109, 23);
            this.btn_chinhSua.TabIndex = 16;
            this.btn_chinhSua.Text = "Chỉnh Sửa";
            this.btn_chinhSua.UseVisualStyleBackColor = true;
            this.btn_chinhSua.Click += new System.EventHandler(this.btn_chinhSua_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label15.Location = new System.Drawing.Point(43, 587);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 18);
            this.label15.TabIndex = 17;
            this.label15.Text = "Thành tiền:";
            // 
            // lb_thanhTien
            // 
            this.lb_thanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lb_thanhTien.Location = new System.Drawing.Point(567, 585);
            this.lb_thanhTien.Name = "lb_thanhTien";
            this.lb_thanhTien.Size = new System.Drawing.Size(200, 23);
            this.lb_thanhTien.TabIndex = 18;
            this.lb_thanhTien.Text = "000,000đ";
            this.lb_thanhTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_huyChinhSua
            // 
            this.btn_huyChinhSua.Location = new System.Drawing.Point(161, 305);
            this.btn_huyChinhSua.Name = "btn_huyChinhSua";
            this.btn_huyChinhSua.Size = new System.Drawing.Size(109, 23);
            this.btn_huyChinhSua.TabIndex = 19;
            this.btn_huyChinhSua.Text = "Hủy";
            this.btn_huyChinhSua.UseVisualStyleBackColor = true;
            this.btn_huyChinhSua.Visible = false;
            this.btn_huyChinhSua.Click += new System.EventHandler(this.btn_huyChinhSua_Click);
            // 
            // ThemHoaDonMoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 672);
            this.Controls.Add(this.btn_huyChinhSua);
            this.Controls.Add(this.lb_thanhTien);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btn_chinhSua);
            this.Controls.Add(this.btn_xoaMatHang);
            this.Controls.Add(this.btn_themHoaDon);
            this.Controls.Add(this.pn_themMatHangXuat);
            this.Controls.Add(this.pn_themMatHangNhap);
            this.Controls.Add(this.dGV_danhSachMatHang);
            this.Controls.Add(this.pn_trangThai);
            this.Controls.Add(this.tb_tenKhachHang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dTP_ngayLap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_nhanVienLap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_loaiHoaDon);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ThemHoaDonMoi";
            this.Text = "ThemHoaDonMoi";
            this.Load += new System.EventHandler(this.ThemHoaDonMoi_Load);
            this.pn_trangThai.ResumeLayout(false);
            this.pn_trangThai.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_danhSachMatHang)).EndInit();
            this.pn_themMatHangNhap.ResumeLayout(false);
            this.pn_themMatHangNhap.PerformLayout();
            this.pn_themMatHangXuat.ResumeLayout(false);
            this.pn_themMatHangXuat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_loaiHoaDon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_nhanVienLap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dTP_ngayLap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_tenKhachHang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pn_trangThai;
        private System.Windows.Forms.RadioButton rb_chuaThanhToan;
        private System.Windows.Forms.RadioButton rb_daThanhToan;
        private System.Windows.Forms.DataGridView dGV_danhSachMatHang;
        private System.Windows.Forms.Panel pn_themMatHangNhap;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_themMatHangNhap;
        private System.Windows.Forms.TextBox tb_donGiaMatHangNhap;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_soLuongMatHangNhap;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_maMatHangNhap;
        private System.Windows.Forms.Panel pn_themMatHangXuat;
        private System.Windows.Forms.DateTimePicker dTP_ngayBaoHanh;
        private System.Windows.Forms.Button btn_themMatHangXuat;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_soLuongMatHangXuat;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_maMatHangXuat;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_themHoaDon;
        private System.Windows.Forms.Button btn_xoaMatHang;
        private System.Windows.Forms.Button btn_chinhSua;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lb_thanhTien;
        private System.Windows.Forms.Button btn_huyChinhSua;
    }
}