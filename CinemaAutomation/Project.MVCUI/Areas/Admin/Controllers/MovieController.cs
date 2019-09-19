﻿using Project.BLL.RepositoryPattern.ConcreteRepository;
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
        public ActionResult MovieList()
        {
            return View(genrp.SelectActives());
        }
    }
}