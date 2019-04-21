using System.Web;
using System.Web.Optimization;

namespace TesteMirum.Mvc
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //          "~/Scripts/bootstrap.js"));


            //bundles.Add(new StyleBundle("~/Content/css").Include(
            //          "~/Content/bootstrap.css",
            //          "~/Content/site.css"));


            bundles.Add(new ScriptBundle("~/bundles/new_layout_js").Include(
                        "~/Content/vendor/jquery/jquery.min.js",
                        "~/Content/vendor/bootstrap/js/bootstrap.bundle.min.js",
                        "~/Content/vendor/jquery-easing/jquery.easing.min.js",
                        "~/Content/vendor/chart.js/Chart.min.js",
                        "~/Content/vendor/datatables/jquery.dataTables.js",
                        "~/Content/vendor/datatables/dataTables.bootstrap4.js",
                        "~/Content/js/sb-admin.min.js",
                        "~/Content/js/demo/datatables-demo.js",
                        "~/Content/js/demo/chart-area-demo.js"));

            bundles.Add(new StyleBundle("~/Content/new_layout_css").Include(
                    "~/Content/vendor/fontawesome-free/css/all.min.css",
                    "~/Content/vendor/datatables/dataTables.bootstrap4.css",
                    "~/Content/css/sb-admin.css"));
        }
    }
}
