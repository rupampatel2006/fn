using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Optimization;

namespace FoloNow.web.UI
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                        "~/Scripts/angular.js"));

            bundles.Add(new ScriptBundle("~/bundles/angularroute").Include(
                        "~/Scripts/angular-route.js"));


            bundles.Add(new ScriptBundle("~/bundles/angular-resource").Include(
                        "~/Scripts/angular-resource.js"));

            bundles.Add(new ScriptBundle("~/bundles/angular-animate").Include(
                         "~/Scripts/angular-animate.js"));

            bundles.Add(new ScriptBundle("~/bundles/angular-ui").Include("~/Scripts/angular-ui/ui-bootstrap.min.js"));

            //TODO: Move dynamic read code to framework 
            const string App = "~/App",
                infrastructure = "~/App/Infrastructure",
                common = "~/App/Common",
                management = "~/App/Management";
            // = "~/App/Gl",
            //Scheduler = "~/App/Scheduler",
            //Report = "~/App/Report",
            //System = "~/App/System",
            //Security = "~/App/Security",
            //Profiles = "~/App/Profiles",
            //Batch = "~/App/Batch",
            //Vendor = "~/App/Vendor",
            //Stocks = "~/App/Stocks";

            bundles.Add(new ScriptBundle("~/bundles/App/js").IncludeDirectory(App, "*.js", true));

            bundles.Add(new ScriptBundle("~/bundles/App/Common/js").IncludeDirectory(common, "*.js", true));

            bundles.Add(new ScriptBundle("~/bundles/Apps").Include(
                        "~/App/app.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/themes/folonow/css").Include("~/Content/themes/folonow/main.css"));

            bundles.Add(new StyleBundle("~/Content/themes/folonow/font-awesome/css").Include("~/Content/themes/folonow/font-awesome/css/font-awesome.css"));

            bundles.Add(new StyleBundle("~/Content/themes/folonow/weather-icons/css").Include("~/Content/themes/folonow/weather-icons/css/weather-icons.css"));

            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
                        "~/Content/themes/base/jquery.ui.core.css",
                        "~/Content/themes/base/jquery.ui.resizable.css",
                        "~/Content/themes/base/jquery.ui.selectable.css",
                        "~/Content/themes/base/jquery.ui.accordion.css",
                        "~/Content/themes/base/jquery.ui.autocomplete.css",
                        "~/Content/themes/base/jquery.ui.button.css",
                        "~/Content/themes/base/jquery.ui.dialog.css",
                        "~/Content/themes/base/jquery.ui.slider.css",
                        "~/Content/themes/base/jquery.ui.tabs.css",
                        "~/Content/themes/base/jquery.ui.datepicker.css",
                        "~/Content/themes/base/jquery.ui.progressbar.css",
                        "~/Content/themes/base/jquery.ui.theme.css"));

        }
    }
}
