using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesafioPratico.Biblioteca;
using DesafioPratico.GerenciamentoFuncionarios;

namespace DesafioPratico
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n--- Desafio Prático POO ---");
                Console.WriteLine("Escolha o sistema:");
                Console.WriteLine("1 - Biblioteca");
                Console.WriteLine("2 - Funcionário");
                Console.WriteLine("0 - Sair");
                Console.Write("Opção: ");
                var opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        RodarSistemaBiblioteca();
                        break;
                    case "2":
                        RodarSistemaFuncionario();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }

        //Executa o sistema de biblioteca
        static void RodarSistemaBiblioteca()
        {
            var biblioteca = new ClassBiblioteca();
            bool sair = false;

            while (!sair)
            {
                Console.WriteLine("\n--- Biblioteca de Livros ---");
                Console.WriteLine("1. Cadastrar Livro");
                Console.WriteLine("2. Listar Livros");
                Console.WriteLine("3. Buscar Livros");
                Console.WriteLine("4. Atualizar Livro");
                Console.WriteLine("5. Remover Livro");
                Console.WriteLine("0. Voltar ao menu principal");
                Console.Write("Escolha uma opção: ");
                var opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Write("Título: ");
                        var titulo = Console.ReadLine();
                        Console.Write("Autor: ");
                        var autor = Console.ReadLine();
                        Console.Write("ISBN: ");
                        var isbn = Console.ReadLine();
                        biblioteca.CadastrarLivro(titulo, autor, isbn);
                        break;
                    case "2":
                        biblioteca.ListarLivros();
                        break;
                    case "3":
                        Console.Write("Digite o termo de busca: ");
                        var termoBusca = Console.ReadLine();
                        var resultados = biblioteca.BuscarLivros(termoBusca);
                        if (resultados.Count == 0)
                            Console.WriteLine("Nenhum livro encontrado.");
                        else
                            foreach (var livro in resultados)
                                Console.WriteLine($"Título: {livro.Titulo}, Autor: {livro.Autor}, ISBN: {livro.ISBN}");
                        break;
                    case "4":
                        Console.Write("Digite o ISBN do livro a ser atualizado: ");
                        var isbnAtualizar = Console.ReadLine();
                        Console.Write("Novo Título: ");
                        var novoTitulo = Console.ReadLine();
                        Console.Write("Novo Autor: ");
                        var novoAutor = Console.ReadLine();
                        biblioteca.AtualizarLivro(isbnAtualizar, novoTitulo, novoAutor);
                        break;
                    case "5":
                        Console.Write("Digite o ISBN do livro a ser removido: ");
                        var isbnRemover = Console.ReadLine();
                        biblioteca.RemoverLivro(isbnRemover);
                        break;
                    case "0":
                        sair = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }

        //Executa o sistema de funcionários
        static void RodarSistemaFuncionario()
        {
            var gerenciador = new GerenciadorFuncionarios();

            while (true)
            {
                Console.WriteLine("\n--- Gerenciamento de Funcionários ---");
                Console.WriteLine("1. Cadastrar");
                Console.WriteLine("2. Listar");
                Console.WriteLine("3. Buscar");
                Console.WriteLine("4. Atualizar");
                Console.WriteLine("5. Remover");
                Console.WriteLine("0. Voltar ao menu principal");
                Console.Write("Escolha uma opção: ");
                var opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Write("Nome: ");
                        var nome = Console.ReadLine();
                        Console.Write("ID: ");
                        int.TryParse(Console.ReadLine(), out var id);
                        Console.Write("Cargo: ");
                        var cargo = Console.ReadLine();
                        gerenciador.CadastrarFuncionario(id, nome, cargo);
                        break;
                    case "2":
                        gerenciador.ListarFuncionarios();
                        break;
                    case "3":
                        Console.Write("Buscar por (1) Nome ou (2) ID? ");
                        var tipoBusca = Console.ReadLine();
                        if (tipoBusca == "1")
                        {
                            Console.Write("Nome: ");
                            var buscaNome = Console.ReadLine();
                            var encontrados = gerenciador.BuscarPorNome(buscaNome);
                            if (encontrados.Count == 0)
                                Console.WriteLine("Nenhum funcionário encontrado.");
                            else
                                foreach (var f in encontrados)
                                    Console.WriteLine($"ID: {f.Id}, Nome: {f.Nome}, Cargo: {f.Cargo}");
                        }
                        else if (tipoBusca == "2")
                        {
                            Console.Write("ID: ");
                            int.TryParse(Console.ReadLine(), out var buscaId);
                            var f = gerenciador.BuscarPorId(buscaId);
                            if (f == null)
                                Console.WriteLine("Funcionário não encontrado.");
                            else
                                Console.WriteLine($"ID: {f.Id}, Nome: {f.Nome}, Cargo: {f.Cargo}");
                        }
                        break;
                    case "4":
                        Console.Write("ID do funcionário a atualizar: ");
                        int.TryParse(Console.ReadLine(), out var idAtualizar);
                        Console.Write("Novo nome: ");
                        var novoNome = Console.ReadLine();
                        Console.Write("Novo cargo: ");
                        var novoCargo = Console.ReadLine();
                        gerenciador.AtualizarFuncionario(idAtualizar, novoNome, novoCargo);
                        break;
                    case "5":
                        Console.Write("ID do funcionário a remover: ");
                        int.TryParse(Console.ReadLine(), out var idRemover);
                        gerenciador.RemoverFuncionario(idRemover);
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }
    }

}
