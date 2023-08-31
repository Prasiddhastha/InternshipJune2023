using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentWebs.Data;
using StudentWebs.Models;
using Microsoft.AspNetCore.Hosting;

namespace StudentWebs.Controllers
{
    public class StudentsController : Controller
    {
        private readonly DataContext _context;
        private readonly IWebHostEnvironment _environment;

        public StudentsController(DataContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        // GET: Students
        public async Task<IActionResult> Index()
        {
            var dataContext = _context.Students.Include(s => s.Faculty);
            return View(await dataContext.ToListAsync());
        }

        // GET: Students/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Students == null)
            {
                return NotFound();
            }

            var student = await _context.Students
                .Include(s => s.Faculty)
                .FirstOrDefaultAsync(m => m.StudentId == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // GET: Students/Create
        public IActionResult Create()
        {
            ViewData["FacultyId"] = new SelectList(_context.Facultys, "Id", "FacultyName");
            return View();
        }

        // POST: Students/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Student student)
        {
            DateTime eighteenYearsAgo = DateTime.Today.AddYears(-18);
            if (student.DateOfBirth.Date > eighteenYearsAgo || student.DateOfBirth.Date >= DateTime.Today.AddDays(1))
            {
                ModelState.AddModelError("DateOfBirth", "Date of birth Error!. Please Enter valid DOB");
            }
            bool isSymbolNoExists = _context.Students.Any(s => s.SymbolNo == student.SymbolNo);
            if (isSymbolNoExists)
            {
                ModelState.AddModelError("SymbolNo", "Symbol No already exists.");
            }
            if (ModelState.IsValid)
            {
                if (student != null)
                {
                    string uniqueFileName = UploadedFile(student);
                    student.ImagePath = uniqueFileName;
                }

                _context.Add(student);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FacultyId"] = new SelectList(_context.Facultys, "Id", "FacultyName", student.FacultyId);
            return View(student);
        }

        // GET: Students/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Students == null)
            {
                return NotFound();
            }

            var student = await _context.Students.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }
            ViewData["FacultyId"] = new SelectList(_context.Facultys, "Id", "FacultyName", student.FacultyId);
            return View(student);
        }

        // POST: Students/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Student student)
        {
            if (id != student.StudentId)
            {
                return NotFound();
            }
            if (student.DateOfBirth.Date > DateTime.Today)
            {
                ModelState.AddModelError("DateOfBirth", "Date of birth Error!.Please Enter Valid DOB");
            }

            var result = await _context.Students.FirstOrDefaultAsync(x => x.StudentId == student.StudentId);
            if(result.SymbolNo != student.SymbolNo)
            {
                bool isSymbolNoExists = _context.Students.Any(s => s.SymbolNo == student.SymbolNo);
                if (isSymbolNoExists)
                {
                    ModelState.AddModelError("SymbolNo", "Symbol No already exists.");
                }
            }
            if (student.Image == null)
            {

                student.ImagePath = result.ImagePath;

            }

            if (ModelState.IsValid)
            {
                if (student.Image != null)
                {
                    if (student != null)
                    {
                        string uniqueFileName = UploadedFile(student);
                        student.ImagePath = uniqueFileName;
                    }
                }
                try
                {
                    _context.Update(student);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentExists(student.StudentId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["FacultyId"] = new SelectList(_context.Facultys, "Id", "FacultyName", student.FacultyId);
            return View(student);
        }

        // GET: Students/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Students == null)
            {
                return NotFound();
            }

            var student = await _context.Students
                .Include(s => s.Faculty)
                .FirstOrDefaultAsync(m => m.StudentId == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // POST: Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Students == null)
            {
                return Problem("Entity set 'DataContext.Students'  is null.");
            }
            var student = await _context.Students.FindAsync(id);
            if (student != null)
            {
                _context.Students.Remove(student);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        private bool StudentExists(int id)
        {
          return (_context.Students?.Any(e => e.StudentId == id)).GetValueOrDefault();
        }
       public string UploadedFile(Student student)
        {
            string uniqueFileName = null;
            if(student.Image != null)
            {
                var uploadsFolder = Path.Combine(_environment.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + student.Image.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using(var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    student.Image.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }
    }
}
