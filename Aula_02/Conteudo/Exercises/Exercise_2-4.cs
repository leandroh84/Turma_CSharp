using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_02.Conteudo.Exercises
{
    class Exercise_2_4
    {
        static void Main(string[] args)
        {
            string name;
            int age;

            Console.WriteLine("What is your first name?");
            name = Console.ReadLine();
            Console.WriteLine("How old are you?");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("Your name is " +name+ " and you are " +age+ " years old");
        }
    }
}
