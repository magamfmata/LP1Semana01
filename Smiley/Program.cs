using System;
using System.Text; 
using System.Globalization;
using System.Runtime.CompilerServices;

namespace Smiley
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Insire o código: ");
            string input1 = Console.ReadLine(); 

            int value = Convert.ToInt32(input1);
            
            char output = Convert.ToChar(input1);
            
            
            




        }
    }
}
