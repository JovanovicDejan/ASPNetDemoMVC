using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASPDemoMVC.Startup))]
namespace ASPDemoMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
