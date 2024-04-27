using Microsoft.AspNetCore.Mvc;
using CinemaSIte.Models;
using System.Linq;

namespace CinemaSIte.Controllers
{
    public class AdminController : Controller
    {
        private readonly DataContext _context;

        public AdminController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var users = _context.Users.ToList();
            var films = _context.Films.ToList();

            ViewBag.Users = users;
            ViewBag.Films = films;

            return View();
        }

        [HttpPost]
        public IActionResult DeleteUser(Guid userId)
        {
            var userToDelete = _context.Users.FirstOrDefault(u => u.Id == userId);
            if (userToDelete != null)
            {
                _context.Users.Remove(userToDelete);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult DeleteFilm(Guid filmId)
        {
            var filmToDelete = _context.Films.FirstOrDefault(f => f.Id == filmId);
            if (filmToDelete != null)
            {
                _context.Films.Remove(filmToDelete);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult EditUser(IFormCollection form)
        {
            var userId = Guid.Parse(form["userId"]);
            var existingUser = _context.Users.FirstOrDefault(u => u.Id == userId);
            if (existingUser != null)
            {
                existingUser.Username = form["username"];
                existingUser.Email = form["email"];
                existingUser.Telephone = form["telephone"];
                existingUser.Age = int.Parse(form["age"]);

                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult EditFilm(IFormCollection form)
        {
            var filmId = Guid.Parse(form["filmId"]);
            var existingFilm = _context.Films.FirstOrDefault(f => f.Id == filmId);
            if (existingFilm != null)
            {
                existingFilm.Title = form["title"];
                existingFilm.Director = form["director"];
                existingFilm.Genre = form["genre"];
                existingFilm.DurationMinutes = int.Parse(form["durationMinutes"]);
                existingFilm.ReleaseDate = DateTime.Parse(form["releaseDate"]);
                existingFilm.ImageUrl = form["imageUrl"];
                existingFilm.VideoUrl = form["videoUrl"];

                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}
