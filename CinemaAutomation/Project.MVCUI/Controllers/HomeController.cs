using Project.BLL.RepositoryPattern.ConcreteRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.MVCUI.Controllers
{
    public class HomeController : Controller
    {
        AppUserRepository aprep;
        AppUserProfileRepository apdrep;
        public HomeController()
        {
            aprep = new AppUserRepository();
            apdrep = new AppUserProfileRepository();
        }
        // GET: Home
        public ActionResult Register()
        {
            return View();
        }
    }
}