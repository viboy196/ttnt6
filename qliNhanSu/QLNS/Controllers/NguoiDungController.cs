using QLNS.Models.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLNS.Controllers
{
    public class NguoiDungController : Controller
    {
        // GET: NguoiDung
        QuanLiNhanSu ql = new QuanLiNhanSu();

        public ActionResult Index()
        {
            return View(ql.Accounts.ToList());
        }
        public ActionResult ThemMoi()
        {
            //Đưa dữ liệu vào dropdownlist


            return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult ThemMoi(Account nd, HttpPostedFileBase fileUpload)
        {
            //Đưa dữ liệu vào dropdownlist

            //kiểm tra đường dẫn ảnh bìa

            //Thêm vào cơ sở dữ liệu
            {

                ql.Accounts.Add(nd);
                ql.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult ChinhSua(string tkhoan)
        {
            //Lấy ra đối tượng sách theo mã 
            Account nd = ql.Accounts.SingleOrDefault(n => n.Nameaccount == tkhoan);
            if (nd == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            //Đưa dữ liệu vào dropdownlist

            return View(nd);
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult ChinhSua(Account nd, HttpPostedFileBase fileUpload)
        {

            //Thêm vào cơ sở dữ liệu
            if (ModelState.IsValid)
            {
                //Lưu tên file

                //sp.HinhAnh = fileUpload.FileName;
                ql.Accounts.Add(nd);
                //Thực hiện cập nhận trong model
                ql.Entry(nd).State = System.Data.Entity.EntityState.Modified;
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
        public ActionResult Xoa(string tkhoan)
        {
            //Lấy ra đối tượng sách theo mã 
            Account nd = ql.Accounts.SingleOrDefault(n => n.Nameaccount == tkhoan);
            if (nd == null)
            {
                Response.StatusCode = 404;
                return null;
            }

            return View(nd);
        }
        [HttpPost, ActionName("Xoa")]

        public ActionResult XacNhanXoa(string tkhoan)
        {
            Account nd = ql.Accounts.SingleOrDefault(n => n.Nameaccount == tkhoan);
            if (nd == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            ql.Accounts.Remove(nd);
            ql.SaveChanges();
            return RedirectToAction("Index");

        }

        [HttpPost]
        public ActionResult KetQuaTimKiem(FormCollection f, int? page)
        {
            string sTuKhoa = f["timkiem"].ToString();
            ViewBag.TuKhoa = sTuKhoa;
            List<Account> lstKQTK = ql.Accounts.Where(n => n.Nameaccount.Contains(sTuKhoa)).ToList();
            //Phân trang

            if (lstKQTK.Count == 0)
            {
                ViewBag.ThongBao = "Không tìm thấy người dùng nào";
                return View(ql.Accounts.OrderBy(n => n.Nameaccount));
            }
            ViewBag.ThongBao = "Đã tìm thấy " + lstKQTK.Count + " kết quả!";
            return View(lstKQTK.OrderBy(n => n.Nameaccount));
        }
        [HttpGet]
        public ActionResult KetQuaTimKiem(int? page, string sTuKhoa)
        {
            ViewBag.TuKhoa = sTuKhoa;
            List<Account> lstKQTK = ql.Accounts.Where(n => n.Nameaccount.Contains(sTuKhoa)).ToList();
            //Phân trang

            if (lstKQTK.Count == 0)
            {
                ViewBag.ThongBao = "Không tìm thấy người dùng nào";
                return View(ql.Accounts.OrderBy(n => n.Nameaccount));
            }
            ViewBag.ThongBao = "Đã tìm thấy " + lstKQTK.Count + " kết quả!";
            return View(lstKQTK.OrderBy(n => n.Nameaccount));
        }
    }
}