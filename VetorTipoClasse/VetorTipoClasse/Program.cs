using System.Globalization;
using VetorTipoClasse;

namespace Vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Produto[] vet = new Produto[n];

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vet[i] = new Produto(name, preco);
            }

            double soma = 0.0;
            for (int i = 0; i < n; i++)
            {
                soma += vet[i].Preco;
            }

            double avg = soma / n;

            Console.WriteLine("Preço Medio = " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}