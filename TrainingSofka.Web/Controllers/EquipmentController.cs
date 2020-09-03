using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TrainingSofka.Web.Data;
using TrainingSofka.Web.Data.Entities;

namespace TrainingSofka.Web.Controllers
{
    public class EquipmentController : Controller
    {
        private readonly DataContext _context;
        public const double Max = 18000;
        public double Acum;
        public EquipmentController(DataContext context)
        {
            _context = context;
        }

        // GET: Equipment
        public async Task<IActionResult> Index()
        {
            return View(await _context.Equipments.ToListAsync());
        }

        // GET: Equipment/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var equipmentEntity = await _context.Equipments
                .FirstOrDefaultAsync(m => m.Id == id);
            if (equipmentEntity == null)
            {
                return NotFound();
            }

            return View(equipmentEntity);
        }

        // GET: Equipment/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Equipment/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Peso,ValueDolars,ValuePesos,TotalEquipment")] EquipmentEntity equipmentEntity)
        {
          
            if (ModelState.IsValid)
            {
                if (equipmentEntity.Peso<500)
                {

                }
                _context.Add(equipmentEntity);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(equipmentEntity);
        }

        // GET: Equipment/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var equipmentEntity = await _context.Equipments.FindAsync(id);
            if (equipmentEntity == null)
            {
                return NotFound();
            }
            return View(equipmentEntity);
        }

        // POST: Equipment/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Peso,ValueDolars,ValuePesos,TotalEquipment")] EquipmentEntity equipmentEntity)
        {
            if (id != equipmentEntity.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(equipmentEntity);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EquipmentEntityExists(equipmentEntity.Id))
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
            return View(equipmentEntity);
        }

        // GET: Equipment/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var equipmentEntity = await _context.Equipments
                .FirstOrDefaultAsync(m => m.Id == id);
            if (equipmentEntity == null)
            {
                return NotFound();
            }

            return View(equipmentEntity);
        }

        // POST: Equipment/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var equipmentEntity = await _context.Equipments.FindAsync(id);
            _context.Equipments.Remove(equipmentEntity);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EquipmentEntityExists(int id)
        {
            return _context.Equipments.Any(e => e.Id == id);
        }
    }
}
