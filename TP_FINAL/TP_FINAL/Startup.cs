using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TP_FINAL.Startup))]
namespace TP_FINAL
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
