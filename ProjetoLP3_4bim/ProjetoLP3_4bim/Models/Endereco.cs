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
        [Column("Rua_idRua")]
        public int RuaIdRua { get; set; }
        [Column("numeroEndereco")]
        public int NumeroEndereco { get; set; }

        [ForeignKey("RuaIdRua")]
        [InverseProperty("Endereco")]
        public Rua RuaIdRuaNavigation { get; set; }
        [InverseProperty("EnderecoIdEnderecoNavigation")]
        public ICollection<Livraria> Livraria { get; set; }
    }
}
