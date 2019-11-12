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
        [Display(Name = "Nome")]
        [StringLength(60, ErrorMessage = "O nome deve ter no máximo 60 caracteres.")]
        public string NomeAutor { get; set; }

        [DataType(DataType.Date)]
        [Column("dataNascAutor", TypeName = "date")]
        [Display(Name ="Data de Nascimento")]
        public DateTime DataNascAutor { get; set; }

        [Column("nacionalidadeAutor")]
        [Display(Name = "Nacionalidade")]
        [StringLength(20, ErrorMessage = "A nacionalidade deve ter no máximo 20 caracteres.")]
        public string NacionalidadeAutor { get; set; }

        [Required]
        [Column("telAutor")]
        [Display(Name = "Telefone")]
        [StringLength(11, ErrorMessage = "O telefone deve ter no máximo 11 números.")]
        public string TelAutor { get; set; }

        [Required]
        [Column("emailAutor")]
        [Display(Name = "E-mail")]
        [StringLength(20, ErrorMessage = "O e-mail deve ter no máximo 20 caracteres.")]
        public string EmailAutor { get; set; }


        [InverseProperty("AutorIdAutorNavigation")]
        public ICollection<Livro> Livro { get; set; }
    }
}
