using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoLP3_4bim.Models
{
    public partial class Compra
    {
        [Key]
        [Column("idCompra")]
        public int IdCompra { get; set; }

        [Column("Livro_idLivro")]
        [Display(Name = "Livro")]
        public int LivroIdLivro { get; set; }

        [Column("Usuario_idUsuario")]
        [Display(Name = "Usuário")]
        public int UsuarioIdUsuario { get; set; }

        [ForeignKey("LivroIdLivro")]
        [InverseProperty("Compra")]
        [Display(Name = "Livro")]
        public Livro LivroIdLivroNavigation { get; set; }

        [ForeignKey("UsuarioIdUsuario")]
        [InverseProperty("Compra")]
        [Display(Name = "Usuário")]
        public Usuario UsuarioIdUsuarioNavigation { get; set; }
    }
}
