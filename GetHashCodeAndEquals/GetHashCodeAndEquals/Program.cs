using GetHashCodeAndEquals.Entities;
using System;

namespace GetHashCodeAndEquals
{
    class program
    {
        static void Main(string[] args)
        {
            Client a = new Client { Name = "Maria", Email = "Maria@gmail.com" };
            Client b = new Client { Name = "Joao", Email = "joao@gmail.com" };

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
        }
    }
}