using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Prj_Auth.Startup))]
namespace Prj_Auth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
