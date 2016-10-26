using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IOCMVCTesting.Startup))]
namespace IOCMVCTesting
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
