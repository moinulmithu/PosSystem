using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Pos.Web.Startup))]
namespace Pos.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
