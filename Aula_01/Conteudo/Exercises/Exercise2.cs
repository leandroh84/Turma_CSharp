using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_01.Conteudo.Exercises
{
    class Exercise2
    {
        static void Main(string[] args)
        {
            //Gabriel marks
            double score1 = 6.5;
            double score2 = 7.8;
            double score3 = 8.0;
            double score4 = 7.1;
            int weight1 = 2;
            int weight2 = 3;

            double weightedAverage = ((score1 * weight1) + (score2 * weight1) + (score3 * weight2) + 
                (score4 * weight2)) / 
                (weight1 + weight1 + weight2 + weight2);

            Console.WriteLine("Gabriel weighted average is: {0:00.00}", weightedAverage);

            if (weightedAverage >= 6)
            {
                Console.WriteLine("Approved");
            }
            else
            {
                Console.WriteLine("Reproved");
            }

        }
    }
}
