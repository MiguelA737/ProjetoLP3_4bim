﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjetoLP3_4bim.Models;

namespace ProjetoLP3_4bim.Controllers
{
    public class LivrariaController : Controller
    {
        private readonly LivrariasContext _context;

        public LivrariaController(LivrariasContext context)
        {
            _context = context;
        }

        // GET: Livraria
        public async Task<IActionResult> Index()
        {
            var livrariasContext = _context.Livraria.Include(l => l.EnderecoIdEnderecoNavigation);
            return View(await livrariasContext.ToListAsync());
        }

        // GET: Livraria/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var livraria = await _context.Livraria
                .Include(l => l.EnderecoIdEnderecoNavigation)
                .FirstOrDefaultAsync(m => m.IdLivraria == id);
            if (livraria == null)
            {
                return NotFound();
            }

            return View(livraria);
        }

        // GET: Livraria/Create
        public IActionResult Create()
        {
            ViewData["EnderecoIdEndereco"] = new SelectList(_context.Endereco, "IdEndereco", "IdEndereco");
            return View();
        }

        // POST: Livraria/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdLivraria,EnderecoIdEndereco,NomeLivraria,TelLivraria,EmailLivraria")] Livraria livraria)
        {
            if (ModelState.IsValid)
            {
                _context.Add(livraria);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EnderecoIdEndereco"] = new SelectList(_context.Endereco, "IdEndereco", "IdEndereco", livraria.EnderecoIdEndereco);
            return View(livraria);
        }

        // GET: Livraria/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var livraria = await _context.Livraria.FindAsync(id);
            if (livraria == null)
            {
                return NotFound();
            }
            ViewData["EnderecoIdEndereco"] = new SelectList(_context.Endereco, "IdEndereco", "IdEndereco", livraria.EnderecoIdEndereco);
            return View(livraria);
        }

        // POST: Livraria/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdLivraria,EnderecoIdEndereco,NomeLivraria,TelLivraria,EmailLivraria")] Livraria livraria)
        {
            if (id != livraria.IdLivraria)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(livraria);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LivrariaExists(livraria.IdLivraria))
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
            ViewData["EnderecoIdEndereco"] = new SelectList(_context.Endereco, "IdEndereco", "IdEndereco", livraria.EnderecoIdEndereco);
            return View(livraria);
        }

        // GET: Livraria/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var livraria = await _context.Livraria
                .Include(l => l.EnderecoIdEnderecoNavigation)
                .FirstOrDefaultAsync(m => m.IdLivraria == id);
            if (livraria == null)
            {
                return NotFound();
            }

            return View(livraria);
        }

        // POST: Livraria/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var livraria = await _context.Livraria.FindAsync(id);
            _context.Livraria.Remove(livraria);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LivrariaExists(int id)
        {
            return _context.Livraria.Any(e => e.IdLivraria == id);
        }
    }
}
