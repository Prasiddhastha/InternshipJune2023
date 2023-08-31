using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using StudentWebs.Data;
using StudentWebs.Models;

namespace StudentWebs.Controllers
{
    public class TeachersController : Controller
    {
        private readonly DataContext _context;
        private readonly IWebHostEnvironment _environment;

        public TeachersController(DataContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }
        
        // GET: Teachers
        public async Task<IActionResult> Index()
        {
            var dataContext = _context.Teachers.Include(t => t.Faculty);
            return View(await dataContext.ToListAsync());
        }

        // GET: Teachers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Teachers == null)
            {
                return NotFound();
            }

            var teacher = await _context.Teachers
                .Include(t => t.Faculty)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (teacher == null)
            {
                return NotFound();
            }

            return View(teacher);
        }

        // GET: Teachers/Create
        public IActionResult Create()
        {
            ViewData["FacultyId"] = new SelectList(_context.Facultys, "Id", "FacultyName");
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( Teacher teacher)
        {
            bool isHodExist = _context.Teachers.Any(s => s.FacultyId == teacher.FacultyId);

            if (isHodExist)
            {
                ModelState.AddModelError("FacultyId", "HOD of this faculty already exists.");
            }

            if (ModelState.IsValid)
            {

                if (teacher != null)
                {
                    string uniqueFileName = UploadedFile(teacher);
                   teacher.ImagePath = uniqueFileName;
                }
                _context.Add(teacher);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FacultyId"] = new SelectList(_context.Facultys, "Id", "FacultyName", teacher.FacultyId);
            return View(teacher);
        }

        // GET: Teachers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Teachers == null)
            {
                return NotFound();
            }

            var teacher = await _context.Teachers.FindAsync(id);
            if (teacher == null)
            {
                return NotFound();
            }
            ViewData["FacultyId"] = new SelectList(_context.Facultys, "Id", "FacultyName", teacher.FacultyId);
            return View(teacher);
        }

        // POST: Teachers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,  Teacher teacher)
        {

            if (id != teacher.Id)
            {
                return NotFound();
            }
            var result = await _context.Teachers.FirstOrDefaultAsync(x => x.Id == teacher.Id);
            if (result.FacultyId != teacher.FacultyId)
            {
                bool isHodExist = _context.Teachers.Any(s => s.FacultyId == teacher.FacultyId);

                if (isHodExist)
                {
                    ModelState.AddModelError("FacultyId", "HOD of this faculty already exists.");
                }
            }
            if (teacher.Image == null)
            {

                teacher.ImagePath = result.ImagePath;

            }
            

            if (ModelState.IsValid)
            {
                if (teacher.Image != null)
                {
                    if (teacher != null)
                    {
                        string uniqueFileName = UploadedFile(teacher);
                        teacher.ImagePath = uniqueFileName;
                    }
                }
                try
                {
                    _context.Update(teacher);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TeacherExists(teacher.Id))
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
            ViewData["FacultyId"] = new SelectList(_context.Facultys, "Id", "FacultyName", teacher.FacultyId);
            return View(teacher);
        }

        // GET: Teachers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Teachers == null)
            {
                return NotFound();
            }

            var teacher = await _context.Teachers
                .Include(t => t.Faculty)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (teacher == null)
            {
                return NotFound();
            }

            return View(teacher);
        }

        // POST: Teachers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Teachers == null)
            {
                return Problem("Entity set 'DataContext.Teachers'  is null.");
            }
            var teacher = await _context.Teachers.FindAsync(id);
            if (teacher != null)
            {
                _context.Teachers.Remove(teacher);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TeacherExists(int id)
        {
          return (_context.Teachers?.Any(e => e.Id == id)).GetValueOrDefault();
        }
        public string UploadedFile(Teacher teacher)
        {
            string uniqueFileName = null;
            if (teacher.Image != null)
            {
                var uploadsFolder = Path.Combine(_environment.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + teacher.Image.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    teacher.Image.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }
    }
}
