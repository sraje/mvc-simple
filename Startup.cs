using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvc_simple.Startup))]
namespace mvc_simple
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
