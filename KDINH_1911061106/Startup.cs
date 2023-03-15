using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KDINH_1911061106.Startup))]
namespace KDINH_1911061106
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
