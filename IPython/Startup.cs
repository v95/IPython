using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IPython.Startup))]
namespace IPython
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
