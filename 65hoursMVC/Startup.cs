using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_65hoursMVC.Startup))]
namespace _65hoursMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
