using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_06.Conteudo.Exercises
{
    class Exercise_06_01
    {
       /* Escreva uma função que receba como parâmetro dois números inteiros e retorne -1 se o
          primeiro for menor que o segundo número, 0 se forem iguais ou 1 se o primeiro for maior que
          o segundo número.*/
        static void Main(string[] args)
        {
            Numbers();
        }
        static void Numbers()
        {
            int[] keyboard = new int[2];
            Console.WriteLine("Type two numbers");
            keyboard[0] = int.Parse(Console.ReadLine());
            keyboard[1] = int.Parse(Console.ReadLine());

            int result;

            result = (keyboard[0] < keyboard[1]) ? -1 : 0;

            Console.WriteLine(result);
        }
    }
}
