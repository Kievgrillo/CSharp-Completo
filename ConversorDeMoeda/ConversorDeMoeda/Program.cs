using System;
using System.Globalization;

namespace ConversorDeMoeda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double cotacaoDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            double quantidadeDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double valorEmReais = ConversorDeMoeda.ConverterDolarParaReal(cotacaoDolar, quantidadeDolar);

            Console.WriteLine("Valor a ser pago em reais = " + valorEmReais.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}