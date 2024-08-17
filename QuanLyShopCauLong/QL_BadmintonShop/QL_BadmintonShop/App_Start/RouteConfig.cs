using QL_BadmintonShop.Models;
using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

//public QL_BadmintonShopDataContext() :
//						base(global::System.Configuration.ConfigurationManager.ConnectionStrings["QL_BadmintonShopConnectionString"].ConnectionString, mappingSource)

//        {
//    OnCreated();
//}
namespace QL_BadmintonShop
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
