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
    public class CompraController : Controller
    {
        private readonly LivrariasContext _context;

        public CompraController(LivrariasContext context)
        {
            _context = context;
        }

        // GET: Compra
        public async Task<IActionResult> Index()
        {
            var livrariasContext = _context.Compra.Include(c => c.LivroIdLivroNavigation).Include(c => c.UsuarioIdUsuarioNavigation);
            return View(await livrariasContext.ToListAsync());
        }

        // GET: Compra/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var compra = await _context.Compra
                .Include(c => c.LivroIdLivroNavigation)
                .Include(c => c.UsuarioIdUsuarioNavigation)
                .FirstOrDefaultAsync(m => m.IdCompra == id);
            if (compra == null)
            {
                return NotFound();
            }

            return View(compra);
        }

        // GET: Compra/Create
        public IActionResult Create()
        {
            ViewData["LivroIdLivro"] = new SelectList(_context.Livro, "IdLivro", "TituloLivro");
            ViewData["UsuarioIdUsuario"] = new SelectList(_context.Usuario, "IdUsuario", "EmailUsuario");
            return View();
        }

        // POST: Compra/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdCompra,LivroIdLivro,UsuarioIdUsuario")] Compra compra)
        {
            if (ModelState.IsValid)
            {
                _context.Add(compra);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["LivroIdLivro"] = new SelectList(_context.Livro, "IdLivro", "TituloLivro", compra.LivroIdLivro);
            ViewData["UsuarioIdUsuario"] = new SelectList(_context.Usuario, "IdUsuario", "EmailUsuario", compra.UsuarioIdUsuario);
            return View(compra);
        }

        // GET: Compra/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var compra = await _context.Compra.FindAsync(id);
            if (compra == null)
            {
                return NotFound();
            }
            ViewData["LivroIdLivro"] = new SelectList(_context.Livro, "IdLivro", "TituloLivro", compra.LivroIdLivro);
            ViewData["UsuarioIdUsuario"] = new SelectList(_context.Usuario, "IdUsuario", "EmailUsuario", compra.UsuarioIdUsuario);
            return View(compra);
        }

        // POST: Compra/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdCompra,LivroIdLivro,UsuarioIdUsuario")] Compra compra)
        {
            if (id != compra.IdCompra)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(compra);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CompraExists(compra.IdCompra))
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
            ViewData["LivroIdLivro"] = new SelectList(_context.Livro, "IdLivro", "TituloLivro", compra.LivroIdLivro);
            ViewData["UsuarioIdUsuario"] = new SelectList(_context.Usuario, "IdUsuario", "EmailUsuario", compra.UsuarioIdUsuario);
            return View(compra);
        }

        // GET: Compra/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var compra = await _context.Compra
                .Include(c => c.LivroIdLivroNavigation)
                .Include(c => c.UsuarioIdUsuarioNavigation)
                .FirstOrDefaultAsync(m => m.IdCompra == id);
            if (compra == null)
            {
                return NotFound();
            }

            return View(compra);
        }

        // POST: Compra/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var compra = await _context.Compra.FindAsync(id);
            _context.Compra.Remove(compra);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CompraExists(int id)
        {
            return _context.Compra.Any(e => e.IdCompra == id);
        }
    }
}
