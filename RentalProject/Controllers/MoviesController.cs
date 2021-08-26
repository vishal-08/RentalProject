using RentalProject.Models;
using RentalProject.ViewModels;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentalProject.Controllers
{
    public class MoviesController : Controller
    {
        private DBContext _context;
        public MoviesController()
        {
            _context = new DBContext();
        }
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
        public ActionResult New()
        {
            var genres = _context.Genres.ToList();
            var viewModel = new NewMovieViewModel
            {
                Genres = genres
            };
            return View(viewModel);
        }
        [HttpPost]
        public ActionResult Save(Movie movie)
        {
            if(movie.Id == 0)
            {
                movie.AddedDate = DateTime.Now;
                _context.Movies.Add(movie);
            }
            else
            {
                var moviesInDb = _context.Movies.Single(m => m.Id == movie.Id);

                moviesInDb.Name = movie.Name;
                moviesInDb.ReleaseDate = movie.ReleaseDate;
                moviesInDb.GenreId = movie.GenreId;
                moviesInDb.NumberInStock = movie.NumberInStock;
            }
            
            _context.SaveChanges();
            return RedirectToAction("Index", "Movies");
        }
        public ActionResult Edit(int Id)

        {
            var movies = _context.Movies.SingleOrDefault(m => m.Id == Id);

            if(movies == null)
                return HttpNotFound();

            var viewModel = new NewMovieViewModel
            {
                Movie = movies,
                Genres = _context.Genres.ToList()
            };
            return View("New", viewModel);
        }

        [Route("movies/released/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year +"/" + month);
        }
        public ActionResult Index()
        {
            var movie = _context.Movies.Include(m => m.Genre).ToList();
           
            return View(movie);
        }
        public ActionResult Detail(int Id)
        {
            var movies = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == Id);
            if (movies == null)
            {
                return HttpNotFound();
            }
            return View(movies); //return in view
        }
        //GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Deadpool !!" };
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
    }
}