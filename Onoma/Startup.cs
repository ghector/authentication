using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Onoma.Startup))]
namespace Onoma
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
