using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(movil1.Backend.Startup))]
namespace movil1.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
