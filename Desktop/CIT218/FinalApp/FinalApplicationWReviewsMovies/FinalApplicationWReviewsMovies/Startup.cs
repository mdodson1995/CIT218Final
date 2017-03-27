using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FinalApplicationWReviewsMovies.Startup))]
namespace FinalApplicationWReviewsMovies
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
