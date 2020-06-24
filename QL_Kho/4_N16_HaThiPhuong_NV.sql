use N16_QLNguyenLieuNhaHang_T6
go


--dữ liệu danh mục
insert into NhaCungCap(TenNCC, DiaChi, SDT) values
	(N'Chợ AA', N'TP HCM', '123123123'),
	(N'Chợ BB', N'Sài Gòn', '456456789'),
	(N'Chợ CC', N'Số 7 Thiền Quang', '9876543'),
	(N'Nhà hàng ZZ', N'Số 8 Lê Duẩn', '212345267'),
	(N'Nhà hàng XX', N'Số 9 Bùi Viện', '3748674937')
go

insert into NhanVien(HoTen, NgaySinh, DiaChi, SDT) values
	(N'Nguyễn Huy Thành', '1/1/1991', N'Hà Nội', '123'), --mm/dd/yyyy
	(N'Hoàng Minh Đại', '2/2/1992', N'Hà Nội', '123'),
	(N'Kim Minh', '3/3/1993', N'Hà Nội', '123'),
	(N'Minh gầy', '4/4/1994', N'Hà Nội', '123'),
	(N'Minh nhỡ', '2/15/1995', N'Hà Nội', '123')
go

insert into NguyenLieu(TenNL, LoaiTuoiKho, GiaTien, SoLuong, TenDonVi) values
	(N'Mật ong hoa', 1, 40000, 8, 'lạng'),
	(N'Mật ong rừng', 1, 50000, 9, 'lạng'),
	(N'Dầu dứa', 1, 60000, 10, 'lạng'),
	(N'Dấm', 1, 70000, 11, 'lạng'),
	(N'Tương cà chua', 1, 80000, 12, 'lạng')
go

--Tạo biên bản thanh lý
insert into BienBanThanhLy(MaNV) values
	(6), (8), (9)
go

--Tạo các chi tiết tương ứng
insert into ChiTietBBTL(MaBB, MaNL, Gia, SoLuong) values
	(1, 11, 10000, 1),
	(1, 13, 20000, 2),
	(1, 15, 30000, 2),

	(2, 12, 40000, 2),
	(2, 13, 50000, 2),
	(2, 14, 55000, 3),

	(3, 11, 22000, 1),
	(3, 15, 23000, 1),
	(3, 12, 24000, 1)
go

--Sau khi thanh lý thì sửa lại số lượng ở các khối tương ứng

--cho biên bản thứ nhất
update NguyenLieu
set SoLuong -= 1 where MaNL = 11
update NguyenLieu
set SoLuong -= 2 where MaNL = 13
update NguyenLieu
set SoLuong -= 3 where MaNL = 15

--cho biên bản thứ hai
update NguyenLieu
set SoLuong -= 2 where MaNL = 12
update NguyenLieu
set SoLuong -= 1 where MaNL = 13
update NguyenLieu
set SoLuong -= 3 where MaNL = 14

--cho biên bản thứ ba
update NguyenLieu
set SoLuong -= 1 where MaNL = 11
update NguyenLieu
set SoLuong -= 1 where MaNL = 15
update NguyenLieu
set SoLuong -= 1 where MaNL = 12