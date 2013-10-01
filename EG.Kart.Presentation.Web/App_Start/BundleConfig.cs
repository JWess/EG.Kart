using System.Web.Optimization;

namespace EG.Kart.Presentation.Web.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/js").Include(
                "~/scripts/lib/jquery-{version}.js",
                "~/scripts/lib/jquery-migrate-{version}.js",
                "~/scripts/lib/bootstrap.js",
                "~/scripts/lib/jquery.validate.js",
                "~/scripts/lib/jquery.validate.unobtrusive.js",
                "~/scripts/lib/jquery.validate.unobtrusive-custom-for-bootstrap.js"
                ));

            bundles.Add(new StyleBundle("~/content/css").Include(
                "~/Content/bootstrap/bootstrap.css",
                "~/Content/bootstrap/bootstrap-theme.css",
                "~/Content/body.css",
                "~/Content/bootstrap-mvc-validation.css"
                ));
        }
    }
}