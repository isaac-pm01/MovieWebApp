using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieWebApp.Models;

namespace MovieWebApp.Controllers
{
    public class MovieController : Controller
    {
        private readonly MovieContext _context;

        public MovieController(MovieContext context) { _context = context; }

        [Route("movies")]
        public async Task<IActionResult> List()
        {
            var movies = await _context.Movies.ToListAsync(); 
            return View(movies);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var movieToDelete = await _context.Movies.FindAsync(id);
            return View(movieToDelete);
        }

        [HttpPost]
        public async Task<IActionResult>Delete(Movie movie)
        {
            _context.Movies.Remove(movie);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(List));
        }

        [HttpGet]
        public async Task<IActionResult> AddEdit(int id)
        {
            if (id == 0)
            {
                ViewBag.Operation = "Add";
                return View(new Movie());
            }
            ViewBag.Operation = "Edit";
            var movie = await _context.Movies.FindAsync(id);
            return View(movie);
            
        }

        [HttpPost]
        public async Task<IActionResult> AddEdit(Movie movie)
        {
            ViewBag.Operation = movie.ID == 0 ? "Add" : "Edit";

            if (ModelState.IsValid)
            {
                if (movie.ID == 0)
                {
                    _context.Add(movie);
                }
                else
                {
                    _context.Update(movie);
                }

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(List));
            }
            return View(movie);
        }
    }
}
