using OnlineShopDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShopDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        [HttpGet()]
        [ActionName("TestCAllAPIGetLocations")]

        public IEnumerable<Models.Location> TestGetLocations()
        {
            List<Location> locations = new List<Location>();

            string[] Id = new string[] { "1", "2", "3" };
            string[] Name = new string[] { "Warehouse 1", "Warehouse 2", "Warehouse 3" };

            for (int i = 0; i < Id.Length; i++)
            {

                locations.Add(new Models.Location()
                {
                    LocationId = Id[i],
                    LocationName = Name[i],
                });
            }

            return locations;
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}