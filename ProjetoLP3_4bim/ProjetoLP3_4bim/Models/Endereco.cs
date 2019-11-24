using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoLP3_4bim.Models
{
    public partial class Endereco
    {
        public Endereco()
        {
            Livraria = new HashSet<Livraria>();
        }

        [Key]
        [Column("idEndereco")]
        public int IdEndereco { get; set; }

        [Required(ErrorMessage = "A rua é obrigatória")]
        [Column("Rua_idRua")]
        [Display(Name = "Rua")]
        public int RuaIdRua { get; set; }

        [Required(ErrorMessage = "O número é obrigatório")]
        [Column("numeroEndereco")]
        [Display(Name = "Número")]
        public int NumeroEndereco { get; set; }

        [ForeignKey("RuaIdRua")]
        [InverseProperty("Endereco")]
        [Display(Name = "Rua")]
        public Rua RuaIdRuaNavigation { get; set; }

        [InverseProperty("EnderecoIdEnderecoNavigation")]
        public ICollection<Livraria> Livraria { get; set; }

    }
}
