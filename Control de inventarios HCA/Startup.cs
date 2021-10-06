using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Control_de_inventarios_HCA.Startup))]
namespace Control_de_inventarios_HCA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
