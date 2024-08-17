

CREATE DATABASE QL_BadmintonShop
USE QL_BadmintonShop

CREATE TABLE NHASANXUAT (
    MANSX INT NOT NULL,
    TENNSX NVARCHAR(250),

    CONSTRAINT PK_NHASANXUAT PRIMARY KEY (MANSX)
);
CREATE TABLE LOAI(
	MALOAI INT NOT NULL,
	TENLOAI NVARCHAR(250),
	
	CONSTRAINT PK_LOAI PRIMARY KEY (MALOAI)
);
CREATE TABLE SANPHAM (
  MASP INT NOT NULL,
  TENSP NVARCHAR(255),
  MALOAI INT,
  GIABAN INT,
  SOLUONG INT,
  MOTASP NVARCHAR(500),
  HINHANH VARCHAR(255),
  HINH2 VARCHAR(255), 
  HINH3 VARCHAR(255),
  MANSX INT,

  CONSTRAINT PK_SANPHAM PRIMARY KEY (MASP),
  CONSTRAINT FK_SANPHAMNSX FOREIGN KEY (MANSX) REFERENCES NHASANXUAT (MANSX),
  CONSTRAINT FK_SANPHAMLOAI FOREIGN KEY (MALOAI) REFERENCES LOAI (MALOAI)
 )

CREATE TABLE NHANVIEN (
  MANV INT NOT NULL,
  HOTEN NVARCHAR(255),
  CHUCVU NVARCHAR(225),
  SDT VARCHAR(20),

  CONSTRAINT PK_NHANVIEN PRIMARY KEY (MANV),
)

CREATE TABLE KHACHHANG (
  MAKH INT NOT NULL,
  HOTEN NVARCHAR(255),
  SDT NVARCHAR(20),

  CONSTRAINT PK_KHACHHANG PRIMARY KEY (MAKH),
)

CREATE TABLE HOADON (
  MAHD INT NOT NULL,
  NGAYBAN DATE,
  TONGTIEN INT,
  MAKH INT,
  MANV INT,
  
  CONSTRAINT PK_HOADON PRIMARY KEY (MAHD),
  CONSTRAINT FK_HODONKH FOREIGN KEY (MAKH) REFERENCES KHACHHANG(MAKH),
  CONSTRAINT FK_HOADONNV FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV),
 )

 CREATE TABLE CHITIETHOADON(
	MACTHD INT NOT NULL,
	MASP INT NOT NULL,
	MAHD INT NOT NULL,
	SOLUONG INT,

	CONSTRAINT PK_CTHD PRIMARY KEY (MACTHD),
	CONSTRAINT FK_CTHD_SP FOREIGN KEY (MASP) REFERENCES SANPHAM(MASP),
	CONSTRAINT FK_CTHD_HD FOREIGN KEY (MAHD) REFERENCES HOADON(MAHD),
 )

INSERT INTO NHASANXUAT( MANSX, TENNSX)
VALUES
(1, 'Yonex'),
(2, 'Lining'),
(3, 'Victor'),
(4, 'Mizuno'),
(5, 'Apacs')

INSERT INTO LOAI( MALOAI, TENLOAI)
VALUES
(1, 'Vot'),
(2, 'Giay'),
(3,'QuanNam'),
(4,'QuanNu'),
(5,'Vay'),
(6,'AoNam'),
(7,'AoNu'),
(8,'Balo'),
(9,'Tui'),
(10,'VoDai'),
(11,'VoNgan'),
(12,'PhuKien') 

INSERT INTO SANPHAM( MASP, TENSP, MALOAI, GIABAN, SOLUONG, MOTASP, HINHANH, HINH2, HINH3, MANSX)
VALUES
(1, N'Yonex Astrox 88D pro',1 , 4500000, 10, N'Dòng vợt cao cấp của hãng Yonex','1.png','1(1).png','1(2).png',1),
(2, N'Yonex Astrox 77D pro',1 , 3500000, 10, N'Dòng vợt cao cấp của hãng Yonex','2.png','2(1).png','2(2).png',1),
(3, N'Yonex Nanoflare 800',1 , 1000000, 10, N'Dòng vợt cao cấp của hãng Yonex','3.png','3(1).png','3(2).png',1),
(4, N'Yonex Nanoflare 1000z',1 , 4000000, 10, N'Dòng vợt cao cấp của hãng Yonex','4.png','4(1).png','4(2).png',1),
(5, N'Lining Techtonic 7',1 , 4500000, 10, N'Dòng vợt cao cấp của hãng Lining','5.png','5(1).png','5(2).png',2),
(6, N'Lining Techtonic 9',1 , 3500000, 10, N'Dòng vợt cao cấp của hãng Lining','6.png','6(1).png','6(2).png',2),
(7, N'Lining Axforce 90',1 , 2500000, 10, N'Dòng vợt cao cấp của hãng Lining','7.png','7(1).png','7(2).png',2),
(8, N'Lining Axforce 80',1 , 1500000, 10, N'Dòng vợt cao cấp của hãng Lining','8.png','8(1).png','8(2).png',2),
(9, N'Victor Drivex 800',1 , 500000, 10, N'Dòng vợt cao cấp của hãng Victor','9.png','9(1).png','9(2).png',3),
(10, N'Victor Thruster Ryuga II Pro',1 , 500000, 10, N'Dòng vợt cao cấp của hãng Victor','10.png','10(1).png','10(2).png',3),
(11, N'Victor ARS 90K II',1 , 100000, 10, N'Dòng vợt cao cấp của hãng Victor','11.png','11(1).png','11(2).png',3),
(12, N'Victor Spider Man Limited',1 , 500000, 10, N'Dòng vợt cao cấp của hãng Victor','12.png','12(1).png','12(2).png',3),
(13, N'Mizuno Altrax 81',1 , 1800000, 10, N'Dòng vợt cao cấp của hãng Mizuno','13.png','13(1).png','13(2).png',4),
(14, N'Mizuno Fortius 11',1 , 2500000, 10, N'Dòng vợt cao cấp của hãng Mizuno','14.png','14(1).png','14(2).png',4),
(15, N'Mizuno Acrospeed 01',1 , 7500000, 10, N'Dòng vợt cao cấp của hãng Mizuno','15.png','15(1).png','15(2).png',4),
(16, N'Mizuno Fortius 20',1 , 2500000, 10, N'Dòng vợt cao cấp của hãng Mizuno','16.png','16(1).png','16(2).png',4),
(17, N'Apacs Ziggler',1 , 8500000, 10, N'Dòng vợt cao cấp của hãng Apacs','17.png','17(1).png','17(2).png',5),
(18, N'Apacs Z-Power 800',1 , 6500000, 10, N'Dòng vợt cao cấp của hãng Apacs','18.png','18(1).png','18(2).png',5),
(19, N'Apacs Precision 1.0 ',1 , 1500000, 10, N'Dòng vợt cao cấp của hãng Apacs','19.png','19(1).png','19(2).png',5),
(20, N'Apacs Power Concept 928',1 , 800000, 10, N'Dòng vợt cao cấp của hãng Apacs','20.png','20(1).png','20(2).png',5),
--Giày
(101, N'Yonex 111',2 , 3000000, 10, N'Giày cao cấp của hãng Yonex','101.png',null, null, 1),
(102, N'Yonex 222',2 , 3500000, 10, N'Giày cao cấp của hãng Yonex','102.png', null, null, 1),
(103, N'Yonex 333',2 , 1000000, 10, N'Giày cao cấp của hãng Yonex','103.png', null, null, 1),
(104, N'Yonex 444',2 , 3000000, 10, N'Giày cao cấp của hãngg Yonex','104.png', null, null, 1),
(105, N'Lining 111',2 , 4500000, 10, N'Giày cao cấp của hãng Lining','105.png', null, null, 2),
(106, N'Lining 222',2 , 3500000, 10, N'Giày cao cấp của hãng Lining','106.png', null, null, 2),
(107, N'Lining 333',2 , 2500000, 10, N'Giày cao cấp của hãng Lining','107.png', null, null, 2),
(108, N'Lining 444',2 , 1500000, 10, N'Giày cao cấp của hãng Lining','108.png', null, null, 2),
(109, N'Victor 111',2 , 500000, 10, N'Giày cao cấp của hãng Victor','109.png', null, null, 3),
(110, N'Victor 222',2 , 500000, 10, N'Giày cao cấp của hãng Victor','110.png', null, null, 3),
(111, N'Victor 333', 2, 100000, 10, N'Giày cao cấp của hãng Victor','111.png', null, null, 3),
(112, N'Victor 444', 2, 500000, 10, N'Giày cao cấp của hãng Victor','112.png', null, null, 3),
(113, N'Mizuno 111', 2, 1800000, 10, N'Giày cao cấp của hãng Mizuno','113.png', null, null, 4),
(114, N'Mizuno 222', 2, 2500000, 10, N'Giày cao cấp của hãng Mizuno','114.png', null, null, 4),
(115, N'Mizuno 333', 2, 7500000, 10, N'Giày cao cấp của hãng Mizuno','115.png', null, null, 4),
(116, N'Mizuno 444', 2, 2500000, 10, N'Giày cao cấp của hãng Mizuno','116.png', null, null, 4),
(117, N'Apacs 111',2, 8500000, 10, N'Giày cao cấp của hãng Apacs','117.png', null, null, 5),
(118, N'Apacs 222', 2, 6500000, 10, N'Giày cao cấp của hãng Apacs','118.png', null, null, 5),
(119, N'Apacs 333 ', 2, 1500000, 10, N'Giày cao cấp của hãng Apacs','119.png', null, null, 5),
(120, N'Apacs 444', 2, 800000, 10, N'Giày cao cấp của hãng Apacs','120.png', null, null, 5),
--Quần nam
(201, N'Quần nam Yonex 01',3, 1000000, 5, N'Yonex Product', '201.png', null, null, 1),
(202, N'Quần nam Yonex 02',3, 2000000, 8, N'Yonex Product', '202.png', null, null, 1),
(203, N'Quần nam Lining 01',3, 3900000, 3, N'Lining Product', '203.png', null, null, 2),
(204, N'Quần nam Lining 02',3, 2000000, 5, N'Lining Product', '204.png', null, null, 2),
(205, N'Quần nam Victor 01',3, 500000, 10, N'Victor Product', '205.png', null, null, 3),
(206, N'Quần nam Victor 02',3, 700000, 9, N'Victor Product', '206.png', null, null, 3),
(207, N'Quần nam Mizuno 01',3, 500000, 7, N'Mizuno Product', '207.png', null, null, 4),
(208, N'Quần nam Mizuno 02',3, 800000, 1, N'Mizuno Product', '208.png', null, null, 4),
(209, N'Quần nam Apacs 01',3, 400000, 2, N'Apacs Product', '209.png', null, null, 5),
(210, N'Quần nam Apacs 02',3, 900000, 4, N'Apacs Product', '210.png', null, null, 5),
--Quần nữ
(251, N'Quần nữ Yonex 01', 4, 100000, 5, N'Yonex Product','251.png',  null, null, 1),
(252, N'Quần nữ Yonex 02', 4, 400000, 8, N'Yonex Product', '252.png',  null, null, 1),
(253, N'Quần nữ Lining 01',4, 390000, 3, N'Lining Product', '253.png', null, null, 2),
(254, N'Quần nữ Lining 02', 4, 100000, 5, N'Lining Product', '254.png', null, null, 2),
(255, N'Quần nữ Victor 01',4, 200000, 10, N'Victor Product', '255.png', null, null, 3),
(256, N'Quần nữ Victor 02',4, 200000, 9, N'Victor Product', '256.png', null, null, 3),
(257, N'Quần nữ Mizuno 01',4, 210000, 7, N'Mizuno Product', '257.png', null, null, 4),
(258, N'Quần nữ Mizuno 02',4, 110000, 1, N'Mizuno Product', '258.png', null, null, 4),
(259, N'Quần nữ Apacs 01',4, 230000, 2, N'Apacs Product', '259.png', null, null, 5),
(260, N'Quần nữ Apacs 02', 4, 160000, 4, N'Apacs Product', '260.png', null, null, 5),
--Váy
(271, N'Váy nữ Yonex 01',5, 1000000, 5, N'Yonex Product', '271.png', null, null, 1),
(272, N'Váy nữ Yonex 02',5, 120000, 8, N'Yonex Product', '272.png', null, null, 1),
(273, N'Váy nữ Lining 01',5, 110000, 3, N'Lining Product', '273.png', null, null, 2),
(274, N'Váy nữ Lining 02',5, 130000, 5, N'Lining Product', '274.png', null, null, 2),
(275, N'Váy nữ Victor 01',5, 180000, 10, N'Lining Product', '275.png', null, null, 3),
(276, N'Váy nữ Victor 02',5, 110000, 9, N'Lining Product', '276.png', null, null, 3),
(277, N'Váy nữ Mizuno 01',5, 160000, 7, N'Mizuno Product', '277.png', null, null, 4),
(278, N'Váy nữ Mizuno 02',5, 100000, 1, N'Mizuno Product', '278.png', null, null, 4),
(279, N'Váy nữ Apacs 01',5, 110000, 2, N'Apacs Product', '279.png',  null, null, 5),
(280, N'Váy nữ Apacs 02',5, 150000, 4, N'Apacs Product', '280.png', null, null, 5),
--Áo nam
(301, N'Áo nam Yonex 01',6, 200000, 3, N'Yonex Product', '301.png',  null, null, 1),
(302, N'Áo nam Yonex 02', 6, 200000, 4, N'Yonex Product', '302.png',  null, null, 1),
(303, N'Áo nam Lining 01', 6, 200000, 2, N'Lining Product', '303.png',  null, null, 2),
(304, N'Áo nam Kining 02', 6, 200000, 1, N'Lining Product', '304.png', null, null, 2),
(305, N'Áo nam Victor 01',6, 200000, 11, N'Victor Product', '305.png', null, null, 3),
(306, N'Áo nam Victor 02',6, 200000, 9, N'Victor Product', '306.png', null, null, 3),
(307, N'Áo nam Mizuno 01',6, 200000, 7, N'Mizuno Product', '307.png', null, null, 4),
(308, N'Áo nam Mizuno 02',6, 200000, 3, N'Mizuno Product', '308.png', null, null, 4),
(309, N'Áo nam Apacs 01',6, 200000, 4, N'Apacs Product', '309.png', null, null, 5),
(310, N'Áo nam Apacs 02',6, 200000, 5, N'Apacs Product', '310.png', null, null, 5),
--Áo nữ
(351, N'Áo nữ Yonex 01',7, 200000, 3, N'Yonex Product', '351.png', null, null, 1),
(352, N'Áo nữ Yonex 02',7, 200000, 4, N'Yonex Product', '352.png', null, null, 1),
(353, N'Áo nữ Lining 01',7, 200000, 2, N'Lining Product', '353.png', null, null, 2),
(354, N'Áo nữ Lining 02',7, 200000, 1, N'Lining Product', '354.png', null, null, 2),
(355, N'Áo nữ Victor 01',7, 200000, 11, N'Victor Product', '355.png', null, null, 3),
(356, N'Áo nữ Victor 02',7, 200000, 9, N'Victor Product', '356.png', null, null, 3),
(357, N'Áo nữ Mizuno 01',7, 200000, 7, N'Mizuno Product', '357.png', null, null, 4),
(358, N'Áo nữ Mizuno 02',7, 200000, 3, N'Mizuno Product', '358.png', null, null, 4),
(359, N'Áo nữ Apacs 01',7, 200000, 4, N'Apacs Product', '359.png', null, null, 5),
(350, N'Áo nữ Apacs 02',7, 200000, 5, N'Apacs Product', '360.png', null, null, 5),
--Balo
(401, N'Balo Yonex 1',8,500000, 3, N'Yonex Product', '401.png', null, null, 1),
(402, N'Balo Yonex 1',8,600000, 4, N'Yonex Product', '402.png', null, null, 1),
(403, N'Balo Lining 1',8,400000, 8, N'Lining Product', '403.png', null, null, 2),
(404, N'Balo Lining 1',8,300000, 9, N'Lining Product', '404.png', null, null, 2),
(405, N'Balo Victor 1',8,350000, 1, N'Victor Product', '405.png', null, null, 3),
(406, N'Balo Victor 1',8,450000, 6, N'Victor Product', '406.png', null, null, 3),
(407, N'Balo Mizuno 1',8,670000, 4, N'Mizuno Product', '407.png', null, null, 4),
(408, N'Balo Mizuno 1',8,250000, 3, N'Mizuno Product', '408.png', null, null, 4),
(409, N'Balo Apacs 1',8,500000, 2, N'Apacs Product', '409.png', null, null, 5),
(410, N'Balo Apacs 1',8,800000, 1, N'Apacs Product', '410.png', null, null, 5),
--Túi
(421, N'Túi Yonex 1',9, 500000, 3, N'Yonex Product', '421.png', null, null, 1),
(422, N'Túi Yonex 2',9,550000,5, N'Yonex Product', '422.png', null, null, 1),
(423, N'Túi Lining 1',9,600000,3, N'Lining Product', '423.png', null, null, 2),
(424, N'Túi Lining 2',9,400000,1, N'Lining Product', '424.png', null, null, 2),
(425, N'Túi Victor 1',9,300000,2, N'Victor Product', '425.png', null, null, 3),
(426, N'Túi Victor 2',9,700000, 7, N'Victor Product', '426.png', null, null, 3),
(427, N'Túi Mizuno 1',9,1000000,10, N'Mizuno Product', '427.png', null, null, 4),
(428, N'Túi Mizuno 2',9,550000,3, N'Mizuno Product', '428.png', null, null, 4),
(429, N'Túi Apacs 1',9,500000,7, N'Apacs Product', '429.png', null, null, 5),
(430, N'Túi Apacs 2',9,490000,5, N'Apacs Product', '430.png', null, null, 5),
--Vớ dài
(451, N'Vớ dài Yonex 1',10, 50000, 3, N'Yonex Product', '451.png', null, null, 1),
(452, N'Vớ dài Lining 1',10, 60000, 3, N'Lining Product', '452.png', null, null, 2),
(453, N'Vớ dài Victor 1',10, 30000, 2, N'Victor Product', '453.png', null, null, 3),
(454, N'Vớ dài Mizuno 1',10, 90000, 10, N'Mizuno Product', '454.png', null, null, 4),
(455, N'Vớ dài Apacs 1',10, 50000, 7, N'Apacs Product', '455.png', null, null, 5),
--Vớ ngắn
(461, N'Vớ ngắn Yonex 2',11, 55000, 5, N'Yonex Product', '461.png', null, null, 1),
(462, N'Vớ ngắn Lining 2',11, 45000, 1, N'Lining Product', '462.png', null, null, 2),
(463, N'Vớ ngắn Victor 2',11, 35000, 7, N'Victor Product', '463.png', null, null, 3),
(464, N'Vớ ngắn Mizuno 2',11, 75000, 3, N'Mizuno Product', '464.png', null, null, 4),
(465, N'Vớ ngắn Apacs 2', 11, 85000, 5, N'Apacs Product', '465.png', null, null, 5),
--Phụ kiện
(471, N'Kéo', 12, 10000, 23, N'Kéo hỗ trợ cắt lưới', '471.png', null, null, 1),
(472, N'Lưới cầu lông Yonex', 12, 120000, 100, N'Yonex Product', '472.png', null, null, 1),
(473, N'Lưới cầu lông Lining', 12, 100000, 100, N'Lining Product','473.png', null, null, 2),
(474, N'Lưới cầu lông Victor', 12, 150000, 100, N'Victor Product','474.png', null, null, 3),
(475, N'Lưới cầu lông Mizuno', 12, 160000, 100, N'Mizuno Product', '475.png', null, null, 4),
(476, N'Lưới cầu lông Apacs', 12, 190000, 100, N'Apacs Product', '476.png', null, null, 5),
(477, N'Quấn cán', 12, 15000, 13, N'Giúp bám dính', '477.png', null, null, 5),
(478, N'Chai khử mùi giày', 12, 20000, 23, N'Khử mùi giày sau khi đánh', '478.png', null, null, 2)

INSERT INTO NHANVIEN( MANV, HOTEN, CHUCVU, SDT)
VALUES
(1, N'Nguyễn Văn Boss', 'Boss', '1122334455'),
(2, N'Phạm Hoàng Bảo', 'Employee', '112231344')

INSERT INTO KHACHHANG( MAKH, HOTEN, SDT)
VALUES
(1, N'Nguyễn Thị B', '0000000'),
(2, N'Phạm Văn D', '0011100'),
(3, N'Nguyễn Bành K', '2200000')




















