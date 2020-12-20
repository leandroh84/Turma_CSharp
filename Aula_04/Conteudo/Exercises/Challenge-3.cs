using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_04.Conteudo.Exercises
{
    class Challenge_3
    {
        static void Main(string[] args)
        {

            Console.WriteLine("============================ FIBONACCI ============================");
            Console.WriteLine("\n\nType a number between 3 and 20");
            int n = int.Parse(Console.ReadLine());

            int t1 = 1;
            int t2 = 1;
            int t3 = t1 + t2;

            if (n >= 3 && n <= 20)
            {
                Console.WriteLine("\n\n" + t1);
                Console.WriteLine(t2);
                Console.WriteLine(t3);

                for (int x = 3; x < n; x++)
                {
                    t2 = t3;
                    t3 = t2 + t1;
                    t1 = t2;
                    Console.WriteLine(t3);
                }
            }
            else
            {
                Console.WriteLine("Invalid Number, try again.");
            }
        }
    }
}
