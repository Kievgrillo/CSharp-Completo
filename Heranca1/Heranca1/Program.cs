using Heranca1.Entities;

namespace Heranca1
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(8010, "maria", 100.00, 500);

            Console.WriteLine(account.Balance);
        }
    }
}