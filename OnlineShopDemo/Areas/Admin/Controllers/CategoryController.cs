
using System.Collections.Generic;
using System.Web.Mvc;
using Models;
using Models.EF;        // remmeber include here

namespace OnlineShopDemo.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
      
        [HttpGet()]
        [ActionName("GetAllCategory")]
        public IEnumerable<Category> GetAllCategory()
        {            
            var category = new CaterogyModel();
            return category.GetAll();
        }

        // GET: Admin/Category
        public ActionResult Index()
        {

            return View();

            //var category = new CaterogyModel();
            //var model = category.GetAll();
            //return View(model);
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

        // POST: Admin/Category/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Category/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/Category/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Category/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/Category/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
