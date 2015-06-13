using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(tanerBlog.Startup))]
namespace tanerBlog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
