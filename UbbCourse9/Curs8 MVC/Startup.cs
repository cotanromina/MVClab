﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Curs8_MVC.Startup))]
namespace Curs8_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
