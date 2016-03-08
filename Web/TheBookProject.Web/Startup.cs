using Microsoft.Owin;

using Owin;

[assembly: OwinStartupAttribute(typeof(TheBookProject.Web.Startup))]

namespace TheBookProject.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            this.ConfigureAuth(app);
        }
    }
}
