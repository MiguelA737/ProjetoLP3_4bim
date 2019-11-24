using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoLP3_4bim.Models
{
    public partial class Estoque
    {
        [Key]
        [Column("idEstoque")]
        public int IdEstoque { get; set; }

        [Column("Livro_idLivro")]
        [Display(Name = "Livro")]
        [Required(ErrorMessage = "O livro é obrigatório")]
        public int LivroIdLivro { get; set; }

        [Column("Livraria_idLivraria")]
        [Display(Name = "Livraria")]
        [Required(ErrorMessage = "A livraria é obrigatório")]
        public int LivrariaIdLivraria { get; set; }

        [Column("qtdLivro")]
        [Display(Name = "Quantidade de exemplares")]
        [Required(ErrorMessage = "A quantidade de exemplares é obrigatória")]
        public int QtdLivro { get; set; }

        [ForeignKey("LivroIdLivro")]
        [InverseProperty("Estoque")]
        [Display(Name = "Livro")]
        public Livro LivroIdLivroNavigation { get; set; }

        [ForeignKey("LivrariaIdLivraria")]
        [InverseProperty("Estoque")]
        [Display(Name = "Livraria")]
        public Livraria LivrariaIdLivrariaNavigation { get; set; }
    }
}
