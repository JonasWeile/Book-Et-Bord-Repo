using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCBookBord.Startup))]
namespace MVCBookBord
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
