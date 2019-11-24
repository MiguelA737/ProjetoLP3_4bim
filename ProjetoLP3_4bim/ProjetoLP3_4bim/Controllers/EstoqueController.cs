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
    public class EstoqueController : Controller
    {
        private readonly LivrariasContext _context;

        public EstoqueController(LivrariasContext context)
        {
            _context = context;
        }

        // GET: Estoque
        public async Task<IActionResult> Index()
        {
            var livrariasContext = _context.Estoque.Include(e => e.LivrariaIdLivrariaNavigation).Include(e => e.LivroIdLivroNavigation);
            return View(await livrariasContext.ToListAsync());
        }

        // GET: Estoque/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estoque = await _context.Estoque
                .Include(e => e.LivrariaIdLivrariaNavigation)
                .Include(e => e.LivroIdLivroNavigation)
                .FirstOrDefaultAsync(m => m.IdEstoque == id);
            if (estoque == null)
            {
                return NotFound();
            }

            return View(estoque);
        }

        // GET: Estoque/Create
        public IActionResult Create()
        {
            ViewData["LivrariaIdLivraria"] = new SelectList(_context.Livraria, "IdLivraria", "EmailLivraria");
            ViewData["LivroIdLivro"] = new SelectList(_context.Livro, "IdLivro", "TituloLivro");
            return View();
        }

        // POST: Estoque/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdEstoque,LivroIdLivro,LivrariaIdLivraria,QtdLivro")] Estoque estoque)
        {
            if (ModelState.IsValid)
            {
                _context.Add(estoque);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["LivrariaIdLivraria"] = new SelectList(_context.Livraria, "IdLivraria", "EmailLivraria", estoque.LivrariaIdLivraria);
            ViewData["LivroIdLivro"] = new SelectList(_context.Livro, "IdLivro", "TituloLivro", estoque.LivroIdLivro);
            return View(estoque);
        }

        // GET: Estoque/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estoque = await _context.Estoque.FindAsync(id);
            if (estoque == null)
            {
                return NotFound();
            }
            ViewData["LivrariaIdLivraria"] = new SelectList(_context.Livraria, "IdLivraria", "EmailLivraria", estoque.LivrariaIdLivraria);
            ViewData["LivroIdLivro"] = new SelectList(_context.Livro, "IdLivro", "TituloLivro", estoque.LivroIdLivro);
            return View(estoque);
        }

        // POST: Estoque/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdEstoque,LivroIdLivro,LivrariaIdLivraria,QtdLivro")] Estoque estoque)
        {
            if (id != estoque.IdEstoque)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(estoque);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EstoqueExists(estoque.IdEstoque))
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
            ViewData["LivrariaIdLivraria"] = new SelectList(_context.Livraria, "IdLivraria", "EmailLivraria", estoque.LivrariaIdLivraria);
            ViewData["LivroIdLivro"] = new SelectList(_context.Livro, "IdLivro", "TituloLivro", estoque.LivroIdLivro);
            return View(estoque);
        }

        // GET: Estoque/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estoque = await _context.Estoque
                .Include(e => e.LivrariaIdLivrariaNavigation)
                .Include(e => e.LivroIdLivroNavigation)
                .FirstOrDefaultAsync(m => m.IdEstoque == id);
            if (estoque == null)
            {
                return NotFound();
            }

            return View(estoque);
        }

        // POST: Estoque/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var estoque = await _context.Estoque.FindAsync(id);
            _context.Estoque.Remove(estoque);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EstoqueExists(int id)
        {
            return _context.Estoque.Any(e => e.IdEstoque == id);
        }
    }
}
