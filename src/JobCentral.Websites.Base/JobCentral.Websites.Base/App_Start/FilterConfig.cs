﻿using System.Web;
using System.Web.Mvc;

namespace JobCentral.Websites.Base
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
