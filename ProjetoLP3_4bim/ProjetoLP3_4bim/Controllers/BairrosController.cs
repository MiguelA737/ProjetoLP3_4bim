using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjetoLP3_4bim.Models;

namespace ProjetoLP3_4bim.Controllers
{
    public class BairrosController : Controller
    {
        private readonly LivrariasContext _context;

        public BairrosController(LivrariasContext context)
        {
            _context = context;
        }

        // GET: Bairros
        public async Task<IActionResult> Index()
        {
            var livrariasContext = _context.Bairro.Include(b => b.PaisIdPaisNavigation);
            return View(await livrariasContext.ToListAsync());
        }

        // GET: Bairros/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bairro = await _context.Bairro
                .Include(b => b.PaisIdPaisNavigation)
                .FirstOrDefaultAsync(m => m.IdBairro == id);
            if (bairro == null)
            {
                return NotFound();
            }

            return View(bairro);
        }

        // GET: Bairros/Create
        public IActionResult Create()
        {
            ViewData["PaisIdPais"] = new SelectList(_context.Pais, "IdPais", "NomePais");
            return View();
        }

        // POST: Bairros/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdBairro,PaisIdPais,NomeBairro")] Bairro bairro)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bairro);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PaisIdPais"] = new SelectList(_context.Pais, "IdPais", "NomePais", bairro.PaisIdPais);
            return View(bairro);
        }

        // GET: Bairros/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bairro = await _context.Bairro.FindAsync(id);
            if (bairro == null)
            {
                return NotFound();
            }
            ViewData["PaisIdPais"] = new SelectList(_context.Pais, "IdPais", "NomePais", bairro.PaisIdPais);
            return View(bairro);
        }

        // POST: Bairros/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdBairro,PaisIdPais,NomeBairro")] Bairro bairro)
        {
            if (id != bairro.IdBairro)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bairro);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BairroExists(bairro.IdBairro))
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
            ViewData["PaisIdPais"] = new SelectList(_context.Pais, "IdPais", "NomePais", bairro.PaisIdPais);
            return View(bairro);
        }

        // GET: Bairros/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bairro = await _context.Bairro
                .Include(b => b.PaisIdPaisNavigation)
                .FirstOrDefaultAsync(m => m.IdBairro == id);
            if (bairro == null)
            {
                return NotFound();
            }

            return View(bairro);
        }

        // POST: Bairros/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bairro = await _context.Bairro.FindAsync(id);
            _context.Bairro.Remove(bairro);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BairroExists(int id)
        {
            return _context.Bairro.Any(e => e.IdBairro == id);
        }
    }
}
