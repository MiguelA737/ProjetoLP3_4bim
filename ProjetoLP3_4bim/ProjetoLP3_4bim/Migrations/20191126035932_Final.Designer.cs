﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoLP3_4bim.Models;

namespace ProjetoLP3_4bim.Migrations
{
    [DbContext(typeof(LivrariasContext))]
    [Migration("20191126035932_Final")]
    partial class Final
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProjetoLP3_4bim.Models.Autor", b =>
                {
                    b.Property<int>("IdAutor")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("idAutor")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataNascAutor")
                        .HasColumnName("dataNascAutor")
                        .HasColumnType("date");

                    b.Property<string>("EmailAutor")
                        .IsRequired()
                        .HasColumnName("emailAutor")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<string>("NacionalidadeAutor")
                        .HasColumnName("nacionalidadeAutor")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<string>("NomeAutor")
                        .IsRequired()
                        .HasColumnName("nomeAutor")
                        .HasMaxLength(60)
                        .IsUnicode(false);

                    b.Property<string>("TelAutor")
                        .IsRequired()
                        .HasColumnName("telAutor")
                        .HasMaxLength(11)
                        .IsUnicode(false);

                    b.HasKey("IdAutor");

                    b.ToTable("Autor");
                });

            modelBuilder.Entity("ProjetoLP3_4bim.Models.Bairro", b =>
                {
                    b.Property<int>("IdBairro")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("idBairro")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NomeBairro")
                        .IsRequired()
                        .HasColumnName("nomeBairro")
                        .HasMaxLength(60)
                        .IsUnicode(false);

                    b.Property<int>("PaisIdPais")
                        .HasColumnName("Pais_idPais");

                    b.HasKey("IdBairro");

                    b.HasIndex("PaisIdPais");

                    b.ToTable("Bairro");
                });

            modelBuilder.Entity("ProjetoLP3_4bim.Models.Compra", b =>
                {
                    b.Property<int>("IdCompra")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("idCompra")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LivroIdLivro")
                        .HasColumnName("Livro_idLivro");

                    b.Property<int>("UsuarioIdUsuario")
                        .HasColumnName("Usuario_idUsuario");

                    b.HasKey("IdCompra");

                    b.HasIndex("LivroIdLivro");

                    b.HasIndex("UsuarioIdUsuario");

                    b.ToTable("Compra");
                });

            modelBuilder.Entity("ProjetoLP3_4bim.Models.Editora", b =>
                {
                    b.Property<int>("IdEditora")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("idEditora")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmailEditora")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<string>("NomeEditora")
                        .IsRequired()
                        .HasColumnName("nomeEditora")
                        .HasMaxLength(60)
                        .IsUnicode(false);

                    b.Property<string>("TelEditora")
                        .IsRequired()
                        .HasColumnName("telEditora")
                        .HasMaxLength(11)
                        .IsUnicode(false);

                    b.HasKey("IdEditora");

                    b.ToTable("Editora");
                });

            modelBuilder.Entity("ProjetoLP3_4bim.Models.Endereco", b =>
                {
                    b.Property<int>("IdEndereco")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("idEndereco")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("NumeroEndereco")
                        .HasColumnName("numeroEndereco");

                    b.Property<int>("RuaIdRua")
                        .HasColumnName("Rua_idRua");

                    b.HasKey("IdEndereco");

                    b.HasIndex("RuaIdRua");

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("ProjetoLP3_4bim.Models.Estoque", b =>
                {
                    b.Property<int>("IdEstoque")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("idEstoque")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LivrariaIdLivraria")
                        .HasColumnName("Livraria_idLivraria");

                    b.Property<int>("LivroIdLivro")
                        .HasColumnName("Livro_idLivro");

                    b.Property<int>("QtdLivro")
                        .HasColumnName("qtdLivro");

                    b.HasKey("IdEstoque");

                    b.HasIndex("LivrariaIdLivraria");

                    b.HasIndex("LivroIdLivro");

                    b.ToTable("Estoque");
                });

            modelBuilder.Entity("ProjetoLP3_4bim.Models.GeneroLivro", b =>
                {
                    b.Property<int>("IdGeneroLivro")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("idGeneroLivro")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DesGeneroLivro")
                        .HasColumnName("desGeneroLivro")
                        .HasColumnType("text")
                        .HasMaxLength(100);

                    b.Property<string>("NomeGeneroLivro")
                        .IsRequired()
                        .HasColumnName("nomeGeneroLivro")
                        .HasMaxLength(60)
                        .IsUnicode(false);

                    b.HasKey("IdGeneroLivro");

                    b.ToTable("GeneroLivro");
                });

            modelBuilder.Entity("ProjetoLP3_4bim.Models.Livraria", b =>
                {
                    b.Property<int>("IdLivraria")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("idLivraria")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmailLivraria")
                        .IsRequired()
                        .HasColumnName("emailLivraria")
                        .IsUnicode(false);

                    b.Property<int>("EnderecoIdEndereco")
                        .HasColumnName("Endereco_idEndereco");

                    b.Property<string>("NomeLivraria")
                        .IsRequired()
                        .HasColumnName("nomeLivraria")
                        .IsUnicode(false);

                    b.Property<string>("TelLivraria")
                        .IsRequired()
                        .HasColumnName("telLivraria")
                        .HasMaxLength(11)
                        .IsUnicode(false);

                    b.HasKey("IdLivraria");

                    b.HasIndex("EnderecoIdEndereco");

                    b.ToTable("Livraria");
                });

            modelBuilder.Entity("ProjetoLP3_4bim.Models.Livro", b =>
                {
                    b.Property<int>("IdLivro")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("idLivro")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AutorIdAutor")
                        .HasColumnName("Autor_idAutor");

                    b.Property<DateTime>("DataLancamentoLivro")
                        .HasColumnName("dataLancamentoLivro")
                        .HasColumnType("date");

                    b.Property<int>("EditoraIdEditora")
                        .HasColumnName("Editora_idEditora");

                    b.Property<int>("GeneroLivroIdGeneroLivro")
                        .HasColumnName("GeneroLivro_idGeneroLivro");

                    b.Property<decimal>("PrecoLivro")
                        .HasColumnName("precoLivro")
                        .HasColumnType("decimal(18, 0)");

                    b.Property<int>("QtdPaginasLivro")
                        .HasColumnName("qtdPaginasLivro");

                    b.Property<string>("SinopseLivro")
                        .HasColumnName("sinopseLivro")
                        .HasColumnType("text");

                    b.Property<string>("TituloLivro")
                        .IsRequired()
                        .HasColumnName("tituloLivro")
                        .HasMaxLength(60)
                        .IsUnicode(false);

                    b.HasKey("IdLivro");

                    b.HasIndex("AutorIdAutor");

                    b.HasIndex("EditoraIdEditora");

                    b.HasIndex("GeneroLivroIdGeneroLivro");

                    b.ToTable("Livro");
                });

            modelBuilder.Entity("ProjetoLP3_4bim.Models.Pais", b =>
                {
                    b.Property<int>("IdPais")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("idPais")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NomePais")
                        .IsRequired()
                        .HasColumnName("nomePais")
                        .HasMaxLength(60)
                        .IsUnicode(false);

                    b.HasKey("IdPais");

                    b.ToTable("Pais");
                });

            modelBuilder.Entity("ProjetoLP3_4bim.Models.Rua", b =>
                {
                    b.Property<int>("IdRua")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("idRua")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BairroIdBairro")
                        .HasColumnName("Bairro_idBairro");

                    b.Property<string>("NomeRua")
                        .IsRequired()
                        .HasColumnName("nomeRua")
                        .HasMaxLength(60)
                        .IsUnicode(false);

                    b.HasKey("IdRua");

                    b.HasIndex("BairroIdBairro");

                    b.ToTable("Rua");
                });

            modelBuilder.Entity("ProjetoLP3_4bim.Models.Usuario", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("idUsuario")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataNascUsuario")
                        .HasColumnName("dataNascUsuario")
                        .HasColumnType("date");

                    b.Property<string>("EmailUsuario")
                        .IsRequired()
                        .HasColumnName("emailUSUARIO")
                        .HasMaxLength(60)
                        .IsUnicode(false);

                    b.Property<string>("NomeUsuario")
                        .IsRequired()
                        .HasColumnName("nomeUsuario")
                        .HasMaxLength(60)
                        .IsUnicode(false);

                    b.Property<string>("TelUsuario")
                        .IsRequired()
                        .HasColumnName("telUsuario")
                        .HasMaxLength(11)
                        .IsUnicode(false);

                    b.HasKey("IdUsuario");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("ProjetoLP3_4bim.Models.Bairro", b =>
                {
                    b.HasOne("ProjetoLP3_4bim.Models.Pais", "PaisIdPaisNavigation")
                        .WithMany("Bairro")
                        .HasForeignKey("PaisIdPais")
                        .HasConstraintName("FK__Bairro__Pais_idP__4CA06362");
                });

            modelBuilder.Entity("ProjetoLP3_4bim.Models.Compra", b =>
                {
                    b.HasOne("ProjetoLP3_4bim.Models.Livro", "LivroIdLivroNavigation")
                        .WithMany("Compra")
                        .HasForeignKey("LivroIdLivro")
                        .HasConstraintName("FK__Compra__Livro_id__6477ECF3");

                    b.HasOne("ProjetoLP3_4bim.Models.Usuario", "UsuarioIdUsuarioNavigation")
                        .WithMany("Compra")
                        .HasForeignKey("UsuarioIdUsuario")
                        .HasConstraintName("FK__Compra__Usuario___656C112C");
                });

            modelBuilder.Entity("ProjetoLP3_4bim.Models.Endereco", b =>
                {
                    b.HasOne("ProjetoLP3_4bim.Models.Rua", "RuaIdRuaNavigation")
                        .WithMany("Endereco")
                        .HasForeignKey("RuaIdRua")
                        .HasConstraintName("FK__Endereco__Rua_id__52593CB8");
                });

            modelBuilder.Entity("ProjetoLP3_4bim.Models.Estoque", b =>
                {
                    b.HasOne("ProjetoLP3_4bim.Models.Livraria", "LivrariaIdLivrariaNavigation")
                        .WithMany("Estoque")
                        .HasForeignKey("LivrariaIdLivraria")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ProjetoLP3_4bim.Models.Livro", "LivroIdLivroNavigation")
                        .WithMany("Estoque")
                        .HasForeignKey("LivroIdLivro")
                        .HasConstraintName("FK__Estoque__Livro_i__68487DD7");
                });

            modelBuilder.Entity("ProjetoLP3_4bim.Models.Livraria", b =>
                {
                    b.HasOne("ProjetoLP3_4bim.Models.Endereco", "EnderecoIdEnderecoNavigation")
                        .WithMany("Livraria")
                        .HasForeignKey("EnderecoIdEndereco")
                        .HasConstraintName("FK__Livraria__Endere__5535A963");
                });

            modelBuilder.Entity("ProjetoLP3_4bim.Models.Livro", b =>
                {
                    b.HasOne("ProjetoLP3_4bim.Models.Autor", "AutorIdAutorNavigation")
                        .WithMany("Livro")
                        .HasForeignKey("AutorIdAutor")
                        .HasConstraintName("FK__Livro__Autor_idA__619B8048");

                    b.HasOne("ProjetoLP3_4bim.Models.Editora", "EditoraIdEditoraNavigation")
                        .WithMany("Livro")
                        .HasForeignKey("EditoraIdEditora")
                        .HasConstraintName("FK__Livro__Editora_i__5FB337D6");

                    b.HasOne("ProjetoLP3_4bim.Models.GeneroLivro", "GeneroLivroIdGeneroLivroNavigation")
                        .WithMany("Livro")
                        .HasForeignKey("GeneroLivroIdGeneroLivro")
                        .HasConstraintName("FK__Livro__GeneroLiv__60A75C0F");
                });

            modelBuilder.Entity("ProjetoLP3_4bim.Models.Rua", b =>
                {
                    b.HasOne("ProjetoLP3_4bim.Models.Bairro", "BairroIdBairroNavigation")
                        .WithMany("Rua")
                        .HasForeignKey("BairroIdBairro")
                        .HasConstraintName("FK__Rua__Bairro_idBa__4F7CD00D");
                });
#pragma warning restore 612, 618
        }
    }
}
