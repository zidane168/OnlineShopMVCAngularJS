using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShopDemo.Areas.Admin.Code
{
    // save session information

    [Serializable] // server binary data
    public class UserSession
    {
        public string UserName { set; get; }

    }
}