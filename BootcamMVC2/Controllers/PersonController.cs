using BootcamMVC2.Data;
using BootcamMVC2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootcamMVC2.Controllers
{
    public class PersonController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PersonController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var people = _context.Person.ToList();
            return View(people);
        }

        public IActionResult Create()
        {
            ViewData["Genres"] = new SelectList(_context.Genre.ToList(), "Id", "Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Person person)
        {
            if (ModelState.IsValid)
            {
                _context.Person.Add(person);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            ViewData["Genres"] = new SelectList(_context.Genre.ToList(), "Id", "Name");
            return View(person);
        }

        
        public IActionResult Edit(int id)
        {
            ViewData["Genres"] = new SelectList(_context.Genre.ToList(), "Id", "Name");

            var person = _context.Person.Find(id);

            if (person == null)
            {
                return NotFound();
            }

            return View(person);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Person person)
        {
            if (ModelState.IsValid)
            {
                _context.Person.Update(person);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            ViewData["Genres"] = new SelectList(_context.Genre.ToList(), "Id", "Name");
            return View(person);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            var person = _context.Person.Find(id);

            if (person == null)
            {
                return NotFound();
            }
            _context.Remove(person);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }


    }
}
