using DiferenceGetHashCodeForValueAndReference.Entities;
using System;
using System.Drawing;
using Point = System.Drawing.Point;

namespace DiferenceGetHashCodeForValueAndReference
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Product> a = new HashSet<Product>();
            a.Add(new Product("TV", 900.00));
            a.Add(new Product("Notebook", 1900.00));

            HashSet<Point> b = new HashSet<Point>();
            b.Add(new Point(3, 4));
            b.Add(new Point(5, 10));

            Product p = new Product("Notebook", 1900.00);
            Console.WriteLine(a.Contains(p));

            Point p2 = new Point(5, 10);
            Console.WriteLine(b.Contains(p2));


        }
    }
}