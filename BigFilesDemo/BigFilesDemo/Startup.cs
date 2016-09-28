using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BigFilesDemo.Startup))]
namespace BigFilesDemo
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
