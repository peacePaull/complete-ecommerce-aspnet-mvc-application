using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class MoviesControllers : Controller
    {
        private readonly AppDbContext _context;

        public MoviesControllers(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
             var data = _context.Movies.ToListAsync();
            return View();
        }
    }
}
