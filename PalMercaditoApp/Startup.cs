using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PalMercaditoApp.Startup))]
namespace PalMercaditoApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
