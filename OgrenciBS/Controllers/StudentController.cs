using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OgrenciBS.Models;

namespace OBS.Controllers
{
    public class StudentController : Controller
    {
        private readonly Data.AppDbContext _context;

        public StudentController(Data.AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Student.Include(x => x.Department).ToList());
        }

        public IActionResult Create()
        {
            ViewBag.BolumListesi = new SelectList(_context.Department.ToList(), "Id", "Name");

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Student s)
        {
            ViewBag.BolumListesi = new SelectList(_context.Department.ToList(), "Id", "Name");

            if (ModelState.IsValid)
            {
                _context.Add(s);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            // Hatalı girişte view tekrar yüklenecek, bu yüzden tekrar ViewBag doldurulmalı
            ViewBag.BolumListesi = new SelectList(_context.Department.ToList(), "Id", "Name");
            return View(s);
        }

        public IActionResult Edit(int? id)
        {
            if (id is not null)
            {
                ViewBag.BolumListesi = _context.Department.ToList();
                var ogr = _context.Student.Where(x => x.Id == id).SingleOrDefault();
                return View(ogr);
            }
            else
            {
                return RedirectToAction("Index");
            }

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Student s)
        {
            ViewBag.BolumListesi = _context.Department.ToList();

            if (ModelState.IsValid)
            {
                _context.Update(s);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }


        }
    }
}
