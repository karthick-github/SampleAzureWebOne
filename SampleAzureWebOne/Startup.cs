using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SampleAzureWebOne.Startup))]
namespace SampleAzureWebOne
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
