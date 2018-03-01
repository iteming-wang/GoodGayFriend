using System.Web;
using System.Web.Optimization;

namespace GGF
{
    public class BundleConfig
    {
        // 有关绑定的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            // 使用要用于开发和学习的 Modernizr 的开发版本。然后，当你做好
            // 生产准备时，请使用 http://modernizr.com 上的生成工具来仅选择所需的测试。
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Content/js/modernizr-*"));

            bundles.Add(new ScriptBundle("~/Public/plugins").Include(
                      "~/Public/plugins/jquery-1.10.2.min.js",
                      "~/Public/plugins/jquery-migrate-1.2.1.min.js",
                      "~/Public/plugins/bootstrap/js/bootstrap.min.js",
                      "~/Public/plugins/hover-dropdown.js",
                      "~/Public/plugins/back-to-top.js",
                      "~/Public/plugins/fancybox/source/jquery.fancybox.pack.js",
                      "~/Public/plugins/revolution_slider/rs-plugin/js/jquery.themepunch.plugins.min.js",
                      "~/Public/plugins/revolution_slider/rs-plugin/js/jquery.themepunch.revolution.min.js",
                      "~/Public/plugins/bxslider/jquery.bxslider.min.js",
                      "~/Public/plugins/respond.min.js"
                      ));
            bundles.Add(new StyleBundle("~/Public/scripts").Include(
                      "~/Public/scripts/app.js"
                      ));
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/css/bootstrap.css",
                      "~/Content/css/site.css"
                      ));

            bundles.Add(new StyleBundle("~/Public/css").Include(
                //开始全局强制样式
                      "~/Public/css/font-awesome/css/font-awesome.min.css",
                      "~/Public/css/bootstrap/css/bootstrap.min.css",
                //开始页面级插件样式
                      "~/Public/css/fancybox/source/jquery.fancybox.css",
                      "~/Public/css/revolution_slider/css/rs-style.css",
                      "~/Public/css/revolution_slider/rs-plugin/css/settings.css",
                      "~/Public/css/bxslider/jquery.bxslider.css",
                //开始主题风格样式
                      "~/Public/css/style-metronic.css",
                      "~/Public/css/style.css",
                      "~/Public/css/style-responsive.css",
                      "~/Public/css/custom.css"
                      
                      ));

        }
    }
}
