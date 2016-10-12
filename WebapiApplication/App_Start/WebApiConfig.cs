﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Net.Http;
using System.Net.Http.Headers;

namespace WebapiApplication.App_Start
{
    public class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
           
            config.Routes.MapHttpRoute(
                    name: "DefaultApi",
                    routeTemplate: "api/{controller}/{action}/{id}/{TypeOfReport}/{pagefrom}/{pageto}",
                    defaults: new { id = RouteParameter.Optional }
                           );

        }
    }
}