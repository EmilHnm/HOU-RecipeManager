
namespace BaiTapLon
{
    partial class ChinhSuaHoaDonXuat
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
            this.pn_themMatHangXuat = new System.Windows.Forms.Panel();
            this.btn_xoaMatHang = new System.Windows.Forms.Button();
            this.btn_suaMatHang = new System.Windows.Forms.Button();
            this.dTP_ngayBaoHanh = new System.Windows.Forms.DateTimePicker();
            this.btn_themMatHangXuat = new System.Windows.Forms.Button();
            this.dGV_danhSachMatHang = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_soLuongMatHangXuat = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_maMatHangXuat = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pn_trangThai = new System.Windows.Forms.Panel();
            this.rb_chuaThanhToan = new System.Windows.Forms.RadioButton();
            this.rb_daThanhToan = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_tenKhachHang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dTP_ngayLap = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_nhanVienLap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_maHoaDon = new System.Windows.Forms.Label();
            this.lb_thanhTien = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_huy = new System.Windows.Forms.Button();
            this.btn_xacNhan = new System.Windows.Forms.Button();
            this.pn_themMatHangXuat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_danhSachMatHang)).BeginInit();
            this.pn_trangThai.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_themMatHangXuat
            // 
            this.pn_themMatHangXuat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_themMatHangXuat.Controls.Add(this.btn_xoaMatHang);
            this.pn_themMatHangXuat.Controls.Add(this.btn_suaMatHang);
            this.pn_themMatHangXuat.Controls.Add(this.dTP_ngayBaoHanh);
            this.pn_themMatHangXuat.Controls.Add(this.btn_themMatHangXuat);
            this.pn_themMatHangXuat.Controls.Add(this.dGV_danhSachMatHang);
            this.pn_themMatHangXuat.Controls.Add(this.label11);
            this.pn_themMatHangXuat.Controls.Add(this.tb_soLuongMatHangXuat);
            this.pn_themMatHangXuat.Controls.Add(this.label12);
            this.pn_themMatHangXuat.Controls.Add(this.tb_maMatHangXuat);
            this.pn_themMatHangXuat.Controls.Add(this.label13);
            this.pn_themMatHangXuat.Controls.Add(this.label14);
            this.pn_themMatHangXuat.Location = new System.Drawing.Point(43, 208);
            this.pn_themMatHangXuat.Name = "pn_themMatHangXuat";
            this.pn_themMatHangXuat.Size = new System.Drawing.Size(721, 328);
            this.pn_themMatHangXuat.TabIndex = 25;
            // 
            // btn_xoaMatHang
            // 
            this.btn_xoaMatHang.Location = new System.Drawing.Point(608, 64);
            this.btn_xoaMatHang.Name = "btn_xoaMatHang";
            this.btn_xoaMatHang.Size = new System.Drawing.Size(106, 23);
            this.btn_xoaMatHang.TabIndex = 28;
            this.btn_xoaMatHang.Text = "Xóa mặt hàng";
            this.btn_xoaMatHang.UseVisualStyleBackColor = true;
            // 
            // btn_suaMatHang
            // 
            this.btn_suaMatHang.Location = new System.Drawing.Point(496, 64);
            this.btn_suaMatHang.Name = "btn_suaMatHang";
            this.btn_suaMatHang.Size = new System.Drawing.Size(106, 23);
            this.btn_suaMatHang.TabIndex = 9;
            this.btn_suaMatHang.Text = "Sửa mặt hàng";
            this.btn_suaMatHang.UseVisualStyleBackColor = true;
            this.btn_suaMatHang.Click += new System.EventHandler(this.btn_suaMatHang_Click);
            // 
            // dTP_ngayBaoHanh
            // 
            this.dTP_ngayBaoHanh.Location = new System.Drawing.Point(534, 28);
            this.dTP_ngayBaoHanh.Name = "dTP_ngayBaoHanh";
            this.dTP_ngayBaoHanh.Size = new System.Drawing.Size(180, 20);
            this.dTP_ngayBaoHanh.TabIndex = 8;
            // 
            // btn_themMatHangXuat
            // 
            this.btn_themMatHangXuat.Location = new System.Drawing.Point(6, 64);
            this.btn_themMatHangXuat.Name = "btn_themMatHangXuat";
            this.btn_themMatHangXuat.Size = new System.Drawing.Size(106, 23);
            this.btn_themMatHangXuat.TabIndex = 7;
            this.btn_themMatHangXuat.Text = "Thêm mặt hàng";
            this.btn_themMatHangXuat.UseVisualStyleBackColor = true;
            this.btn_themMatHangXuat.Click += new System.EventHandler(this.btn_themMatHangXuat_Click);
            // 
            // dGV_danhSachMatHang
            // 
            this.dGV_danhSachMatHang.AllowUserToAddRows = false;
            this.dGV_danhSachMatHang.AllowUserToDeleteRows = false;
            this.dGV_danhSachMatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_danhSachMatHang.Location = new System.Drawing.Point(6, 93);
            this.dGV_danhSachMatHang.Name = "dGV_danhSachMatHang";
            this.dGV_danhSachMatHang.ReadOnly = true;
            this.dGV_danhSachMatHang.Size = new System.Drawing.Size(708, 226);
            this.dGV_danhSachMatHang.TabIndex = 28;
            this.dGV_danhSachMatHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_danhSachMatHang_CellClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label11.Location = new System.Drawing.Point(459, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 17);
            this.label11.TabIndex = 5;
            this.label11.Text = "Bảo hành";
            // 
            // tb_soLuongMatHangXuat
            // 
            this.tb_soLuongMatHangXuat.Location = new System.Drawing.Point(336, 29);
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
            this.label12.Location = new System.Drawing.Point(261, 30);
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
            this.label14.Size = new System.Drawing.Size(193, 17);
            this.label14.TabIndex = 0;
            this.label14.Text = "Chỉnh sửa thông tin mặt hàng";
            // 
            // pn_trangThai
            // 
            this.pn_trangThai.Controls.Add(this.rb_chuaThanhToan);
            this.pn_trangThai.Controls.Add(this.rb_daThanhToan);
            this.pn_trangThai.Controls.Add(this.label6);
            this.pn_trangThai.Location = new System.Drawing.Point(43, 166);
            this.pn_trangThai.Name = "pn_trangThai";
            this.pn_trangThai.Size = new System.Drawing.Size(721, 24);
            this.pn_trangThai.TabIndex = 23;
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
            // tb_tenKhachHang
            // 
            this.tb_tenKhachHang.Location = new System.Drawing.Point(193, 131);
            this.tb_tenKhachHang.Name = "tb_tenKhachHang";
            this.tb_tenKhachHang.Size = new System.Drawing.Size(571, 20);
            this.tb_tenKhachHang.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(40, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Tên Khách Hàng";
            // 
            // dTP_ngayLap
            // 
            this.dTP_ngayLap.Location = new System.Drawing.Point(564, 57);
            this.dTP_ngayLap.Name = "dTP_ngayLap";
            this.dTP_ngayLap.Size = new System.Drawing.Size(200, 20);
            this.dTP_ngayLap.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(482, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Ngày Lập";
            // 
            // tb_nhanVienLap
            // 
            this.tb_nhanVienLap.Location = new System.Drawing.Point(193, 92);
            this.tb_nhanVienLap.Name = "tb_nhanVienLap";
            this.tb_nhanVienLap.Size = new System.Drawing.Size(279, 20);
            this.tb_nhanVienLap.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(40, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nhân Viên Lập";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 54);
            this.label1.TabIndex = 14;
            this.label1.Text = "Hóa đơn bán hàng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(40, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Mã hóa đơn";
            // 
            // lb_maHoaDon
            // 
            this.lb_maHoaDon.AutoSize = true;
            this.lb_maHoaDon.Location = new System.Drawing.Point(193, 58);
            this.lb_maHoaDon.Name = "lb_maHoaDon";
            this.lb_maHoaDon.Size = new System.Drawing.Size(43, 13);
            this.lb_maHoaDon.TabIndex = 27;
            this.lb_maHoaDon.Text = "000000";
            // 
            // lb_thanhTien
            // 
            this.lb_thanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lb_thanhTien.Location = new System.Drawing.Point(660, 548);
            this.lb_thanhTien.Name = "lb_thanhTien";
            this.lb_thanhTien.Size = new System.Drawing.Size(100, 23);
            this.lb_thanhTien.TabIndex = 32;
            this.lb_thanhTien.Text = "000,000";
            this.lb_thanhTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label7.Location = new System.Drawing.Point(482, 553);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 17);
            this.label7.TabIndex = 31;
            this.label7.Text = "Thành tiền: ";
            // 
            // btn_huy
            // 
            this.btn_huy.Location = new System.Drawing.Point(40, 591);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(120, 35);
            this.btn_huy.TabIndex = 30;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // btn_xacNhan
            // 
            this.btn_xacNhan.Location = new System.Drawing.Point(640, 591);
            this.btn_xacNhan.Name = "btn_xacNhan";
            this.btn_xacNhan.Size = new System.Drawing.Size(120, 35);
            this.btn_xacNhan.TabIndex = 29;
            this.btn_xacNhan.Text = "Xác nhận";
            this.btn_xacNhan.UseVisualStyleBackColor = true;
            this.btn_xacNhan.Click += new System.EventHandler(this.btn_xacNhan_Click);
            // 
            // ChinhSuaHoaDonXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 633);
            this.Controls.Add(this.lb_thanhTien);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_xacNhan);
            this.Controls.Add(this.lb_maHoaDon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pn_themMatHangXuat);
            this.Controls.Add(this.pn_trangThai);
            this.Controls.Add(this.tb_tenKhachHang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dTP_ngayLap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_nhanVienLap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "ChinhSuaHoaDonXuat";
            this.Text = "Chỉnh sửa hóa đơn xuất";
            this.Load += new System.EventHandler(this.ChinhSuaHoaDonXuat_Load);
            this.pn_themMatHangXuat.ResumeLayout(false);
            this.pn_themMatHangXuat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_danhSachMatHang)).EndInit();
            this.pn_trangThai.ResumeLayout(false);
            this.pn_trangThai.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pn_themMatHangXuat;
        private System.Windows.Forms.DateTimePicker dTP_ngayBaoHanh;
        private System.Windows.Forms.Button btn_themMatHangXuat;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_soLuongMatHangXuat;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_maMatHangXuat;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel pn_trangThai;
        private System.Windows.Forms.RadioButton rb_chuaThanhToan;
        private System.Windows.Forms.RadioButton rb_daThanhToan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_tenKhachHang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dTP_ngayLap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_nhanVienLap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_maHoaDon;
        private System.Windows.Forms.Button btn_xoaMatHang;
        private System.Windows.Forms.Button btn_suaMatHang;
        private System.Windows.Forms.DataGridView dGV_danhSachMatHang;
        private System.Windows.Forms.Label lb_thanhTien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.Button btn_xacNhan;
    }
}