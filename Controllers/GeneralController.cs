using Microsoft.AspNetCore.Mvc;
using CinemaSIte.Models;
using System.Linq;

namespace CinemaSIte.Controllers
{
    public class GeneralController : Controller
    {
        private readonly DataContext _context;

        public GeneralController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var films = _context.Films.ToList();

            return View(films);
        }
        public IActionResult Details(Guid id)
        {
            var film = _context.Films.FirstOrDefault(f => f.Id == id);

            if (film == null)
            {
                return NotFound();
            }

            return View(film);
        }
    }
}