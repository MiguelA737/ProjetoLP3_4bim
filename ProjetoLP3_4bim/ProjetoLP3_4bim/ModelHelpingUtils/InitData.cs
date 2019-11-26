using ProjetoLP3_4bim.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoLP3_4bim.ModelHelpingUtils
{
    public class InitData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new LivrariasContext(
            serviceProvider.GetRequiredService
            <DbContextOptions<LivrariasContext>>()))
            {
                if(context.Livraria.Any() && context.Autor.Any() && context.Bairro.Any() && context.Editora.Any() && context.Endereco.Any() && context.GeneroLivro.Any() && context.Estoque.Any() && context.Livro.Any() && context.Pais.Any() && context.Rua.Any() && context.Usuario.Any() && context.Compra.Any())
                {
                    return;
                }
                context.Pais.AddRange(
                    new Pais
                    {
                        NomePais = "Brasil"
                    }
                );

                context.Bairro.AddRange(
                    new Bairro
                    {
                        PaisIdPais = 1,
                        NomeBairro = "Mooca"
                    }
                );

                context.Rua.AddRange(
                    new Rua
                    {
                        IdRua = 1,
                        BairroIdBairro = 1,
                        NomeRua = "Rua da Mooca"
                    }
                );

                context.Endereco.AddRange(
                    new Endereco
                    {
                        IdEndereco = 1,
                        RuaIdRua = 1,
                        NumeroEndereco = 333
                    }
                );

                context.Livraria.AddRange(
                    new Livraria
                    {
                        IdLivraria = 1,
                        EnderecoIdEndereco = 1,
                        NomeLivraria = "Culturoteca",
                        TelLivraria = "11940536453",
                        EmailLivraria = "cult@cult.com"
                    }
                );

                context.Usuario.AddRange(
                    new Usuario
                    {
                        NomeUsuario = "Alessandro",
                        DataNascUsuario = DateTime.Now.AddYears(-18),
                        TelUsuario = "11937473078",
                        EmailUsuario = "ale@mail.com.br"
                    }
                );

                context.GeneroLivro.AddRange(
                    new GeneroLivro
                    {
                        NomeGeneroLivro = "Romance Policial",
                        DesGeneroLivro = "Histórias com mistério e suspense!"
                    }
                );

                context.Editora.AddRange(
                    new Editora
                    {
                        NomeEditora = "Ática",
                        TelEditora = "11977977978",
                        EmailEditora = "at@atica.com.br"
                    }
                );

                context.Autor.AddRange(
                    new Autor
                    {
                        NomeAutor = "Conan Doyle",
                        DataNascAutor = DateTime.Now.AddYears(-71),
                        NacionalidadeAutor = "Escocês",
                        TelAutor = "22946592",
                        EmailAutor = "cdoyle@mail.com"
                    }
                );

                context.Livro.AddRange(
                    new Livro
                    {
                        IdLivro = 1,
                        EditoraIdEditora = 1,
                        GeneroLivroIdGeneroLivro = 1,
                        AutorIdAutor = 1,
                        TituloLivro = "Sherlock Holmes 1: Um Estudo Em Vermelho",
                        DataLancamentoLivro = DateTime.Now.AddYears(-50),
                        QtdPaginasLivro = 430,
                        PrecoLivro = 30,
                        SinopseLivro = "Detetive que todos já devem ter ouvido falar."
                    }
                );

                context.Estoque.AddRange(
                    new Estoque
                    {
                        IdEstoque = 1,
                        LivroIdLivro = 1,
                        LivrariaIdLivraria = 1,
                        QtdLivro = 20
                    }
                );

                context.Compra.AddRange(
                    new Compra
                    {
                        IdCompra = 1,
                        LivroIdLivro = 1,
                        UsuarioIdUsuario = 1
                    }
                );

                context.SaveChanges();
            }
        }
    }
}