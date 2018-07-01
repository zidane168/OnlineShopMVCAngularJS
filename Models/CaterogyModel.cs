using Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class CaterogyModel
    {
        private OnlineShopDbContext context = null;

        public CaterogyModel()
        {
            context = new OnlineShopDbContext();
        }

        public List<Models.EF.Category> GetAll()
        {
            var lst = context.Database.SqlQuery<Models.EF.Category>("uspGetAllCategory").ToList();
            return lst;

        }
        public Models.EF.Category getCaterogyWithParentID(string ParentID)
        {
            using (OnlineShopDbContext dataContext = new OnlineShopDbContext())
            {
                int parentID = Convert.ToInt32(ParentID);
                var category = dataContext.Categories.Find(parentID);
                return category;
            }
        }


        public string AddCategory(Category category)
        {
            if (category == null)
            {
                return "Invalid Category";
            }

            using (OnlineShopDbContext dataContext = new OnlineShopDbContext())
            {

                dataContext.Categories.Add(category);
                dataContext.SaveChanges();
                return "Category Updated!";
            }
        }

        public string DeleteCategory(Category category)
        {
            if (category == null)
            {
                return "Invalid Category";
            }

            using (OnlineShopDbContext dataContext = new OnlineShopDbContext())
            {
                int no = Convert.ToInt32(category.ID);
                var lst = dataContext.Categories.Where(x => x.ID == no).FirstOrDefault();
                dataContext.Categories.Remove(lst);
                dataContext.SaveChanges();
                return "Category Deleted";
                
            }
        }
    }
}
