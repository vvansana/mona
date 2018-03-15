using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using MonaLisaWebApi.Models;
using Owin;
using System.Web.Http;
using Microsoft.Owin.Security.OAuth;
using MonaLisaWebApi.Providers;

[assembly: OwinStartup(typeof(MonaLisaWebApi.Startup))]

namespace MonaLisaWebApi
{
    public partial class Startup
    {
        public void ConfigureAuth2(IAppBuilder app)
        {

            var OAuthOptions = new OAuthAuthorizationServerOptions
            {
                AllowInsecureHttp = true,
                TokenEndpointPath = new PathString("/token"),
                AccessTokenExpireTimeSpan = TimeSpan.FromMinutes(20),
                Provider = new ApplicationOAuthProvider("1")
            };

            app.UseOAuthBearerTokens(OAuthOptions);
            app.UseOAuthAuthorizationServer(OAuthOptions);
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());

            HttpConfiguration config = new HttpConfiguration();
            WebApiConfig.Register(config);
        }
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth2(app);
            ConfigureAuth(app);
         
           
        }
    }
}
