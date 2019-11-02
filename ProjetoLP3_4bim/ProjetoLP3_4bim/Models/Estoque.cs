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
        public int LivroIdLivro { get; set; }
        [Column("qtdLivro")]
        public int QtdLivro { get; set; }

        [ForeignKey("LivroIdLivro")]
        [InverseProperty("Estoque")]
        public Livro LivroIdLivroNavigation { get; set; }
    }
}
