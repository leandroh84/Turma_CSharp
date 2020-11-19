using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_02.Conteudo.Exercises
{
    class Exercise_2_2
    {
        static void Main(string[] args)
        {
            int x;

            Console.WriteLine("Type a number.");
            x = int.Parse(Console.ReadLine());

            int y = x - 1;

            Console.WriteLine("The number before is " +y);
        }
    }
}
