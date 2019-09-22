using Project.BLL.RepositoryPattern.ConcreteRepository;
using Project.COMMON.Tools;
using Project.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.MVCUI.Areas.Admin.Controllers
{
    public class RealMovieController : Controller
    {
        MovieRepository movp;
        GenreRepository genrp;
        public RealMovieController()
        {
            movp = new MovieRepository();
            genrp = new GenreRepository();
        }
        // GET: Admin/RealMovie
        public ActionResult MovieList()
        {
            return View(movp.SelectActives());
        }
        public ActionResult AddMovie()
        {
            return View(Tuple.Create(genrp.SelectActives(), new Movie()));
        }
        [HttpPost]
        public ActionResult AddMovie([Bind(Prefix = "Item2")] Movie item, HttpPostedFileBase resim)
        {
            item.ImagePath = ImageUploader.UploadImage("~/Pictures/", resim);
            movp.Add(item);
            return RedirectToAction("MovieList");
        }
        public ActionResult MovieDetail(int id)
        {
            return View(movp.Default(x => x.MovieID == id));
        }
        public ActionResult DeleteMovie(int id)
        {
            movp.Delete(movp.GetByID(id));
            return RedirectToAction("MovieList");
        }
        public ActionResult UpdateMovie(int id)
        {
            return View(Tuple.Create(genrp.SelectActives(), movp.GetByID(id)));
        }
        [HttpPost]
        public ActionResult UpdateMovie([Bind(Prefix = "Item2")] Movie item, HttpPostedFileBase resim, string resimSil)
        {
            if (resimSil == "true")
            {
                item.ImagePath = "Dosya boş";
            }
            else
            {

                if (resim == null)
                {
                    Movie tempMovie = movp.GetByID(item.MovieID);
                    item.ImagePath = tempMovie.ImagePath;

                }
                else
                {
                    item.ImagePath = ImageUploader.UploadImage("~/Pictures/", resim);
                }
            }

            movp.Update(item);
            return RedirectToAction("MovieList");
        }
    
    }
}