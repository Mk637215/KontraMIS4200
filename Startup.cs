using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KontraMIS4200.Startup))]
namespace KontraMIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
