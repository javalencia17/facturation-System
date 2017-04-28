using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Facturador.UI.Web.Startup))]
namespace Facturador.UI.Web
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
