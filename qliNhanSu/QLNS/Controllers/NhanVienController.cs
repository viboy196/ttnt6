using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using QLNS.Models.entity;

namespace qlNS.Controllers
{
    public class NhanVienController : Controller
    {
        // GET: NhanVien
        QuanLiNhanSu ql = new QuanLiNhanSu();

        public ActionResult Index()
        {
            return View(ql.NhanViens.ToList());
        }
        public ActionResult ThemMoi()
        {
            //Đưa dữ liệu vào dropdownlist
            ViewBag.MaPB = new SelectList(ql.PhongBans.ToList().OrderBy(n => n.TenPb), "MaPB", "TenPb");
            ViewBag.MaCV = new SelectList(ql.ChucVus.ToList().OrderBy(n => n.TenCV), "MaCV", "TenCV");
            ViewBag.MaLuong = new SelectList(ql.Luongs.ToList().OrderBy(n => n.LuongCB), "MaLuong", "LuongCB");
            ViewBag.MaTD = new SelectList(ql.TrinhDoHVs.ToList().OrderBy(n => n.TenTDHV), "MaTD", "TenTDHV", "ChuyenNganh");
            ViewBag.MaHD = new SelectList(ql.HopDongs.ToList().OrderBy(n => n.LoaiHD), "MaHD", "TenHD" );
            return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult ThemMoi(NhanVien nv, HttpPostedFileBase fileUpload)
        {


            //Đưa dữ liệu vào dropdownlist
            ViewBag.MaPB = new SelectList(ql.PhongBans.ToList().OrderBy(n => n.TenPb), "MaPB", "TenPb");
            ViewBag.MaCV = new SelectList(ql.ChucVus.ToList().OrderBy(n => n.TenCV), "MaCV", "TenCV");
            ViewBag.MaLuong = new SelectList(ql.Luongs.ToList().OrderBy(n => n.LuongCB), "MaLuong", "LuongCB");
            ViewBag.MaTD = new SelectList(ql.TrinhDoHVs.ToList().OrderBy(n => n.TenTDHV), "MaTD", "TenTDHV", "ChuyenNganh");
            ViewBag.MaHD = new SelectList(ql.HopDongs.ToList().OrderBy(n => n.LoaiHD), "MaHD", "TenHD" );
            //kiểm tra đường dẫn ảnh bìa

            //Thêm vào cơ sở dữ liệu
            {
                //sp.HinhAnh = fileUpload.FileName;
                ql.NhanViens.Add(nv);
                ql.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult ChinhSua(string Manv)
        {
            //Lấy ra đối tượng sách theo mã 
            NhanVien nv = ql.NhanViens.SingleOrDefault(n => n.MaNV == Manv);
            if (nv == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            //Đưa dữ liệu vào dropdownlist
            ViewBag.MaPB = new SelectList(ql.PhongBans.ToList().OrderBy(n => n.TenPb), "MaPB", "TenPb");
            ViewBag.MaCV = new SelectList(ql.ChucVus.ToList().OrderBy(n => n.TenCV), "MaCV", "TenCV");
            ViewBag.MaLuong = new SelectList(ql.Luongs.ToList().OrderBy(n => n.LuongCB), "MaLuong", "LuongCB");
            ViewBag.MaTD = new SelectList(ql.TrinhDoHVs.ToList().OrderBy(n => n.TenTDHV), "MaTD", "TenTDHV", "ChuyenNganh");
            return View(nv);
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult ChinhSua(NhanVien nv, HttpPostedFileBase fileUpload)
        {
            ViewBag.MaPB = new SelectList(ql.PhongBans.ToList().OrderBy(n => n.TenPb), "MaPB", "TenPb");
            ViewBag.MaCV = new SelectList(ql.ChucVus.ToList().OrderBy(n => n.TenCV), "MaCV", "TenCV");
            ViewBag.MaLuong = new SelectList(ql.Luongs.ToList().OrderBy(n => n.LuongCB), "MaLuong", "LuongCB");
            ViewBag.MaTD = new SelectList(ql.TrinhDoHVs.ToList().OrderBy(n => n.TenTDHV), "MaTD", "TenTDHV", "ChuyenNganh");
            ViewBag.MaHD = new SelectList(ql.HopDongs.ToList().OrderBy(n => n.LoaiHD), "MaHD", "TenHD" );
            //Thêm vào cơ sở dữ liệu
            //if (ModelState.IsValid)
            {
                //Lưu tên file

                //sp.HinhAnh = fileUpload.FileName;
                ql.NhanViens.Add(nv);
                //Thực hiện cập nhận trong model
                ql.Entry(nv).State = System.Data.Entity.EntityState.Modified;
                ql.SaveChanges();

            }
            return RedirectToAction("Index");
            //return View();
        }


        //Hiển thị sản phẩm
        public ActionResult HienThi(string Manv)
        {
            //Lấy ra đối tượng sách theo mã 
            NhanVien nv = ql.NhanViens.SingleOrDefault(n => n.MaNV == Manv);
            if (nv == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(nv);
        }
        [HttpGet]
        public ActionResult Xoa(string Manv)
        {
            //Lấy ra đối tượng sách theo mã 
            NhanVien nv = ql.NhanViens.SingleOrDefault(n => n.MaNV == Manv);
            if (nv == null)
            {
                Response.StatusCode = 404;
                return null;
            }

            return View(nv);
        }
        [HttpPost, ActionName("Xoa")]

        public ActionResult XacNhanXoa(string Manv)
        {
            NhanVien nv = ql.NhanViens.SingleOrDefault(n => n.MaNV == Manv);
            HopDong hd = ql.HopDongs.SingleOrDefault(n => n.MaNV == Manv);
            if (nv == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            ql.NhanViens.Remove(nv);
            ql.HopDongs.Remove(hd);
            ql.SaveChanges();
            return RedirectToAction("Index");

        }
        public PartialViewResult TheoPhongBan()
        {
            var PhongBan = ql.PhongBans.ToList();
            return PartialView(PhongBan);
        }
        public ViewResult XemTheoLoai(string MaPB)
        {
            //int pageNumber = (Page ?? 1);
            //int pageSize = 10;
            PhongBan pb  = ql.PhongBans.SingleOrDefault(n => n.MaPB == MaPB);
            if (pb == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            List<NhanVien> lisp = ql.NhanViens.Where(n => n.MaPB == MaPB).ToList();
            if (lisp.Count == 0)
            {
                ViewBag.SanPham = "không có nhân viên phòng này";
            }
            return View(lisp);
        }
        [HttpPost]
        public ActionResult KetQuaTimKiem(FormCollection f, int? page)
        {
            string sTuKhoa = f["timkiem"].ToString();
            ViewBag.TuKhoa = sTuKhoa;
            List<NhanVien> lstKQTK = ql.NhanViens.Where(n => n.HoTen.Contains(sTuKhoa)).ToList();
            //Phân trang

            if (lstKQTK.Count == 0)
            {
                ViewBag.ThongBao = "Không tìm thấy nhân viên nào";
                return View(ql.NhanViens.OrderBy(n => n.HoTen));
            }
            ViewBag.ThongBao = "Đã tìm thấy " + lstKQTK.Count + " kết quả!";
            return View(lstKQTK.OrderBy(n => n.HoTen));
        }
        [HttpGet]
        public ActionResult KetQuaTimKiem(int? page, string sTuKhoa)
        {
            ViewBag.TuKhoa = sTuKhoa;
            List<NhanVien> lstKQTK = ql.NhanViens.Where(n => n.HoTen.Contains(sTuKhoa)).ToList();
            //Phân trang

            if (lstKQTK.Count == 0)
            {
                ViewBag.ThongBao = "Không tìm thấy nhân viên nào";
                return View(ql.NhanViens.OrderBy(n => n.HoTen));
            }
            ViewBag.ThongBao = "Đã tìm thấy " + lstKQTK.Count + " kết quả!";
            return View(lstKQTK.OrderBy(n => n.HoTen));
        }
    }
}