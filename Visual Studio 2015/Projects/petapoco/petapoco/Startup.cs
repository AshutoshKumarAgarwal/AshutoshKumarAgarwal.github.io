using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(petapoco.Startup))]
namespace petapoco
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
