using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DemoMvc.Data;
using PTPMQL;

namespace DemoMvc.Controllers
{
    public class EmployeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmployeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Employe
        public async Task<IActionResult> Index()
        {
            return View(await _context.Employe.ToListAsync());
        }

        // GET: Employe/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employe = await _context.Employe
                .FirstOrDefaultAsync(m => m.cancuoccongdan == id);
            if (employe == null)
            {
                return NotFound();
            }

            return View(employe);
        }

        // GET: Employe/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Employe/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("cancuoccongdan,hoten,quequan")] Employe employe)
        {
            if (ModelState.IsValid)
            {
                _context.Add(employe);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(employe);
        }

        // GET: Employe/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employe = await _context.Employe.FindAsync(id);
            if (employe == null)
            {
                return NotFound();
            }
            return View(employe);
        }

        // POST: Employe/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("cancuoccongdan,hoten,quequan")] Employe employe)
        {
            if (id != employe.cancuoccongdan)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employe);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeExists(employe.cancuoccongdan))
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
            return View(employe);
        }

        // GET: Employe/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employe = await _context.Employe
                .FirstOrDefaultAsync(m => m.cancuoccongdan == id);
            if (employe == null)
            {
                return NotFound();
            }

            return View(employe);
        }

        // POST: Employe/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var employe = await _context.Employe.FindAsync(id);
            if (employe != null)
            {
                _context.Employe.Remove(employe);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeExists(string id)
        {
            return _context.Employe.Any(e => e.cancuoccongdan == id);
        }
    }
}
