using Project.BLL.RepositoryPattern.ConcreteRepository;
using Project.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.MVCUI.Areas.Admin.Controllers
{
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
            movp.Delete(movp.GetByID(id));
            return RedirectToAction("GenreList");
        }
        
    
    }
}