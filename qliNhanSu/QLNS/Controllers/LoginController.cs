using Models;
using QLNS.Controllers.code;
using QLNS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLNS.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(LoginModel model)
        {
            var result = new AccountModel().Login(model.Nameaccount, model.Password);
            if(result&& ModelState.IsValid)
            
            {
                SessionHelper.SetSession(new UserSession() { Taikhoan = model.Nameaccount });
                return RedirectToAction("Index", "NhanVien");
            }
            else
            {
                ModelState.AddModelError("", "Tên đăng nhập hoặc mật khẩu không đúng");

            }
            return View(model);
        }
    }
}