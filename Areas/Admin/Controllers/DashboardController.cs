using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using web_exam.DAL;
using web_exam.Models;

namespace web_exam.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        private readonly AppDbContext _context;

        public DashboardController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<Worker> workers = await _context.Workers.ToListAsync();

            return View(workers);
        }
    }
}
