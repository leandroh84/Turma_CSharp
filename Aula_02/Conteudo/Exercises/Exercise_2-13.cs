using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_02.Conteudo.Exercises
{
    class Exercise_2_13
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type your year of birth.");
            int y = int.Parse(Console.ReadLine());

            int t = DateTime.Now.Year;
            int x = t - y;

            if (x >= 16)
            {
                Console.WriteLine("You can change the future of your country.");
            }
            else
            {
                int d = 16 - x;
                Console.WriteLine("Sorry, you can vote in " +d+ " years.");
            }
        }
    }
}
