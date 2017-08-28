using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(biznes.Startup))]
namespace biznes
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
