using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TrainingSofka.Web.Data;
using TrainingSofka.Web.Data.Entities;

namespace TrainingSofka.Web.Controllers
{
    public class TravelsController : Controller
    {
        private readonly DataContext _context;

        public TravelsController(DataContext context)
        {
            _context = context;
        }

        // GET: Travels
        public async Task<IActionResult> Index()
        {
            return View(await _context.Travels.ToListAsync());
        }

        // GET: Travels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var travelsEntity = await _context.Travels
                .FirstOrDefaultAsync(m => m.Id == id);
            if (travelsEntity == null)
            {
                return NotFound();
            }

            return View(travelsEntity);
        }

        // GET: Travels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Travels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Destination,Days,Distance,Total,Discount")] TravelsEntity travelsEntity)
        {
            travelsEntity.Total = travelsEntity.Distance * 35 * travelsEntity.Days;
            if (travelsEntity.Distance>1000 && travelsEntity.Days>7)
            {
                travelsEntity.Discount = travelsEntity.Total * 0.30;
            }
            if (ModelState.IsValid)
            {
                _context.Add(travelsEntity);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(travelsEntity);
        }

        // GET: Travels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var travelsEntity = await _context.Travels.FindAsync(id);
            if (travelsEntity == null)
            {
                return NotFound();
            }
            return View(travelsEntity);
        }

        // POST: Travels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Destination,Days,Distance,Total")] TravelsEntity travelsEntity)
        {
            if (id != travelsEntity.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(travelsEntity);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TravelsEntityExists(travelsEntity.Id))
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
            return View(travelsEntity);
        }

        // GET: Travels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var travelsEntity = await _context.Travels
                .FirstOrDefaultAsync(m => m.Id == id);
            if (travelsEntity == null)
            {
                return NotFound();
            }

            return View(travelsEntity);
        }

        // POST: Travels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var travelsEntity = await _context.Travels.FindAsync(id);
            _context.Travels.Remove(travelsEntity);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TravelsEntityExists(int id)
        {
            return _context.Travels.Any(e => e.Id == id);
        }
    }
}
