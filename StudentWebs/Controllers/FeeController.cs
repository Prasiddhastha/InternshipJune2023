using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentWebs.Data;
using StudentWebs.Models.Fee;
using StudentWebs.Models.ViewModel;

namespace StudentWebs.Controllers
{
    public class FeeController : Controller
    {
        private readonly DataContext _context;
        private readonly IWebHostEnvironment _environment;

        public FeeController(DataContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }
        public async Task<IActionResult> Index()
        {
            var dataContext = _context.Students.Include(s => s.Faculty);
            return View(await dataContext.ToListAsync());
        }

        public IActionResult CreateFee(int id)
        {
            var student = _context.Students.Find(id);
            if (student == null)
            {
                return NotFound();
            }

            var viewModel = new FeeCreateViewModel
            {
                StudentId = student.StudentId,
                FirstName = student.FirstName,
                LastName = student.LastName,
                SymbolNo = student.SymbolNo,
                ImagePath = student.ImagePath // Set the image path from the Student model
            };

            return View(viewModel);
        }
        [HttpPost]
        public IActionResult CreateFee(FeeCreateViewModel viewModel)
        {

            if (viewModel.Amount == 0.00m)
            {
                ModelState.AddModelError("Amount", "Please Enter Amount.");
            }

            var existingFee = _context.Fees.FirstOrDefault(f => f.StudentId == viewModel.StudentId && f.Semester == viewModel.Semester);
            if (existingFee != null)
            {
                ModelState.AddModelError("Semester", "A fee for this semester already exists for the selected student.");
            }

            viewModel.ImagePath = _context.Students
                            .Where(s => s.StudentId == viewModel.StudentId)
                            .Select(s => s.ImagePath)
                            .FirstOrDefault();


            if (ModelState.IsValid)
            {
                var data = new Fee()
                {
                    Semester = viewModel.Semester,
                    Amount = viewModel.Amount,
                    IsPaid = false, // fee not paid at time of creation
                    StudentId = viewModel.StudentId
                };

                _context.Fees.Add(data);
                _context.SaveChanges();

                return RedirectToAction("Index", "Fee", new { id = viewModel.StudentId });
            }

            return View(viewModel);

        }
        public IActionResult FeeStatus(int id)
        {
            var student = _context.Students.FirstOrDefault(s => s.StudentId == id);
            if (student == null)
            {
                return NotFound();
            }

            var fees = _context.Fees.Where(f => f.StudentId == id).ToList();

            var viewModel = new FeeStatusViewModel
            {
                StudentId = student.StudentId,
                FirstName = student.FirstName,
                LastName = student.LastName,
                SymbolNo = student.SymbolNo,
                ImagePath = student.ImagePath,

                Fees = _context.Fees.Where(f => f.StudentId == id)
                    .Select(f => new FeeViewModel
                    {
                        Id = f.Id,
                        Semester = f.Semester,
                        Amount = f.Amount,
                        IsPaid = f.IsPaid
                    })
                    .ToList()
            };

            return View(viewModel);
        }



        [HttpPost]
        public IActionResult ClearDue(int id, decimal amount)
        {
            var fee = _context.Fees.FirstOrDefault(f => f.Id == id);
            if (fee == null)
            {
                return NotFound();
            }

            if (amount <= 0)
            {
                ModelState.AddModelError("amount", "Amount must be greater than 0.");
                return Json(new { success = false, message = "Amount must be greater than 0." });
            }

            fee.Amount -= amount;//deduct amount
            if (fee.Amount < 0)
            {
                ModelState.AddModelError("amount", "Amount cannot exceed the due amount.");
                return Json(new { success = false, message = "Amount cannot exceed the due amount." });
            }

            fee.IsPaid = fee.Amount == 0;

            if (fee.IsPaid)
            {
                fee.IsPaid = true;
            }

            _context.Fees.Update(fee);
            _context.SaveChanges();
           
            return Json(new { success = true, message = "Hello", newAmount = fee.Amount, isPaid = fee.IsPaid });


        }
    }
}
