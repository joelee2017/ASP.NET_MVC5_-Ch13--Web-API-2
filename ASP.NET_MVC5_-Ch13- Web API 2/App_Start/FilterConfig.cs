﻿using System.Web;
using System.Web.Mvc;

namespace ASP.NET_MVC5__Ch13__Web_API_2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
