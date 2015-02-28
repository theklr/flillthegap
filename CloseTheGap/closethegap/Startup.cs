using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(closethegap.Startup))]
namespace closethegap
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
