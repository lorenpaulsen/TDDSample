using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebServiceClient.Web.Startup))]
namespace WebServiceClient.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
