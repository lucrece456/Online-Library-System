﻿using System.Web;
using System.Web.Mvc;

namespace oNLINE_LIBRARY_SYSTEM
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
