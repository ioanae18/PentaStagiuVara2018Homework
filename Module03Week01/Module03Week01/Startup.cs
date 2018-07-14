using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Module03Week01.Startup))]
namespace Module03Week01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
