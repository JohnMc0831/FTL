using System.Web;
using System.Web.Optimization;

namespace FTL
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

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/essential").Include(
                      "~/Scripts/modernizr.custom.js",
                      "~/Scripts/jquery.mousewheel-3.0.6.pack.js",
                      "~/Scripts/jquery.easing.js",
                      "~/Scripts/jquery.metadata.js",
                      "~/Scripts/jquery.hoverup.js",
                      "~/Scripts/jquery.hoverdir.js",
                      "~/Scripts/jquery.stellar.js",
                      "~/assets/responsive-mobile-nav/js/jquery.dlmenu.js",
                      "~/assets/responsive-mobile-nav/js/jquery.dlmenu.autofill.js",
                      "~/assets/mixitup/jquery.mixitup.js",
                      "~/assets/mixitup/jquery.mixitup.init.js",
                      "~/assets/fancybox/jquery.fancybox.pack.js?v=2.1.5",
                      "~/assets/bootstrap/js/tooltip.js",
                      "~/assets/bootstrap/js/popover.js",
                      "~/assets/layerslider/js/greensock.js",
                      "~/assets/layerslider/js/layerslider.transitions.js",
                      "~/assets/layerslider/js/layerslider.kreaturamedia.jquery.js"
                ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/fonts/font-awesome/css/font-awesome.css",
                      "~/assets/fancybox/jquery.fancybox.css?v=2.1.5",
                      "~/Content/css/global-style.css",
                      "~/assets/owl-carousel/owl.theme.css",
                      "~/assets/sky-forms/css/sky-forms.css",
                      "~/assets/layerslider/css/layerslider.css",
                      "~/Content/site.css"));
        }
    }
}