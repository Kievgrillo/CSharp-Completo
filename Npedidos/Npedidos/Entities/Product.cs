namespace Npedidos.Entities
{
    class Product
    {
        public double Price { get; set; }
        public string Name { get; set; }

        public Product()
        {
        }
        public Product(double price, string name)
        {
            Price = price;
            Name = name;
        }
    }
}
