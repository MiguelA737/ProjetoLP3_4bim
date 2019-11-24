using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ProjetoLP3_4bim.Models
{
    public partial class LivrariasContext : DbContext
    {
        public LivrariasContext()
        {
        }

        public LivrariasContext(DbContextOptions<LivrariasContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Autor> Autor { get; set; }
        public virtual DbSet<Bairro> Bairro { get; set; }
        public virtual DbSet<Compra> Compra { get; set; }
        public virtual DbSet<Editora> Editora { get; set; }
        public virtual DbSet<Endereco> Endereco { get; set; }
        public virtual DbSet<Estoque> Estoque { get; set; }
        public virtual DbSet<GeneroLivro> GeneroLivro { get; set; }
        public virtual DbSet<Livraria> Livraria { get; set; }
        public virtual DbSet<Livro> Livro { get; set; }
        public virtual DbSet<Pais> Pais { get; set; }
        public virtual DbSet<Rua> Rua { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //if (!optionsBuilder.IsConfigured)
            //{
                optionsBuilder.UseSqlServer("Server=localhost; Database=Livrarias; Trusted_Connection=True;");
            //}
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Autor>(entity =>
            {
                entity.Property(e => e.EmailAutor).IsUnicode(false);

                entity.Property(e => e.NacionalidadeAutor).IsUnicode(false);

                entity.Property(e => e.NomeAutor).IsUnicode(false);

                entity.Property(e => e.TelAutor).IsUnicode(false);
            });

            modelBuilder.Entity<Bairro>(entity =>
            {
                entity.Property(e => e.NomeBairro).IsUnicode(false);

                entity.HasOne(d => d.PaisIdPaisNavigation)
                    .WithMany(p => p.Bairro)
                    .HasForeignKey(d => d.PaisIdPais)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Bairro__Pais_idP__4CA06362");
            });

            modelBuilder.Entity<Compra>(entity =>
            {
                entity.HasOne(d => d.LivroIdLivroNavigation)
                    .WithMany(p => p.Compra)
                    .HasForeignKey(d => d.LivroIdLivro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Compra__Livro_id__6477ECF3");

                entity.HasOne(d => d.UsuarioIdUsuarioNavigation)
                    .WithMany(p => p.Compra)
                    .HasForeignKey(d => d.UsuarioIdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Compra__Usuario___656C112C");
            });

            modelBuilder.Entity<Editora>(entity =>
            {
                entity.Property(e => e.EmailEditora).IsUnicode(false);

                entity.Property(e => e.NomeEditora).IsUnicode(false);

                entity.Property(e => e.TelEditora).IsUnicode(false);
            });

            modelBuilder.Entity<Endereco>(entity =>
            {
                entity.HasOne(d => d.RuaIdRuaNavigation)
                    .WithMany(p => p.Endereco)
                    .HasForeignKey(d => d.RuaIdRua)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Endereco__Rua_id__52593CB8");
            });

            modelBuilder.Entity<Estoque>(entity =>
            {
                entity.HasOne(d => d.LivroIdLivroNavigation)
                    .WithMany(p => p.Estoque)
                    .HasForeignKey(d => d.LivroIdLivro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Estoque__Livro_i__68487DD7");
            });

            modelBuilder.Entity<GeneroLivro>(entity =>
            {
                entity.Property(e => e.NomeGeneroLivro).IsUnicode(false);
            });

            modelBuilder.Entity<Livraria>(entity =>
            {
                entity.Property(e => e.EmailLivraria).IsUnicode(false);

                entity.Property(e => e.NomeLivraria).IsUnicode(false);

                entity.Property(e => e.TelLivraria).IsUnicode(false);

                entity.HasOne(d => d.EnderecoIdEnderecoNavigation)
                    .WithMany(p => p.Livraria)
                    .HasForeignKey(d => d.EnderecoIdEndereco)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Livraria__Endere__5535A963");
            });

            modelBuilder.Entity<Livro>(entity =>
            {
                entity.Property(e => e.TituloLivro).IsUnicode(false);

                entity.HasOne(d => d.AutorIdAutorNavigation)
                    .WithMany(p => p.Livro)
                    .HasForeignKey(d => d.AutorIdAutor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Livro__Autor_idA__619B8048");

                entity.HasOne(d => d.EditoraIdEditoraNavigation)
                    .WithMany(p => p.Livro)
                    .HasForeignKey(d => d.EditoraIdEditora)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Livro__Editora_i__5FB337D6");

                entity.HasOne(d => d.GeneroLivroIdGeneroLivroNavigation)
                    .WithMany(p => p.Livro)
                    .HasForeignKey(d => d.GeneroLivroIdGeneroLivro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Livro__GeneroLiv__60A75C0F");
            });

            modelBuilder.Entity<Pais>(entity =>
            {
                entity.Property(e => e.NomePais).IsUnicode(false);
            });

            modelBuilder.Entity<Rua>(entity =>
            {
                entity.Property(e => e.NomeRua).IsUnicode(false);

                entity.HasOne(d => d.BairroIdBairroNavigation)
                    .WithMany(p => p.Rua)
                    .HasForeignKey(d => d.BairroIdBairro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Rua__Bairro_idBa__4F7CD00D");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.Property(e => e.EmailUsuario).IsUnicode(false);

                entity.Property(e => e.NomeUsuario).IsUnicode(false);

                entity.Property(e => e.TelUsuario).IsUnicode(false);
            });
        }
    }
}
