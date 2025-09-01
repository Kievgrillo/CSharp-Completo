using HerdarCumprirContrato.Model.Entities;
using HerdarCumprirContrato.Model.Enums;

namespace HerdarCumprirContrato
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape s1 = new Circle() { Color = Color.White, Radius = 2.0 };
            IShape s2 = new Rectangle() { Color = Color.Black, Height = 4.2, width = 3.5 };

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}