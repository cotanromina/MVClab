using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCcourse8.Startup))]
namespace MVCcourse8
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
