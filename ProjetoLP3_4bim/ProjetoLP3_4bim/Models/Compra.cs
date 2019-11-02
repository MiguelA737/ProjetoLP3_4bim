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
        public int LivroIdLivro { get; set; }
        [Column("Usuario_idUsuario")]
        public int UsuarioIdUsuario { get; set; }

        [ForeignKey("LivroIdLivro")]
        [InverseProperty("Compra")]
        public Livro LivroIdLivroNavigation { get; set; }
        [ForeignKey("UsuarioIdUsuario")]
        [InverseProperty("Compra")]
        public Usuario UsuarioIdUsuarioNavigation { get; set; }
    }
}
