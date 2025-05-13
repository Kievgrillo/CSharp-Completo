using System;
using System.Globalization;

namespace ClasseRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo L = new Retangulo();

            Console.WriteLine("Entre com a largura e altura do retângulo: ");
            L.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            L.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Area = " + L.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perimetro = " + L.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal = " + L.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}