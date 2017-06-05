using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StudentRegistrationTool.Startup))]
namespace StudentRegistrationTool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
