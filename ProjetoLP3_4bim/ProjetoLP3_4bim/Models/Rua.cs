using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoLP3_4bim.Models
{
    public partial class Rua
    {
        public Rua()
        {
            Endereco = new HashSet<Endereco>();
        }

        [Key]
        [Column("idRua")]
        public int IdRua { get; set; }
        [Column("Bairro_idBairro")]
        public int BairroIdBairro { get; set; }
        [Column("nomeRua")]
        [Display(Name = "Nome")]
        [StringLength(60, ErrorMessage = "O nome deve ter no máximo 60 caracteres."), Required(ErrorMessage = "O nome é obrigatório.")]
        public string NomeRua { get; set; }

        [ForeignKey("BairroIdBairro")]
        [InverseProperty("Rua")]
        public Bairro BairroIdBairroNavigation { get; set; }
        [InverseProperty("RuaIdRuaNavigation")]
        public ICollection<Endereco> Endereco { get; set; }
    }
}
