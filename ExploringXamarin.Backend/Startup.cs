using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(ExploringXamarin.Backend.Startup))]

namespace ExploringXamarin.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}