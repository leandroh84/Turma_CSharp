using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_04.Conteudo.Exercises
{
    class Challenge_2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============== PRIME NUMBERS ==============");
            Console.WriteLine("Type a number");
            int number = int.Parse(Console.ReadLine());

            int rest, count = 0;
            
            for (rest = 2; rest <= number / 2; rest++)
            {
                if (number % 2 == 0)
                {
                    count++;
                    break;
                }
            }

            if (count == 0)
                Console.WriteLine("Prime Number");
            else
                Console.WriteLine("No Prime");

        }
    }
}
