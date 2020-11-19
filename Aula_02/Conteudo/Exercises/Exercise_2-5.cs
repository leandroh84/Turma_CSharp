using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_02.Conteudo.Exercises
{
    class Exercise_2_5
    {
        static void Main(string[] args)
        {
            double salary;
            double adjustment;

            Console.WriteLine("Type the salary.");
            salary = double.Parse(Console.ReadLine());
            Console.WriteLine("Type the salary adjustment in %.");
            adjustment = double.Parse(Console.ReadLine());

            double corrected = (salary * (adjustment / 100))+salary;

            Console.WriteLine("The new salary is " +corrected);
        }
    }
}
