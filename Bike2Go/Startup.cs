using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bike2Go.Startup))]
namespace Bike2Go
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
