using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(sie.Startup))]
namespace sie
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
