using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoLP3_4bim.Models
{
    public partial class Livro
    {
        public Livro()
        {
            Compra = new HashSet<Compra>();
            Estoque = new HashSet<Estoque>();
        }

        [Key]
        [Column("idLivro")]
        public int IdLivro { get; set; }
        [Column("Editora_idEditora")]
        public int EditoraIdEditora { get; set; }
        [Column("GeneroLivro_idGeneroLivro")]
        public int GeneroLivroIdGeneroLivro { get; set; }
        [Column("Autor_idAutor")]
        public int AutorIdAutor { get; set; }
        [Required]
        [Column("tituloLivro")]
        [StringLength(1)]
        public string TituloLivro { get; set; }
        [Column("dataLancamentoLivro", TypeName = "date")]
        public DateTime DataLancamentoLivro { get; set; }
        [Column("qtdPaginasLivro")]
        public int QtdPaginasLivro { get; set; }
        [Column("precoLivro", TypeName = "decimal(18, 0)")]
        public decimal PrecoLivro { get; set; }
        [Column("sinopseLivro", TypeName = "text")]
        public string SinopseLivro { get; set; }

        [ForeignKey("AutorIdAutor")]
        [InverseProperty("Livro")]
        public Autor AutorIdAutorNavigation { get; set; }
        [ForeignKey("EditoraIdEditora")]
        [InverseProperty("Livro")]
        public Editora EditoraIdEditoraNavigation { get; set; }
        [ForeignKey("GeneroLivroIdGeneroLivro")]
        [InverseProperty("Livro")]
        public GeneroLivro GeneroLivroIdGeneroLivroNavigation { get; set; }
        [InverseProperty("LivroIdLivroNavigation")]
        public ICollection<Compra> Compra { get; set; }
        [InverseProperty("LivroIdLivroNavigation")]
        public ICollection<Estoque> Estoque { get; set; }
    }
}
