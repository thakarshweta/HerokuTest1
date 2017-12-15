using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Herokutest1.Startup))]
namespace Herokutest1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
