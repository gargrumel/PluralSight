using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PluralSight.Startup))]
namespace PluralSight
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
