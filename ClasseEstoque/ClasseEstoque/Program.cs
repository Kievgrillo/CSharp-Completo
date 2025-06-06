﻿using System;
using System.Net;
using System.Globalization;

namespace ClasseEstoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Entre os dados do produto :");
            Console.Write("Nome : ");
            p.Nome = Console.ReadLine();

            Console.Write("Preço : ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade no estoque : ");
            p.Quantidade = int.Parse(Console.ReadLine());


            Console.WriteLine("Dados do produto:" + p);

            Console.WriteLine();
            Console.Write("Digite o número de propdutos a ser adicionados ao estoque: " );
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);


            Console.WriteLine();
            Console.Write("Digite o número de propdutos a ser removidos do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}