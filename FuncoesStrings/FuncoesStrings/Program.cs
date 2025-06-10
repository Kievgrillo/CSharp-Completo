using System;

namespace FuncoesStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "abcde FGHIJ ABC abc DEFG ";

            //fazer com que a variavel se torne totalmente maiuscula
            string s1 = original.ToUpper();

            //fazer com que a variavel se torne totalmente minuscula
            string s2 = original.ToLower();

            //tira os espacos da variavel perto dos ""
            string s3 = original.Trim();

            //função para procurar o index que está em evidência
            int n1 = original.IndexOf("bc");

            //função para procurar o último index que está em evidência
            int n2 = original.LastIndexOf("bc");

            //Recortar a string a partir de um certo ponto, vc fala o indice que inicia
            string s4 = original.Substring(3);

            //Recortar a string a partir de um certo ponto, vc fala o indice que inicia que é o 3  com 5 caracteres em diante
            string s5 = original.Substring(3, 5);

            //substituir um caractere e substituir um string
            string s6 = original.Replace('a', 'x');
            string s7 = original.Replace("abc", "xy");

            //muito útil para saber se a variável está vindo como nula ou vazia ou se usuário deixou em branco algum campo
            bool b1 = String.IsNullOrEmpty(original);

            //vai testar se a variável é nula ou espaço em branco 
            bool b2 = String.IsNullOrWhiteSpace(original);


            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("ToUpper: -" + s1 + "-");
            Console.WriteLine("ToLower: -" + s2 + "-");
            Console.WriteLine("Trim: -" + s3 + "-");
            Console.WriteLine("IndexOf('bc'): " + n1);
            Console.WriteLine("LastIndexOf('bc'): " + n2);
            Console.WriteLine("Substring(3): -" + s4 + "-");
            Console.WriteLine("Substring(3, 5): -" + s5 + "-");
            Console.WriteLine("Replace('a', 'x'): -" + s6 + "-");
            Console.WriteLine("Replace('abc', 'xy'): -" + s7 + "-");
            Console.WriteLine("IsNullOrEmpty: " + b1);
            Console.WriteLine("IsNullOrWhiteSpace: " + b2);
        }
    }
}