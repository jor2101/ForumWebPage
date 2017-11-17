using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ForumWebPage.Startup))]
namespace ForumWebPage
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
