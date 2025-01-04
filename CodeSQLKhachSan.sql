go
create database QuanLyKhachSan

go
use QuanLyKhachSan

go
Create Table KhachHang( 
MAKH INT PRIMARY KEY, 
TenKH nvarchar(200) NOT NULL,
SDT char(10) not null check (len(SDT)=10), 
CCCD char (12) not null
);

go
Create Table HoaDon( 
MaHD INT PRIMARY KEY, 
MAKH INT, FOREIGN KEY (MaKH) REFERENCES KhachHang (MaKH), 
NgayTT CHAR(100) NOT NULL, 
ThanhTien char(190) NOT NULL check(len(ThanhTien)!=0), 
TenHD nvarchar(100) NOT NULL, 
NgayTao char(100) NOT NULL
);

go
Create Table NhanVien(  
MANV INT PRIMARY KEY, 
MAHD INT, FOREIGN KEY (MaHD) REFERENCES HoaDon (MaHD), 
HoTenNV nvarchar(200) NOT NULL,
DiaChi nvarchar (200) NOT NULL, 
SDTNV CHAR(10) NOT NULL check (len (SDTNV)=10), 
ChucVu nvarchar(100) NOT NULL
);

go
Create Table Phong ( 
MaPhong INT PRIMARY KEY, 
MANV INT, 
FOREIGN KEY (MaNV) REFERENCES NhanVien (MaNV), 
TenPhong nvarchar(100) NOT NULL, 
LoaiPhong nvarchar(100) NOT NULL, Gia char (100) NOT NULL, 
TinhTrangPhong nvarchar(190) NOT NULL 
);

go
Create Table Thue( 
MAKH INT, 
MaPhong INT, 
Primary Key (MaKH, MaPhong), 
FOREIGN KEY (MaKH) REFERENCES KhachHang (MaKH), 
FOREIGN KEY (MaPhong) REFERENCES Phong (MaPhong), 
NgayDI char (200) NOT NULL, 
NgayVe char (200) NOT NULL
); 


INSERT INTO KhachHang(MAKH, TenKH, SDT, CCCD) VALUES 
		(1, 'Nguyen Van A', '0123456789', '123456789012'),
       (2, 'Le Thi B', '0987654321', '210987654321'),
       (3, 'Tran Van C', '0123434567', '234567890123'),
       (4, 'Pham Thi D', '0987654320', '321098765432'),
       (5, 'Hoang Van E', '0123456788', '432109876543');

INSERT INTO HoaDon(MaHD, MAKH, NgayTT, ThanhTien, TenHD, NgayTao)
VALUES (1, 1, '2024-04-26', '1000000', 'HoaDon1', '2024-04-26'),
       (2, 2, '2024-04-27', '2000000', 'HoaDon2', '2024-04-27'),
       (3, 3, '2024-04-28', '1500000', 'HoaDon3', '2024-04-28'),
       (4, 4, '2024-04-29', '1200000', 'HoaDon4', '2024-04-29'),
       (5, 5, '2024-04-30', '1800000', 'HoaDon5', '2024-04-30');

INSERT INTO NhanVien(MANV, MaHD, HoTenNV, DiaChi, SDTNV, ChucVu)
VALUES (1, 1, 'Nguyen Van A', 'Address 1', '0123456789', 'Manager'),
       (2, 2, 'Le Thi B', 'Address 2', '0987654321', 'Staff'),
       (3, 3, 'Tran Van C', 'Address 3', '0123434567', 'Staff'),
       (4, 4, 'Pham Thi D', 'Address 4', '0987654320', 'Staff'),
       (5, 5, 'Hoang Van E', 'Address 5', '0123456788', 'Manager');

INSERT INTO KhachHang(MAKH, TenKH, SDT, CCCD)
VALUES (1, 'Nguyen Van A', '0123456789', '123456789012'),
       (2, 'Le Thi B', '0987654321', '210987654321'),
       (3, 'Tran Van C', '0123434567', '234567890123'),
       (4, 'Pham Thi D', '0987654320', '321098765432'),
       (5, 'Hoang Van E', '0123456788', '432109876543');

INSERT INTO HoaDon(MaHD, MAKH, NgayTT, ThanhTien, TenHD, NgayTao)
VALUES (1, 1, '2024-04-26', '1000000', 'HoaDon1', '2024-04-26'),
       (2, 2, '2024-04-27', '2000000', 'HoaDon2', '2024-04-27'),
       (3, 3, '2024-04-28', '1500000', 'HoaDon3', '2024-04-28'),
       (4, 4, '2024-04-29', '1200000', 'HoaDon4', '2024-04-29'),
       (5, 5, '2024-04-30', '1800000', 'HoaDon5', '2024-04-30');

INSERT INTO NhanVien(MANV, MaHD, HoTenNV, DiaChi, SDTNV, ChucVu)
VALUES (1, 1, 'Nguyen Van A', 'Address 1', '0123456789', 'Manager'),
       (2, 2, 'Le Thi B', 'Address 2', '0987654321', 'Staff'),
       (3, 3, 'Tran Van C', 'Address 3', '0123434567', 'Staff'),
       (4, 4, 'Pham Thi D', 'Address 4', '0987654320', 'Staff'),
       (5, 5, 'Hoang Van E', 'Address 5', '0123456788', 'Manager');
