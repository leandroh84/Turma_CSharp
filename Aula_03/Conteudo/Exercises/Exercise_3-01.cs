using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_03.Conteudo.Exercises
{
    class Exercise_3_01
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========= Math Operation =========");
            Console.WriteLine("Type the first number: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Type the second number: ");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine("Now choose an operation.\n1- Sum\n2- Subtraction\n3- Division\n4- Multiplication");
            double option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    double sum = x + y;
                    Console.WriteLine(x+ " + " +y+ " = " +sum);
                    break;
                case 2:
                    double subtraction = x - y;
                    Console.WriteLine(x + " - " + y + " = " +subtraction);
                    break;
                case 3:
                    double division = x / y;
                    Console.WriteLine(x + " / " + y + " = " +division);
                    break;
                case 4:
                    double multiplication = x * y;
                    Console.WriteLine(x + " x " + y + " = " +multiplication);
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }
    }
}
