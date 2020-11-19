using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_02.Conteudo.Exercises
{
    class Challenge2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a year.");
            int year = int.Parse(Console.ReadLine());

            if (((year % 400) == 0) || (year % 4 == 0 && year % 100 != 0))
            {
                Console.WriteLine("Leap Year");
            }
            else
            {
                Console.WriteLine("Not Leap Year");
            }
        }
    }
}
