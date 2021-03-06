﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Microsoft.AspNet.FriendlyUrls;

namespace MvcApplication2
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // Manually created webforms routes. I'll prefer to use FriendlyUrls
            //RouteTable.Routes.MapPageRoute("TouristAttraction", "WF", "~/WebForms/Default.aspx");
            //RouteTable.Routes.MapPageRoute("TouristAttraction2", "WF/Attraction", "~/WebForms/Default.aspx");
            //RouteTable.Routes.MapPageRoute("TouristAttractionNew", "WF/Attraction/Create", "~/WebForms/Create.aspx");
            //RouteTable.Routes.MapPageRoute("TouristAttractionEdit", "WF/Attraction/Edit/{id}", "~/WebForms/Edit.aspx");
            //RouteTable.Routes.MapPageRoute("TouristAttractionDelete", "WF/Attraction/Delete/{id}", "~/WebForms/Delete.aspx");
            //RouteTable.Routes.MapPageRoute("TouristAttractionDetails", "WF/Attraction/Details/{id}", "~/WebForms/Details.aspx");
  
            //MVC will be for MVC, while WebForms is under /WebForms/ using Friendly URLs
            routes.MapRoute(
                name: "Default",
                url: "MVC/{controller}/{action}/{id}",
                defaults: new { controller = "Attraction", action = "Index", id = UrlParameter.Optional }
            );

            routes.EnableFriendlyUrls();
        }
    }
}