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
        [Required]
        [Column("nomePais")]
        [StringLength(1)]
        public string NomePais { get; set; }

        [InverseProperty("PaisIdPaisNavigation")]
        public ICollection<Bairro> Bairro { get; set; }
    }
}
