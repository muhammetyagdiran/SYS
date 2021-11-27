using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SYS.Models;
using SYS.Models.Entities;

namespace SYS.Controllers
{
    public class SporcuBilgiController : Controller
    {
        private readonly SysContext _context;

        public SporcuBilgiController(SysContext context)
        {
            _context = context;
        }

        // GET: SporcuBilgi
        public async Task<IActionResult> Index()
        {
            return View(await _context.SporcuBilgiler.ToListAsync());
        }

        // GET: SporcuBilgi/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sporcuBilgi = await _context.SporcuBilgiler
                .FirstOrDefaultAsync(m => m.id == id);
            if (sporcuBilgi == null)
            {
                return NotFound();
            }

            return View(sporcuBilgi);
        }

        // GET: SporcuBilgi/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SporcuBilgi/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,Ad,Soyad,DogumYeri,DogumTarihi,EvTelefon,email,EvAdresi,KanGrubu,Boy,Kilo,OkuduguOkul")] SporcuBilgi sporcuBilgi)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sporcuBilgi);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sporcuBilgi);
        }

        // GET: SporcuBilgi/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sporcuBilgi = await _context.SporcuBilgiler.FindAsync(id);
            if (sporcuBilgi == null)
            {
                return NotFound();
            }
            return View(sporcuBilgi);
        }

        // POST: SporcuBilgi/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,Ad,Soyad,DogumYeri,DogumTarihi,EvTelefon,email,EvAdresi,KanGrubu,Boy,Kilo,OkuduguOkul")] SporcuBilgi sporcuBilgi)
        {
            if (id != sporcuBilgi.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sporcuBilgi);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SporcuBilgiExists(sporcuBilgi.id))
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
            return View(sporcuBilgi);
        }

        // GET: SporcuBilgi/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sporcuBilgi = await _context.SporcuBilgiler
                .FirstOrDefaultAsync(m => m.id == id);
            if (sporcuBilgi == null)
            {
                return NotFound();
            }

            return View(sporcuBilgi);
        }

        // POST: SporcuBilgi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sporcuBilgi = await _context.SporcuBilgiler.FindAsync(id);
            _context.SporcuBilgiler.Remove(sporcuBilgi);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SporcuBilgiExists(int id)
        {
            return _context.SporcuBilgiler.Any(e => e.id == id);
        }
    }
}
