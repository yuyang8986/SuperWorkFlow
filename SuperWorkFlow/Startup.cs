using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SuperWorkFlow.Startup))]
namespace SuperWorkFlow
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
