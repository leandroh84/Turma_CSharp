using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_05.Conteudo.Exercices
{
    class Exercise_5_07
    {
        static void Main (string[] args)
        {
            /* Construa o padrão a seguir usando arrays:
               1 1 1 1
               1 0 0 1
               1 0 0 1
               1 0 0 1
               1 0 0 1
               1 1 1 1*/
            int[,] matrix = new int[6,4];
            int lines = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            //Console.WriteLine(matrix.GetLength(0));

            for (int l = 0; l < lines; l++)
            {
                for (int c = 0; c < columns; c++)
                {
                    matrix[l, c] = 0;

                    if (l == 0 || l == lines - 1)
                        matrix[l, c] = 1;
                    if (c == 0 || c == columns - 1)
                        matrix[l, c] = 1;


                    Console.Write(matrix[l,c] +" ");
                }
                Console.WriteLine();
            }
        }
    }
}
