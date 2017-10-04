using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JabberJaw.Startup))]
namespace JabberJaw
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
