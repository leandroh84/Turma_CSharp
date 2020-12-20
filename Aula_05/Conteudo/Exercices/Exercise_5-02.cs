using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_05.Conteudo.Exercices
{
    class Exercise_5_02
    {
        static void Main (string[] args)
        {
            int[] number = new int[20] {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20};
            int soma = 0;
            soma = number[1] + number[3] + number[5] + number[7] + number[9] + number[11] + number[13] + number[15] + number[17] + number[19];
            Console.WriteLine(soma);
        }
    }
}
