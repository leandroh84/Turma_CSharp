using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_01.Conteudo.Exercises
{
    class Challenge1
    {
        static void Main (string[] args)
        {
            int a = 2;
            int b = 4;
            int c = -6;
            double x1 = (-b + (Math.Sqrt(Math.Pow(b, 2) - 4 * a * c))) / (2 * a);
            double x2 = (-b - (Math.Sqrt(Math.Pow(b, 2) - 4 * a * c))) / (2 * a);

            Console.WriteLine("x1= " +x1+ "\nx2= " +x2);
        }
    }
}
