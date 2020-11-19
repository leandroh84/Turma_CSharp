using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_02.Conteudo.Exercises
{
    class Exercise_2_7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type the Fahrenheit temperature to convert to Celsius.");
            double f = double.Parse(Console.ReadLine());

            double c = (f - 32) * 5 / 9;
            Console.WriteLine(c+ "°C");
        }
    }
}
