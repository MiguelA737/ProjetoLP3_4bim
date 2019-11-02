using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoLP3_4bim.Models
{
    public partial class Bairro
    {
        public Bairro()
        {
            Rua = new HashSet<Rua>();
        }

        [Key]
        [Column("idBairro")]
        public int IdBairro { get; set; }
        [Column("Pais_idPais")]
        public int PaisIdPais { get; set; }
        [Required]
        [Column("nomeBairro")]
        [StringLength(1)]
        public string NomeBairro { get; set; }

        [ForeignKey("PaisIdPais")]
        [InverseProperty("Bairro")]
        public Pais PaisIdPaisNavigation { get; set; }
        [InverseProperty("BairroIdBairroNavigation")]
        public ICollection<Rua> Rua { get; set; }
    }
}
