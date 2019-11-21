using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SuperHero_Creator.Startup))]
namespace SuperHero_Creator
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
