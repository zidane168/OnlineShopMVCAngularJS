using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShopDemo.Areas.Admin.Controllers
{

    [Authorize]             // dùng membership  -> tự động checklogin
    // [AllowAnonymous]     // -> enter controller no need check login
    public class HomeController : Controller
    {
        // GET: Admin/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}