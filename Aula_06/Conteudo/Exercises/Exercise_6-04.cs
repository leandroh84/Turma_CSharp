using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_06.Conteudo.Exercises
{
    //Escreva uma função que calcule a área de um círculo, recebendo o raio como parâmetro.
    class Exercise_6_04
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Type the radius.");
            double area = Radius(double.Parse(Console.ReadLine()));
            Console.WriteLine(area);
        }
        public static double Radius(double r)
        {
            double a = Math.PI * r * r;
            return a;
        }
    }
}
