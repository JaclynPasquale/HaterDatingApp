using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HaterDatingApp.Startup))]
namespace HaterDatingApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
