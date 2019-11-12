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
        [Display(Name = "Nome")]
        [StringLength(60, ErrorMessage = "O nome deve ter no máximo 60 caracteres.")]
        [Column("nomeGeneroLivro")]
        public string NomeGeneroLivro { get; set; }

        [Column("desGeneroLivro", TypeName = "text")]
        [Display(Name = "Descrição")]
        [StringLength(100, ErrorMessage = "A descrição deve ter no máximo 100 caracteres.")]
        public string DesGeneroLivro { get; set; }


        [InverseProperty("GeneroLivroIdGeneroLivroNavigation")]
        public ICollection<Livro> Livro { get; set; }
    }
}
