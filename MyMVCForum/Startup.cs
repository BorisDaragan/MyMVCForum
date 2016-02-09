using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyMVCForum.Startup))]
namespace MyMVCForum
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
