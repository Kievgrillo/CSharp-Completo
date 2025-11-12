using System;

namespace ApplicationLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            //specify the data source
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };

            //define the query expression
            IEnumerable<int> result = numbers
               .Where(n => n % 2 == 0)
               .Select(n => n * n);
            //Execute the query
            foreach (int n in result)
            {
                Console.WriteLine(n);
            }
        }
    }
}