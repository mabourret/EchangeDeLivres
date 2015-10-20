using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EchangeDeLivres.Startup))]
namespace EchangeDeLivres
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
