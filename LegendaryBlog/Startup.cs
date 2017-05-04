using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LegendaryBlog.Startup))]
namespace LegendaryBlog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
