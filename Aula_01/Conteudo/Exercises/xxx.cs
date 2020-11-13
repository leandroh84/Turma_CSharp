using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_01.Conteudo.Exercises
{
    class xxx
    {
        static void Main(string[] args)
        {
            double score1;
            double score2;
            double score3;
            double score4;
            int weight1 = 2;
            int weight2 = 3;

            Console.WriteLine("Input the first mark: ");
            score1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Input the second mark: ");
            score2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Input the third mark: ");
            score3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Input the fourth mark: ");
            score4 = double.Parse(Console.ReadLine());

            double weightAverage = ((score1 * weight1) + (score2 * weight1) + (score3 * weight2) + (score4 * weight2)) / weight1 + weight1 + weight2 + weight2;

            if (weightAverage >= 42)
            {
                Console.WriteLine("Congratulations, your score was {0:00.00} and you are APPROVED!", weightAverage);
            }
            else
            {
                Console.WriteLine("Unfortunately your score was {0:00.00} and you failed!", weightAverage);
            }
        }

    }
}
