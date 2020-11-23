using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Autentication.Startup))]
namespace Autentication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
