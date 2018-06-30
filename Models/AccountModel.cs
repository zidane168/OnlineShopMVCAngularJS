using Models.EF;
using System.Data.SqlClient;
using System.Linq;

namespace Models
{
    public class AccountModel
    {

        private OnlineShopDbContext context = null;

        public AccountModel()
        {
            context = new OnlineShopDbContext();    // must init before call
        }

        public bool Login(string username, string password)
        {
            try
            {
                object[] sqlParams =
                {
                    new SqlParameter("@UserName", username),
                    new SqlParameter("@Password", password),
                };

                return context.Database.SqlQuery<bool>("uspAccountLogin @UserName, @Password", sqlParams).SingleOrDefault();
            }
            catch {
                throw;
            }

        }
    }
}
