create database QL_ShopBanQA
use QL_ShopBanQA

-- Tạo bảng `NHANVIEN`
CREATE TABLE NHANVIEN (
  MANV                 char(10)             not null,
  TENNV                nvarchar(100)        null,
  DIACHI               nvarchar(256)        null,
  SDT                  char(11)             null,
  GIOITINH             nvarchar(10)         null,
  MATKHAU              nvarchar(255)        null,
  VAITRO               nvarchar(50)         null,
  constraint PK_NHANVIEN primary key nonclustered (MANV)
);

-- Tạo bảng `LOAIHANG`
CREATE TABLE LOAIHANG (
  MALOAI               char(10)             not null,
  MANV                 char(10)             not null,
  TENLOAI              nvarchar(100)        null,
  constraint PK_LOAIHANG primary key nonclustered (MALOAI),
  Constraint fk_LOAIHANG_NV4 Foreign Key(MANV) references NHANVIEN(MANV)
);

-- Tạo bảng `MATHANG`
CREATE TABLE MATHANG (
  MAMH                 char(10)             not null,
  MALOAI               char(10)             not null,
  TENMH                nvarchar(100)        null,
  DVT                  nvarchar(20)         null,
  DONGIA               float                null,
  SOLUONGTON          int                  null,
  constraint PK_MATHANG primary key nonclustered (MAMH),
  Constraint fk_MATHANG_LH Foreign Key(MALOAI) references LOAIHANG (MALOAI)
);

-- Tạo bảng `NCC`
CREATE TABLE NCC (
  MANCC                char(10)             not null,
  TENNCC               nvarchar(100)        null,
  DIACHI               nvarchar(256)        null,
  SDT                  char(11)             null,
  constraint PK_NCC primary key nonclustered (MANCC),
);

-- Tạo bảng `KHACHHANG`
CREATE TABLE KHACHHANG (
  MAKH                 char(10)             not null,
  TENKH                nvarchar(100)        null,
  DIACHI               nvarchar(256)        null,
  SDT                  char(11)             null,
  constraint PK_KHACHHANG primary key nonclustered (MAKH)
);

-- Tạo bảng `HOADON`
CREATE TABLE HOADON (
  MAHD                 char(10)             not null,
  MANV                 char(10)             not null,
  MAKH                 char(10)             not null,
  NGAYLAP              datetime             null,
  PHUONGTHUCTT         nvarchar(50)         null,
  constraint PK_HOADON primary key nonclustered (MAHD),
  Constraint fk_DONDATHANG_KH1 Foreign Key(MAKH) references KHACHHANG(MAKH),
  Constraint fk_DONDATHANG_NV0 Foreign Key(MANV) references NHANVIEN(MANV)
);

-- Tạo bảng `DONDATHANG`
CREATE TABLE DONDATHANG (
  MADH                 char(10)             not null,
  MANCC                char(10)             not null,
  MANV                 char(10)             not null,
  NGAYLAP              datetime             null,
  constraint PK_DONDATHANG primary key nonclustered (MADH),
  Constraint fk_DONDATHANG_NCC Foreign Key(MANCC) references NCC(MANCC),
  Constraint fk_DONDATHANG_NV Foreign Key(MANV) references NHANVIEN(MANV)
);

-- Tạo bảng `CT_DH`
CREATE TABLE CT_DH (
  MAMH                 char(10)             not null,
  MADH                 char(10)             not null,
  SOLUONG              int                  null,
  constraint PK_CT_DH primary key nonclustered (MAMH, MADH),
  Constraint fk_DONDATHANG_KH2 Foreign Key(MAMH) references MATHANG(MAMH),
  Constraint fk_DONDATHANG_NV1 Foreign Key(MADH) references DONDATHANG(MADH)
);

-- Tạo bảng `CT_HD`
CREATE TABLE CT_HD (
  MAMH                 char(10)             not null,
  MAHD                 char(10)             not null,
  SOLUONG              int                  null,
  constraint PK_CT_HD primary key nonclustered (MAMH, MAHD),
  Constraint fk_DONDATHANG_KH3 Foreign Key(MAMH) references MATHANG(MAMH),
  Constraint fk_DONDATHANG_NV2 Foreign Key(MAHD) references HOADON(MAHD)
);

-- Tạo bảng `CT_MH`
CREATE TABLE CT_MH (
  MAMH                 char(10)             not null,
  MANCC                char(10)             not null,
  SOLUONG              int                  null,
  constraint PK_CT_MH primary key nonclustered (MAMH, MANCC),
  Constraint fk_MATHANG_NCC Foreign Key(MAMH) references MATHANG(MAMH),
  Constraint fk_NCC_MH Foreign Key(MANCC) references NCC(MANCC)
);

INSERT INTO NHANVIEN (MANV, TENNV, DIACHI, SDT, GIOITINH, MATKHAU, VAITRO)
VALUES ('NV001', N'Nguyễn Văn A', N'123 Nguyễn Văn Linh, Quận 7, TP.HCM', '09012345678', N'Nam', '123456', N'Quản lý'),
       ('NV002', N'Trần Thị B', N'456 Lê Duẩn, Quận 1, TP.HCM', '09876543210', N'Nữ', '789012', N'Nhân viên bán hàng'),
       ('NV003', N'Lê Văn C', N'789 Điện Biên Phủ, Quận Bình Thạnh, TP.HCM', '01234567890', N'Nam', '345678', N'Nhân viên giao hàng'),
       ('NV004', N'Đỗ Thị D', N'101 Hoàng Văn Thụ, Quận Phú Nhuận, TP.HCM', '09112233445', N'Nữ', '901234', N'Nhân viên bán hàng'),
       ('NV005', N'Huỳnh Văn E', N'234 Nguyễn Đình Chiểu, Quận 3, TP.HCM', '09612345678', N'Nam', '567890', N'Nhân viên bán hàng'),
       ('NV006', N'Trần Thị F', N'456 Lê Văn Sỹ, Quận Tân Bình, TP.HCM', '09912345679', N'Nữ', '1234567890', N'Nhân viên chăm sóc khách hàng'),
       ('NV007', N'Nguyễn Văn G', N'789 Nguyễn Trãi, Quận 5, TP.HCM', '09012345678', N'Nam', '9876543210', N'Nhân viên kỹ thuật'),
       ('NV008', N'Trần Thị H', N'101 Hai Bà Trưng, Quận 10, TP.HCM', '09112233445', N'Nữ', '34567890', N'Nhân viên bảo vệ');

INSERT INTO LOAIHANG (MALOAI, MANV, TENLOAI)
VALUES ('L001', 'NV001', N'Áo Khoác'),
       ('L002', 'NV002', N'Áo thun'),
       ('L003', 'NV003', N'Quần Jean'),
       ('L004', 'NV004', N'Quần Tây'),
       ('L005', 'NV005', N'Quần Thể Thao'),
       ('L006', 'NV006', N'Áo sơ mi'),
       ('L007', 'NV007', N'Áo Jean'),
       ('L008', 'NV008', N'Áo hoodie');

INSERT INTO MATHANG (MAMH, MALOAI, TENMH, DVT, DONGIA, SOLUONGTON)
VALUES ('MH001', 'L004', N'Áo sơ mi nam', N'Cái', 200000, 100),
       ('MH002', 'L004', N'Áo sơ mi nữ', N'Cái', 150000, 200),
       ('MH003', 'L004', N'Quần jean nam', N'Cái', 300000, 50),
       ('MH004', 'L004', N'Quần jean nữ', N'Cái', 250000, 100),
       ('MH005', 'L004', N'Áo thun nam', N'Cái', 100000, 150),
       ('MH006', 'L004', N'Áo thun nữ', N'Cái', 80000, 200),
       ('MH007', 'L004', N'Váy đầm', N'Cái', 500000, 100),
       ('MH008', 'L004', N'Quần áo trẻ em', N'Cái', 200000, 200);

INSERT INTO NCC (MANCC, TENNCC, DIACHI, SDT)
VALUES ('NCC001', N'Công ty TNHH Thương mại ABC', N'123 Nguyễn Văn Linh, Quận 7, TP.HCM', '09012345678'),
       ('NCC002', N'Công ty Cổ phần XYZ', N'456 Lê Duẩn, Quận 1, TP.HCM', '09876543210'),
       ('NCC003', N'Công ty TNHH MTV DEF', N'789 Điện Biên Phủ, Quận Bình Thạnh, TP.HCM', '01234567890'),
       ('NCC004', N'Công ty TNHH GH', N'101 Hoàng Văn Thụ, Quận Phú Nhuận, TP.HCM', '09112233445'),
       ('NCC005', N'Công ty Cổ phần JK', N'234 Nguyễn Đình Chiểu, Quận 3, TP.HCM', '09612345678'),
       ('NCC006', N'Công ty TNHH MTV LM', N'456 Lê Văn Sỹ, Quận Tân Bình, TP.HCM', '09912345679'),
       ('NCC007', N'Công ty TNHH ST', N'789 Nguyễn Trãi, Quận 5, TP.HCM', '09012345678'),
       ('NCC008', N'Công ty TNHH MTV UV', N'101 Hai Bà Trưng, Quận 10, TP.HCM', '09112233445');


INSERT INTO KHACHHANG (MAKH, TENKH, DIACHI, SDT)
VALUES ('KH001', N'Nguyễn Văn A', N'123 Đường ABC, Quận XYZ, TP.HCM', '0123456789'),
       ('KH002', N'Trần Thị B', N'456 Đường DEF, Quận GHI, TP.HCM', '0987654321'),
       ('KH003', N'Lê Văn C', N'789 Đường HIJ, Quận KLM, TP.HCM', '0123456789'),
       ('KH004', N'Phạm Thị D', N'321 Đường NOP, Quận QRS, TP.HCM', '0987654321'),
       ('KH005', N'Trần Văn E', N'654 Đường TUV, Quận WXY, TP.HCM', '0123456789'),
       ('KH006', N'Nguyễn Thị F', N'987 Đường ZAB, Quận CDE, TP.HCM', '0987654321'),
       ('KH007', N'Lê Văn G', N'789 Đường FGH, Quận IJK, TP.HCM', '0123456789'),
       ('KH008', N'Phạm Thị H', N'654 Đường LMN, Quận OPQ, TP.HCM', '0987654321');

INSERT INTO HOADON (MAHD, MANV, MAKH, NGAYLAP, PHUONGTHUCTT)
VALUES ('HD001', 'NV001', 'KH001', '2023-10-01 10:30:00', N'Tiền mặt'),
       ('HD002', 'NV002', 'KH002', '2023-10-02 14:45:00', N'Chuyển khoản'),
       ('HD003', 'NV003', 'KH003', '2023-10-03 09:15:00', N'Tiền mặt'),
       ('HD004', 'NV001', 'KH004', '2023-10-04 17:30:00', N'Chuyển khoản'),
       ('HD005', 'NV002', 'KH005', '2023-10-05 11:00:00', N'Tiền mặt'),
       ('HD006', 'NV003', 'KH006', '2023-10-06 13:45:00', N'Chuyển khoản'),
       ('HD007', 'NV001', 'KH007', '2023-10-07 16:20:00', N'Tiền mặt'),
       ('HD008', 'NV002', 'KH008', '2023-10-08 10:10:00', N'Chuyển khoản');

INSERT INTO DONDATHANG (MADH, MANCC, MANV, NGAYLAP)
VALUES ('DH001', 'NCC001', 'NV001', '2023-10-01 10:30:00'),
       ('DH002', 'NCC002', 'NV002', '2023-10-02 14:45:00'),
       ('DH003', 'NCC003', 'NV003', '2023-10-03 09:15:00'),
       ('DH004', 'NCC001', 'NV001', '2023-10-04 17:30:00'),
       ('DH005', 'NCC002', 'NV002', '2023-10-05 11:00:00'),
       ('DH006', 'NCC003', 'NV003', '2023-10-06 13:45:00'),
       ('DH007', 'NCC001', 'NV001', '2023-10-07 16:20:00'),
       ('DH008', 'NCC002', 'NV002', '2023-10-08 10:10:00');

INSERT INTO CT_DH (MAMH, MADH, SOLUONG)
VALUES ('MH001', 'DH001', 5),
       ('MH002', 'DH001', 3),
       ('MH003', 'DH002', 2),
       ('MH004', 'DH002', 4),
       ('MH001', 'DH003', 6),
       ('MH002', 'DH003', 2),
       ('MH003', 'DH004', 3),
       ('MH004', 'DH004', 5);

INSERT INTO CT_HD (MAMH, MAHD, SOLUONG)
VALUES ('MH001', 'HD001', 5),
       ('MH002', 'HD001', 3),
       ('MH003', 'HD002', 2),
       ('MH004', 'HD002', 4),
       ('MH001', 'HD003', 6),
       ('MH002', 'HD003', 2),
       ('MH003', 'HD004', 3),
       ('MH004', 'HD004', 5);

INSERT INTO CT_MH (MAMH, MANCC, SOLUONG)
VALUES ('MH001', 'NCC001', 5),
       ('MH001', 'NCC002', 3),
       ('MH002', 'NCC001', 2),
       ('MH002', 'NCC002', 4),
       ('MH003', 'NCC001', 1),
       ('MH003', 'NCC002', 6),
       ('MH004', 'NCC001', 7),
       ('MH004', 'NCC002', 2);

select * from NHANVIEN
select * from CT_DH
select * from CT_MH
select * from DONDATHANG
select * from KHACHHANG
select * from LOAIHANG
select * from MATHANG
select * from CT_HD
select * from HOADON
select * from NCC

--SELECT
--  m.TENMH,
--  ct.SOLUONG,
--  hd.NGAYLAP,
--  m.DONGIA,
--  ct.SOLUONG * m.DONGIA AS 'Doanh Thu'
--FROM CT_HD ct
--JOIN MATHANG m
--  ON ct.MAMH = m.MAMH
--JOIN HOADON hd
--  ON ct.MAHD = hd.MAHD;

SELECT
  CONVERT(VARCHAR(10), hd.NGAYLAP, 101) AS NGAYLAP,
  SUM(ct.SOLUONG) AS TONGSOLUONG,
  SUM(ct.SOLUONG * m.DONGIA) AS TONGDOANHTHU
FROM CT_HD ct
JOIN MATHANG m
  ON ct.MAMH = m.MAMH
JOIN HOADON hd
  ON ct.MAHD = hd.MAHD
WHERE hd.NGAYLAP BETWEEN '2023-10-03' AND '2023-10-05'
GROUP BY CONVERT(VARCHAR(10), hd.NGAYLAP, 101)
ORDER BY NGAYLAP;
