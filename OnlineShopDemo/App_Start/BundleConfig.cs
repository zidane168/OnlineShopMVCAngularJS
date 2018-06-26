using System.Web;
using System.Web.Optimization;

namespace OnlineShopDemo
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            // added by vi.ly
            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                        "~/Scripts/angular-1.4.9.js",
                        "~/Scripts/angular-route.min-1.4.9.js" ));



              //<script src="s"> </script>
              //  <script src="https://cdnjs.cloudflare.com/ajax/libs/angular.js/1.4.9/angular-route.min.js"> </script>
              //  <script src="https://ajax.googleapis.com/ajax/libs/angularjs/1.4.9/angular-animate.js"> </script>
        }
    }
}
