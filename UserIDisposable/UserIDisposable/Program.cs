using System;

namespace UserIDisposable
{
    class Progam
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Keven\test.txt ";

            try
            {
                using (StreamReader sr = File.OpenText(path)) 
                {
                    while(!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }                        
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
