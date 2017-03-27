using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FinalApplicationWithReviews.Startup))]
namespace FinalApplicationWithReviews
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
