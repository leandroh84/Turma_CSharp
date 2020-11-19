using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_02.Conteudo.Exercises
{
    class Exercise_2_11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a number.");
            int n = int.Parse(Console.ReadLine());

            int x = n % 2;

            if (x == 0)
            {
                Console.WriteLine("Positive number.");
            }
            else
            {
                Console.WriteLine("Negative number.");
            }
        }
    }
}
