using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjetRendezVous.Startup))]
namespace ProjetRendezVous
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
