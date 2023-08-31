using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebMVC.Data;
using WebMVC.Models;

namespace WebMVC.Controllers
{
    public class CustomerController : Controller
    {
        private readonly DataContext _context;

        public CustomerController(DataContext context)
        {
            _context = context;
        }

        // GET: Customer
        public async Task<IActionResult> Index()
        {
              return _context.CustomersModel != null ? 
                          View(await _context.CustomersModel.ToListAsync()) :
                          Problem("Entity set 'DataContext.CustomersModel'  is null.");
        }

        // GET: Customer/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.CustomersModel == null)
            {
                return NotFound();
            }

            var customersModel = await _context.CustomersModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customersModel == null)
            {
                return NotFound();
            }

            return View(customersModel);
        }

        // GET: Customer/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,Email,PhoneNumber,Address,DateOfBirths")] CustomersModel customersModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(customersModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(customersModel);
        }

        // GET: Customer/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.CustomersModel == null)
            {
                return NotFound();
            }

            var customersModel = await _context.CustomersModel.FindAsync(id);
            if (customersModel == null)
            {
                return NotFound();
            }
            return View(customersModel);
        }

        // POST: Customer/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,Email,PhoneNumber,Address,DateOfBirths")] CustomersModel customersModel)
        {
            if (id != customersModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customersModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomersModelExists(customersModel.Id))
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
            return View(customersModel);
        }

        // GET: Customer/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.CustomersModel == null)
            {
                return NotFound();
            }

            var customersModel = await _context.CustomersModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customersModel == null)
            {
                return NotFound();
            }

            return View(customersModel);
        }

        // POST: Customer/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.CustomersModel == null)
            {
                return Problem("Entity set 'DataContext.CustomersModel'  is null.");
            }
            var customersModel = await _context.CustomersModel.FindAsync(id);
            if (customersModel != null)
            {
                _context.CustomersModel.Remove(customersModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomersModelExists(int id)
        {
          return (_context.CustomersModel?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
