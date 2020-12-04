using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_04.Conteudo.Exercises
{
    class Exercise_4_05
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a integer number:");
            int n = int.Parse(Console.ReadLine());
            
            while (n >= 1)
            {
                if (n == 0)
                    break;
                Console.WriteLine(n);
                n = n - 1;
            }
        }
    }
}
