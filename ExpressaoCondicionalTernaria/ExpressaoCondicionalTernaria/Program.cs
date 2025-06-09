using System;
using System.Globalization;

namespace ExpressaoCondicionalTernaria
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //isso substitui um IF dependendo do caso, mais perfomance para o projeto.
            double desconto = (preco < 20.0) ? preco * 0.15 : preco * 0.10;

            Console.WriteLine(desconto);
        }
    }
}