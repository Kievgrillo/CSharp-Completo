using System;
using System.Globalization;

namespace ClasseAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno AL = new Aluno();

            Console.WriteLine("Digite o nome do aluno: ");
            AL.NomeAluno = Console.ReadLine();

            Console.WriteLine("Digite as tres notas do aluno: ");
            AL.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            AL.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            AL.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("NOTA FINAL: " + AL.NotaAnual().ToString("F2", CultureInfo.InvariantCulture));

            if (AL.Aprovacao())
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
                Console.WriteLine("Faltou " + AL.NotaRestante().ToString("F2", CultureInfo.InvariantCulture) + " Pontos ");
            }

        }
    }
}