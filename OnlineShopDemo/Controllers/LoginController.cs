using OnlineShopDemo.Models;
using System.Web.Mvc;
using System.Web.Security;

namespace OnlineShopDemo.Controllers
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
        [ValidateAntiForgeryToken]  // server gen token, client gen token, chống request liên tục
        public ActionResult Index(LoginModel model)
        {
            // Method 1: using session
            //AccountModel acc = new AccountModel();
            //var result = acc.Login(model.UserName, model.Password);

            //if (result && ModelState.IsValid)   // login succeed
            //{
            //    UserSession usersession = new UserSession()
            //    {
            //        UserName = model.UserName                    
            //    };

            //    SessionHelper.SetSession(usersession);
            //    return RedirectToAction("Index", "Home");

            //}
            //else
            //{
            //    ModelState.AddModelError("", "Tên Đăng Nhập Hay Mạt khẩu chưa đúng!");
            //}

            //return View(model);


            // ------------------------------------------------
            // Method 2: using membership
            
            if (Membership.ValidateUser(model.UserName, model.Password) && ModelState.IsValid)   // login succeed
            {
                FormsAuthentication.SetAuthCookie(model.UserName, model.RememberMe);
                return RedirectToAction("Index", "Home");   // return Admin/Index/Home

            }
            else
            {
                ModelState.AddModelError("", "Tên Đăng Nhập Hay Mật khẩu chưa đúng!");
            }

            return View(model);

        }


        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();  // hủy all cookies
            return RedirectToAction("Index", "Login");  // return Admin/Index/Login
        }
    }
}