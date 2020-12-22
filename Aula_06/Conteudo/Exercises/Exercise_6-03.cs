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
            Console.WriteLine("Type a number and then it expoent");
            int v1 = int.Parse(Console.ReadLine());
            int v2 = int.Parse(Console.ReadLine());
            Expoent(v1,v2);
        }
        public static void Expoent(int n1, int n2)
        {
            double res = Math.Pow(n1, n2);
            Console.WriteLine(res);
        }
    }
}
