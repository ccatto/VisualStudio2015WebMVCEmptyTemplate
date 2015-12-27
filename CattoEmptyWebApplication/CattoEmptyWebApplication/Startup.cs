using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CattoEmptyWebApplication.Startup))]
namespace CattoEmptyWebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
