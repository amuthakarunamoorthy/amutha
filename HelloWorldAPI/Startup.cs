using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HelloWorldAPI.Startup))]
namespace HelloWorldAPI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
