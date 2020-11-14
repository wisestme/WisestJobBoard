using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JobberGuys.Startup))]
namespace JobberGuys
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
