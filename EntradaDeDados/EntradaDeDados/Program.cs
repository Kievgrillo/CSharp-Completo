using System;

namespace EntradaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            string A = vet[0];
            string B = vet[1];
            string C = vet[2];

            Console.WriteLine(A);
            Console.WriteLine(B);
            Console.WriteLine(C);
        }
    }
}