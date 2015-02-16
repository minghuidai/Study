using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Study.Web.MVC.Startup))]
namespace Study.Web.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
