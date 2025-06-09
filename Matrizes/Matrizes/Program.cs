using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //ler um INT de N
            int n = int.Parse(Console.ReadLine());

            //declarando a matriz chamada MAT
            int[,] mat = new int[n, n];

            //metodo para percorrer as colunas e linhas da matriz
            for (int i = 0; i < n; i++)
            {
                //criada um vetor VALUES de string
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    //chamando a VAR MAT e preenchendo ela com I e J referente a colunas e linhas da matriz
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            //lendo a diagona principal do programa
            Console.WriteLine("Main diagonal:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i, i] + " ");
            }
            Console.WriteLine();

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("Negative numbers: " + count);

        }
    }
}