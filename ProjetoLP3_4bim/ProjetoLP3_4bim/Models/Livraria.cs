using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoLP3_4bim.Models
{
    public partial class Livraria
    {
        [Key]
        [Column("idLivraria")]
        public int IdLivraria { get; set; }
        [Column("Endereco_idEndereco")]
        public int EnderecoIdEndereco { get; set; }
        [Required]
        [Column("nomeLivraria")]
        [StringLength(1)]
        public string NomeLivraria { get; set; }
        [Required]
        [Column("telLivraria")]
        [StringLength(11)]
        public string TelLivraria { get; set; }
        [Required]
        [Column("emailLivraria")]
        [StringLength(1)]
        public string EmailLivraria { get; set; }

        [ForeignKey("EnderecoIdEndereco")]
        [InverseProperty("Livraria")]
        public Endereco EnderecoIdEnderecoNavigation { get; set; }
    }
}
