using System;
using System.Globalization;

namespace FuncaoEstatica
{
    class Program
    {
        static double Pi = 3.14;

        static void Main(string[] args)
        {
            Console.WriteLine("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = circunferencia(raio);
            double volume = Volume(raio);

            Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Pi.ToString("F2", CultureInfo.InvariantCulture));
        }

        static double circunferencia(double R)
        {
            return 2.0 * Pi * R;
        }

        static double Volume(double R)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(R, 3.0);
        }
    }
}