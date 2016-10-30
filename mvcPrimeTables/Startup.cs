using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvcPrimeTables.Startup))]
namespace mvcPrimeTables
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
