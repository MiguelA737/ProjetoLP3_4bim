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
    public class LivroController : Controller
    {
        private readonly LivrariasContext _context;

        public LivroController(LivrariasContext context)
        {
            _context = context;
        }

        // GET: Livro
        public async Task<IActionResult> Index()
        {
            var livrariasContext = _context.Livro.Include(l => l.AutorIdAutorNavigation).Include(l => l.EditoraIdEditoraNavigation).Include(l => l.GeneroLivroIdGeneroLivroNavigation);
            return View(await livrariasContext.ToListAsync());
        }

        // GET: Livro/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var livro = await _context.Livro
                .Include(l => l.AutorIdAutorNavigation)
                .Include(l => l.EditoraIdEditoraNavigation)
                .Include(l => l.GeneroLivroIdGeneroLivroNavigation)
                .FirstOrDefaultAsync(m => m.IdLivro == id);
            if (livro == null)
            {
                return NotFound();
            }

            return View(livro);
        }

        // GET: Livro/Create
        public IActionResult Create()
        {
            ViewData["AutorIdAutor"] = new SelectList(_context.Autor, "IdAutor", "EmailAutor");
            ViewData["EditoraIdEditora"] = new SelectList(_context.Editora, "IdEditora", "EmailEditora");
            ViewData["GeneroLivroIdGeneroLivro"] = new SelectList(_context.GeneroLivro, "IdGeneroLivro", "NomeGeneroLivro");
            return View();
        }

        // POST: Livro/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdLivro,EditoraIdEditora,GeneroLivroIdGeneroLivro,AutorIdAutor,TituloLivro,DataLancamentoLivro,QtdPaginasLivro,PrecoLivro,SinopseLivro")] Livro livro)
        {
            if (ModelState.IsValid)
            {
                _context.Add(livro);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AutorIdAutor"] = new SelectList(_context.Autor, "IdAutor", "EmailAutor", livro.AutorIdAutor);
            ViewData["EditoraIdEditora"] = new SelectList(_context.Editora, "IdEditora", "EmailEditora", livro.EditoraIdEditora);
            ViewData["GeneroLivroIdGeneroLivro"] = new SelectList(_context.GeneroLivro, "IdGeneroLivro", "NomeGeneroLivro", livro.GeneroLivroIdGeneroLivro);
            return View(livro);
        }

        // GET: Livro/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var livro = await _context.Livro.FindAsync(id);
            if (livro == null)
            {
                return NotFound();
            }
            ViewData["AutorIdAutor"] = new SelectList(_context.Autor, "IdAutor", "EmailAutor", livro.AutorIdAutor);
            ViewData["EditoraIdEditora"] = new SelectList(_context.Editora, "IdEditora", "EmailEditora", livro.EditoraIdEditora);
            ViewData["GeneroLivroIdGeneroLivro"] = new SelectList(_context.GeneroLivro, "IdGeneroLivro", "NomeGeneroLivro", livro.GeneroLivroIdGeneroLivro);
            return View(livro);
        }

        // POST: Livro/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdLivro,EditoraIdEditora,GeneroLivroIdGeneroLivro,AutorIdAutor,TituloLivro,DataLancamentoLivro,QtdPaginasLivro,PrecoLivro,SinopseLivro")] Livro livro)
        {
            if (id != livro.IdLivro)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(livro);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LivroExists(livro.IdLivro))
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
            ViewData["AutorIdAutor"] = new SelectList(_context.Autor, "IdAutor", "EmailAutor", livro.AutorIdAutor);
            ViewData["EditoraIdEditora"] = new SelectList(_context.Editora, "IdEditora", "EmailEditora", livro.EditoraIdEditora);
            ViewData["GeneroLivroIdGeneroLivro"] = new SelectList(_context.GeneroLivro, "IdGeneroLivro", "NomeGeneroLivro", livro.GeneroLivroIdGeneroLivro);
            return View(livro);
        }

        // GET: Livro/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var livro = await _context.Livro
                .Include(l => l.AutorIdAutorNavigation)
                .Include(l => l.EditoraIdEditoraNavigation)
                .Include(l => l.GeneroLivroIdGeneroLivroNavigation)
                .FirstOrDefaultAsync(m => m.IdLivro == id);
            if (livro == null)
            {
                return NotFound();
            }

            return View(livro);
        }

        // POST: Livro/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var livro = await _context.Livro.FindAsync(id);
            _context.Livro.Remove(livro);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LivroExists(int id)
        {
            return _context.Livro.Any(e => e.IdLivro == id);
        }
    }
}
