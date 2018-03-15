using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PostingAdmin.Startup))]
namespace PostingAdmin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
