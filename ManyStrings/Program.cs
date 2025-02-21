﻿using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text; 

namespace ManyStrings
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Hello LP1!");

            string string1 = "texto1\t e '\u263d'";
            Console.WriteLine(string1);

            string string2 = "texto2\t e '\u2646'";
            Console.WriteLine(string2);

            string string3 = "A "+"Escrever "+"Uma "+"Frase";
            string string4 = "Uma Frase " + 4;

            Console.WriteLine(string3);
            Console.WriteLine(string4);

            string string5 = $"{2} mais {3} e igual a {2 + 3}";
            Console.WriteLine(string5);

            string string6 = $"{6} mais {3} e igual a {6 + 3}";
            Console.WriteLine(string6);



        }
    }
}
