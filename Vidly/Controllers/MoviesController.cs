using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        public ActionResult Index()
        {
            var movies = new List<Movie>
            {
                new Movie{ Name = "Movie 1" },
                new Movie{ Name = "Movie 2" }
            };

            var viewModel = new MoviesViewModel

            {
                Movies = movies
            };
            return View(viewModel);
        }

        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek" };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
            };

            return View(viewModel);
        }



        //[Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]

        //public ActionResult ByReleaseDate(int year, int month)
        //{
        //    return Content(year + "/" + month);
        //}


        //public ActionResult Edit(int id)
        //{
        //    return Content("id=" + id);
        //}

        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if (!pageIndex.HasValue)
        //    {
        //        pageIndex = 1;
        //    }

        //    if (String.IsNullOrWhiteSpace(sortBy))
        //    {
        //        sortBy = "Name";
        //    }

        //    return Content($"pageIndex={pageIndex}&sortBy={sortBy}");
        //}


    }
}