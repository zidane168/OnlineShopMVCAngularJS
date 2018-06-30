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
            var lst = context.Database.SqlQuery<Models.EF.Category>("uspGetCategory").ToList();
            return lst;

        }
    }
}
