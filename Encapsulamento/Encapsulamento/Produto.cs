using System.Globalization;
namespace Course
{
    class Produto
    {
        //indica que os atributos sao privativos e nao podem ser acessados e por convenção no C# para trabalhar com atributo privativo,
        //você coloca o "_nome" antes do atributo eexemplo abaixo.

        private string _nome;
        private double _preco;
        private int _quantidade;
        public Produto()
        {
        }
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        //metodo para receber o valor do atributo nome
        public string GetNome()
        {
            return _nome;
        }

        //metodo para definir o nome
        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 2)
            {
                _nome = nome;
            }
        }
        
        //metodo para receber o valor do atributo preco
        public double GetPreco()
        {
            return _preco;
        }

        //metodo para receber o valor do atributo quantidade
        public int GetQuantidade()
        {
            return _quantidade;
        }
        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}