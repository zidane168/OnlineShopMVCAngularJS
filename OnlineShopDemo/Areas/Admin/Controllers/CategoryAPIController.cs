using Models;
using Models.EF;
using System.Collections.Generic;
using System.Web.Http;

namespace OnlineShopDemo.Areas.Admin.Controllers
{
    public class CategoryAPIController : ApiController
    {
        [HttpGet()]
        [ActionName("GetAllCategory")]
        public IEnumerable<Category> GetAllCategory()
        {
            var category = new CaterogyModel();
            return category.GetAll();
        }


        // Admin/Category/Category/AddCategory


        [HttpPost()]
        [ActionName("AddCategory")]
        public string AddCategory(Category c)
        {
            var category = new CaterogyModel();
            return category.AddCategory(c);
        }
    }
}
