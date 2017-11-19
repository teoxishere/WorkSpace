using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DrugStoreReloaded.Startup))]
namespace DrugStoreReloaded
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
