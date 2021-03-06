using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vedly.Startup))]
namespace Vedly
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
