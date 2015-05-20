using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PublicadorFbk.Startup))]
namespace PublicadorFbk
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
