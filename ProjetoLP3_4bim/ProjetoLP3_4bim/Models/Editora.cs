using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoLP3_4bim.Models
{
    public partial class Editora
    {
        public Editora()
        {
            Livro = new HashSet<Livro>();
        }

        [Key]
        [Column("idEditora")]
        public int IdEditora { get; set; }

        [Required]
        [Column("nomeEditora")]
        [Display(Name = "Nome")]
        [StringLength(60, ErrorMessage = "O nome deve ter no máximo 60 caracteres.")]
        public string NomeEditora { get; set; }

        [Required]
        [Column("telEditora")]
        [Display(Name = "Telefone")]
        [StringLength(11, ErrorMessage = "O telefone deve ter no máximo 11 números.")]
        public string TelEditora { get; set; }

        [Required]
        [Display(Name = "E-mail")]
        [StringLength(20, ErrorMessage = "O e-mail deve ter no máximo 20 caracteres.")]
        public string EmailEditora { get; set; }


        [InverseProperty("EditoraIdEditoraNavigation")]
        public ICollection<Livro> Livro { get; set; }
    }
}
