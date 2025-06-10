using System;

namespace Date
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2025, 06, 10);
            DateTime d2 = new DateTime(2025, 06, 10, 20, 45, 1);
            DateTime d3 = new DateTime(2025, 06, 10, 20, 45, 1, 500);

            DateTime d4 = DateTime.Now;
            DateTime d5 = DateTime.UtcNow;
            DateTime d6 = DateTime.Today;

            DateTime d7 = DateTime.Parse("2023-08-15");
            DateTime d8 = DateTime.Parse("2023-08-15 13:05:30");

            DateTime d9 = DateTime.Parse("19/08/2021");
            DateTime d10 = DateTime.Parse("01/06/2025 12:11:30");

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine(d7);
            Console.WriteLine(d8);
            Console.WriteLine(d9);
            Console.WriteLine(d10);
        }
    }
}