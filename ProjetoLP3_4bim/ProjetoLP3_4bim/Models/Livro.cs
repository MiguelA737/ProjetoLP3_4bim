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
        [Display(Name = "Editora")]
        public int EditoraIdEditora { get; set; }

        [Column("GeneroLivro_idGeneroLivro")]
        [Display(Name = "Gênero")]
        public int GeneroLivroIdGeneroLivro { get; set; }

        [Column("Autor_idAutor")]
        [Display(Name = "Autor")]
        public int AutorIdAutor { get; set; }

        [Required(ErrorMessage = "O título é obrigatório")]
        [Column("tituloLivro")]
        [StringLength(60, ErrorMessage = "O título deve ter no máximo 60 caracteres.")]
        [Display(Name = "Título do livro")]
        public string TituloLivro { get; set; }

        [Column("dataLancamentoLivro", TypeName = "date")]
        [Display(Name = "Data de lançamento")]
        public DateTime DataLancamentoLivro { get; set; }

        [Column("qtdPaginasLivro")]
        [Display(Name = "Quantidade de páginas")]
        public int QtdPaginasLivro { get; set; }

        [Column("precoLivro", TypeName = "decimal(18, 0)")]
        [Display(Name = "Preço")]
        public decimal PrecoLivro { get; set; }

        [Column("sinopseLivro", TypeName = "text")]
        [Display(Name = "Sinopse")]
        public string SinopseLivro { get; set; }

        [ForeignKey("AutorIdAutor")]
        [InverseProperty("Livro")]
        [Display(Name = "Autor")]
        public Autor AutorIdAutorNavigation { get; set; }

        [ForeignKey("EditoraIdEditora")]
        [InverseProperty("Livro")]
        [Display(Name = "Editora")]
        public Editora EditoraIdEditoraNavigation { get; set; }

        [ForeignKey("GeneroLivroIdGeneroLivro")]
        [InverseProperty("Livro")]
        [Display(Name = "Gênero")]
        public GeneroLivro GeneroLivroIdGeneroLivroNavigation { get; set; }

        [InverseProperty("LivroIdLivroNavigation")]
        public ICollection<Compra> Compra { get; set; }

        [InverseProperty("LivroIdLivroNavigation")]
        public ICollection<Estoque> Estoque { get; set; }
    }
}
