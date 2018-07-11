using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using Vidly_MVC.Models;
using Vidly_MVC.ViewModels;

namespace Vidly_MVC.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
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
        public ActionResult Create(Movie movie)
        {
            _context.Movies.Add(movie);

            _context.SaveChanges();
            return RedirectToAction("Index", "Movies");
        }
        // GET: Movies
        public ActionResult Index()
        {
            var movies = _context.Movies.Include(m => m.Genre).ToList();
            return View(movies);
        }

        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        public ActionResult Save()
        {
            throw new System.NotImplementedException();
        }
    }
}