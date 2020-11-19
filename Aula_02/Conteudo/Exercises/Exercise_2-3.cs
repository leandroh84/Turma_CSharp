using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_02.Conteudo.Exercises
{
    class Exercise_2_3
    {
        static void Main(string[] args)
        {
            double x, y;

            Console.WriteLine("Type the rectangle base.");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Type the rectangle hight.");
            y = double.Parse(Console.ReadLine());

            double area = x * y;

            Console.WriteLine("The rectangle area is " +area);
        }
    }
}
