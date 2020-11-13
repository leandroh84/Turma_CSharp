using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_01.Conteudo.Exercises
{
    class Exercise3
    {
        static void Main(string[] args)
        {
            //Circle perimeter
            double radius = 6.5;
            double perimeter = 2 * radius * Math.PI;
            double area = Math.Pow(radius, 2) * Math.PI;

            Console.WriteLine("Perimeter: " +perimeter+ "\n Area: " +area);
        }
    }
}
