--Tạo cơ sở dữ liệu shop quản lý bán cầu lông

--1. Xác định các bảng dữ liệu cần thiết:

--Bảng Sản phẩm:

--    Mã sản phẩm (khóa chính)
--    Tên sản phẩm
--    Loại sản phẩm (ví dụ: vợt, giày, quần áo, phụ kiện)
--    Hãng sản xuất
--    Giá bán
--    Số lượng tồn kho
--    Mô tả sản phẩm
--    Hình ảnh sản phẩm

--Bảng Khách hàng:

--    Mã khách hàng (khóa chính)
--    Họ và tên
--    Số điện thoại
--    Địa chỉ
--    Email
--    Ghi chú

--Bảng Hóa đơn bán hàng:

--    Mã hóa đơn (khóa chính)
--    Ngày bán
--    Mã khách hàng (khóa ngoại tham chiếu bảng Khách hàng)
--    Mã nhân viên (khóa ngoại tham chiếu bảng Nhân viên)
--    Tổng giá trị hóa đơn
--    Hình thức thanh toán
--    Ghi chú

--Bảng Chi tiết hóa đơn:

--    Mã hóa đơn (khóa ngoại tham chiếu bảng Hóa đơn bán hàng)
--    Mã sản phẩm (khóa ngoại tham chiếu bảng Sản phẩm)
--    Số lượng
--    Giá bán

--Bảng Nhân viên:

--    Mã nhân viên (khóa chính)
--    Họ và tên
--    Chức vụ
--    Lương
--    Số điện thoại
--    Địa chỉ

CREATE DATABASE QL_CAULONG

CREATE TABLE SANPHAM (
  MASP INT NOT NULL,
  TENSP VARCHAR(255),
  LOAISP VARCHAR(50),
  HANGSX VARCHAR(50),
  GIABAN INT,
  SOLUONG INT,
  MOTASP TEXT,
  HINHANH VARCHAR(255),
  MANSX INT,

  CONSTRAINT PK_SANPHAM PRIMARY KEY (MASP),
 );

CREATE TABLE NHASANXUAT(
	MANSX INT NOT NULL,
	TENNSX VARCHAR(250),

	CONSTRAINT PK_NHASANXUAT PRIMARY KEY (MANSX),
);
CREATE TABLE KHACHHANG (
  MAKH INT NOT NULL,
  HOTEN VARCHAR(255),
  SDT VARCHAR(20),
  DIACHI VARCHAR(255),
  GHICHU TEXT,

  CONSTRAINT PK_KHACHHANG PRIMARY KEY (MAKH),
);

CREATE TABLE HOADON (
  MAHD INT NOT NULL,
  NGAYBAN DATE,
  SOLUONG INT,
  TONGTIEN INT,
  GHICHU TEXT,
  MAKH INT,
  MANV INT,
  
  CONSTRAINT PK_HOADON PRIMARY KEY (MAHD),
 );

CREATE TABLE NHANVIEN (
  MANV INT,
  HOTEN VARCHAR(255),
  CHUCVU VARCHAR(50),
  SDT VARCHAR(20),

  CONSTRAINT PK_NHANVIEN PRIMARY KEY (MANV),
);