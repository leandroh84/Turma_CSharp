using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_04.Conteudo.Exercises
{
    class Exercise_4_02
    {
        static void Main(string[] args)
        {
            int i = 100;
            while (i <= 110)
            {
                if (i > 110)
                    break;
                Console.WriteLine(i);
                i = i + 1;
            }

        }
    }
}
