using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoLP3_4bim.ControllerHelpingUtils
{
    public class SearchResultLivro
    {
        public string Type { get; set; }

        public int IdLivro { get; set; }

        public int EditoraIdEditora { get; set; }
        public string EditoraNomeEditora { get; set; }


        public int GeneroLivroIdGeneroLivro { get; set; }
        public string GeneroLivroNomeGeneroLivro { get; set; }

        public int AutorIdAutor { get; set; }
        public string AutorNomeAutor { get; set; }

        public string TituloLivro { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataLancamentoLivro { get; set; }
        public int QtdPaginasLivro { get; set; }
        public decimal PrecoLivro { get; set; }
    }
}
