--dữ liệu danh mục
use N16_QLNguyenLieuNhaHang_T6
go

INSERT INTO dbo.NhaCungCap
		(TenNCC, DiaChi, SDT)
VALUES	(N'Chợ Đồng Xa', 'Hà Tĩnh', '123'),--mm/dd/yyyy
		(N'Siêu thị A.', 'Hương Khê', '456'),
		(N'Siêu thị B.', 'Nam Định', '789'),
		(N'Siêu thị C.', 'Tiên Lãng', '999'),
		(N'Chợ X.', 'Hà Nội', '777')
GO

insert into NhanVien(HoTen, NgaySinh, DiaChi, SDT) values
	(N'Phan Huy Tiến', '1/1/1991', N'Hà Nội', '123'), --mm/dd/yyyy
	(N'Phan Văn Nhật', '2/2/1992', N'Hà Nội', '123'),
	(N'Đỗ Kim Phương', '3/3/1993', N'Hà Nội', '123'),
	(N'Lê Ngọc Trâm', '4/4/1994', N'Hà Nội', '123'),
	(N'Phạm Văn Thoại', '2/15/1995', N'Hà Nội', '123')
go

insert into NguyenLieu(TenNL, LoaiTuoiKho, GiaTien, TenDonVi) values
	(N'Gan trời', 1, 10000, 'm3'),
	(N'Thịt ngỗng', 1, 20000, 'hộp 10m3'),
	(N'Mỡ muỗi', 1, 30000, 'thùng 1m3'),
	(N'Gan ngỗng', 1, 15000, 'khối 3m3'),
	(N'Cá basa', 1, 20000, '8 lạng')
go

--tạo 3 phiếu đặt nguyên liệu
INSERT INTO PhieuDatNL
        ( MaNCC, MaNV )
VALUES  ( 1, 3 ),
		( 2, 4 ),
		( 3, 5 )
GO

--với mỗi phiếu đặt có 3 chi tiết tương ứng
--mã nguyên liệu từ 5 đến 10 là nguyên liệu tươi
INSERT INTO ChiTietPDNL
        ( MaPDNL, MaNL, SoLuong )
VALUES  ( 1, 6, 2 ),
		( 1, 7, 3 ),
		( 1, 8, 4 ),

		( 2, 9, 5 ),
		( 2, 6, 6 ),
		( 2, 7, 6 ),

		( 3, 8, 5 ),
		( 3, 9, 6 ),
		( 3, 10, 6 )
GO

--tạo 3 hóa đơn nhập liệu tương ứng với 3 phiếu đặt
INSERT INTO HoaDonNhapNL
        ( MaPDNL, MaNV )
VALUES  ( 1, 7 ),
		( 2, 8 ),
		( 3, 9 )
GO

--với mỗi hóa đơn nhập có 3 chi tiết tương ứng
INSERT INTO dbo.ChiTietHDN
        ( MaHD, MaNL, SoLuong )
VALUES  ( 1, 6, 2 ),
		( 1, 7, 3 ),
		( 1, 8, 4 ),

		( 2, 9, 5 ),
		( 2, 6, 5 ),
		( 2, 7, 5 ),

		( 3, 8, 5 ),
		( 3, 9, 6 ),
		( 3, 10, 6 )
GO

--sau khi nhập xong thì có các câu lệnh update tương ứng
--hóa đơn nhập thứ nhất
update NguyenLieu
set SoLuong += 2 where MaNL = 6
update NguyenLieu
set SoLuong += 3 where MaNL = 7
update NguyenLieu
set SoLuong += 4 where MaNL = 8

--hóa đơn nhập thứ hai
update NguyenLieu
set SoLuong += 5 where MaNL = 9
update NguyenLieu
set SoLuong += 5 where MaNL = 6
update NguyenLieu
set SoLuong += 5 where MaNL = 7

--hóa đơn nhập thứ ba
update NguyenLieu
set SoLuong += 5 where MaNL = 8
update NguyenLieu
set SoLuong += 6 where MaNL = 9
update NguyenLieu
set SoLuong += 6 where MaNL = 10