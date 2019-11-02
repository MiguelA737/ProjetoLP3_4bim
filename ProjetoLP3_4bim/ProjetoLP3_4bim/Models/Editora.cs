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
        [StringLength(1)]
        public string NomeEditora { get; set; }
        [Required]
        [Column("telEditora")]
        [StringLength(1)]
        public string TelEditora { get; set; }
        [Required]
        [Column("emailEditora")]
        [StringLength(1)]
        public string EmailEditora { get; set; }

        [InverseProperty("EditoraIdEditoraNavigation")]
        public ICollection<Livro> Livro { get; set; }
    }
}
