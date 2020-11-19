using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_02.Conteudo.Exercises
{
    class Exercise_2_12
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many apples did you buy?");
            int a = int.Parse(Console.ReadLine());

            double price;

            if (a >= 12)
            {
                price = a * 1.0;
                Console.WriteLine("Total price: R$ " +price);
            }
            else
            {
                price = a * 1.3;
                Console.WriteLine("Total price: R$ " +price);
            }
        }
    }
}
