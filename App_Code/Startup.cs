using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SonarTest.Startup))]
namespace SonarTest
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
