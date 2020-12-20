using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_05.Conteudo.Exercices
{
    class Exercise_5_03
    {
        static void Main (string [] args)
        {
            string[] name1 = new string[3];
            Console.WriteLine("Type 3 names:");
            name1[0] = Console.ReadLine();
            name1[1] = Console.ReadLine();
            name1[2] = Console.ReadLine();

            Console.WriteLine("Type another name:");
            string name2 = Console.ReadLine();

            for (int i = 0; i <= 2; i++)
            {
                if (name1[i] == name2)
                {
                    Console.WriteLine("Name " + name2 + " already exist.");
                    //break;
                }

            }
        }
    }
}
