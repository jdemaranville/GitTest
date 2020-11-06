using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitTest.UI.MVC.Startup))]
namespace GitTest.UI.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
