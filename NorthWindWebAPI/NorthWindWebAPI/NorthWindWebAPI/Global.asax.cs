using NorthWInd.GenericRepository;
using NorthWindWebAPI.Business.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace NorthWindWebAPI
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Database.SetInitializer<NorhWindModel>(null);
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
