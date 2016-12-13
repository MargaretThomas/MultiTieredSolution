using Microsoft.Owin;
using Owin;
using Microsoft.Owin.Security.DataProtection;

[assembly: OwinStartup(typeof(DemoWebApp.Startup))]

namespace DemoWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var container = UnityConfig.RegisterComponents(app.GetDataProtectionProvider());
            ConfigureAuth(app);
        }
    }
}
