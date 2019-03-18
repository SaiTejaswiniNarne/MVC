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
    public class DegreeCreditsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DegreeCreditsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: DegreeCredits
        public async Task<IActionResult> Index(string sortOrder, string searchString)
        {
            ViewData["DegreeIDParm"] = String.IsNullOrEmpty(sortOrder) ? "DegreeID_desc" : "";
            ViewData["RequirementIDParm"] = sortOrder == "RequirementID" ? "RequirementID_desc" : "RequirementID";
            ViewData["CurrentFilter"] = searchString;
            var degreereq = from s in _context.DegreeCredits
                            select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                degreereq = degreereq.Where(s => s.DegreeID.ToString().Contains(searchString)
                                       || s.CreditID.ToString().Contains(searchString));
            }

            switch (sortOrder)
            {
                case "DegreeID_desc":
                    degreereq = degreereq.OrderByDescending(s => s.DegreeID);
                    break;

                case "RequirementID":
                    degreereq = degreereq.OrderBy(s => s.CreditID);
                    break;
                case "RequirementID_desc":
                    degreereq = degreereq.OrderByDescending(s => s.CreditID);
                    break;
                default:
                    degreereq = degreereq.OrderBy(s => s.DegreeCreditID);
                    break;
            }

            return View(await degreereq.AsNoTracking().ToListAsync());
        }


        // GET: DegreeCredits/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var degreeCredit = await _context.DegreeCredits
                .Include(d => d.Credit)
                .Include(d => d.Degree)
                .FirstOrDefaultAsync(m => m.DegreeCreditID == id);
            if (degreeCredit == null)
            {
                return NotFound();
            }

            return View(degreeCredit);
        }

        // GET: DegreeCredits/Create
        public IActionResult Create()
        {
            ViewData["CreditID"] = new SelectList(_context.Credits, "CreditID", "CreditID");
            ViewData["DegreeID"] = new SelectList(_context.Degrees, "DegreeID", "DegreeID");
            return View();
        }

        // POST: DegreeCredits/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DegreeCreditID,CreditID,DegreeID")] DegreeCredit degreeCredit)
        {
            if (ModelState.IsValid)
            {
                _context.Add(degreeCredit);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CreditID"] = new SelectList(_context.Credits, "CreditID", "CreditID", degreeCredit.CreditID);
            ViewData["DegreeID"] = new SelectList(_context.Degrees, "DegreeID", "DegreeID", degreeCredit.DegreeID);
            return View(degreeCredit);
        }

        // GET: DegreeCredits/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var degreeCredit = await _context.DegreeCredits.FindAsync(id);
            if (degreeCredit == null)
            {
                return NotFound();
            }
            ViewData["CreditID"] = new SelectList(_context.Credits, "CreditID", "CreditID", degreeCredit.CreditID);
            ViewData["DegreeID"] = new SelectList(_context.Degrees, "DegreeID", "DegreeID", degreeCredit.DegreeID);
            return View(degreeCredit);
        }

        // POST: DegreeCredits/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DegreeCreditID,CreditID,DegreeID")] DegreeCredit degreeCredit)
        {
            if (id != degreeCredit.DegreeCreditID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(degreeCredit);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DegreeCreditExists(degreeCredit.DegreeCreditID))
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
            ViewData["CreditID"] = new SelectList(_context.Credits, "CreditID", "CreditID", degreeCredit.CreditID);
            ViewData["DegreeID"] = new SelectList(_context.Degrees, "DegreeID", "DegreeID", degreeCredit.DegreeID);
            return View(degreeCredit);
        }

        // GET: DegreeCredits/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var degreeCredit = await _context.DegreeCredits
                .Include(d => d.Credit)
                .Include(d => d.Degree)
                .FirstOrDefaultAsync(m => m.DegreeCreditID == id);
            if (degreeCredit == null)
            {
                return NotFound();
            }

            return View(degreeCredit);
        }

        // POST: DegreeCredits/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var degreeCredit = await _context.DegreeCredits.FindAsync(id);
            _context.DegreeCredits.Remove(degreeCredit);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DegreeCreditExists(int id)
        {
            return _context.DegreeCredits.Any(e => e.DegreeCreditID == id);
        }
    }
}
