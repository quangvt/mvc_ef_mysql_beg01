﻿using System.Web;
using System.Web.Mvc;

namespace mvc_ef_mysql_beg01
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
