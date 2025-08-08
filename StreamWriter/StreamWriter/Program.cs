using System;

namespace StreamWriterr
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcerPatch = @"C:\Users\Keven\test.txt";
            string TargetPatch = @"C:\Users\Keven\test2.txt";

            try
            {
                string[] lines = System.IO.File.ReadAllLines(sourcerPatch);

                using (StreamWriter sw = File.AppendText(TargetPatch))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}