using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(testGIT.Startup))]
namespace testGIT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
