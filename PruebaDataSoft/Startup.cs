using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PruebaDataSoft.Startup))]
namespace PruebaDataSoft
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
