using System.Globalization;

namespace AtividadeComLista
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Pagamento { get; private set; }

        public Funcionario(int id, string nome, double pagamento)
        {
            Id = id;
            Nome = nome;
            Pagamento = pagamento;
        }

        public void Salario(double porcentagem)
        {
            Pagamento += Pagamento + porcentagem / 100.00;
        }

        public override string ToString()
        {
            return Id + ", " + Nome + ", " + Pagamento.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
