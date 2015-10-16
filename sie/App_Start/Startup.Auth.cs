using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;

namespace sie
{
    public partial class Startup {

        
        public void ConfigureAuth(IAppBuilder app)
        {
            
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Account/Login")
            });
            app.UseExternalSignInCookie(DefaultAuthenticationTypes.ExternalCookie);

            //app.UseMicrosoftAccountAuthentication(
            //    clientId: "",
            //    clientSecret: "");
            app.UseFacebookAuthentication(
            appId: "164036663938806",
              appSecret: "6ce61a03d40570e8734a18f952a3331c");

            app.UseGoogleAuthentication(
                clientId: "217098232518-49mp60tvep8t0lv8cu7u5o4f3c8j096e.apps.googleusercontent.com",
                clientSecret: "3IvKEq3xS3UOydx7i4X0JhoZ");
        }
    }
}
