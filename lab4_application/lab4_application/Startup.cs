using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lab4_application.Startup))]
namespace lab4_application
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
