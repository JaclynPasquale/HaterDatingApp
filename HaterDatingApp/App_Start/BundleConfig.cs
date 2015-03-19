using System.Web;
using System.Web.Optimization;

namespace HaterDatingApp
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                      "~/scripts/angular.min.js",
                      "~/scripts/angular-route.min.js",
                      "~/scripts/angular-resource.min.js",
                      "~/scripts/angular-local-storage.min.js",
                      "~/scripts/loading-bar.min.js"
                      ));

            bundles.Add(new ScriptBundle("~/bundles/jQuery").Include(
                      "~/scripts/bootstrap.min.js",
                      "~/scripts/jquery-1.10.2.min.js"
                      ));

            bundles.Add(new ScriptBundle("~/bundles/HaterDatingApp").Include(
                      "~/App/Main.js",
                      "~/App/Mainconfig.js")
                      .IncludeDirectory("~/App/Controllers", "*.js")
                      .IncludeDirectory("~/App/Services", "*.js"));

            BundleTable.EnableOptimizations = true;
        }
    }
}
