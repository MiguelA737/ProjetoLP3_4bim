using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoLP3_4bim.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Autor",
                columns: table => new
                {
                    idAutor = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nomeAutor = table.Column<string>(unicode: false, maxLength: 1, nullable: false),
                    dataNascAutor = table.Column<DateTime>(type: "date", nullable: false),
                    nacionalidadeAutor = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    telAutor = table.Column<string>(unicode: false, maxLength: 11, nullable: false),
                    emailAutor = table.Column<string>(unicode: false, maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autor", x => x.idAutor);
                });

            migrationBuilder.CreateTable(
                name: "Editora",
                columns: table => new
                {
                    idEditora = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nomeEditora = table.Column<string>(unicode: false, maxLength: 1, nullable: false),
                    telEditora = table.Column<string>(unicode: false, maxLength: 1, nullable: false),
                    emailEditora = table.Column<string>(unicode: false, maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Editora", x => x.idEditora);
                });

            migrationBuilder.CreateTable(
                name: "GeneroLivro",
                columns: table => new
                {
                    idGeneroLivro = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nomeGeneroLivro = table.Column<string>(unicode: false, maxLength: 1, nullable: false),
                    desGeneroLivro = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneroLivro", x => x.idGeneroLivro);
                });

            migrationBuilder.CreateTable(
                name: "Pais",
                columns: table => new
                {
                    idPais = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nomePais = table.Column<string>(unicode: false, maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pais", x => x.idPais);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    idUsuario = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nomeUsuario = table.Column<string>(unicode: false, maxLength: 1, nullable: false),
                    dataNascUsuario = table.Column<DateTime>(type: "date", nullable: false),
                    telUsuario = table.Column<string>(unicode: false, maxLength: 11, nullable: false),
                    emailUSUARIO = table.Column<string>(unicode: false, maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.idUsuario);
                });

            migrationBuilder.CreateTable(
                name: "Livro",
                columns: table => new
                {
                    idLivro = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Editora_idEditora = table.Column<int>(nullable: false),
                    GeneroLivro_idGeneroLivro = table.Column<int>(nullable: false),
                    Autor_idAutor = table.Column<int>(nullable: false),
                    tituloLivro = table.Column<string>(unicode: false, maxLength: 1, nullable: false),
                    dataLancamentoLivro = table.Column<DateTime>(type: "date", nullable: false),
                    qtdPaginasLivro = table.Column<int>(nullable: false),
                    precoLivro = table.Column<decimal>(type: "decimal(18, 0)", nullable: false),
                    sinopseLivro = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Livro", x => x.idLivro);
                    table.ForeignKey(
                        name: "FK__Livro__Autor_idA__619B8048",
                        column: x => x.Autor_idAutor,
                        principalTable: "Autor",
                        principalColumn: "idAutor",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Livro__Editora_i__5FB337D6",
                        column: x => x.Editora_idEditora,
                        principalTable: "Editora",
                        principalColumn: "idEditora",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Livro__GeneroLiv__60A75C0F",
                        column: x => x.GeneroLivro_idGeneroLivro,
                        principalTable: "GeneroLivro",
                        principalColumn: "idGeneroLivro",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Bairro",
                columns: table => new
                {
                    idBairro = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Pais_idPais = table.Column<int>(nullable: false),
                    nomeBairro = table.Column<string>(unicode: false, maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bairro", x => x.idBairro);
                    table.ForeignKey(
                        name: "FK__Bairro__Pais_idP__4CA06362",
                        column: x => x.Pais_idPais,
                        principalTable: "Pais",
                        principalColumn: "idPais",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Compra",
                columns: table => new
                {
                    idCompra = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Livro_idLivro = table.Column<int>(nullable: false),
                    Usuario_idUsuario = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compra", x => x.idCompra);
                    table.ForeignKey(
                        name: "FK__Compra__Livro_id__6477ECF3",
                        column: x => x.Livro_idLivro,
                        principalTable: "Livro",
                        principalColumn: "idLivro",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Compra__Usuario___656C112C",
                        column: x => x.Usuario_idUsuario,
                        principalTable: "Usuario",
                        principalColumn: "idUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Estoque",
                columns: table => new
                {
                    idEstoque = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Livro_idLivro = table.Column<int>(nullable: false),
                    qtdLivro = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estoque", x => x.idEstoque);
                    table.ForeignKey(
                        name: "FK__Estoque__Livro_i__68487DD7",
                        column: x => x.Livro_idLivro,
                        principalTable: "Livro",
                        principalColumn: "idLivro",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rua",
                columns: table => new
                {
                    idRua = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Bairro_idBairro = table.Column<int>(nullable: false),
                    nomeRua = table.Column<string>(unicode: false, maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rua", x => x.idRua);
                    table.ForeignKey(
                        name: "FK__Rua__Bairro_idBa__4F7CD00D",
                        column: x => x.Bairro_idBairro,
                        principalTable: "Bairro",
                        principalColumn: "idBairro",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    idEndereco = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Rua_idRua = table.Column<int>(nullable: false),
                    numeroEndereco = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.idEndereco);
                    table.ForeignKey(
                        name: "FK__Endereco__Rua_id__52593CB8",
                        column: x => x.Rua_idRua,
                        principalTable: "Rua",
                        principalColumn: "idRua",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Livraria",
                columns: table => new
                {
                    idLivraria = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Endereco_idEndereco = table.Column<int>(nullable: false),
                    nomeLivraria = table.Column<string>(unicode: false, maxLength: 1, nullable: false),
                    telLivraria = table.Column<string>(unicode: false, maxLength: 11, nullable: false),
                    emailLivraria = table.Column<string>(unicode: false, maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Livraria", x => x.idLivraria);
                    table.ForeignKey(
                        name: "FK__Livraria__Endere__5535A963",
                        column: x => x.Endereco_idEndereco,
                        principalTable: "Endereco",
                        principalColumn: "idEndereco",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bairro_Pais_idPais",
                table: "Bairro",
                column: "Pais_idPais");

            migrationBuilder.CreateIndex(
                name: "IX_Compra_Livro_idLivro",
                table: "Compra",
                column: "Livro_idLivro");

            migrationBuilder.CreateIndex(
                name: "IX_Compra_Usuario_idUsuario",
                table: "Compra",
                column: "Usuario_idUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_Rua_idRua",
                table: "Endereco",
                column: "Rua_idRua");

            migrationBuilder.CreateIndex(
                name: "IX_Estoque_Livro_idLivro",
                table: "Estoque",
                column: "Livro_idLivro");

            migrationBuilder.CreateIndex(
                name: "IX_Livraria_Endereco_idEndereco",
                table: "Livraria",
                column: "Endereco_idEndereco");

            migrationBuilder.CreateIndex(
                name: "IX_Livro_Autor_idAutor",
                table: "Livro",
                column: "Autor_idAutor");

            migrationBuilder.CreateIndex(
                name: "IX_Livro_Editora_idEditora",
                table: "Livro",
                column: "Editora_idEditora");

            migrationBuilder.CreateIndex(
                name: "IX_Livro_GeneroLivro_idGeneroLivro",
                table: "Livro",
                column: "GeneroLivro_idGeneroLivro");

            migrationBuilder.CreateIndex(
                name: "IX_Rua_Bairro_idBairro",
                table: "Rua",
                column: "Bairro_idBairro");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Compra");

            migrationBuilder.DropTable(
                name: "Estoque");

            migrationBuilder.DropTable(
                name: "Livraria");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Livro");

            migrationBuilder.DropTable(
                name: "Endereco");

            migrationBuilder.DropTable(
                name: "Autor");

            migrationBuilder.DropTable(
                name: "Editora");

            migrationBuilder.DropTable(
                name: "GeneroLivro");

            migrationBuilder.DropTable(
                name: "Rua");

            migrationBuilder.DropTable(
                name: "Bairro");

            migrationBuilder.DropTable(
                name: "Pais");
        }
    }
}
