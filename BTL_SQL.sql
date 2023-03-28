
CREATE DATABASE BaiTapLon 
USE BaiTapLon

CREATE TABLE tblNhomHang (
    PK_iMaNhomHang int identity(1, 1) PRIMARY KEY, 
    sTenNhomHang nvarchar(50) NOT NULL UNIQUE
)

INSERT INTO tblNhomHang (sTenNhomHang)
VALUES (N'Chuột'), (N'Bàn Phím'), (N'Màn Hình'), (N'Tai Nghe'), (N'Máy In'), (N'Camera'), (N'Loa'), (N'Lưu Trữ')

CREATE TABLE tblHangHoa (
	PK_iMaHangHoa int identity(1, 1) PRIMARY KEY, 
	FK_iMaNhomHang int FOREIGN KEY REFERENCES tblNhomHang(PK_iMaNhomHang), 
	sTenHangHoa nvarchar(50) NOT NULL, 
	iSoLuong int NOT NULL,
	iGiaBan int NOT NULL, 
	sNhanHieu nvarchar(50) NOT NULL, 
	sMauSac nvarchar(50) NOT NULL,
	sDacTinhKiThuat ntext NOT NULL
)

INSERT INTO tblHangHoa (FK_iMaNhomHang, sTenHangHoa, iSoLuong, iGiaBan, sNhanHieu, sMauSac, sDacTinhKiThuat)
VALUES (1, N'Chuột Fuhlen L102', 20, 169000, 'Fuhlen', N'Đen Đỏ', N'Thiết kế đối xứng tiện dụng; chuẩn giao tiếp USB;
phù hợp cho công việc văn phòng và giải trí bình thường'),
(1, N'Chuột Logitech B100 Black', 15, 139000, 'Logitech', N'Đen', N'Chuột quang; độ phân giải 800dpi; Kết nối USB; 
Thiết kế đẹp'),
(1, N'Chuột Razer Basilisk Essential Gaming', 10, 1189000, 'Razer', N'Đen', N'Phiên bản phổ thông của Razer Basilisk;
Thiết kế công thái học giữ nguyên;
Cảm giác cầm cực kì thoải mái;
Mắt cảm biết Razer 5G với 6400DPI cực kì chính xác;
Hệ thống Led màu xanh Green;
Phù hợp với các game thủ cầm chuột Palm Grip;
Trọng lượng giảm 12g, phù hợp để Try Hard FPS'),
(2, N'Bàn phím Fuhlen L500S', 30, 239000, 'Fuhlen', N'Đen', N'Chuẩn kết nối: USB; Số lượng phím: 104;
Độ bền: 20 triệu lần nhấn'),
(2, N'Bàn phím IKBC CD87 PD', 35, 1939000, 'IKBC', N'Đen', N'Bàn phím cơ IKBC CD87 phiên bản PD;
Keycap PBT Doubleshot (PD) dày dặn chắc chắn;
Dùng Switch Cherry nổi tiếng cho cảm giác gõ tốt và độ bền cao;
Build quality chắc chắn, chất lượng rất tốt trong tầm giá;
Layout chuẩn ANSI quốc tế, dễ làm quen;
Màu sắc và thiết kế đơn giản.'),
(3, N'Màn hình Dell S2419HGF', 26, 5389000, 'Dell', N'Đen', N'Kích Thước Màn Hình 24 inch; Độ Sáng Màn Hình 350 cd/m²;
Tỉ Lệ Tương Phản 1000: 1/8000000: 1 (động); Độ Phân Giải Màn Hình Full HD (1080p) 1920x1080 ở 144 Hz (Overclock);
Thời Gian Đáp Ứng 1 ms; Hỗ trợ màu 16.7 Triệu Màu; Góc nhìn 170'),
(3, N'Màn hình LG 27UL850-W.ATV', 88, 11229000, 'LG', N'Ghi', N'Loại màn hình: Phẳng; Tỉ lệ: 16:09; Kích thước: 27 inch;
Tấm nền: IPS; Độ phân giải: UHD 3840 x 2160; Tốc độ làm mới: 60Hz; Thời gian đáp ứng: 5ms;
Cổng kết nối: DisplayPort HDMI, USB Type-C;
Có loa;
Phụ kiện: Cáp nguồn, Cáp HDMI,..'),
(4, N'Tai nghe Sony ZX310AP', 11, 689000, 'Sony', N'Xanh', N'Trọng lượng nhẹ;
Thiết kế linh hoạt, dễ dàng mang theo người;
Có microphone giúp đàm thoại tiện lợi'),
(5, N'Máy in Canon PIXMA G570', 66, 6989000, 'Canon', N'Đen', N'Chức năng : In phun màu;
Khổ giấy: A4;
Cổng giao tiếp: USB , Wifi;
Số hộp mực : 6'),
(5, N'Máy in HP LaserJet M211D', 54, 3989000, 'HP', N'Trắng', N'Tính năng: In trắng đen;
Độ phân giải: 600 x 600 dpi;
Khổ giấy in: A4; A5; A6; B5 (JIS);
Tốc độ in: Lên đến 29 trang / phút')

CREATE TABLE tblHoaDonNhapHang (
	PK_iMaHoaDon int identity(1, 1) PRIMARY KEY,
	dNgayNhap date NOT NULL,
	sTenNguoiNhap nvarchar(50) NOT NULL,
	sNhaCungCap nvarchar(50) NOT NULL
)

INSERT INTO tblHoaDonNhapHang (dNgayNhap, sTenNguoiNhap, sNhaCungCap)
VALUES ('2021-02-25', N'Phan Nhật Minh', N'Công Ty TNHH It Systems Việt Nam'),
('2021-05-31', N'Trần Ngọc Bình', N'Công Ty TNHH Công Nghệ Máy Tính An Phát'),
('2021-08-17', N'Phạm Việt Đức', N'Công Ty TNHH Tin Học Minh An'),
('2021-06-10', N'Đỗ Trí Tân', N'Công Ty TNHH Tin Học HKC')

CREATE TABLE tblHangNhap (
	FK_iMaHangHoa int FOREIGN KEY REFERENCES tblHangHoa(PK_iMaHangHoa),
	FK_iMaHoaDon int FOREIGN KEY REFERENCES tblHoaDonNhapHang(PK_iMaHoaDon),
	iSoLuong int NOT NULL,
	iGiaMotSanPham int NOT NULL
)

INSERT INTO tblHangNhap 
VALUES (1, 1, 13, 169000),
(2, 1, 22, 139000),
(7, 2, 48, 11229000),
(4, 3, 69, 239000),
(5, 3, 77, 1939000),
(10, 4, 35, 3989000)

CREATE TABLE tblHoaDonBanHang (
	PK_iMaHoaDon int identity(1, 1) PRIMARY KEY,
	sTenNguoiNhap nvarchar(50) NOT NULL,
	sTenKhachHang nvarchar(50) NOT NULL,
	dNgayBan date NOT NULL,
	bDaThanhToan bit NOT NULL
)

INSERT INTO tblHoaDonBanHang (sTenNguoiNhap, sTenKhachHang, dNgayBan, bDaThanhToan)
VALUES (N'Nguyễn Văn Toản', 'Richard Bradley', '2021-11-03', 0),
(N'Bùi Văn Hiếu', 'Adam Zapel', '2021-08-07', 1),
(N'Trần Mạnh Hải', 'Amanda Zentro', '2021-03-14', 1),
(N'Phạm Tiến Hưng', 'Jason Comus', '2021-02-02', 0),
(N'Hoàng Thị Bích', 'Zach Copolla', '2021-03-22', 1)

CREATE TABLE tblHangDaBan (
	FK_iMaHoaDon int FOREIGN KEY REFERENCES tblHoaDonBanHang(PK_iMaHoaDon),
	FK_iMaHangHoa int FOREIGN KEY REFERENCES tblHangHoa(PK_iMaHangHoa),
	iSoLuong int NOT NULL,
	dHanBaoHanh date NOT NULL
)

INSERT INTO tblHangDaBan
VALUES (1, 2, 1, '2024-02-15'),
(2, 4, 1, '2024-03-19'),
(3, 5, 2, '2024-03-25'),
(4, 7, 1, '2024-04-01'),
(5, 9, 1, '2024-10-22')
GO

CREATE PROC ShowProduct
AS
SELECT tblNhomHang.sTenNhomHang, tblHangHoa.*
FROM tblNhomHang
RIGHT JOIN tblHangHoa ON tblNhomHang.PK_iMaNhomHang = tblHangHoa.FK_iMaNhomHang
GO

CREATE PROC DeleteProduct
@Id int
AS
DELETE FROM tblHangHoa WHERE PK_iMaHangHoa =  @Id
GO

CREATE PROC UpdateProduct
@Id int, @CategoryId int, @Name nvarchar(50), @Quantity int,
@Price int, @Label nvarchar(50), @Color nvarchar(50), @Attributes ntext
AS
UPDATE tblHangHoa
SET FK_iMaNhomHang = @CategoryId, sTenHangHoa = @Name, iSoLuong = @Quantity, iGiaBan = @Price, sNhanHieu = @Label,
sMauSac = @Color, sDacTinhKiThuat = @Attributes
WHERE PK_iMaHangHoa = @Id
GO

CREATE PROC InsertProduct
@CategoryId int, @Name nvarchar(50), @Quantity int,
@Price int, @Label nvarchar(50), @Color nvarchar(50), @Attributes ntext
AS
INSERT INTO tblHangHoa (FK_iMaNhomHang, sTenHangHoa, iSoLuong, iGiaBan, sNhanHieu, sMauSac, sDacTinhKiThuat)
VALUES (@CategoryId, @Name, @Quantity, @Price, @Label, @Color, @Attributes)
GO

CREATE PROCEDURE [dbo].[PROC_getImportReceiptInfo]
	@param1 /*parameter name*/ int /*datatype_for_param1*/ = 0 /*default_value_for_param1*/
-- add more stored procedure parameters here
AS
	-- body of the stored procedure
	SELECT  tblHangHoa.PK_iMaHangHoa,sTenHangHoa,sNhanHieu,sMausac, tblHangNhap.iSoLuong,iGiaMotSanPham
	FROM tblHangNhap INNER JOIN tblHangHoa ON tblHangNhap.FK_iMaHangHoa = tblHangHoa.PK_iMaHangHoa WHERE FK_iMaHoaDon=@param1
GO

-- Create a new stored procedure called 'PROC_getExportDetailInfo' in schema 'dbo'
-- Drop the stored procedure if it already exists
IF EXISTS (
SELECT *
	FROM INFORMATION_SCHEMA.ROUTINES
WHERE SPECIFIC_SCHEMA = N'dbo'
	AND SPECIFIC_NAME = N'PROC_getExportDetailInfo'
)
DROP PROCEDURE dbo.PROC_getExportDetailInfo
GO
-- Create the stored procedure in the specified schema
CREATE PROCEDURE dbo.PROC_getExportDetailInfo
	@param1 /*parameter name*/ int /*datatype_for_param1*/ = 0 /*default_value_for_param1*/
-- add more stored procedure parameters here
AS
	-- body of the stored procedure
	SELECT tblHangHoa.PK_iMaHangHoa,sTenHangHoa,sNhanHieu,sMauSac, iGiaBan, tblHangDaBan.iSoLuong,dHanBaoHanh
	FROM tblHangDaBan INNER JOIN tblHangHoa ON tblHangDaBan.FK_iMaHangHoa = tblHangHoa.PK_iMaHangHoa
	WHERE tblHangDaBan.FK_iMaHoaDon = @param1
GO


-- Create a new stored procedure called 'PROC_insertTotblHoaDonNhapHang' in schema 'dbo'
-- Drop the stored procedure if it already exists
IF EXISTS (
SELECT *
	FROM INFORMATION_SCHEMA.ROUTINES
WHERE SPECIFIC_SCHEMA = N'dbo'
	AND SPECIFIC_NAME = N'PROC_insertTotblHoaDonNhapHang'
)
DROP PROCEDURE dbo.PROC_insertTotblHoaDonNhapHang
GO
-- Create the stored procedure in the specified schema
CREATE PROCEDURE dbo.PROC_insertTotblHoaDonNhapHang
	@dNgayNhap /*parameter name*/ date /*datatype_for_param1*/ , /*default_value_for_param1*/
	@sTenNguoiNhap /*parameter name*/ nvarchar(50) /*datatype_for_param1*/,  /*default_value_for_param2*/
	@sNhaCungCap /*parameter name*/ nvarchar(50) /*datatype_for_param1*/  /*default_value_for_param2*/
-- add more stored procedure parameters here
AS
	-- body of the stored procedure
	-- Insert rows into table 'tblHoaDonNhapHang'
	INSERT INTO tblHoaDonNhapHang
	VALUES
	( -- first row: values for the columns in the list above
	 @dNgayNhap, @sTenNguoiNhap, @sNhaCungCap
	)
	-- add more rows here
	GO
GO

-- Create a new stored procedure called 'PROC_instertTotblHangNhap' in schema 'dbo'
-- Drop the stored procedure if it already exists
IF EXISTS (
SELECT *
	FROM INFORMATION_SCHEMA.ROUTINES
WHERE SPECIFIC_SCHEMA = N'dbo'
	AND SPECIFIC_NAME = N'PROC_instertTotblHangNhap'
)
DROP PROCEDURE dbo.PROC_instertTotblHangNhap
GO
-- Create the stored procedure in the specified schema
CREATE PROCEDURE dbo.PROC_instertTotblHangNhap
	@FK_iMaHangHoa /*parameter name*/ int /*datatype_for_param1*/ = 0, /*default_value_for_param1*/
	@FK_iMaHoaDon /*parameter name*/ int /*datatype_for_param1*/ = 0, /*default_value_for_param2*/
	@iSoLuong /*parameter name*/ int /*datatype_for_param1*/ = 0, /*default_value_for_param2*/
	@iGiaMotSanPham /*parameter name*/ int /*datatype_for_param1*/ = 0 /*default_value_for_param2*/
-- add more stored procedure parameters here
AS
	-- body of the stored procedure
	INSERT INTO tblHangNhap
	VALUES
	(@FK_iMaHangHoa,@FK_iMaHoaDon,@iSoLuong, @iGiaMotSanPham)
GO


-- Create a new stored procedure called 'PROC_getLatestInsertedKeyFromtblHoaDonNhapHang' in schema 'dbo'
-- Drop the stored procedure if it already exists
IF EXISTS (
SELECT *
	FROM INFORMATION_SCHEMA.ROUTINES
WHERE SPECIFIC_SCHEMA = N'dbo'
	AND SPECIFIC_NAME = N'PROC_getLatestInsertedKeyFromtblHoaDonNhapHang'
)
DROP PROCEDURE dbo.PROC_getLatestInsertedKeyFromtblHoaDonNhapHang
GO
-- Create the stored procedure in the specified schema
CREATE PROCEDURE dbo.PROC_getLatestInsertedKeyFromtblHoaDonNhapHang

-- add more stored procedure parameters here
AS
	-- body of the stored procedure
	SELECT IDENT_CURRENT('tblHoaDonNhapHang')
GO


-- Create a new stored procedure called 'PROC_insertTotblHoaDonBanHang' in schema 'dbo'
-- Drop the stored procedure if it already exists
IF EXISTS (
SELECT *
	FROM INFORMATION_SCHEMA.ROUTINES
WHERE SPECIFIC_SCHEMA = N'dbo'
	AND SPECIFIC_NAME = N'PROC_insertTotblHoaDonBanHang'
)
DROP PROCEDURE dbo.PROC_insertTotblHoaDonBanHang
GO
-- Create the stored procedure in the specified schema
CREATE PROCEDURE dbo.PROC_insertTotblHoaDonBanHang
	@sTenNguoiNhap /*parameter name*/ nvarchar(50) /*datatype_for_param1*/ , /*default_value_for_param1*/
	@sTenKhachHang /*parameter name*/ nvarchar(50) /*datatype_for_param1*/, /*default_value_for_param1*/
	@dNgayBan /*parameter name*/ date /*datatype_for_param1*/, /*default_value_for_param1*/
	@bDaThanhToan /*parameter name*/ bit /*datatype_for_param1*/  /*default_value_for_param2*/
-- add more stored procedure parameters here
AS
	-- body of the stored procedure
	-- Insert rows into table 'tblHoaDonBanHang'
	INSERT INTO tblHoaDonBanHang
	VALUES
	( -- first row: values for the columns in the list above
	 @sTenNguoiNhap, @sTenKhachHang, @dNgayBan, @bDaThanhToan
	)
	-- add more rows here
	GO
GO


-- Create a new stored procedure called 'PROC_getLatestInsertedKeyFromtblHoaDonBanHang' in schema 'dbo'
-- Drop the stored procedure if it already exists
IF EXISTS (
SELECT *
	FROM INFORMATION_SCHEMA.ROUTINES
WHERE SPECIFIC_SCHEMA = N'dbo'
	AND SPECIFIC_NAME = N'PROC_getLatestInsertedKeyFromtblHoaDonBanHang'
)
DROP PROCEDURE dbo.PROC_getLatestInsertedKeyFromtblHoaDonBanHang
GO
-- Create the stored procedure in the specified schema
CREATE PROCEDURE dbo.PROC_getLatestInsertedKeyFromtblHoaDonBanHang
	
AS
	-- body of the stored procedure
	SELECT IDENT_CURRENT('tblHoaDonBanHang')
GO
-- example to execute the stored procedure we just created

-- Create a new stored procedure called 'insertTotblHangDaBan' in schema 'dbo'
-- Drop the stored procedure if it already exists
IF EXISTS (
SELECT *
	FROM INFORMATION_SCHEMA.ROUTINES
WHERE SPECIFIC_SCHEMA = N'dbo'
	AND SPECIFIC_NAME = N'insertTotblHangDaBan'
)
DROP PROCEDURE dbo.insertTotblHangDaBan
GO
-- Create the stored procedure in the specified schema
CREATE PROCEDURE dbo.insertTotblHangDaBan
	@FK_iMaHoaDon /*parameter name*/ int /*datatype_for_param1*/ = 0, /*default_value_for_param1*/
	@FK_iMaHangHoa /*parameter name*/ int /*datatype_for_param1*/ = 0, /*default_value_for_param1*/
	@iSoLuong /*parameter name*/ int /*datatype_for_param1*/ = 0, /*default_value_for_param1*/
	@dHanBaoHanh /*parameter name*/ date /*datatype_for_param1*/ /*default_value_for_param2*/
-- add more stored procedure parameters here
AS
	-- body of the stored procedure
	INSERT INTO tblHangDaBan
	VALUES 
	(@FK_iMaHoaDon, @FK_iMaHangHoa, @iSoLuong, @dHanBaoHanh)
GO


-- Create a new stored procedure called 'PROC_deleteRowstblHoaDonBanHang' in schema 'dbo'
-- Drop the stored procedure if it already exists
IF EXISTS (
SELECT *
	FROM INFORMATION_SCHEMA.ROUTINES
WHERE SPECIFIC_SCHEMA = N'dbo'
	AND SPECIFIC_NAME = N'PROC_deleteRowstblHoaDonBanHang'
)
DROP PROCEDURE dbo.PROC_deleteRowstblHoaDonBanHang
GO
-- Create the stored procedure in the specified schema
CREATE PROCEDURE dbo.PROC_deleteRowstblHoaDonBanHang
	@param1 /*parameter name*/ int /*datatype_for_param1*/ = 0 /*default_value_for_param1*/
-- add more stored procedure parameters here
AS
	-- body of the stored procedure
	-- Delete rows from table 'tblHoaDonBanHang'
	DELETE FROM tblHoaDonBanHang
	WHERE PK_iMaHoaDon = @param1	/* add search conditions here */
GO

-- Create a new stored procedure called 'PROC_deleteRowstblHangDaBan' in schema 'dbo'
-- Drop the stored procedure if it already exists
IF EXISTS (
SELECT *
	FROM INFORMATION_SCHEMA.ROUTINES
WHERE SPECIFIC_SCHEMA = N'dbo'
	AND SPECIFIC_NAME = N'PROC_deleteRowstblHangDaBan'
)
DROP PROCEDURE dbo.PROC_deleteRowstblHangDaBan
GO
-- Create the stored procedure in the specified schema
CREATE PROCEDURE dbo.PROC_deleteRowstblHangDaBan
	@param1 /*parameter name*/ int /*datatype_for_param1*/ = 0 /*default_value_for_param1*/
-- add more stored procedure parameters here
AS
	-- body of the stored procedure
	DELETE FROM tblHangDaBan
	WHERE FK_iMaHoaDon = @param1
GO

-- Create a new stored procedure called 'PROC_deleteRowtblHoaDonNhapHang' in schema 'dbo'
-- Drop the stored procedure if it already exists
IF EXISTS (
SELECT *
	FROM INFORMATION_SCHEMA.ROUTINES
WHERE SPECIFIC_SCHEMA = N'dbo'
	AND SPECIFIC_NAME = N'PROC_deleteRowtblHoaDonNhapHang'
)
DROP PROCEDURE dbo.PROC_deleteRowtblHoaDonNhapHang
GO
-- Create the stored procedure in the specified schema
CREATE PROCEDURE dbo.PROC_deleteRowtblHoaDonNhapHang
	@param1 /*parameter name*/ int /*datatype_for_param1*/ = 0 /*default_value_for_param1*/
-- add more stored procedure parameters here
AS
	-- body of the stored procedure
	-- Delete rows from table 'tblHoaDonNhapHang'
	DELETE FROM tblHoaDonNhapHang
	WHERE PK_iMaHoaDon = @param1	/* add search conditions here */
GO

-- Create a new stored procedure called 'PROC_deleteRowstblHangNhap' in schema 'dbo'
-- Drop the stored procedure if it already exists
IF EXISTS (
SELECT *
	FROM INFORMATION_SCHEMA.ROUTINES
WHERE SPECIFIC_SCHEMA = N'dbo'
	AND SPECIFIC_NAME = N'PROC_deleteRowstblHangNhap'
)
DROP PROCEDURE dbo.PROC_deleteRowstblHangNhap
GO
-- Create the stored procedure in the specified schema
CREATE PROCEDURE dbo.PROC_deleteRowstblHangNhap
	@param1 /*parameter name*/ int /*datatype_for_param1*/ = 0 /*default_value_for_param1*/
AS
	-- body of the stored procedure
	DELETE FROM tblHangNhap
	WHERE FK_iMaHoaDon = @param1
GO

-- Create a new stored procedure called 'PROC_updatetblHoaDonNhapHang' in schema 'dbo'
-- Drop the stored procedure if it already exists
IF EXISTS (
SELECT *
	FROM INFORMATION_SCHEMA.ROUTINES
WHERE SPECIFIC_SCHEMA = N'dbo'
	AND SPECIFIC_NAME = N'PROC_updatetblHoaDonNhapHang'
)
DROP PROCEDURE dbo.PROC_updatetblHoaDonNhapHang
GO
-- Create the stored procedure in the specified schema
CREATE PROCEDURE dbo.PROC_updatetblHoaDonNhapHang
	@PK_iMaHoaDon /*parameter name*/ int /*datatype_for_param1*/ , /*default_value_for_param1*/
	@dNgayNhap /*parameter name*/ date /*datatype_for_param1*/ , /*default_value_for_param1*/
	@sTenNguoiNhap /*parameter name*/ nvarchar(50) /*datatype_for_param1*/ , /*default_value_for_param1*/
	@sNhaCungCap /*parameter name*/ nvarchar(50) /*datatype_for_param1*/  /*default_value_for_param2*/
-- add more stored procedure parameters here
AS
	-- body of the stored procedure
	UPDATE tblHoaDonNhapHang
	SET dNgayNhap = @dNgayNhap, 
		sTenNguoiNhap = @sTenNguoiNhap,
		sNhaCungCap = @sNhaCungCap
	WHERE PK_iMaHoaDon = @PK_iMaHoaDon
GO


-- Create a new stored procedure called 'PROC_updatetblHoaDonBanHang' in schema 'SchemaName'
-- Drop the stored procedure if it already exists
IF EXISTS (
SELECT *
	FROM INFORMATION_SCHEMA.ROUTINES
WHERE SPECIFIC_SCHEMA = N'dbo'
	AND SPECIFIC_NAME = N'PROC_updatetblHoaDonBanHang'
)
DROP PROCEDURE dbo.PROC_updatetblHoaDonBanHang
GO
-- Create the stored procedure in the specified schema
CREATE PROCEDURE dbo.PROC_updatetblHoaDonBanHang
	@PK_iMaHoaDon /*parameter name*/ int /*datatype_for_param1*/ ,
	@sTenNguoiNhap /*parameter name*/ nvarchar(50) /*datatype_for_param1*/ ,
	@sTenKhachHang /*parameter name*/ nvarchar(50) /*datatype_for_param1*/ ,
	@dNgayBan /*parameter name*/ date /*datatype_for_param1*/ ,
	@bDaThanhToan /*parameter name*/ bit /*datatype_for_param1*/ 
-- add more stored procedure parameters here
AS
	-- body of the stored procedure
	-- Update rows in table 'tblHoaDonBanHang'
	UPDATE tblHoaDonBanHang
	SET
		[sTenNguoiNhap] = @sTenNguoiNhap,
		[sTenKhachHang] = @sTenKhachHang,
		[dNgayBan] = @dNgayBan,
		[bDaThanhToan] = @bDaThanhToan
		-- add more columns and values here
	WHERE PK_iMaHoaDon = @PK_iMaHoaDon	/* add search conditions here */
	GO
GO


-- Create a new stored procedure called 'PROC_getImportReceipt' in schema 'dbo'
-- Drop the stored procedure if it already exists
IF EXISTS (
SELECT *
	FROM INFORMATION_SCHEMA.ROUTINES
WHERE SPECIFIC_SCHEMA = N'dbo'
	AND SPECIFIC_NAME = N'PROC_getImportReceipt'
)
DROP PROCEDURE dbo.PROC_getImportReceipt
GO
-- Create the stored procedure in the specified schema
CREATE PROCEDURE dbo.PROC_getImportReceipt
	@param1 /*parameter name*/ int /*datatype_for_param1*/ = 0
-- add more stored procedure parameters here
AS
	-- body of the stored procedure
	SELECT * FROM tblHoaDonNhapHang
	WHERE PK_iMaHoaDon = @param1
GO
-- example to execute the stored procedure we just created
EXECUTE dbo.PROC_getImportReceipt 1 /*value_for_param1*/
GO


-- Create a new stored procedure called 'PROC_getImportReceiptInfo' in schema 'dbo'
-- Drop the stored procedure if it already exists
IF EXISTS (
SELECT *
	FROM INFORMATION_SCHEMA.ROUTINES
WHERE SPECIFIC_SCHEMA = N'dbo'
	AND SPECIFIC_NAME = N'PROC_getImportReceiptInfoById'
)
DROP PROCEDURE dbo.PROC_getImportReceiptInfoById
GO
-- Create the stored procedure in the specified schema
CREATE PROCEDURE dbo.PROC_getImportReceiptInfoById
	@param1 /*parameter name*/ int /*datatype_for_param1*/ = 0 /*default_value_for_param1*/
-- add more stored procedure parameters here
AS
	-- body of the stored procedure
	SELECT tblHangHoa.PK_iMaHangHoa,sNhanHieu,sNhaCungCap ,tblHangNhap.iSoLuong,tblHangNhap.iGiaMotSanPham
	FROM (tblHoaDonNhapHang INNER JOIN tblHangNhap ON tblHoaDonNhapHang.PK_iMaHoaDon = tblHangNhap.FK_iMaHoaDon)
			INNER JOIN tblHangHoa ON tblHangNhap.FK_iMaHangHoa = tblHangHoa.PK_iMaHangHoa
	WHERE tblHoaDonNhapHang.PK_iMaHoaDon = @param1
GO
-- example to execute the stored procedure we just created
EXECUTE dbo.PROC_getImportReceiptInfoById 1 /*value_for_param1*/
GO

-- Create a new stored procedure called 'PROC_getExportReceipt' in schema 'dbo'
-- Drop the stored procedure if it already exists
IF EXISTS (
SELECT *
	FROM INFORMATION_SCHEMA.ROUTINES
WHERE SPECIFIC_SCHEMA = N'dbo'
	AND SPECIFIC_NAME = N'PROC_getExportReceipt'
)
DROP PROCEDURE dbo.PROC_getExportReceipt
GO
-- Create the stored procedure in the specified schema
CREATE PROCEDURE dbo.PROC_getExportReceipt
	@param1 /*parameter name*/ int /*datatype_for_param1*/ = 0 /*default_value_for_param1*/
-- add more stored procedure parameters here
AS
	-- body of the stored procedure
	SELECT *
	FROM tblHoaDonBanHang
GO


-- Create a new stored procedure called 'PROC_getExportReceiptDetailById' in schema 'dbo'
-- Drop the stored procedure if it already exists
IF EXISTS (
SELECT *
	FROM INFORMATION_SCHEMA.ROUTINES
WHERE SPECIFIC_SCHEMA = N'dbo'
	AND SPECIFIC_NAME = N'PROC_getExportReceiptDetailById'
)
DROP PROCEDURE dbo.PROC_getExportReceiptDetailById
GO
-- Create the stored procedure in the specified schema
CREATE PROCEDURE dbo.PROC_getExportReceiptDetailById
	@param1 /*parameter name*/ int /*datatype_for_param1*/ = 0 /*default_value_for_param1*/
-- add more stored procedure parameters here
AS
	-- body of the stored procedure
	SELECT tblHangDaBan.FK_iMaHangHoa,dHanBaoHanh, tblHangDaBan.iSoLuong, tblHangHoa.sTenHangHoa,iGiaBan
	FROM tblHangDaBan INNER JOIN tblHangHoa ON tblHangDaBan.FK_iMaHangHoa = tblHangHoa.PK_iMaHangHoa
	WHERE tblHangDaBan.FK_iMaHoaDon = @param1
GO
-- example to execute the stored procedure we just created

CREATE TABLE Accounts (
	PK_iMaTaiKhoan int identity(1, 1) PRIMARY KEY,
	sTenTaiKhoan nvarchar(50) NOT NULL,
	sMatKhau nvarchar(50) NOT NULL,
	sEmail nvarchar(50) NOT NULL,
	sSoDienThoai nvarchar(50) NOT NULL
)

insert into Accounts (sTenTaiKhoan, sMatKhau, sEmail, sSoDienThoai)
Values
--('bunnerz2001', '12345', 'bunnerz2001@gmail.com', '0904733549'),
('admin', '123', 'admin@gmail.com', '0000000000')

CREATE TABLE RememberMe (
	sTenTaiKhoan nvarchar(50),
	sMatKhau nvarchar(50),
	bChecked bit
)
GO

CREATE PROC SaveAccountInfo
@Username nvarchar(50), @Password nvarchar(50)
AS
INSERT INTO RememberMe
VALUES(@Username, @Password, 1)
GO

CREATE PROC DropAccountInfo
AS
TRUNCATE TABLE RememberMe
GO


alter PROC getAccountID
@username nvarchar(50) 
AS
SELECT PK_iMaTaiKhoan FROM Accounts WHERE sTenTaiKhoan = @username
GO

alter PROC getAccountName
@username nvarchar(50)
AS
SELECT sTenTaiKhoan FROM Accounts WHERE sTenTaiKhoan = @username
GO

alter PROC getAccountEmail
@username nvarchar(50)
AS
SELECT sEmail FROM Accounts WHERE sTenTaiKhoan = @username
GO

alter PROC getAccountPhoneNumber
@username nvarchar(50)
AS
SELECT sSoDienThoai FROM Accounts WHERE sTenTaiKhoan = @username
GO

SELECT * FROM tblHangHoa

alter proc InsertAccount
@stentaikhoan nvarchar(50),
@sMatkhau nvarchar(50),
@sLaimatkhau nvarchar(50),
@sEmail nvarchar(50),
@sSDT nvarchar(50)
as
begin
	insert into Accounts(sTenTaiKhoan,sMatKhau,sLaiMatKhau,sEmail,sSoDienThoai)
	values(@stentaikhoan,@sMatkhau,@sLaimatkhau,@sEmail,@sSDT)
end