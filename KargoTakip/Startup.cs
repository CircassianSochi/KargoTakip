using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KargoTakip.Startup))]
namespace KargoTakip
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
