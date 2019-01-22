using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(humanResource.Startup))]
namespace humanResource
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
