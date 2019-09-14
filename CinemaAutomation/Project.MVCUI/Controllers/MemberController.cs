using Project.BLL.RepositoryPattern.ConcreteRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.MVCUI.Controllers
{
    public class MemberController : Controller
    {
        MovieRepository movp;
        GenreRepository genrp;
        // GET: Member
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Movies()
        {
            return View();
        }
        public ActionResult ContactUs()
        {
            return View();
        }
        public ActionResult SingleMovie()
        {
            return View();
        }
        public ActionResult GetByGenres(int id)
        {
            return View(Tuple.Create(movp.Where(x => x.GenreID == id), genrp.SelectActives()));
        }
    }
}