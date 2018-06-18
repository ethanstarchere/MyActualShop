using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyActualShop.WebUI.Startup))]
namespace MyActualShop.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
