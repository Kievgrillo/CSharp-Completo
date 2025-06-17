using System.Diagnostics.Contracts;
using WorkerContract.Entities.Enums;

namespace WorkerContract.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public double BaseSalary { get; set; }
        public WorkerLevel Level { get; set; }

        //propriedade chamada contract para receber uma lista de contratos do trabalhador, mas ela n pode ser vazia, pois o trabalhador pode receber varias listas 
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        //Associacao de duas classes diferentes 
        public Department Department { get; set; }

        public Worker()
        {
        }
        public Worker(string name, double baseSalary, WorkerLevel level, Department department)
        {
            Name = name;
            BaseSalary = baseSalary;
            Level = level;
            Department = department;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double soma = BaseSalary;

            //foreach para percorrer a lista de contratos
            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    soma += contract.TotalValue();
                }
            }

            return soma;
        }

    }
}
