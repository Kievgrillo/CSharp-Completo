using System.Globalization;
using System;

namespace DadosFuncionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario F = new Funcionario();

            Console.WriteLine("Nome :");
            F.Nome = Console.ReadLine();
            Console.WriteLine("Salario Bruto :");
            F.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine("Imposto :");
            F.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Funcionário :" + F);
            Console.WriteLine();

            Console.WriteLine("Digite a porcetagem para aumentar o salário: ");
            double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            F.AumentarSalario(porcent);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + F.Nome + F.SalarioBruto);
        }
    }

}