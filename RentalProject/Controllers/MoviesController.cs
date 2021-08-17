using RentalProject.Models;
using RentalProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentalProject.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() {Name = "Deadpool !!" };
            var customer = new List<Customer>
            {
                new Customer {Name = "Amit"},
                new Customer {Name = "Anuj"}
            };
            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customer = customer
            };
            return View(viewModel);
        }
        public ActionResult Edit(int Id)
        {
            return Content("Id = " +Id);
        }

        [Route("movies/released/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year +"/" + month);
        }
        public ActionResult Index()
        {
            var movie = new List<Movie> 
            {
                new Movie { Name = "Deadpool !!" },
                new Movie { Name = "Iron Man !!" },
                new Movie { Name = "Thor !!" },
            };
            return View(movie);
        }
    }
}