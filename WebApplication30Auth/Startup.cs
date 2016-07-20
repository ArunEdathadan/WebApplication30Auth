using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApplication30Auth.Startup))]
namespace WebApplication30Auth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
