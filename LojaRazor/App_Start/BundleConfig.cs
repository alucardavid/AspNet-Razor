using System.Web;
using System.Web.Optimization;

namespace LojaRazor
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            StyleBundle estilos = new StyleBundle("~/bundles/estilos");
            ScriptBundle scripts = new ScriptBundle("~/bundles/scripts");

            estilos.Include("~/Content/bootstrap/css/bootstrap.css");
            estilos.Include("~/Content/Style.css");

            scripts.Include("~/Scripts/jquery-1.7.1.js");
            scripts.Include("~/Scripts/jquery.validade.js");
            scripts.Include("~/Scripts/jquery.validade.unobtrusive.js");

            bundles.Add(estilos);
            bundles.Add(scripts);


        }
    }
}