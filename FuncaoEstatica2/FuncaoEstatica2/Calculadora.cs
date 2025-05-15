

namespace FuncaoEstatica2
{
    class Calculadora
    {
        public static double Pi = 3.14;

        public static double circunferencia(double R)
        {
            return 2.0 * Pi * R;
        }
        public static double Volume(double R)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(R, 3.0);
        }
    }
}
