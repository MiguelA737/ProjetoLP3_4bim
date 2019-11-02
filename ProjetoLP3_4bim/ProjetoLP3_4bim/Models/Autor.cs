using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoLP3_4bim.Models
{
    public partial class Autor
    {
        public Autor()
        {
            Livro = new HashSet<Livro>();
        }

        [Key]
        [Column("idAutor")]
        public int IdAutor { get; set; }
        [Required]
        [Column("nomeAutor")]
        [StringLength(1)]
        public string NomeAutor { get; set; }
        [Column("dataNascAutor", TypeName = "date")]
        public DateTime DataNascAutor { get; set; }
        [Column("nacionalidadeAutor")]
        [StringLength(1)]
        public string NacionalidadeAutor { get; set; }
        [Required]
        [Column("telAutor")]
        [StringLength(11)]
        public string TelAutor { get; set; }
        [Required]
        [Column("emailAutor")]
        [StringLength(1)]
        public string EmailAutor { get; set; }

        [InverseProperty("AutorIdAutorNavigation")]
        public ICollection<Livro> Livro { get; set; }
    }
}
