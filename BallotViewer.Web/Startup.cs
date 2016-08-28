using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BallotViewer.Web.Startup))]
namespace BallotViewer.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
