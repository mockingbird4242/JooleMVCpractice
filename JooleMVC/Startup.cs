using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JooleMVC.Startup))]
namespace JooleMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
