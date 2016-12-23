using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EmotionsWeb.Startup))]
namespace EmotionsWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
