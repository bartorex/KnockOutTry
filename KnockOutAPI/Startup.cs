using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KnockOutAPI.Startup))]
namespace KnockOutAPI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
