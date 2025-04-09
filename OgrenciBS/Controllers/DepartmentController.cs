using Microsoft.AspNetCore.Mvc;
using OgrenciBS.Models;


namespace OBS.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly Data.AppDbContext _context;

        public DepartmentController(Data.AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var bolumListesi = _context.Department.ToList();
            return View(bolumListesi);
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Department d)
        {
            if (ModelState.IsValid)
            {
                _context.Add(d);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
