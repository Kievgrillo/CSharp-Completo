﻿using Course;
using System;

namespace Encapsolamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.00, 10);

            p.SetNome("X");

            Console.WriteLine(p.GetNome());
            Console.WriteLine(p.GetPreco());
        }
    }
}