using System;
using System.Collections.Generic;
using System.Linq;

namespace PrimeiroPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada = "";
            List<Pessoa> alunos = new List<Pessoa>();

            var p1 = new Pessoa("Exemplo de Aluno", 18, alunos.Count());
           

            do
            {
                Console.Clear();

                if (entrada == "add")
                {
                    
                    Console.WriteLine("Para adicionar um aluno, digite seu nome: ");
                    var Nome = Console.ReadLine();
                    Console.WriteLine("Digite agora a idade do aluno: ");
                    var Idade = int.Parse(Console.ReadLine());
                    var Id = alunos.Count();

                    var pessoa = new Pessoa(Nome, Idade, Id);

                    alunos.Add(pessoa);
                    Console.WriteLine("Deseja mais alguma coisa? Digite 'sim' para voltar ou 'exit' para sair");
                    entrada = Console.ReadLine();
                    if (entrada == "sim")
                    {
                        entrada = string.Empty;
                    }
                }

                if (entrada == "dir")
                {
                    Console.WriteLine(String.Join("------------" + Environment.NewLine, alunos));
                    entrada = string.Empty;
                }

                if (entrada == "search")
                {
                    Console.WriteLine("Digite o nome do aluno que deseja encontrar: ");
                    var busca = Console.ReadLine();
                    var result = alunos.Where(a => a.Nome.Contains(busca));
                    Console.WriteLine(String.Join("------------" + Environment.NewLine, result));
                }

                Console.WriteLine("--------------[ Banco de Dados de Alunos ]------------");
                Console.WriteLine("Digite 'add' para adicionar um aluno.");
                Console.WriteLine("Digite 'dir' para ver toda a lista de alunos.");
                Console.WriteLine("Digite 'search' para buscar um aluno. Exemplo de aluno:");
                Console.WriteLine("------------");
                entrada = Console.ReadLine();
            } while (entrada != "exit");
        }
    }
}
