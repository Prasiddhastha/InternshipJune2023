using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudentWebs.Data;
using StudentWebs.Models;
using StudentWebs.Models.ViewModel;
using System.Diagnostics;

namespace StudentWebs.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly DataContext _context;
        

       
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, DataContext context)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            int facultyCount = _context.Facultys.Count();
            int studentCount = _context.Students.Count();
            int teacherCount = _context.Teachers.Count();
            var viewModel = new CountViewModel
            {
                FacultyCount = facultyCount,
                StudentCount = studentCount,
                TeacherCount = teacherCount
            };

            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}