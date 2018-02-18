using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using MonaLisaWebApi.Models;
using Owin;

[assembly: OwinStartup(typeof(MonaLisaWebApi.Startup))]

namespace MonaLisaWebApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
         
           
        }
    }
}
