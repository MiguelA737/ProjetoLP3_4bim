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
        [Required]
        [Column("nomeUsuario")]
        [StringLength(1)]
        public string NomeUsuario { get; set; }
        [Column("dataNascUsuario", TypeName = "date")]
        public DateTime DataNascUsuario { get; set; }
        [Required]
        [Column("telUsuario")]
        [StringLength(11)]
        public string TelUsuario { get; set; }
        [Required]
        [Column("emailUSUARIO")]
        [StringLength(1)]
        public string EmailUsuario { get; set; }

        [InverseProperty("UsuarioIdUsuarioNavigation")]
        public ICollection<Compra> Compra { get; set; }
    }
}
