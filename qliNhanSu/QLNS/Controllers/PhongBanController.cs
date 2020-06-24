using QLNS.Models.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLNS.Controllers
{
    public class PhongBanController : Controller
    {
        // GET: PhongBan
        QuanLiNhanSu ql = new QuanLiNhanSu();

        public ActionResult Index()
        {
            return View(ql.PhongBans.ToList());
        }
        public ActionResult ThemMoi()
        {
            //Đưa dữ liệu vào dropdownlist
            

            return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult ThemMoi(PhongBan pb, HttpPostedFileBase fileUpload)
        {


            //Đưa dữ liệu vào dropdownlist
           
            //kiểm tra đường dẫn ảnh bìa

            //Thêm vào cơ sở dữ liệu
            {
                
                ql.PhongBans.Add(pb);
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
        public ActionResult Xoa(string Mapb)
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
        [HttpPost, ActionName("Xoa")]

        public ActionResult XacNhanXoa(string Mapb)
        {
            PhongBan pb = ql.PhongBans.SingleOrDefault(n => n.MaPB == Mapb);
            if (pb == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            ql.PhongBans.Remove(pb);
            ql.SaveChanges();
            return RedirectToAction("Index");

        }
        
        [HttpPost]
        public ActionResult KetQuaTimKiem(FormCollection f, int? page)
        {
            string sTuKhoa = f["timkiem"].ToString();
            ViewBag.TuKhoa = sTuKhoa;
            List<PhongBan> lstKQTK = ql.PhongBans.Where(n => n.TenPb.Contains(sTuKhoa)).ToList();
            //Phân trang

            if (lstKQTK.Count == 0)
            {
                ViewBag.ThongBao = "Không tìm thấy sản phẩm nào";
                return View(ql.PhongBans.OrderBy(n => n.TenPb));
            }
            ViewBag.ThongBao = "Đã tìm thấy " + lstKQTK.Count + " kết quả!";
            return View(lstKQTK.OrderBy(n => n.TenPb));
        }
        [HttpGet]
        public ActionResult KetQuaTimKiem(int? page, string sTuKhoa)
        {
            ViewBag.TuKhoa = sTuKhoa;
            List<PhongBan> lstKQTK = ql.PhongBans.Where(n => n.TenPb.Contains(sTuKhoa)).ToList();
            //Phân trang

            if (lstKQTK.Count == 0)
            {
                ViewBag.ThongBao = "Không tìm thấy sản phẩm nào";
                return View(ql.PhongBans.OrderBy(n => n.TenPb));
            }
            ViewBag.ThongBao = "Đã tìm thấy " + lstKQTK.Count + " kết quả!";
            return View(lstKQTK.OrderBy(n => n.TenPb));
        }
    }
}