using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PatientProfile.Startup))]
namespace PatientProfile
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
