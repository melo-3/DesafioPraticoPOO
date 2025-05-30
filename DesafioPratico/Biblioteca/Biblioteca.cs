using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPratico.Biblioteca
{
    //Gerencia operações relacionadas à biblioteca de livros
    public class ClassBiblioteca
    {
        private List<Livro> livros = new List<Livro>();

        public void CadastrarLivro(string titulo, string autor, string isbn)
        {
            var novoLivro = new Livro
            {
                Titulo = titulo,
                Autor = autor,
                ISBN = isbn
            };
            livros.Add(novoLivro);
        }

        public void ListarLivros()
        {
            if (livros.Count == 0)
            {
                Console.WriteLine("Nenhum livro cadastrado.");
                return;
            }

            foreach (var livro in livros)
            {
                Console.WriteLine($"Título: {livro.Titulo}, Autor: {livro.Autor}, ISBN: {livro.ISBN}");
            }
        }

        public List<Livro> BuscarLivros(string termoBusca)
        {
            if (string.IsNullOrEmpty(termoBusca))
                return new List<Livro>();

            termoBusca = termoBusca.ToLower();

            return livros
                .Where(l => (l.Titulo != null && l.Titulo.ToLower().Contains(termoBusca)) ||
                            (l.Autor != null && l.Autor.ToLower().Contains(termoBusca)))
                .ToList();
        }

        public bool AtualizarLivro(string isbn, string novoTitulo, string novoAutor)
        {
            var livro = livros.FirstOrDefault(l => l.ISBN == isbn);
            if (livro == null)
            {
                Console.WriteLine("Livro não encontrado.");
                return false;
            }

            livro.Titulo = novoTitulo;
            livro.Autor = novoAutor;
            Console.WriteLine("Livro atualizado com sucesso.");
            return true;
        }

        public bool RemoverLivro(string isbn)
        {
            var livro = livros.FirstOrDefault(l => l.ISBN == isbn);
            if (livro == null)
            {
                Console.WriteLine("Livro não encontrado.");
                return false;
            }
            livros.Remove(livro);
            Console.WriteLine("Livro removido com sucesso.");
            return true;
        }
    }
}
