using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BookManage1.Startup))]
namespace BookManage1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
