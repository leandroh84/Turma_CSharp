using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_04.Conteudo.Exercises
{
    class Challenge_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================ FATORIAL ================");
            Console.WriteLine("Type a  number:");
            int number = int.Parse(Console.ReadLine());
            int fatorial, i;

            fatorial = number;

            for (i = number - 1; i >= 1; i--)
                fatorial = fatorial * i;
            Console.WriteLine(number+ "! = " +fatorial);
        }
    }
}
