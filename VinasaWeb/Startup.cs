using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VinasaWeb.Startup))]
namespace VinasaWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
