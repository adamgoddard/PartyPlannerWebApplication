using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PartyPlannerWebApplication.Startup))]
namespace PartyPlannerWebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
