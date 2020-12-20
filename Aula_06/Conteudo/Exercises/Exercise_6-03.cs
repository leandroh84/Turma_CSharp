using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_06.Conteudo.Exercises
{
    //Escreva uma função que receba dois números: base e expoente. Em seguida, calcule a base
    //elevada ao expoente.
    class Exercise_6_03
    {
        static void Main (string[] args)
        {
            Expoent();
        }
        public static void Expoent()
        {
            int[] number = new int[2];
            Console.WriteLine("Type a number and then it expoent");
            number[0] = int.Parse(Console.ReadLine());
            number[1] = int.Parse(Console.ReadLine());

            double res = Math.Pow(number[0], number[1]);
            Console.WriteLine(res);
        }
    }
}
