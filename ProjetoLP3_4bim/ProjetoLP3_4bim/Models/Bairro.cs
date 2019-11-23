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

        [Display(Name = "País")]
        [Column("Pais_idPais")]
        public int PaisIdPais { get; set; }
        [Column("nomeBairro")]
        [Display(Name = "Nome")]
        [StringLength(60, ErrorMessage = "O nome deve ter no máximo 60 caracteres."), Required(ErrorMessage = "O nome é obrigatório.")]
        public string NomeBairro { get; set; }

        [Display(Name = "País")]
        [ForeignKey("PaisIdPais")]
        [InverseProperty("Bairro")]
        public Pais PaisIdPaisNavigation { get; set; }
        [InverseProperty("BairroIdBairroNavigation")]
        public ICollection<Rua> Rua { get; set; }
    }
}
