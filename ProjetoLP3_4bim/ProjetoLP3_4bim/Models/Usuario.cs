using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoLP3_4bim.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            Compra = new HashSet<Compra>();
        }

        [Key]
        [Column("idUsuario")]
        public int IdUsuario { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório")]
        [Column("nomeUsuario")]
        [StringLength(60, ErrorMessage = "O nome deve ter no máximo 60 caracteres.")]
        [Display(Name = "Nome")]
        public string NomeUsuario { get; set; }

        [DataType(DataType.Date)]
        [Column("dataNascUsuario", TypeName = "date")]
        [Display(Name = "Data de Nascimento")]
        public DateTime DataNascUsuario { get; set; }

        [Required(ErrorMessage = "O telefone é obrigatório")]
        [Column("telUsuario")]
        [StringLength(11, ErrorMessage = "O telefone deve ter no máximo 11 caracteres.")]
        [Display(Name = "Telefone")]
        public string TelUsuario { get; set; }

        [Required(ErrorMessage = "O e-mail é obrigatório")]
        [Column("emailUSUARIO")]
        [StringLength(60, ErrorMessage = "O e-mail deve ter no máximo 60 caracteres.")]
        [Display(Name = "E-mail")]
        public string EmailUsuario { get; set; }

        [InverseProperty("UsuarioIdUsuarioNavigation")]
        public ICollection<Compra> Compra { get; set; }
    }
}
