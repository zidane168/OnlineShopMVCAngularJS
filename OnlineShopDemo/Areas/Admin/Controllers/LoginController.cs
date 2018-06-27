using Models;
using OnlineShopDemo.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShopDemo.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {


        // GET: Admin/Login

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginModel model)
        {
            AccountModel acc = new AccountModel();
            var result = acc.Login(model.UserName, model.Password);

            if (result && ModelState.IsValid)
            {

            }
            else
            {
                ModelState.AddModelError("", "Tên Đăng Nhập Hay Mạt khẩu chưa đúng!");
            }

            return View(model);
        }
    }
}