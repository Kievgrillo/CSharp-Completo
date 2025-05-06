using System;
using System.Globalization;

namespace EntradaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            char B = char.Parse(Console.ReadLine());
            double C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //para poder aceitar valores com "."

            string[] vet = Console.ReadLine().Split(' '); //vetor 
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture); //para poder aceitar valores com "."

           
            Console.WriteLine("Numero inteiro :" + A);  //Cancatenando VAR
            Console.WriteLine("Caractere :" + B);
            Console.WriteLine("Numero double : " + C);
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2" , CultureInfo.InvariantCulture));

        }
    }
}