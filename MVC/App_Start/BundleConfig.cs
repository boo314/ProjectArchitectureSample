using System.Configuration;
using System.Web;
using System.Web.Optimization;

namespace MVC
{
    public class BundleConfig
    {
        
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            var scriptsPath = ConfigurationManager.AppSettings["Frontend.ScriptsPath"];
            var stylesPath = ConfigurationManager.AppSettings["Frontend.StylesPath"];

            RegisterJQuery(bundles, scriptsPath, stylesPath);
            RegisterModernizer(bundles);
            RegisterBootstrap(bundles);
            RegisterCustomStyles(bundles);
        }

        private static void RegisterJQuery(BundleCollection bundles, string scriptsPath = "", string stylesPath = "")
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        scriptsPath + "libs/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        scriptsPath + "libs/jquery.validate*"));
        }

        private static void RegisterBootstrap(BundleCollection bundles, string scriptsPath = "", string stylesPath = "")
        {
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Frontend/Scripts/libs/bootstrap.js",
                      "~/Frontend/Scripts/libs/respond.js"));

            bundles.Add(new StyleBundle("~/styles/bootstrap").Include(
                      "~/Frontend/Styles/bootstrap.css"));
        }

        private static void RegisterModernizer(BundleCollection bundles, string scriptsPath = "", string stylesPath = "")
        {
            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Frontend/Scripts/libs/modernizr-*"));
        }
        private static void RegisterCustomStyles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/styles/custom").Include(
                      "~/Frontend/Styles/style.css"));
        }
    }
}
