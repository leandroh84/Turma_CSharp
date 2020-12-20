using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_05.Conteudo.Exercices
{
    class Exercise_5_06
    {
        static void Main (string[] args)
        {
            /*Dado o array a seguir, encontre o menor e o maior valor:
            int[] tab = { 545, 5665, 65, 76, 12, 65 };*/

            int[] tab = { 545, 5665, 65, 76, 12, 65 };
            int menor = tab[0];
            int maior = tab[0];

            /*for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] < menor)
                    menor = tab[i];

                if (tab[i] > maior)
                    maior = tab[i];
            }*/

            foreach (int i in tab)
            {
                if (i < menor)
                    menor = i;

                if (i > maior)
                    maior = i;
            }

            Console.WriteLine("O menor valor: " +menor);
            Console.WriteLine("O maior valor: " +maior);

        }
    }
}
