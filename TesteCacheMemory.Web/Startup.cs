using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TesteCacheMemory.Web.Startup))]
namespace TesteCacheMemory.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
