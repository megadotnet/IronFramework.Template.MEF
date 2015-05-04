using System.Web;
using System.Web.Optimization;

namespace WebAppMVC5
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/kendo").Include(
                        "~/Scripts/kendo.all.min.js",
                        "~/Scripts/kendo.aspnetmvc.min.js",
                        "~/Scripts/kendo.timezones.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/demo").Include(
                        "~/Scripts/console.js"));

            bundles.Add(new StyleBundle("~/Content/kendo/css").Include(
                        "~/Content/web/kendo.common.min.css",
                        "~/Content/web/kendo.rtl.min.css",
                        "~/Content/web/kendo.default.min.css",
                        "~/Content/web/kendo.default.mobile.min.css",
                        "~/Content/dataviz/kendo.dataviz.min.css",
                        "~/Content/dataviz/kendo.dataviz.default.min.css",
                        "~/Content/mobile/kendo.mobile.all.min.css"));


            bundles.Add(new StyleBundle("~/Content/mobile/css").Include(
                        "~/Content/mobile/kendo.mobile.all.min.css"));

            bundles.Add(new StyleBundle("~/Content/shared/css").Include(
                        "~/Content/shared/examples-offline.css"));

            bundles.IgnoreList.Clear();
        }
    }
}
