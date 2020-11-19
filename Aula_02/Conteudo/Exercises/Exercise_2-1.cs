using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_02.Conteudo.Exercises
{
    class Exercise_2_1
    {
        static void Main(string[] args)
        {
            double x, y;
            
            Console.WriteLine("Type a number.");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Type another number to subtract.");
            y = double.Parse(Console.ReadLine());
            double result = x - y;
            Console.WriteLine("The result is: " + result);
        }
    }
}
