using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hangman_WebForms.Startup))]
namespace Hangman_WebForms
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
