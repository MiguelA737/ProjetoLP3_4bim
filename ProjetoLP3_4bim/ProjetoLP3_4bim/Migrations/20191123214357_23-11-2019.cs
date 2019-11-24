using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoLP3_4bim.Migrations
{
    public partial class _23112019 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "emailEditora",
                table: "Editora",
                newName: "EmailEditora");

            migrationBuilder.AlterColumn<string>(
                name: "nomeUsuario",
                table: "Usuario",
                unicode: false,
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 1);

            migrationBuilder.AlterColumn<string>(
                name: "emailUSUARIO",
                table: "Usuario",
                unicode: false,
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 1);

            migrationBuilder.AlterColumn<string>(
                name: "nomeRua",
                table: "Rua",
                unicode: false,
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 1);

            migrationBuilder.AlterColumn<string>(
                name: "nomePais",
                table: "Pais",
                unicode: false,
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 1);

            migrationBuilder.AlterColumn<string>(
                name: "tituloLivro",
                table: "Livro",
                unicode: false,
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 1);

            migrationBuilder.AlterColumn<string>(
                name: "nomeLivraria",
                table: "Livraria",
                unicode: false,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 1);

            migrationBuilder.AlterColumn<string>(
                name: "emailLivraria",
                table: "Livraria",
                unicode: false,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 1);

            migrationBuilder.AlterColumn<string>(
                name: "nomeGeneroLivro",
                table: "GeneroLivro",
                unicode: false,
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 1);

            migrationBuilder.AddColumn<int>(
                name: "Livraria_idLivraria",
                table: "Estoque",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "telEditora",
                table: "Editora",
                unicode: false,
                maxLength: 11,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 1);

            migrationBuilder.AlterColumn<string>(
                name: "nomeEditora",
                table: "Editora",
                unicode: false,
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 1);

            migrationBuilder.AlterColumn<string>(
                name: "EmailEditora",
                table: "Editora",
                unicode: false,
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 1);

            migrationBuilder.AlterColumn<string>(
                name: "nomeBairro",
                table: "Bairro",
                unicode: false,
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 1);

            migrationBuilder.AlterColumn<string>(
                name: "nomeAutor",
                table: "Autor",
                unicode: false,
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 1);

            migrationBuilder.AlterColumn<string>(
                name: "nacionalidadeAutor",
                table: "Autor",
                unicode: false,
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "emailAutor",
                table: "Autor",
                unicode: false,
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 1);

            migrationBuilder.CreateIndex(
                name: "IX_Estoque_Livraria_idLivraria",
                table: "Estoque",
                column: "Livraria_idLivraria");

            migrationBuilder.AddForeignKey(
                name: "FK_Estoque_Livraria_Livraria_idLivraria",
                table: "Estoque",
                column: "Livraria_idLivraria",
                principalTable: "Livraria",
                principalColumn: "idLivraria",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estoque_Livraria_Livraria_idLivraria",
                table: "Estoque");

            migrationBuilder.DropIndex(
                name: "IX_Estoque_Livraria_idLivraria",
                table: "Estoque");

            migrationBuilder.DropColumn(
                name: "Livraria_idLivraria",
                table: "Estoque");

            migrationBuilder.RenameColumn(
                name: "EmailEditora",
                table: "Editora",
                newName: "emailEditora");

            migrationBuilder.AlterColumn<string>(
                name: "nomeUsuario",
                table: "Usuario",
                unicode: false,
                maxLength: 1,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 60);

            migrationBuilder.AlterColumn<string>(
                name: "emailUSUARIO",
                table: "Usuario",
                unicode: false,
                maxLength: 1,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 60);

            migrationBuilder.AlterColumn<string>(
                name: "nomeRua",
                table: "Rua",
                unicode: false,
                maxLength: 1,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 60);

            migrationBuilder.AlterColumn<string>(
                name: "nomePais",
                table: "Pais",
                unicode: false,
                maxLength: 1,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 60);

            migrationBuilder.AlterColumn<string>(
                name: "tituloLivro",
                table: "Livro",
                unicode: false,
                maxLength: 1,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 60);

            migrationBuilder.AlterColumn<string>(
                name: "nomeLivraria",
                table: "Livraria",
                unicode: false,
                maxLength: 1,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false);

            migrationBuilder.AlterColumn<string>(
                name: "emailLivraria",
                table: "Livraria",
                unicode: false,
                maxLength: 1,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false);

            migrationBuilder.AlterColumn<string>(
                name: "nomeGeneroLivro",
                table: "GeneroLivro",
                unicode: false,
                maxLength: 1,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 60);

            migrationBuilder.AlterColumn<string>(
                name: "telEditora",
                table: "Editora",
                unicode: false,
                maxLength: 1,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 11);

            migrationBuilder.AlterColumn<string>(
                name: "nomeEditora",
                table: "Editora",
                unicode: false,
                maxLength: 1,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 60);

            migrationBuilder.AlterColumn<string>(
                name: "emailEditora",
                table: "Editora",
                unicode: false,
                maxLength: 1,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "nomeBairro",
                table: "Bairro",
                unicode: false,
                maxLength: 1,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 60);

            migrationBuilder.AlterColumn<string>(
                name: "nomeAutor",
                table: "Autor",
                unicode: false,
                maxLength: 1,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 60);

            migrationBuilder.AlterColumn<string>(
                name: "nacionalidadeAutor",
                table: "Autor",
                unicode: false,
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "emailAutor",
                table: "Autor",
                unicode: false,
                maxLength: 1,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 20);
        }
    }
}
