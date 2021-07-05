using System;

namespace pooMaiorIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1;

            Pessoa p2;

            Pessoa p3;

            Console.WriteLine("Determina qual é pessoa é a mais velha");

            //leitura de dados da 1 pessoa

            Console.Write("Nome da 1 pessoa: ");

            p1 = new Pessoa();

            p1.Nome = Console.ReadLine();

            Console.Write("Idade da 1 pessoa: ");

            p1.Idade = Convert.ToInt32(Console.ReadLine());

            //leitura de dados da 2 pessoa

            Console.Write("Nome da 2 pessoa: ");

            p2 = new Pessoa();

            p2.Nome = Console.ReadLine();

            Console.Write("Idade da 2 pessoa: ");

            p2.Idade = Convert.ToInt32(Console.ReadLine());

            //leitura de dados da 3 pessoa

            Console.Write("Nome da 3 pessoa: ");

            String nome = Console.ReadLine();

            Console.Write("Idade da 3 pessoa: ");

            int idade = Convert.ToInt32(Console.ReadLine());

            p3 = new Pessoa(idade, nome);

            Console.WriteLine(qualMaior(p1, p2, p3));
        }


        private static string qualMaior(params Pessoa[] list)
        {
            int maior = list[0].Idade;
            string nome = "";
            foreach (Pessoa pessoa in list)
            {
                if (maior < pessoa.Idade)
                {
                    maior = pessoa.Idade;
                    nome = pessoa.Nome;
                }
            }
            return nome;
        }
    }
}
