using System;
using System.Text; 
namespace VariousTypes
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Hello LP1!");
            int variavel1 = 6;
            uint variavel2 = 6U; 
            long variavel3 = 6L;
            ulong variavel4 = 6UL;
            
            Console.WriteLine(variavel1);
            Console.WriteLine(variavel2);
            Console.WriteLine(variavel3);
            Console.WriteLine(variavel4);

            char estrela = '\u269D';
            Console.WriteLine(estrela);

            char lua = '\u263D';
            Console.WriteLine(lua);

        }
    }
}
