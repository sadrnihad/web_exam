using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using web_exam.Areas.Admin.ViewModels;
using web_exam.DAL;
using web_exam.Models;

namespace web_exam.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class WorkerController : Controller
    {
        private readonly AppDbContext _context;

        public WorkerController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<Worker> workers = await _context.Workers.ToListAsync();

            return View(workers);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpGet]

        public async Task<IActionResult> Create(CreateWorkerVm createWorkerVm)
        {


            if(!ModelState.IsValid)
            {
                return View(createWorkerVm);
            }

            Worker worker = new Worker()
            {
                Fullname = createWorkerVm.Fullname,
                Designation = createWorkerVm.Designation,
                //Imageurl = createWorkerVm.ImageUrl
            };
            await _context.Workers.AddAsync(worker);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Dashboard");



        }

        public IActionResult Edit()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }
            Worker? worker = await _context.Workers.FindAsync(id);

            if (worker == null)
            {
                return NotFound();
            }

            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Dashboard");
        }





        public IActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            Worker? worker = await _context.Workers.FindAsync(id);
            if (worker == null)
            {
                return NotFound();
            }
            _context.Workers.Remove(worker);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Dashboard");
        }
    }
}
