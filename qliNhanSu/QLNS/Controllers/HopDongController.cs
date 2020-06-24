using QLNS.Models.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLNS.Controllers
{
    public class HopDongController : Controller
    {
        // GET: HopDong
        QuanLiNhanSu ql = new QuanLiNhanSu();

        public ActionResult Index()
        {
            return View(ql.HopDongs.ToList());
        }
        public ActionResult ThemMoi()
        {
            //Đưa dữ liệu vào dropdownlist

            ViewBag.MaNV = new SelectList(ql.NhanViens.ToList().OrderBy(n => n.MaNV), "MaNV","HoTen");
            return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult ThemMoi(HopDong hd, HttpPostedFileBase fileUpload)
        {


            //Đưa dữ liệu vào dropdownlist

            //kiểm tra đường dẫn ảnh bìa
            ViewBag.MaNV = new SelectList(ql.NhanViens.ToList().OrderBy(n => n.MaNV), "MaNV", "HoTen");
            //Thêm vào cơ sở dữ liệu
            {
                ql.HopDongs.Add(hd);
                ql.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult ChinhSua(string Mapb)
        {
            //Lấy ra đối tượng sách theo mã 
            PhongBan pb = ql.PhongBans.SingleOrDefault(n => n.MaPB == Mapb);
            if (pb == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            //Đưa dữ liệu vào dropdownlist

            return View(pb);
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult ChinhSua(PhongBan pb, HttpPostedFileBase fileUpload)
        {


            //Thêm vào cơ sở dữ liệu
            if (ModelState.IsValid)
            {
                //Lưu tên file

                //sp.HinhAnh = fileUpload.FileName;
                ql.PhongBans.Add(pb);
                //Thực hiện cập nhận trong model
                ql.Entry(pb).State = System.Data.Entity.EntityState.Modified;
                ql.SaveChanges();

            }
            return RedirectToAction("Index");
            //return View();
        }


        //Hiển thị sản phẩm
        public ActionResult HienThi(string Mapb)
        {
            //Lấy ra đối tượng sách theo mã 
            PhongBan pb = ql.PhongBans.SingleOrDefault(n => n.MaPB == Mapb);
            if (pb == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(pb);
        }
        [HttpGet]
        public ActionResult Xoa(string Mahd)
        {
            //Lấy ra đối tượng sách theo mã 
            HopDong hd = ql.HopDongs.SingleOrDefault(n => n.MaHD == Mahd);
            if (hd == null)
            {
                Response.StatusCode = 404;
                return null;
            }

            return View(hd);
        }
        [HttpPost, ActionName("Xoa")]

        public ActionResult XacNhanXoa(string Mahd)
        {
            HopDong hd = ql.HopDongs.SingleOrDefault(n => n.MaHD == Mahd);
            if (hd == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            ql.HopDongs.Remove(hd);
            ql.SaveChanges();
            return RedirectToAction("Index");

        }

        [HttpPost]
        public ActionResult KetQuaTimKiem(FormCollection f, int? page)
        {
            string sTuKhoa = f["timkiem"].ToString();
            ViewBag.TuKhoa = sTuKhoa;
            List<HopDong> lstKQTK = ql.HopDongs.Where(n => n.NhanVien.HoTen.Contains(sTuKhoa)).ToList();
            //Phân trang

            if (lstKQTK.Count == 0)
            {
                ViewBag.ThongBao = "Không tìm thấy sản phẩm nào";
                return View(ql.HopDongs.OrderBy(n => n.NhanVien.HoTen));
            }
            ViewBag.ThongBao = "Đã tìm thấy " + lstKQTK.Count + " kết quả!";
            return View(lstKQTK.OrderBy(n => n.NhanVien.HoTen));
        }
        [HttpGet]
        public ActionResult KetQuaTimKiem(int? page, string sTuKhoa)
        {
            ViewBag.TuKhoa = sTuKhoa;
            List<HopDong> lstKQTK = ql.HopDongs.Where(n => n.NhanVien.HoTen.Contains(sTuKhoa)).ToList();
            //Phân trang

            if (lstKQTK.Count == 0)
            {
                ViewBag.ThongBao = "Không tìm thấy hợp đồng nào";
                return View(ql.HopDongs.OrderBy(n => n.NhanVien.HoTen));
            }
            ViewBag.ThongBao = "Đã tìm thấy " + lstKQTK.Count + " kết quả!";
            return View(lstKQTK.OrderBy(n => n.NhanVien.HoTen));
        }
    }
}
