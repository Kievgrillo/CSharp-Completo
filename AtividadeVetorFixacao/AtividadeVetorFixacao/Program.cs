using System;

namespace AtividadeVetorFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudante[] vet = new Estudante[10];

            Console.WriteLine("Quantos quartos serao alugados ? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i}:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.WriteLine("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vet[quarto] = new Estudante(nome, email);
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados");
            for(int i = 0;i < vet.Length;i++)
            {
                if (vet[i] != null)
                {
                    Console.WriteLine(i + ": " + vet[i]);
                }
            }
        }
    }
}