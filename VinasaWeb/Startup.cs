using Microsoft.Extensions.DependencyInjection;
using Microsoft.Owin;
using Owin;
using VinasaWeb.Services;

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
