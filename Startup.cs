using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AromaStock.Startup))]
namespace AromaStock
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
