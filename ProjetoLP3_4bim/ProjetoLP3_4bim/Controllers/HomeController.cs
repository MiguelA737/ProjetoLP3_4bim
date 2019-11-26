using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoLP3_4bim.ControllerHelpingUtils;
using ProjetoLP3_4bim.Models;

namespace ProjetoLP3_4bim.Controllers
{
    public class HomeController : Controller
    {
        private readonly LivrariasContext _context;

        public HomeController(LivrariasContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Search()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetResults(Search search)
        {
            if (search.Type == "Livro")
            {
                var results = from s in _context.Livro.Include(m => m.EditoraIdEditoraNavigation).Include(n => n.GeneroLivroIdGeneroLivroNavigation).Include(o => o.AutorIdAutorNavigation)
                              where s.TituloLivro.Contains(search.Input) || s.SinopseLivro.Contains(search.Input)
                              select new SearchResultLivro
                              {
                                  Type = "Livro",

                                  IdLivro = s.IdLivro,

                                  EditoraIdEditora = s.EditoraIdEditora,
                                  EditoraNomeEditora = s.EditoraIdEditoraNavigation.NomeEditora,

                                  GeneroLivroIdGeneroLivro = s.GeneroLivroIdGeneroLivro,
                                  GeneroLivroNomeGeneroLivro = s.GeneroLivroIdGeneroLivroNavigation.NomeGeneroLivro,

                                  AutorIdAutor = s.AutorIdAutor,
                                  AutorNomeAutor = s.AutorIdAutorNavigation.NomeAutor,

                                  TituloLivro = s.TituloLivro,

                                  DataLancamentoLivro = s.DataLancamentoLivro,

                                  QtdPaginasLivro = s.QtdPaginasLivro,

                                  PrecoLivro = s.PrecoLivro

                              };

                IEnumerable<SearchResultLivro> post = results;

                return Json(post);

            }

            if(search.Type == "Livraria")
            {
                var results = from s in _context.Livraria.Include(m => m.EnderecoIdEnderecoNavigation).Include(n => n.EnderecoIdEnderecoNavigation.RuaIdRuaNavigation)
                              where s.NomeLivraria.Contains(search.Input) || s.EnderecoIdEnderecoNavigation.RuaIdRuaNavigation.NomeRua.Contains(search.Input) || s.EmailLivraria.Contains(search.Input) || s.TelLivraria.Contains(search.Input)
                              select new SearchResultLivraria
                              {
                                  Type = "Livraria",

                                  IdLivraria = s.IdLivraria,

                                  EnderecoIdEndereco = s.EnderecoIdEndereco,
                                  Local = s.EnderecoIdEnderecoNavigation.RuaIdRuaNavigation.NomeRua + ", " + s.EnderecoIdEnderecoNavigation.NumeroEndereco,

                                  NomeLivraria = s.NomeLivraria,

                                  TelLivraria = s.TelLivraria,

                                  EmailLivraria = s.EmailLivraria

                              };

                IEnumerable<SearchResultLivraria> post = results;

                return Json(post);

            }

            return Json(null);
        }

    }

}
