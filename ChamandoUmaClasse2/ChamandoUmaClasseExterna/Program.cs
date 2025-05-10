using System;

namespace ChamandoUmaClasseExterna
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoas p1 = new Pessoas();
            Pessoas p2 = new Pessoas();

            Console.WriteLine("Digita os dados da primeira pessoa: ");
            Console.Write("Nome : ");
            p1.Nome = Console.ReadLine();
            Console.Write("Idade : ");
            p1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digita os dados da segunda pessoa: ");
            Console.Write("Nome : ");
            p2.Nome = Console.ReadLine();
            Console.Write("Idade : ");
            p2.Idade = int.Parse(Console.ReadLine());

            if (p1.Idade > p2.Idade)
            {
                Console.WriteLine("A primeira pessoa é mais velha: ");
            } else
            {
                Console.WriteLine("A segunda pessoa é mais velha:");
            }
        }
    }
}