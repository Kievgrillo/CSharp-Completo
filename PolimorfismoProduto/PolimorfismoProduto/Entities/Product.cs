using System.Globalization;

namespace PolimorfismoProduto.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; } 

        public Product()
        {
        }
        public Product(string nme, double price)
        {
            Name = nme;
            Price = price;
        }

        public virtual string PriceTag()
        {
            return Name
               + " $ "
               + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
