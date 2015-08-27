using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DevOpsQuestioner.Startup))]
namespace DevOpsQuestioner
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
