using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication4.Data;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class SlotsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SlotsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Slots
        public async Task<IActionResult> Index(string sortOrder, string searchString)
        {
            ViewData["StatusSortParm"] = String.IsNullOrEmpty(sortOrder) ? "status_desc" : "";
            ViewData["CreditSortParm"] = sortOrder == "Credits" ? "credit_desc" : "Credits";
            ViewData["TermsSortParm"] = sortOrder == "Terms" ? "term_desc" : "Term";
            ViewData["DegreePlanParm"] = sortOrder == "DegreePlans" ? "degreeplan_desc" : "Degreeplan";

            ViewData["CurrentFilter"] = searchString;
            var slots = from s in _context.Slots
                        select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                slots = slots.Where(s => s.Term.ToString().Contains(searchString)
                                 || s.CreditID.ToString().Contains(searchString));
            }
            switch (sortOrder)
            {
                case "status_desc":
                    slots = slots.OrderByDescending(s => s.Status);
                    break;
                case "credit_desc":
                    slots = slots.OrderBy(s => s.CreditID);
                    break;
                case "term_desc":
                    slots = slots.OrderByDescending(s => s.Term);
                    break;
                case "Credits":
                    slots = slots.OrderBy(s => s.CreditID);
                    break;
                case "Term":
                    slots = slots.OrderByDescending(s => s.Term);
                    break;
                case "DegreePlan":
                    slots = slots.OrderByDescending(s => s.DegreePlan);
                    break;
                default:
                    slots = slots.OrderBy(s => s.SlotID);
                    break;
            }
            //  var applicationDbContext = _context.Slots.Include(s => s.SlotId).Include(s => s.DegreePlan);
            //return View(await applicationDbContext.ToListAsync());
            return View(await slots.AsNoTracking().ToListAsync());
        }

        // GET: Slots/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var slot = await _context.Slots
                .Include(s => s.Credit)
                .Include(s => s.DegreePlan)
                .FirstOrDefaultAsync(m => m.SlotID == id);
            if (slot == null)
            {
                return NotFound();
            }

            return View(slot);
        }

        // GET: Slots/Create
        public IActionResult Create()
        {
            ViewData["CreditID"] = new SelectList(_context.Credits, "CreditID", "CreditID");
            ViewData["DegreePlanID"] = new SelectList(_context.DegreePlans, "DegreePlanID", "DegreePlanID");
            return View();
        }

        // POST: Slots/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SlotID,DegreePlanID,Term,CreditID,Status")] Slot slot)
        {
            if (ModelState.IsValid)
            {
                _context.Add(slot);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CreditID"] = new SelectList(_context.Credits, "CreditID", "CreditID", slot.CreditID);
            ViewData["DegreePlanID"] = new SelectList(_context.DegreePlans, "DegreePlanID", "DegreePlanID", slot.DegreePlanID);
            return View(slot);
        }

        // GET: Slots/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var slot = await _context.Slots.FindAsync(id);
            if (slot == null)
            {
                return NotFound();
            }
            ViewData["CreditID"] = new SelectList(_context.Credits, "CreditID", "CreditID", slot.CreditID);
            ViewData["DegreePlanID"] = new SelectList(_context.DegreePlans, "DegreePlanID", "DegreePlanID", slot.DegreePlanID);
            return View(slot);
        }

        // POST: Slots/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SlotID,DegreePlanID,Term,CreditID,Status")] Slot slot)
        {
            if (id != slot.SlotID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(slot);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SlotExists(slot.SlotID))
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
            ViewData["CreditID"] = new SelectList(_context.Credits, "CreditID", "CreditID", slot.CreditID);
            ViewData["DegreePlanID"] = new SelectList(_context.DegreePlans, "DegreePlanID", "DegreePlanID", slot.DegreePlanID);
            return View(slot);
        }

        // GET: Slots/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var slot = await _context.Slots
                .Include(s => s.Credit)
                .Include(s => s.DegreePlan)
                .FirstOrDefaultAsync(m => m.SlotID == id);
            if (slot == null)
            {
                return NotFound();
            }

            return View(slot);
        }

        // POST: Slots/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var slot = await _context.Slots.FindAsync(id);
            _context.Slots.Remove(slot);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SlotExists(int id)
        {
            return _context.Slots.Any(e => e.SlotID == id);
        }
    }
}
