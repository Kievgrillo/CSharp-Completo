using AtividadeComLista;
using System;
using System.Globalization;
using System.Collections.Generic;

namespace AtividaeComLista
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Quantos funcionários serão registrados ?");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> list = new List<Funcionario>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Funcionaroio #" + i + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome :");
                string nome = Console.ReadLine();
                Console.Write("Salário :");
                double pagamento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Funcionario(id, nome, pagamento));
                Console.WriteLine();
            }

            Console.WriteLine("Entre com ID do funcionário que terá o salário aumentado :");
            int procurarId = int.Parse(Console.ReadLine());

            Funcionario func = list.Find(x => x.Id == procurarId);
            if (func != null)
            {
                Console.WriteLine("Entre com porcentagem :");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                func.Salario(porcentagem);
            }
            else
            {
                Console.WriteLine("Id nao existe");
            }
            Console.WriteLine("Lista atualizada de funcionários");
            foreach (Funcionario obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}