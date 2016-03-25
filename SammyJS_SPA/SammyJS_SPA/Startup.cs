using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SammyJS_SPA.Startup))]
namespace SammyJS_SPA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
