using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FoloNow.Web.UI.Startup))]
namespace FoloNow.Web.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
