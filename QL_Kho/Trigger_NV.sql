use N16_QLNguyenLieuNhaHang_T6
go

--select từ một bảng
select * from NguyenLieu

--select từ hai bảng
select * from NhanVien, BienBanThanhLy
where BienBanThanhLy.MaNV = NhanVien.MaNV

--select từ ba bảng
select * from BienBanThanhLy, ChiTietBBTL, NguyenLieu
where BienBanThanhLy.MaBB = ChiTietBBTL.MaBB
and ChiTietBBTL.MaNL = NguyenLieu.MaNL

--view thứ nhất: lấy ra tất cả các biên bản và chi tiết
drop view TatCaBBVaCT
go

create view TatCaBBVaCT as
select BienBanThanhLy.MaBB, NguyenLieu.TenNL, ChiTietBBTL.SoLuong from BienBanThanhLy, ChiTietBBTL, NguyenLieu
where BienBanThanhLy.MaBB = ChiTietBBTL.MaBB
and ChiTietBBTL.MaNL = NguyenLieu.MaNL
go

select * from TatCaBBVaCT

--view thứ hai: lấy ra tất cả nhân viên và biên bản thanh lý
drop view TatCaNVvaBBTL
go

create view TatCaNVvaBBTL as
select HoTen, MaBB from BienBanThanhLy, NhanVien
where BienBanThanhLy.MaNV = NhanVien.MaNV
go

select * from TatCaNVvaBBTL

--procedure thứ nhất: thêm chi tiết biên bản thanh lý thì trừ đi số lượng tương ứng
drop proc ThemChiTiet
go

create proc ThemChiTiet @MaBB int, @MaNL int, @Gia int, @SoLuong float
as
begin
	insert into ChiTietBBTL(MaBB, MaNL, Gia, SoLuong) values (@MaBB, @MaNL, @Gia, @SoLuong)
	update NguyenLieu set SoLuong -= @SoLuong where MaNL = @MaNL
end
go

--procedure thứ hai: xóa biên bản thanh lý

drop proc XoaBienBan
go

create proc XoaBienBan @MaBB int
as
begin
	delete from ChiTietBBTL where MaBB = @MaBB
	delete from BienBanThanhLy where MaBB = @MaBB
end
go

--trigger thứ nhất: tự động trừ đi số lượng khi thêm chi tiết biên bản thanh lý
create trigger TuDongTruCTBBTL on ChiTietBBTL
after insert as
begin
	update NguyenLieu
	set SoLuong += (select SoLuong from inserted)
end
go

drop trigger TuDongTruCTBBTL

--trigger thứ hai: tự động tăng số lượng khi xóa chi tiết biên bản thanh lý
create trigger TuDongTangCTBBTL on ChiTietBBTL
after delete as
begin
	update NguyenLieu
	set SoLuong -= (select SoLuong from deleted)
end
go

drop trigger TuDongTangCTBBTL
go

--chọn thông tin nghiệp vụ
select HoTen, TenNL, ChiTietBBTL.SoLuong, TenDonVi, GiaTien, (GiaTien * ChiTietBBTL.SoLuong) as TongTien, BienBanThanhLy.NgayLap
from NhanVien
join BienBanThanhLy on BienBanThanhLy.MaNV = NhanVien.MaNV
join ChiTietBBTL on ChiTietBBTL.MaBB = BienBanThanhLy.MaBB
join NguyenLieu on ChiTietBBTL.MaNL = NguyenLieu.MaNL