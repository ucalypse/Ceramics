using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ceramics.Startup))]
namespace Ceramics
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
