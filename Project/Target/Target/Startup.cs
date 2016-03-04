using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Target.Startup))]
namespace Target
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
