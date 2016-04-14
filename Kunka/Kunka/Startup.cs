using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Kunka.Startup))]
namespace Kunka
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
