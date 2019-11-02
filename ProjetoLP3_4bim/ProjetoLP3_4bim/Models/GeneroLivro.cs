using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoLP3_4bim.Models
{
    public partial class GeneroLivro
    {
        public GeneroLivro()
        {
            Livro = new HashSet<Livro>();
        }

        [Key]
        [Column("idGeneroLivro")]
        public int IdGeneroLivro { get; set; }
        [Required]
        [Column("nomeGeneroLivro")]
        [StringLength(1)]
        public string NomeGeneroLivro { get; set; }
        [Column("desGeneroLivro", TypeName = "text")]
        public string DesGeneroLivro { get; set; }

        [InverseProperty("GeneroLivroIdGeneroLivroNavigation")]
        public ICollection<Livro> Livro { get; set; }
    }
}
