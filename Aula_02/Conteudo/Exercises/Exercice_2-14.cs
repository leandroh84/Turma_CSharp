using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_02.Conteudo.Exercises
{
    class Exercice_2_14
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("What is your profession?");
            string profession = Console.ReadLine().ToLower();

            if ((age <= 21 || age > 64) || (profession.Equals("student"))) //profession.Equals("student", StringComparison.OrdinalIgnoreCase )
            {
                Console.WriteLine("You can pay half ticket.");
            }
            else
            {
                Console.WriteLine("You do not fill up the requirements to pay half ticket.");
            }
        }
    }
}
