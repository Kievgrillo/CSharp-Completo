using System;
using System.Collections.Generic;

namespace MetodoList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("maria");
            list.Add("joao");
            list.Add("bob");
            list.Add("Ana");
            list.Add("gabriel");
            list.Add("Alvaro");
            list.Insert(2, "marco");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("List count : " + list.Count);

            //Expressao lambda ,forma resumida de um metodo do parametro x que deve encontrar a partir da posicao 0 de x alguem que o caractere A no nome.
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("Primeiro 'A' " + s1);
            //encontrar a ultima posicao
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Ultimo 'A' " + s2);
            int pos2 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Primeira posicao " + pos2);
            // Encontrar a ultima ocorrencia do parametro x que tenha o caractere A
            int pos1 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Ultima posicao " + pos1);

            List<String> list2 = list.FindAll(x => x.Length == 6);
            Console.WriteLine("-------------");
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }

            list.Remove("maria");
            Console.WriteLine("-------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveAt(2);
            Console.WriteLine("-------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveRange(2, 1);
            Console.WriteLine("-------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveAll(x => x[0] == 'A');
            Console.WriteLine("-------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            
        }
    }
}