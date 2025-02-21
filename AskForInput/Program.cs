using System;

namespace AskForInput
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello LP1!");

            Console.WriteLine("Insira um número inteiro");
            string input1 = Console.ReadLine();

            int conversor1 = int.Parse(input1);

            Console.WriteLine("Insira um número real");
            string input2 = Console.ReadLine();

            float conversor2 = float.Parse(input2);

            Console.WriteLine($"a soma dos dois números é {conversor1 + conversor2}");
        }
    }
}
