using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RedisgnBabaJob.Startup))]
namespace RedisgnBabaJob
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
