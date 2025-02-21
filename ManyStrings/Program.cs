using System;
using System.Text; 

namespace ManyStrings
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Hello LP1!");

            string string1 = "texto\t e '\u263d'";
            Console.WriteLine(string1);

            string string2 = "texto2\t e '\u2646'";
            Console.WriteLine(string2);
        }
    }
}
