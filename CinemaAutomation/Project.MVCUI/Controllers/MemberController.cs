using PagedList;
using Project.BLL.RepositoryPattern.ConcreteRepository;
using Project.MODEL.Entities;
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

        public MemberController()
        {
            movp = new MovieRepository();
            genrp = new GenreRepository();
        }
        // GET: Member
        public ActionResult Index(int? page)
        {
            return View(movp.SelectActives());
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Movies(int? page)
        {
            return View(Tuple.Create(genrp.SelectActives(), movp.SelectActives().ToPagedList(page ?? 1, 9)));
        }
        public ActionResult ContactUs()
        {
            return View();
        }
        public ActionResult SingleMovie(int id)
        {
            return View(movp.Default(x => x.MovieID == id));
        }
        public ActionResult GetByGenres(int id,int? page)
        {
            return View(Tuple.Create(movp.Where(x => x.GenreID == id).ToPagedList(page ?? 1, 9), genrp.SelectActives()));
        }

    }
}