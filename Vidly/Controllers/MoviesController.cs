using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        //GET: Movies
        public ActionResult Index()
        {
            var movies = new List<Movie> { 
                new Movie {Name = "Shrek!"},
                new Movie() {Name = "Titanic"}
                };

            return View(movies);
        }
    }
}