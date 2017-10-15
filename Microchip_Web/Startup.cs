using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Microchip_Web.Startup))]
namespace Microchip_Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
