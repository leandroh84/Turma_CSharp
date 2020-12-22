using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_06.Conteudo.Exercises
{
    //Escreva uma função que receba como parâmetro um array e o devolve invertido.
    class Exercise_6_07
    {
        static void Main (string[] args)
        {
            int[] array1 = { 1, 2, 3, 4, 5 };
            int[] array2 = InverteArray(array1);
            string result = string.Join(",", array2);
            Console.WriteLine(result);
        }
        static int[] InverteArray (int[] array)
        {
            int posicao = array.Length - 1;
            int[] arrayInvertido = new int[array.Length];
            
            for (int x = 0; x < arrayInvertido.Length; x++)
            {
                arrayInvertido[x] = array[posicao];
                posicao--;
            }
            return arrayInvertido;
        }
    }
}
