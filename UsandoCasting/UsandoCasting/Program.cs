using System;

namespace UsandoCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 5;
            int B = 2;

            //Conversao implicita, fazendo a var A INT ser divisivel por DOUBLE
            double resultado = (double)A / B;

            Console.WriteLine(resultado);
        }
    }
}