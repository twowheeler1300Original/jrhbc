using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JamesRiverHBC.Startup))]
namespace JamesRiverHBC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
