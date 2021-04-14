using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(nguyen_cake.Startup))]
namespace nguyen_cake
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
