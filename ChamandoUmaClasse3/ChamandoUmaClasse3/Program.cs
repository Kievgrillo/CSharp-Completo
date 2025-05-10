using System;
using System.Globalization;

namespace ChamandoUmaClasse3
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario A1 = new Funcionario();
            Funcionario A2 = new Funcionario();

            Console.WriteLine("Digite os dados do primeiro funcionario :");
            Console.Write("Nome :");
            A1.Nome = Console.ReadLine();
            Console.Write("Salario :");
            A1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite os dados do segundo funcionario :");
            Console.Write("Nome :");
            A2.Nome = Console.ReadLine();
            Console.Write("Salario :");
            A2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double MediaSalario = (A1.Salario + A2.Salario) / 2.0;

            Console.WriteLine("Salario médio = R$" + MediaSalario.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}