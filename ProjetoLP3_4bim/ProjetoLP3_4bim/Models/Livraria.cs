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

        [Required(ErrorMessage = "O endereço da livraria é obrigatório")]
        [Column("Endereco_idEndereco")]
        [Display(Name = "Endereço da Livraria")]
        public int EnderecoIdEndereco { get; set; }

        [Required(ErrorMessage = "O nome da livraria é obrigatório")]
        [Column("nomeLivraria")]
        [Display(Name = "Nome da Livraria")]
        public string NomeLivraria { get; set; }

        [Required(ErrorMessage = "O telefone da livraria é obrigatório")]
        [Column("telLivraria")]
        [StringLength(11, ErrorMessage = "O telefone da livraria deve ter no máximo 11 caracteres.")]
        [Display(Name = "Telefone da Livraria")]
        public string TelLivraria { get; set; }

        [Required(ErrorMessage = "O e-mail da livraria é obrigatório")]
        [Column("emailLivraria")]
        [Display(Name = "E-mail da Livraria")]
        public string EmailLivraria { get; set; }

        [ForeignKey("EnderecoIdEndereco")]
        [InverseProperty("Livraria")]
        [Display(Name = "Endereço da Livraria")]
        public Endereco EnderecoIdEnderecoNavigation { get; set; }
    }
}
