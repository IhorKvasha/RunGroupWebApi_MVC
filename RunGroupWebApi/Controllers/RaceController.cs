using Microsoft.AspNetCore.Mvc;
using RunGroupWebApi.Models;
using RunGroupWebApi.Data;

namespace RunGroopWebApp.Controllers
{
    public class RaceController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RaceController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Race> races = _context.Race.ToList();
            return View(races);
        }
    }
}