
using System.Collections.Generic;
using System.Web.Mvc;
using Models;
using Models.EF;        // remmeber include here

namespace OnlineShopDemo.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
      
  

        // GET: Admin/Category
        public ActionResult Index()
        {

            return View();
        }

        // GET: Admin/Category/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/Category/Create
        public ActionResult Create()
        {
            return View();
        }

        // insert, update, delete data
  

    }
}
