using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.MVCUI.AuthenticationClasses
{
    public class SuperAdminAuthentication:AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            if (httpContext.Session["SuperAdmin"] != null)
            {
                return true;
            }
            httpContext.Response.Redirect("/Admin/RealMovie/MovieList");
            return false;
        }
    }
}