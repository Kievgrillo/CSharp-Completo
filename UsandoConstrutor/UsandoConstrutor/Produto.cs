using System.Globalization;

namespace UsandoConstrutor
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        // var de parametro de entrada de funcao "(int quantidade)"
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade = Quantidade + quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade = Quantidade - quantidade;
        }
        public override string ToString()
        {
            return Nome + ", $" + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", " + Quantidade + " unidades, Total: $ " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}