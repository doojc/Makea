using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Makea.Startup))]
namespace Makea
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
