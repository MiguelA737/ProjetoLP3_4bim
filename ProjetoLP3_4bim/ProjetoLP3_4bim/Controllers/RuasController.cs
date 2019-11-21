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
    public class RuasController : Controller
    {
        private readonly LivrariasContext _context;

        public RuasController(LivrariasContext context)
        {
            _context = context;
        }

        // GET: Ruas
        public async Task<IActionResult> Index()
        {
            var livrariasContext = _context.Rua.Include(r => r.BairroIdBairroNavigation);
            return View(await livrariasContext.ToListAsync());
        }

        // GET: Ruas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rua = await _context.Rua
                .Include(r => r.BairroIdBairroNavigation)
                .FirstOrDefaultAsync(m => m.IdRua == id);
            if (rua == null)
            {
                return NotFound();
            }

            return View(rua);
        }

        // GET: Ruas/Create
        public IActionResult Create()
        {
            ViewData["BairroIdBairro"] = new SelectList(_context.Bairro, "IdBairro", "NomeBairro");
            return View();
        }

        // POST: Ruas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdRua,BairroIdBairro,NomeRua")] Rua rua)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rua);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BairroIdBairro"] = new SelectList(_context.Bairro, "IdBairro", "NomeBairro", rua.BairroIdBairro);
            return View(rua);
        }

        // GET: Ruas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rua = await _context.Rua.FindAsync(id);
            if (rua == null)
            {
                return NotFound();
            }
            ViewData["BairroIdBairro"] = new SelectList(_context.Bairro, "IdBairro", "NomeBairro", rua.BairroIdBairro);
            return View(rua);
        }

        // POST: Ruas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdRua,BairroIdBairro,NomeRua")] Rua rua)
        {
            if (id != rua.IdRua)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rua);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RuaExists(rua.IdRua))
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
            ViewData["BairroIdBairro"] = new SelectList(_context.Bairro, "IdBairro", "NomeBairro", rua.BairroIdBairro);
            return View(rua);
        }

        // GET: Ruas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rua = await _context.Rua
                .Include(r => r.BairroIdBairroNavigation)
                .FirstOrDefaultAsync(m => m.IdRua == id);
            if (rua == null)
            {
                return NotFound();
            }

            return View(rua);
        }

        // POST: Ruas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rua = await _context.Rua.FindAsync(id);
            _context.Rua.Remove(rua);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RuaExists(int id)
        {
            return _context.Rua.Any(e => e.IdRua == id);
        }
    }
}
