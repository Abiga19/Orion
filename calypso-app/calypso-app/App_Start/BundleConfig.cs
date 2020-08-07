using System.Web;
using System.Web.Optimization;

namespace calypso_app
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
            // para la producción, use la herramienta de compilación disponible en https://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/assets/js/jquery-1.12.4.min.js",
                      "~/assets/js/popper.min.js",
                      "~/assets/bootstrap/js/bootstrap.min.js",
                      "~/assets/owlcarousel/js/owl.carousel.min.js",
                      "~/assets/js/magnific-popup.min.js",
                      "~/assets/js/waypoints.min.js",
                      "~/assets/js/parallax.js",
                      "~/assets/js/jquery.countdown.min.js",
                      "~/assets/js/imagesloaded.pkgd.min.js",
                      "~/assets/js/isotope.min.js",
                      "~/assets/js/jquery.dd.min.js",
                      "~/assets/js/slick.min.js",
                      "~/assets/js/jquery.elevatezoom.js",
                      "~/assets/js/scripts.js"
                      ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/assets/css/animate.css",
                      "~/assets/bootstrap/css/bootstrap.min.css",
                      "~/assets/css/all.min.css",
                      "~/assets/css/ionicons.min.css",
                      "~/assets/css/themify-icons.css",
                      "~/assets/css/linearicons.css",
                      "~/assets/css/flaticon.css",
                      "~/assets/css/simple-line-icons.css",
                      "~/assets/owlcarousel/css/owl.theme.css",
                      "~/assets/owlcarousel/css/owl.theme.default.min.css",
                      "~/assets/css/magnific-popup.css",
                      "~/assets/css/slick.css",
                      "~/assets/css/slick-theme.css",
                      "~/assets/css/style.css",
                      "~/assets/css/responsive.css",
                      "~/assets/css/rtl-style.css"
                      ));
        }
    }
}
