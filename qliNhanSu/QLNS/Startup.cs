using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QLNS.Startup))]
namespace QLNS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
