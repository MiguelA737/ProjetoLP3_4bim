using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoLP3_4bim.Models
{
    public partial class Pais
    {
        public Pais()
        {
            Bairro = new HashSet<Bairro>();
        }

        [Key]
        [Column("idPais")]
        public int IdPais { get; set; }
        [Column("nomePais")]
        [Display(Name = "Nome")]
        [StringLength(60, ErrorMessage = "Deve ter no máximo 60 caracteres."), Required(ErrorMessage = "O nome é obrigatório.")]
        public string NomePais { get; set; }

        [InverseProperty("PaisIdPaisNavigation")]
        public ICollection<Bairro> Bairro { get; set; }
    }
}
