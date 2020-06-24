

CREATE DATABASE QLTV_LOAN
GO
USE QLTV_LOAN
GO

CREATE TABLE TaiKhoan(
MaTK int IDENTITY(1,1)  primary key,
Usename  Nvarchar(50),
Password nvarchar(50))

CREATE TABLE DocGia(
MaDocGia Nchar(10) primary key,
TenDocGia nvarchar(50),
NgaySinh date,
GioiTinh nchar(10),
DiaChi nvarchar(100),
SDT NCHAR(20))

CREATE TABLE NhanVien(
MaNV nchar(10) primary key,
TenNV nvarchar(50),
NgaySinh date,
GioiTinh nchar(10),
DiaChi nvarchar(100),
SDT NCHAR(10),
Luong char(30))

create table TacGia(
MaTG nchar(10) primary key,
TenTG nvarchar(50),
DiaChiTG nvarchar(100))

create table TheLoai(
MaTheLoai nchar(10) primary key,
TenTheLoai nvarchar(50)
)

CREATE TABLE Sach(
MaSach nchar(10) primary key,
TenSach Nvarchar(100),
NXB nvarchar(50),
NamXB int,
GiaTien nchar(30),
SoTrang int,
TinhTrangSach nvarchar(50),
MaTheLoai nchar(10) references TheLoai(MaTheLoai),
MaTG nchar(10) references TacGia(MaTG),
SoLuong int)


create table NhuCau(
STT int IDENTITY(1,1) primary key,
SoPM int,
MaDocGia nchar(10) references DocGia(MaDocGia),
MaNV nchar(10) references NhanVien(MaNV),
MaSach nchar(10) references Sach(MaSach),
NgayMuon date,
NgayHanTra date,
SoLuongSachMuon int,
GhiChu Nvarchar(50))
 delete  from DocGia


insert into DocGia
values ('1',N'Vũ Hải Nam','1998-05-07',N'nam',N'Hà Nội','0987563214'),
('2',N'Đào Thị Minh Trang','1998-08-12',N'nữ',N'Hà Nội','0345761789'),
('3',N'Phạm Đức Cảnh','1998-12-02',N'nam',N'Ninh Bình','0987563198'),
('4',N'Phạm Thị Kim Oanh','1998-09-05',N'nữ',N'Thái Bình','0987563217'),
('5',N'Nguyễn Minh Phúc','1998-07-08',N'nam',N'Hà Nam','0987563814'),
('6',N'Bùi Đình Nam','1998-04-03',N'nam',N'Nam Định','0965563214'),
('7',N'Trần thị Thu Hương','1998-10-07',N'nữ',N'Hải Phòng','0987583714'),
('8',N'Vũ Tường Vy','1998-08-27',N'nữ',N'Hà Nội','0967363214')

insert into NhanVien
values('1',N'Hà Thanh Thúy ','1989-05-05',N'nữ',N'Hà Nội','0987621080','9.000.000'),
('2',N'Đào Thị Huệ','1990-05-07',N'nữ',N'Hải Dương','0375617951','10.000.000'),
('3',N'Mai Thị Mỹ Linh','1991-08-24',N'nữ',N'Hà Nội','0945963214','9.000.000'),
('4',N'Trần Thị Thu ','1992-10-08',N'nữ',N'Ninh Bình','0987830014','9.000.000'),
('5',N'Vũ Thị Hà','1990-09-27',N'nữ',N'Hà Nội','0932563214','9,000,000')

insert into TheLoai
values('1',N'Triết Học'),
('2',N'Sách chuyên ngành  CNTT'),
('3',N'Sách chuyên ngành Khoa Cơ Khí'),
('4',N'Khác'),
('5',N'Quân Sự')

insert into TacGia
values('1',N'Trần Hùng',N'Hà Nội'),
('2',N'Trần Trọng Long',N'Nghệ An'),
('3',N'Trần Văn Sơn',N'Hà Nội'),
('4',N'Vũ Quang Vinh',N'Hà Nội'),
('5',N'Bùi Đình Nam',N'Hà Nội'),
('6',N'Hoàng Công Sỹ',N'Hà Nội'),
('7',N'Trần Tiến Nam',N'Hà Nội'),
('8',N'Dương Đắc Trương',N'Hà Nội'),
('9',N'Vũ Hải Hậu',N'Hà Nội'),
('10',N'vũ Xuân Quảng',N'TP HCM'),
('11',N'Nguyễn Tiến Mạnh',N'TP Đà Nẵng'),
('12',N'Mai Tiến Dũng ',N'Hà Nội'),
('13',N'Nguyễn Minh Nghĩa',N'Hà Nội'),
('14',N'Phạm Văn Việt',N'Hà Nội'),
('15',N'Nguyễn Mạnh Trường',N'TP HCM')


insert into Sach
values('1',N'Phân Tích Và Thiết Kế Giải Thuật',N'HVKTQS','2008','90.000','120','','2','1','1000'),
('2',N'Tư Tưởng Hồ Chí Minh',N'Giáo Dục','2010','85.000','1','','1','2','1000'),
('3',N'Giải tích 1',N'HVKTQS','2008','120.000','150','','4','3','1000'),
('4',N'Hình Họa Và vẽ Kĩ Thuật',N'HVKTQS','2008','74.000','120','','4','4','1000'),
('5',N'Công Tác Quốc Phòng An Ninh',N'HVKTQS','2008','36.000','54','','5','5','1000'),
('6',N'Giải tích 2',N'Giáo Dục','2008','95.000','120','','4','6','1000'),
('7',N'vật lý 1',N'HVKTQS','2008','90,000','120','','4','7','1000'),
('8',N'Những Nguyên Lý Cơ Bản Của Chủ Ngiã Mac-Lennin',N'HVKTQS','2008','73.000','65','','1','8','1000'),
('9',N'Lý Thuyết Xác Suất Thống kê',N'HVKTQS','2005','80.000','120','','4','9','1000'),
('10',N'Vẽ Kĩ Thuật Cơ Khí Và BTL',N'HVKTQS','2008','45.000','60','','3','10','1000'),
('11',N'Lập Trình Cơ Bản',N'HVKTQS','2008','45.000','60','','2','11','1000'),
('12',N'Đường Lối Cách Mạng CUả Đảng Cộng Sản Việt Nam',N'HVKTQS','2008','45.000','56','','5','12','1000'),
('13',N'Mạng Máy Tính',N'HVKTQS','2008','55.000','60','','2','13','1000'),
('14',N'Cấu Trúc Máy Tính',N'HVKTQS','2001','46.500','45','','2','14','1000'),
('15',N'Toán Rời Rạc',N'HVKTQS','2008','75.000','110','','2','15','1000')

insert into NhuCau(SoPM,MaSach,MaDocGia,MaNV,NgayMuon,NgayHanTra,SoLuongSachMuon,GhiChu)
values ('1','1','1','1','2019-02-24','2019-06-01','1',''),
('1','2','1','1','2019-02-24','2019-06-01','1',''),
('1','3','1','1','2019-02-24','2019-06-01','1',''),
('1','4','1','1','2019-02-24','2019-06-01','1',''),
('2','1','3','1','2019-02-24','2019-06-01','1',''),
('2','5','3','1','2019-02-24','2019-06-01','1',''),
('2','11','3','1','2019-02-24','2019-06-01','1',''),
('3','1','7','4','2019-02-24','2019-06-01','1',''),
('3','8','7','4','2019-02-24','2019-06-01','1',''),
('3','5','7','4','2019-02-24','2019-06-01','1',''),
('4','11','2','4','2019-02-24','2019-06-01','1',''),
('4','3','2','4','2019-02-24','2019-06-01','1',''),
('4','7','2','4','2019-02-24','2019-06-01','1',''),
('4','5','2','4','2019-02-24','2019-06-01','1',''),
('5','12','6','5','2019-02-24','2019-06-01','1',''),
('5','6','6','5','2019-02-24','2019-06-01','1',''),
('5','10','6','5','2019-02-24','2019-06-01','1',''),
('6','11','7','2','2019-02-24','2019-06-01','1',''),
('6','12','7','2','2019-02-24','2019-06-01','1',''),
('6','15','7','2','2019-02-24','2019-06-01','1','')

insert into TaiKhoan(Usename,Password)
values( N'admin','123'),
(N'loan',N'1998')