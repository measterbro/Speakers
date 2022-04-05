using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Security2.Data;
using Security2.Models;

namespace Security2.Controllers
{
    public class SpeakerAddressTypeLookupModelsController : Controller
    {
        private readonly Security2Context _context;

        public SpeakerAddressTypeLookupModelsController(Security2Context context)
        {
            _context = context;
        }

        // GET: SpeakerAddressTypeLookupModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.SpeakerAddressTypeLookupModel.ToListAsync());
        }

        // GET: SpeakerAddressTypeLookupModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var speakerAddressTypeLookupModel = await _context.SpeakerAddressTypeLookupModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (speakerAddressTypeLookupModel == null)
            {
                return NotFound();
            }

            return View(speakerAddressTypeLookupModel);
        }

        // GET: SpeakerAddressTypeLookupModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SpeakerAddressTypeLookupModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AddressType")] SpeakerAddressTypeLookupModel speakerAddressTypeLookupModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(speakerAddressTypeLookupModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(speakerAddressTypeLookupModel);
        }

        // GET: SpeakerAddressTypeLookupModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var speakerAddressTypeLookupModel = await _context.SpeakerAddressTypeLookupModel.FindAsync(id);
            if (speakerAddressTypeLookupModel == null)
            {
                return NotFound();
            }
            return View(speakerAddressTypeLookupModel);
        }

        // POST: SpeakerAddressTypeLookupModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,AddressType")] SpeakerAddressTypeLookupModel speakerAddressTypeLookupModel)
        {
            if (id != speakerAddressTypeLookupModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(speakerAddressTypeLookupModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SpeakerAddressTypeLookupModelExists(speakerAddressTypeLookupModel.Id))
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
            return View(speakerAddressTypeLookupModel);
        }

        // GET: SpeakerAddressTypeLookupModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var speakerAddressTypeLookupModel = await _context.SpeakerAddressTypeLookupModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (speakerAddressTypeLookupModel == null)
            {
                return NotFound();
            }

            return View(speakerAddressTypeLookupModel);
        }

        // POST: SpeakerAddressTypeLookupModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var speakerAddressTypeLookupModel = await _context.SpeakerAddressTypeLookupModel.FindAsync(id);
            _context.SpeakerAddressTypeLookupModel.Remove(speakerAddressTypeLookupModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SpeakerAddressTypeLookupModelExists(int id)
        {
            return _context.SpeakerAddressTypeLookupModel.Any(e => e.Id == id);
        }
    }
}
