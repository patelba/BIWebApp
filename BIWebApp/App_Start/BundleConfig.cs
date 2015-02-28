using System.Web;
using System.Web.Optimization;

namespace BIWebApp
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/classie.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                       "~/Scripts/handlebars.js",
                      "~/Scripts/respond.js",
                      //"~/Scripts/plugins/jQuery/jQuery-2.1.3.min.js",
                      "~/Scripts/plugins/slimScroll/jquery.slimScroll.min.js",
                      "~/Scripts/plugins/fastclick/fastclick.min.js",
                      "~/Scripts/dist/js/app.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/AdminLTE.min.css",
                      "~/Content/bootstrap.css",
                      "~/Content/skins/_all-skins.min.css"
                      ));
        }
    }
}
