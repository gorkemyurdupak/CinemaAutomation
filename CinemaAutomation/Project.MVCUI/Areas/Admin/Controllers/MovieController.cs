using Project.BLL.RepositoryPattern.ConcreteRepository;
using Project.MODEL.Entities;
using Project.MVCUI.AuthenticationClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.MVCUI.Areas.Admin.Controllers
{
    [AdminAuthentication]
    public class MovieController : Controller
    {
        MovieRepository movp;
        GenreRepository genrp;

        public MovieController()
        {
            movp = new MovieRepository();
            genrp = new GenreRepository();
        }
        public ActionResult GenreList()
        {
            return View(genrp.SelectActives());
        }
        public ActionResult AddGenre()
        {
            return View(new Genre());
        }
        [HttpPost]
        public ActionResult AddGenre( Genre item ) 
        {
            genrp.Add(item);
            return RedirectToAction("GenreList");
        }
        public ActionResult DeleteGenre(int id)
        {
            genrp.Delete(genrp.GetByID(id));
            return RedirectToAction("GenreList");
        }
        public ActionResult UpdateGenre(int id)
        {
            return View(genrp.GetByID(id));
        }
        [HttpPost]
        public ActionResult UpdateGenre(Genre item)
        {
           
            genrp.Update(item);
            return RedirectToAction("GenreList");
        }


    }
}