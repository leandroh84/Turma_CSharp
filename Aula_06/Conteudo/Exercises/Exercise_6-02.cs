using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_06.Conteudo.Exercises
{
    //Escreva uma função que receba um número e retorne -1 se o número for ímpar ou 1 se for par.
    class Exercise_6_02
    {
        static void Main (string[] args)
        {
            testnumber();
        }
        public static void testnumber()
        {
            int number;
            Console.WriteLine("Type an number");
            number = int.Parse(Console.ReadLine());

            int result;

            result = (number % 2 == 1) ? -1 : 1;
            Console.WriteLine(result);
        }
    }
}
