use N16_QLNguyenLieuNhaHang_T6
go

--dữ liệu danh mục
insert into NhaCungCap(TenNCC, DiaChi, SDT) values
	(N'Chợ đầu mối', N'Hà Nội', '123'),
	(N'Siêu thị X.', N'Thăng Long', '456'),
	(N'Siêu thị Y.', N'Đông Đô', '789'),
	(N'Siêu thị Z.', N'Thanh Hóa', '888'),
	(N'Chợ A.', N'Nghệ An', '777')
go

insert into NhanVien(HoTen, NgaySinh, DiaChi, SDT) values
	(N'Nguyễn Văn A', '1/1/1991', N'Hà Nội', '123'), --mm/dd/yyyy
	(N'Ngã Vân Uyên', '2/2/1992', N'Hà Nội', '123'),
	(N'Nga Vân Uyển', '3/3/1993', N'Hà Nội', '123'),
	(N'Nguyễn Văn B', '4/4/1994', N'Hà Nội', '123'),
	(N'Nguyễn Văn D', '2/15/1995', N'Hà Nội', '123')
go

insert into NguyenLieu(TenNL, LoaiTuoiKho, GiaTien, SoLuong, TenDonVi) values
	(N'Thịt bò', 1, 10000, 3.5, 'cân'),
	(N'Thịt lợn', 1, 20000, 4, 'cân'),
	(N'Nước mắm', 0, 30000, 5, 'lít'),
	(N'Bột canh', 0, 15000, 6, 'cân'),
	(N'Mì chính', 1, 20000, 7, 'cân')
go

--tạo 3 phiếu thống kê
insert into PhieuThongKe(MaNV) values
	(1), (2), (3)
go

--với mỗi phiếu thống kê, đặt vào 3 chi tiết tương ứng
insert into ChiTietPTK(MaPTK, MaNL) values
	(1, 1),
	(1, 2),
	(1, 3),

	(2, 2),
	(2, 3),
	(2, 4),

	(3, 3),
	(3, 4),
	(3, 5)
go