using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WorkoutWeekly.WebMVC.Startup))]
namespace WorkoutWeekly.WebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
