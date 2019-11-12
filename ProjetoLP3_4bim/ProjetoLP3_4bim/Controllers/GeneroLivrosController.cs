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
    public class GeneroLivrosController : Controller
    {
        private readonly LivrariasContext _context;

        public GeneroLivrosController(LivrariasContext context)
        {
            _context = context;
        }

        // GET: GeneroLivros
        public async Task<IActionResult> Index()
        {
            return View(await _context.GeneroLivro.ToListAsync());
        }

        // GET: GeneroLivros/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var generoLivro = await _context.GeneroLivro
                .FirstOrDefaultAsync(m => m.IdGeneroLivro == id);
            if (generoLivro == null)
            {
                return NotFound();
            }

            return View(generoLivro);
        }

        // GET: GeneroLivros/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GeneroLivros/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdGeneroLivro,NomeGeneroLivro,DesGeneroLivro")] GeneroLivro generoLivro)
        {
            if (ModelState.IsValid)
            {
                _context.Add(generoLivro);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(generoLivro);
        }

        // GET: GeneroLivros/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var generoLivro = await _context.GeneroLivro.FindAsync(id);
            if (generoLivro == null)
            {
                return NotFound();
            }
            return View(generoLivro);
        }

        // POST: GeneroLivros/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdGeneroLivro,NomeGeneroLivro,DesGeneroLivro")] GeneroLivro generoLivro)
        {
            if (id != generoLivro.IdGeneroLivro)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(generoLivro);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GeneroLivroExists(generoLivro.IdGeneroLivro))
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
            return View(generoLivro);
        }

        // GET: GeneroLivros/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var generoLivro = await _context.GeneroLivro
                .FirstOrDefaultAsync(m => m.IdGeneroLivro == id);
            if (generoLivro == null)
            {
                return NotFound();
            }

            return View(generoLivro);
        }

        // POST: GeneroLivros/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var generoLivro = await _context.GeneroLivro.FindAsync(id);
            _context.GeneroLivro.Remove(generoLivro);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GeneroLivroExists(int id)
        {
            return _context.GeneroLivro.Any(e => e.IdGeneroLivro == id);
        }
    }
}
