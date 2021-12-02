using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASP.NET_MVC_Application.Startup))]
namespace ASP.NET_MVC_Application
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //this is main file
            //checking the prvious changes
            ConfigureAuth(app);
        }
    }
}
