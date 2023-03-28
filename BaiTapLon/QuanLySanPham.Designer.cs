
namespace BaiTapLon
{
    partial class MainForm
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
            this.DGV = new System.Windows.Forms.DataGridView();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Attributes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabsControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DGV2 = new System.Windows.Forms.DataGridView();
            this.CateID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CateName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.DeleteBTN = new System.Windows.Forms.Button();
            this.PrintBTN = new System.Windows.Forms.Button();
            this.SearchBTN = new System.Windows.Forms.Button();
            this.UpdateBTN = new System.Windows.Forms.Button();
            this.AddBTN = new System.Windows.Forms.Button();
            this.ProdAttributes = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ProdColor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ProdLabel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ProdPricing = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ProdQuantity = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.ProdName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ProdCatList = new System.Windows.Forms.ComboBox();
            this.ShowBTN = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_cancelSearching = new System.Windows.Forms.Button();
            this.lb_searchById = new System.Windows.Forms.Label();
            this.btn_searchById = new System.Windows.Forms.Button();
            this.tb_searchById = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dGV_DanhSachHoaDon = new System.Windows.Forms.DataGridView();
            this.btn_xoaHoaDon = new System.Windows.Forms.Button();
            this.btn_xemChiTiet = new System.Windows.Forms.Button();
            this.btn_suaHoaDon = new System.Windows.Forms.Button();
            this.btn_themHoaDon = new System.Windows.Forms.Button();
            this.btn_lamMoi = new System.Windows.Forms.Button();
            this.cb_loaiHoaDon = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AccPhoneNumber = new System.Windows.Forms.Label();
            this.AccEmail = new System.Windows.Forms.Label();
            this.AccID = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AccName = new System.Windows.Forms.Label();
            this.ChangePassword = new System.Windows.Forms.Button();
            this.LogoutBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.TabsControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProdQuantity)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_DanhSachHoaDon)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CategoryName,
            this.ProductID,
            this.CategoryID,
            this.ProductName,
            this.Quantity,
            this.Price,
            this.Brand,
            this.Color,
            this.Attributes});
            this.DGV.Location = new System.Drawing.Point(5, 434);
            this.DGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.RowHeadersWidth = 51;
            this.DGV.RowTemplate.Height = 24;
            this.DGV.Size = new System.Drawing.Size(1131, 222);
            this.DGV.TabIndex = 0;
            // 
            // CategoryName
            // 
            this.CategoryName.DataPropertyName = "sTenNhomHang";
            this.CategoryName.HeaderText = "Tên Nhóm Hàng";
            this.CategoryName.MinimumWidth = 6;
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.ReadOnly = true;
            this.CategoryName.Width = 125;
            // 
            // ProductID
            // 
            this.ProductID.DataPropertyName = "PK_iMaHangHoa";
            this.ProductID.HeaderText = "Mã Hàng Hóa";
            this.ProductID.MinimumWidth = 6;
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            this.ProductID.Width = 125;
            // 
            // CategoryID
            // 
            this.CategoryID.DataPropertyName = "FK_iMaNhomHang";
            this.CategoryID.HeaderText = "Mã Nhóm Hàng";
            this.CategoryID.MinimumWidth = 6;
            this.CategoryID.Name = "CategoryID";
            this.CategoryID.ReadOnly = true;
            this.CategoryID.Width = 125;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "sTenHangHoa";
            this.ProductName.HeaderText = "Tên Hàng Hóa";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 125;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "iSoLuong";
            this.Quantity.HeaderText = "Số Lượng";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 125;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "iGiaBan";
            this.Price.HeaderText = "Giá Bán";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 125;
            // 
            // Brand
            // 
            this.Brand.DataPropertyName = "sNhanHieu";
            this.Brand.HeaderText = "Nhãn Hiệu";
            this.Brand.MinimumWidth = 6;
            this.Brand.Name = "Brand";
            this.Brand.ReadOnly = true;
            this.Brand.Width = 125;
            // 
            // Color
            // 
            this.Color.DataPropertyName = "sMauSac";
            this.Color.HeaderText = "Màu Sắc";
            this.Color.MinimumWidth = 6;
            this.Color.Name = "Color";
            this.Color.ReadOnly = true;
            this.Color.Width = 125;
            // 
            // Attributes
            // 
            this.Attributes.DataPropertyName = "sDacTinhKiThuat";
            this.Attributes.HeaderText = "Đặc Tính Kỹ Thuật";
            this.Attributes.MinimumWidth = 6;
            this.Attributes.Name = "Attributes";
            this.Attributes.ReadOnly = true;
            this.Attributes.Width = 125;
            // 
            // TabsControl
            // 
            this.TabsControl.Controls.Add(this.tabPage1);
            this.TabsControl.Controls.Add(this.tabPage2);
            this.TabsControl.Controls.Add(this.tabPage3);
            this.TabsControl.Location = new System.Drawing.Point(12, 7);
            this.TabsControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabsControl.Name = "TabsControl";
            this.TabsControl.SelectedIndex = 0;
            this.TabsControl.Size = new System.Drawing.Size(1151, 690);
            this.TabsControl.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DGV2);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.DeleteBTN);
            this.tabPage1.Controls.Add(this.PrintBTN);
            this.tabPage1.Controls.Add(this.SearchBTN);
            this.tabPage1.Controls.Add(this.UpdateBTN);
            this.tabPage1.Controls.Add(this.AddBTN);
            this.tabPage1.Controls.Add(this.ProdAttributes);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.ProdColor);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.ProdLabel);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.ProdPricing);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.ProdQuantity);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.ProdName);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.ProdCatList);
            this.tabPage1.Controls.Add(this.ShowBTN);
            this.tabPage1.Controls.Add(this.DGV);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1143, 661);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quản Lý Sản Phẩm";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DGV2
            // 
            this.DGV2.AllowUserToAddRows = false;
            this.DGV2.AllowUserToDeleteRows = false;
            this.DGV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CateID,
            this.CateName});
            this.DGV2.Location = new System.Drawing.Point(823, 59);
            this.DGV2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGV2.Name = "DGV2";
            this.DGV2.ReadOnly = true;
            this.DGV2.RowHeadersWidth = 51;
            this.DGV2.RowTemplate.Height = 24;
            this.DGV2.Size = new System.Drawing.Size(281, 270);
            this.DGV2.TabIndex = 25;
            // 
            // CateID
            // 
            this.CateID.DataPropertyName = "PK_iMaNhomHang";
            this.CateID.HeaderText = "Mã Loại Hàng";
            this.CateID.MinimumWidth = 6;
            this.CateID.Name = "CateID";
            this.CateID.ReadOnly = true;
            this.CateID.Width = 125;
            // 
            // CateName
            // 
            this.CateName.DataPropertyName = "sTenNhomHang";
            this.CateName.HeaderText = "Tên Loại Hàng";
            this.CateName.MinimumWidth = 6;
            this.CateName.Name = "CateName";
            this.CateName.ReadOnly = true;
            this.CateName.Width = 125;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(816, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Danh sách các loại hàng";
            // 
            // DeleteBTN
            // 
            this.DeleteBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBTN.Location = new System.Drawing.Point(592, 223);
            this.DeleteBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteBTN.Name = "DeleteBTN";
            this.DeleteBTN.Size = new System.Drawing.Size(132, 36);
            this.DeleteBTN.TabIndex = 23;
            this.DeleteBTN.Text = "Xóa";
            this.DeleteBTN.UseVisualStyleBackColor = true;
            this.DeleteBTN.Click += new System.EventHandler(this.DeleteBTN_Click);
            // 
            // PrintBTN
            // 
            this.PrintBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintBTN.Location = new System.Drawing.Point(592, 363);
            this.PrintBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PrintBTN.Name = "PrintBTN";
            this.PrintBTN.Size = new System.Drawing.Size(132, 36);
            this.PrintBTN.TabIndex = 22;
            this.PrintBTN.Text = "In";
            this.PrintBTN.UseVisualStyleBackColor = true;
            this.PrintBTN.Click += new System.EventHandler(this.PrintBTN_Click);
            // 
            // SearchBTN
            // 
            this.SearchBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBTN.Location = new System.Drawing.Point(592, 293);
            this.SearchBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchBTN.Name = "SearchBTN";
            this.SearchBTN.Size = new System.Drawing.Size(132, 36);
            this.SearchBTN.TabIndex = 21;
            this.SearchBTN.Text = "Tìm Kiếm";
            this.SearchBTN.UseVisualStyleBackColor = true;
            this.SearchBTN.Click += new System.EventHandler(this.SearchBTN_Click);
            // 
            // UpdateBTN
            // 
            this.UpdateBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBTN.Location = new System.Drawing.Point(592, 151);
            this.UpdateBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpdateBTN.Name = "UpdateBTN";
            this.UpdateBTN.Size = new System.Drawing.Size(132, 36);
            this.UpdateBTN.TabIndex = 19;
            this.UpdateBTN.Text = "Sửa";
            this.UpdateBTN.UseVisualStyleBackColor = true;
            this.UpdateBTN.Click += new System.EventHandler(this.UpdateBTN_Click);
            // 
            // AddBTN
            // 
            this.AddBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBTN.Location = new System.Drawing.Point(592, 80);
            this.AddBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddBTN.Name = "AddBTN";
            this.AddBTN.Size = new System.Drawing.Size(132, 36);
            this.AddBTN.TabIndex = 18;
            this.AddBTN.Text = "Thêm";
            this.AddBTN.UseVisualStyleBackColor = true;
            this.AddBTN.Click += new System.EventHandler(this.AddBTN_Click);
            // 
            // ProdAttributes
            // 
            this.ProdAttributes.Location = new System.Drawing.Point(155, 331);
            this.ProdAttributes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProdAttributes.Multiline = true;
            this.ProdAttributes.Name = "ProdAttributes";
            this.ProdAttributes.Size = new System.Drawing.Size(393, 90);
            this.ProdAttributes.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(69, 331);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 24);
            this.label8.TabIndex = 16;
            this.label8.Text = "ĐTKT:";
            // 
            // ProdColor
            // 
            this.ProdColor.Location = new System.Drawing.Point(155, 284);
            this.ProdColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProdColor.Name = "ProdColor";
            this.ProdColor.Size = new System.Drawing.Size(169, 22);
            this.ProdColor.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(53, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Màu Sắc:";
            // 
            // ProdLabel
            // 
            this.ProdLabel.Location = new System.Drawing.Point(155, 231);
            this.ProdLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProdLabel.Name = "ProdLabel";
            this.ProdLabel.Size = new System.Drawing.Size(356, 22);
            this.ProdLabel.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nhãn Hiệu:";
            // 
            // ProdPricing
            // 
            this.ProdPricing.Location = new System.Drawing.Point(155, 185);
            this.ProdPricing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProdPricing.Name = "ProdPricing";
            this.ProdPricing.Size = new System.Drawing.Size(201, 22);
            this.ProdPricing.TabIndex = 10;
            this.ProdPricing.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Pricing_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Giá Bán:";
            // 
            // ProdQuantity
            // 
            this.ProdQuantity.Location = new System.Drawing.Point(155, 132);
            this.ProdQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProdQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.ProdQuantity.Name = "ProdQuantity";
            this.ProdQuantity.Size = new System.Drawing.Size(169, 22);
            this.ProdQuantity.TabIndex = 8;
            this.ProdQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Số Lượng:";
            // 
            // ProdName
            // 
            this.ProdName.Location = new System.Drawing.Point(155, 80);
            this.ProdName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProdName.Name = "ProdName";
            this.ProdName.Size = new System.Drawing.Size(356, 22);
            this.ProdName.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên Hàng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Loại Hàng:";
            // 
            // ProdCatList
            // 
            this.ProdCatList.FormattingEnabled = true;
            this.ProdCatList.Location = new System.Drawing.Point(155, 27);
            this.ProdCatList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProdCatList.MaxDropDownItems = 100;
            this.ProdCatList.Name = "ProdCatList";
            this.ProdCatList.Size = new System.Drawing.Size(201, 24);
            this.ProdCatList.TabIndex = 3;
            // 
            // ShowBTN
            // 
            this.ShowBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowBTN.Location = new System.Drawing.Point(592, 15);
            this.ShowBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShowBTN.Name = "ShowBTN";
            this.ShowBTN.Size = new System.Drawing.Size(132, 36);
            this.ShowBTN.TabIndex = 1;
            this.ShowBTN.Text = "Xem";
            this.ShowBTN.UseVisualStyleBackColor = true;
            this.ShowBTN.Click += new System.EventHandler(this.XemBTN_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_cancelSearching);
            this.tabPage2.Controls.Add(this.lb_searchById);
            this.tabPage2.Controls.Add(this.btn_searchById);
            this.tabPage2.Controls.Add(this.tb_searchById);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.dGV_DanhSachHoaDon);
            this.tabPage2.Controls.Add(this.btn_xoaHoaDon);
            this.tabPage2.Controls.Add(this.btn_xemChiTiet);
            this.tabPage2.Controls.Add(this.btn_suaHoaDon);
            this.tabPage2.Controls.Add(this.btn_themHoaDon);
            this.tabPage2.Controls.Add(this.btn_lamMoi);
            this.tabPage2.Controls.Add(this.cb_loaiHoaDon);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1143, 661);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Quản Lý Hóa Đơn";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_cancelSearching
            // 
            this.btn_cancelSearching.Location = new System.Drawing.Point(936, 176);
            this.btn_cancelSearching.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_cancelSearching.Name = "btn_cancelSearching";
            this.btn_cancelSearching.Size = new System.Drawing.Size(100, 28);
            this.btn_cancelSearching.TabIndex = 12;
            this.btn_cancelSearching.Text = "Hủy";
            this.btn_cancelSearching.UseVisualStyleBackColor = true;
            this.btn_cancelSearching.Visible = false;
            this.btn_cancelSearching.Click += new System.EventHandler(this.btn_cancelSearching_Click);
            // 
            // lb_searchById
            // 
            this.lb_searchById.AutoSize = true;
            this.lb_searchById.Location = new System.Drawing.Point(43, 176);
            this.lb_searchById.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_searchById.Name = "lb_searchById";
            this.lb_searchById.Size = new System.Drawing.Size(142, 17);
            this.lb_searchById.TabIndex = 11;
            this.lb_searchById.Text = "Tìm theo mã hóa đơn";
            this.lb_searchById.Visible = false;
            // 
            // btn_searchById
            // 
            this.btn_searchById.Location = new System.Drawing.Point(471, 174);
            this.btn_searchById.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_searchById.Name = "btn_searchById";
            this.btn_searchById.Size = new System.Drawing.Size(140, 28);
            this.btn_searchById.TabIndex = 10;
            this.btn_searchById.Text = "Tìm kiếm";
            this.btn_searchById.UseVisualStyleBackColor = true;
            this.btn_searchById.Click += new System.EventHandler(this.btn_searchById_Click);
            // 
            // tb_searchById
            // 
            this.tb_searchById.Location = new System.Drawing.Point(423, 176);
            this.tb_searchById.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tb_searchById.Name = "tb_searchById";
            this.tb_searchById.Size = new System.Drawing.Size(204, 22);
            this.tb_searchById.TabIndex = 9;
            this.tb_searchById.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label10.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label10.Location = new System.Drawing.Point(395, 50);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(324, 48);
            this.label10.TabIndex = 8;
            this.label10.Text = "Quản lý hóa đơn";
            // 
            // dGV_DanhSachHoaDon
            // 
            this.dGV_DanhSachHoaDon.AllowUserToAddRows = false;
            this.dGV_DanhSachHoaDon.AllowUserToDeleteRows = false;
            this.dGV_DanhSachHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_DanhSachHoaDon.Location = new System.Drawing.Point(27, 364);
            this.dGV_DanhSachHoaDon.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dGV_DanhSachHoaDon.Name = "dGV_DanhSachHoaDon";
            this.dGV_DanhSachHoaDon.ReadOnly = true;
            this.dGV_DanhSachHoaDon.RowHeadersWidth = 51;
            this.dGV_DanhSachHoaDon.Size = new System.Drawing.Size(1083, 286);
            this.dGV_DanhSachHoaDon.TabIndex = 7;
            this.dGV_DanhSachHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_DanhSachHoaDon_CellContentClick);
            // 
            // btn_xoaHoaDon
            // 
            this.btn_xoaHoaDon.Location = new System.Drawing.Point(619, 287);
            this.btn_xoaHoaDon.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_xoaHoaDon.Name = "btn_xoaHoaDon";
            this.btn_xoaHoaDon.Size = new System.Drawing.Size(185, 53);
            this.btn_xoaHoaDon.TabIndex = 6;
            this.btn_xoaHoaDon.Text = "Xóa Hóa Đơn";
            this.btn_xoaHoaDon.UseVisualStyleBackColor = true;
            this.btn_xoaHoaDon.Click += new System.EventHandler(this.btn_xoaHoaDon_Click);
            // 
            // btn_xemChiTiet
            // 
            this.btn_xemChiTiet.Location = new System.Drawing.Point(27, 287);
            this.btn_xemChiTiet.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_xemChiTiet.Name = "btn_xemChiTiet";
            this.btn_xemChiTiet.Size = new System.Drawing.Size(185, 53);
            this.btn_xemChiTiet.TabIndex = 5;
            this.btn_xemChiTiet.Text = "Xem Chi Tiết Hóa Đơn";
            this.btn_xemChiTiet.UseVisualStyleBackColor = true;
            this.btn_xemChiTiet.Click += new System.EventHandler(this.btn_xemChiTiet_Click);
            // 
            // btn_suaHoaDon
            // 
            this.btn_suaHoaDon.Location = new System.Drawing.Point(920, 287);
            this.btn_suaHoaDon.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_suaHoaDon.Name = "btn_suaHoaDon";
            this.btn_suaHoaDon.Size = new System.Drawing.Size(185, 53);
            this.btn_suaHoaDon.TabIndex = 4;
            this.btn_suaHoaDon.Text = "Sửa Hóa Đơn";
            this.btn_suaHoaDon.UseVisualStyleBackColor = true;
            this.btn_suaHoaDon.Click += new System.EventHandler(this.btn_suaHoaDon_Click);
            // 
            // btn_themHoaDon
            // 
            this.btn_themHoaDon.Location = new System.Drawing.Point(320, 287);
            this.btn_themHoaDon.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_themHoaDon.Name = "btn_themHoaDon";
            this.btn_themHoaDon.Size = new System.Drawing.Size(185, 53);
            this.btn_themHoaDon.TabIndex = 3;
            this.btn_themHoaDon.Text = "Thêm Hóa Đơn";
            this.btn_themHoaDon.UseVisualStyleBackColor = true;
            this.btn_themHoaDon.Click += new System.EventHandler(this.btn_themHoaDon_Click);
            // 
            // btn_lamMoi
            // 
            this.btn_lamMoi.Location = new System.Drawing.Point(652, 132);
            this.btn_lamMoi.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_lamMoi.Name = "btn_lamMoi";
            this.btn_lamMoi.Size = new System.Drawing.Size(156, 26);
            this.btn_lamMoi.TabIndex = 2;
            this.btn_lamMoi.Text = "Làm Mới";
            this.btn_lamMoi.UseVisualStyleBackColor = true;
            this.btn_lamMoi.Click += new System.EventHandler(this.btn_lamMoi_Click);
            // 
            // cb_loaiHoaDon
            // 
            this.cb_loaiHoaDon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_loaiHoaDon.FormattingEnabled = true;
            this.cb_loaiHoaDon.Location = new System.Drawing.Point(252, 128);
            this.cb_loaiHoaDon.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cb_loaiHoaDon.Name = "cb_loaiHoaDon";
            this.cb_loaiHoaDon.Size = new System.Drawing.Size(203, 24);
            this.cb_loaiHoaDon.TabIndex = 1;
            this.cb_loaiHoaDon.SelectedIndexChanged += new System.EventHandler(this.cb_loaiHoaDon_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 132);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Loại hóa đơn";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.pictureBox1);
            this.tabPage3.Controls.Add(this.AccName);
            this.tabPage3.Controls.Add(this.ChangePassword);
            this.tabPage3.Controls.Add(this.LogoutBTN);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Size = new System.Drawing.Size(1143, 661);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tài Khoản";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AccPhoneNumber);
            this.groupBox1.Controls.Add(this.AccEmail);
            this.groupBox1.Controls.Add(this.AccID);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(501, 113);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(609, 279);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN TÀI KHOẢN";
            // 
            // AccPhoneNumber
            // 
            this.AccPhoneNumber.AutoSize = true;
            this.AccPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccPhoneNumber.Location = new System.Drawing.Point(277, 194);
            this.AccPhoneNumber.Name = "AccPhoneNumber";
            this.AccPhoneNumber.Size = new System.Drawing.Size(213, 32);
            this.AccPhoneNumber.TabIndex = 10;
            this.AccPhoneNumber.Text = "(Số Điện Thoại)";
            // 
            // AccEmail
            // 
            this.AccEmail.AutoSize = true;
            this.AccEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccEmail.Location = new System.Drawing.Point(153, 119);
            this.AccEmail.Name = "AccEmail";
            this.AccEmail.Size = new System.Drawing.Size(105, 32);
            this.AccEmail.TabIndex = 9;
            this.AccEmail.Text = "(Email)";
            // 
            // AccID
            // 
            this.AccID.AutoSize = true;
            this.AccID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccID.Location = new System.Drawing.Point(277, 49);
            this.AccID.Name = "AccID";
            this.AccID.Size = new System.Drawing.Size(212, 32);
            this.AccID.TabIndex = 8;
            this.AccID.Text = "(Mã Nhân Viên)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(41, 194);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(217, 32);
            this.label14.TabIndex = 7;
            this.label14.Text = "Số Điện Thoại:  ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(41, 119);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 32);
            this.label13.TabIndex = 6;
            this.label13.Text = "Email: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(41, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(209, 32);
            this.label12.TabIndex = 5;
            this.label12.Text = "Mã Nhân Viên: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BaiTapLon.Properties.Resources.Avatar;
            this.pictureBox1.Location = new System.Drawing.Point(19, 112);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(436, 281);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // AccName
            // 
            this.AccName.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccName.Location = new System.Drawing.Point(19, 425);
            this.AccName.Name = "AccName";
            this.AccName.Size = new System.Drawing.Size(436, 57);
            this.AccName.TabIndex = 3;
            this.AccName.Text = "(Tên Tài Khoản)";
            this.AccName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChangePassword
            // 
            this.ChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangePassword.Location = new System.Drawing.Point(709, 571);
            this.ChangePassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChangePassword.Name = "ChangePassword";
            this.ChangePassword.Size = new System.Drawing.Size(223, 57);
            this.ChangePassword.TabIndex = 1;
            this.ChangePassword.Text = "Đổi Mật Khẩu";
            this.ChangePassword.UseVisualStyleBackColor = true;
            this.ChangePassword.Click += new System.EventHandler(this.ChangePassword_Click_1);
            // 
            // LogoutBTN
            // 
            this.LogoutBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBTN.Location = new System.Drawing.Point(965, 571);
            this.LogoutBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogoutBTN.Name = "LogoutBTN";
            this.LogoutBTN.Size = new System.Drawing.Size(144, 57);
            this.LogoutBTN.TabIndex = 0;
            this.LogoutBTN.Text = "Đăng Xuất";
            this.LogoutBTN.UseVisualStyleBackColor = true;
            this.LogoutBTN.Click += new System.EventHandler(this.LogoutBTN_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1175, 700);
            this.Controls.Add(this.TabsControl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài Tập Lớn";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.TabsControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProdQuantity)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_DanhSachHoaDon)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Attributes;
        private System.Windows.Forms.TabControl TabsControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button ShowBTN;
        private System.Windows.Forms.ComboBox ProdCatList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ProdName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown ProdQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ProdPricing;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ProdLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ProdColor;
        private System.Windows.Forms.TextBox ProdAttributes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button AddBTN;
        private System.Windows.Forms.Button PrintBTN;
        private System.Windows.Forms.Button SearchBTN;
        private System.Windows.Forms.Button UpdateBTN;
        private System.Windows.Forms.Button DeleteBTN;
        private System.Windows.Forms.DataGridView DGV2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CateID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CateName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_xoaHoaDon;
        private System.Windows.Forms.Button btn_xemChiTiet;
        private System.Windows.Forms.Button btn_suaHoaDon;
        private System.Windows.Forms.Button btn_themHoaDon;
        private System.Windows.Forms.Button btn_lamMoi;
        private System.Windows.Forms.ComboBox cb_loaiHoaDon;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dGV_DanhSachHoaDon;
        private System.Windows.Forms.Label lb_searchById;
        private System.Windows.Forms.Button btn_searchById;
        private System.Windows.Forms.TextBox tb_searchById;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_cancelSearching;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button LogoutBTN;
        private System.Windows.Forms.Button ChangePassword;
        private System.Windows.Forms.Label AccName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label AccPhoneNumber;
        private System.Windows.Forms.Label AccEmail;
        private System.Windows.Forms.Label AccID;
    }
}

