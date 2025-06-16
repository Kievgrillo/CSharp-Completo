using Enums.Entities;
using Enums.Entities.Enums;
using System;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 100,
                Moment = DateTime.Now,
                Status = OrderStatus.PagamentoPendente
            };

            Console.WriteLine(order);

            //trasnformando um tipo enumerado para tipo string
            string txt = OrderStatus.PagamentoPendente.ToString();
            Console.WriteLine(txt);

            //transformando um tipo string para um tipo enumerado
            OrderStatus OS = Enum.Parse<OrderStatus>("Entregue");
            Console.WriteLine(OS);
        }
    }
}