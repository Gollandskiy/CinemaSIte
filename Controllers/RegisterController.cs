using CinemaSIte.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CinemaSIte.Controllers
{
    public class RegisterController : Controller
    {
        private readonly DataContext _context;

        public RegisterController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new UserClass
                {
                    Id = Guid.NewGuid(),
                    Username = model.Username,
                    Email = model.Email,
                    Password = model.Password,
                    Telephone = model.Telephone,
                    Age = model.Age,
                    RegistrationDate = DateTime.Now
                };

                _context.Users.Add(user);
                _context.SaveChanges();

                return RedirectToAction("Index", "General");
            }

            return View(model);
        }
    }
}