using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPratico.GerenciamentoFuncionarios
{
    //Gerencia operações relacionadas aos funcionários
    public class GerenciadorFuncionarios
    {
        private readonly List<Funcionario> funcionarios = new List<Funcionario>();
        private readonly Dictionary<int, Funcionario> funcionariosPorId = new Dictionary<int, Funcionario>();

        public List<Funcionario> BuscarPorNome(string nome)
        {
            return funcionarios.FindAll(f => f.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
        }

        public void CadastrarFuncionario(int id, string nome, string cargo)
        {
            if (funcionariosPorId.ContainsKey(id))
            {
                Console.WriteLine("Funcionário(a) já cadastrado.");
                return;
            }
            var funcionario = new Funcionario { Id = id, Nome = nome, Cargo = cargo };
            funcionarios.Add(funcionario);
            funcionariosPorId[funcionario.Id] = funcionario;
            Console.WriteLine($"Funcionário(a) {nome} cadastrado(a) com sucesso.");
        }

        public void ListarFuncionarios()
        {
            if (funcionarios.Count == 0)
            {
                Console.WriteLine("Nenhum funcionário cadastrado.");
                return;
            }
            Console.WriteLine("Lista de Funcionários:");
            foreach (var funcionario in funcionarios)
            {
                Console.WriteLine($"ID: {funcionario.Id}, Nome: {funcionario.Nome}, Cargo: {funcionario.Cargo}");
            }
        }

        public Funcionario BuscarPorId(int id)
        {
            if (funcionariosPorId.TryGetValue(id, out var funcionario))
            {
                return funcionario;
            }
            return null;
        }

        public void AtualizarFuncionario(int id, string novoNome, string novoCargo)
        {
            if (funcionariosPorId.TryGetValue(id, out var funcionario))
            {
                funcionario.Nome = novoNome;
                funcionario.Cargo = novoCargo;
                Console.WriteLine($"Funcionário {id} atualizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Funcionário não encontrado.");
            }
        }

        public void RemoverFuncionario(int id)
        {
            if (funcionariosPorId.TryGetValue(id, out var funcionario))
            {
                funcionarios.Remove(funcionario);
                funcionariosPorId.Remove(id);
                Console.WriteLine($"Funcionário {id} removido com sucesso.");
            }
            else
            {
                Console.WriteLine("Funcionário não encontrado.");
            }
        }
    }
}
