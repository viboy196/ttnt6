use N16_QLNguyenLieuNhaHang_T6
go


--dữ liệu danh mục
insert into NhaCungCap(TenNCC, DiaChi, SDT) values
	(N'TVP Food', N'TP HCM', '123123123'),
	(N'Công ty Cổ phần Tôn Phan', N'Sài Gòn', '456456789'),
	(N'Thực phẩm Đại Thuận', N'Số 10 Thiền Quang', '9876543'),
	(N'San Hà Food', N'Số 11 Lê Duẩn', '212345267'),
	(N'G.C Food', N'Số 12 Bùi Viện', '3748674937')
go

insert into NhanVien(HoTen, NgaySinh, DiaChi, SDT) values
	(N'Nguyễn Minh Đức', '1/1/1991', N'Hà Nội', '123'), --mm/dd/yyyy
	(N'Mai Quốc Khánh', '2/2/1992', N'Hà Nội', '123'),
	(N'Lê Thị Diễm', '3/3/1993', N'Hà Nội', '123'),
	(N'Hoàng Thị Thảo', '4/4/1994', N'Hà Nội', '123'),
	(N'Mai Văn Trường', '2/15/1995', N'Hà Nội', '123')
go

insert into NguyenLieu(TenNL, LoaiTuoiKho, GiaTien, TenDonVi) values
	(N'Bột ca cao', 0, 10000, N'cân'),
	(N'Bột hạnh nhân', 0, 20000, N'cân'),
	(N'Bột kem sữa', 0, 30000, N'cân'),
	(N'Bột mỳ', 0, 40000, N'cân'),
	(N'Bột trà xanh', 0, 50000, N'cân')
go

--tạo 3 phiếu đặt nguyên liệu
INSERT INTO dbo.PhieuDatNL
        ( MaNCC, MaNV )
VALUES  ( 1, 3 ),
		( 2, 4 ),
		( 3, 5 )
GO

--với mỗi phiếu đặt có 3 chi tiết tương ứng
--mã nguyên liệu từ 16 đến 20 là nguyên liệu khô
INSERT INTO dbo.ChiTietPDNL
        ( MaPDNL, MaNL, SoLuong )
VALUES  ( 4, 16, 2 ),
		( 4, 17, 3 ),
		( 4, 18, 4 ),

		( 5, 19, 5 ),
		( 5, 16, 6 ),
		( 5, 17, 7 ),

		( 6, 18, 6 ),
		( 6, 19, 5 ),
		( 6, 20, 4 )
GO

--tạo 3 hóa đơn nhập liệu tương ứng với 3 phiếu đặt
INSERT INTO dbo.HoaDonNhapNL
        ( MaPDNL, MaNV)
VALUES  ( 4, 10 ),
		( 5, 11 ),
		( 6, 12 )
GO

--với mỗi hóa đơn nhập có 3 chi tiết tương ứng
INSERT INTO dbo.ChiTietHDN
        ( MaHD, MaNL, SoLuong )
VALUES  ( 4, 16, 2 ),
		( 4, 17, 3 ),
		( 4, 18, 4 ),

		( 5, 19, 5 ),
		( 5, 16, 6 ),
		( 5, 17, 7 ),

		( 6, 18, 6 ),
		( 6, 19, 5 ),
		( 6, 20, 4 )
GO


--sau khi nhập xong thì có các câu lệnh update tương ứng
--hóa đơn nhập thứ nhất
update NguyenLieu
set SoLuong += 2 where MaNL = 16
update NguyenLieu
set SoLuong += 3 where MaNL = 17
update NguyenLieu
set SoLuong += 4 where MaNL = 18

--hóa đơn nhập thứ hai
update NguyenLieu
set SoLuong += 5 where MaNL = 19
update NguyenLieu
set SoLuong += 6 where MaNL = 16
update NguyenLieu
set SoLuong += 7 where MaNL = 17

--hóa đơn nhập thứ ba
update NguyenLieu
set SoLuong += 6 where MaNL = 18
update NguyenLieu
set SoLuong += 5 where MaNL = 19
update NguyenLieu
set SoLuong += 4 where MaNL = 20