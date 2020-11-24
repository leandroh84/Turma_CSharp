using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_03.Conteudo.Exercises
{
    class Exercise_3_02
    {
        static void Main (string[] args)
        {
            Console.WriteLine("=========== Fuel Option ===========");
            Console.WriteLine("1 - Etanol\n2 - Gasoline\n");
            Console.WriteLine("Type your option below.");
            int option = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Liters:");
            double l = double.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    if(l >= 20)
                    {
                        double discount = (2.9 - (2.9 * 0.05)) * l;
                        Console.WriteLine("TOTAL: R${0:0.000}", discount);
                    }
                    else
                    {
                        double discount = (2.9 - (2.9 * 0.03)) * l;
                        Console.WriteLine("TOTAL: R${0:0.000}", discount);
                    }
                    break;
                case 2:
                    if (l >= 20)
                    {
                        double discount = (3.3 - (3.3 * 0.06)) * l;
                        Console.WriteLine("TOTAL: R${0:0.000}", discount);
                    }
                    else
                    {
                        double discount = (3.3 - (3.3 * 0.04)) * l;
                        Console.WriteLine("TOTAL: R${0:0.000}", discount);
                    }
                    break;
                default:
                    Console.WriteLine("Invalid Option!");
                    break;
            }
        }
    }
}
