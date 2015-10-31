using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PartyPlanner.Startup))]
namespace PartyPlanner
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
