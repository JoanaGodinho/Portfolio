using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(portofolio.Startup))]
namespace portofolio
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
