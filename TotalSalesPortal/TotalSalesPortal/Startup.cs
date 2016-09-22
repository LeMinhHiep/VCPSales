using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TotalSalesPortal.Startup))]
namespace TotalSalesPortal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
