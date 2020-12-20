using System;

namespace Aula_05
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um algoritmo que permita a leitura das notas de uma turma de 5 alunos. 
            Calcular a média da turma e contar quantos alunos obteve nota acima desta média calculada.*/
            string[,] school = new string[5, 3];

            Console.WriteLine("Type students name:");
            school[0, 0] = Console.ReadLine();
            school[1, 0] = Console.ReadLine();
            school[2, 0] = Console.ReadLine();
            school[3, 0] = Console.ReadLine();
            school[4, 0] = Console.ReadLine();

            Console.WriteLine("Type the marks for " + school[0, 0] + " in the last 2 exams");
            school[0, 1] = Console.ReadLine();
            school[0, 2] = Console.ReadLine();

            Console.WriteLine("Type the marks for " + school[1, 0] + " in the last 2 exams");
            school[1, 1] = Console.ReadLine();
            school[1, 2] = Console.ReadLine();

            Console.WriteLine("Type the marks for " + school[2, 0] + " in the last 2 exams");
            school[2, 1] = Console.ReadLine();
            school[2, 2] = Console.ReadLine();

            Console.WriteLine("Type the marks for " + school[3, 0] + " in the last 2 exams");
            school[3, 1] = Console.ReadLine();
            school[3, 2] = Console.ReadLine();

            Console.WriteLine("Type the marks for " + school[4, 0] + " in the last 2 exams");
            school[4, 1] = Console.ReadLine();
            school[4, 2] = Console.ReadLine();

            Console.WriteLine("=================== Class Average ===================");

            double classaverage = ((Convert.ToDouble(school[0, 1]) + Convert.ToDouble(school[0, 2])) +
                                (Convert.ToDouble(school[1, 1]) + Convert.ToDouble(school[1, 2])) +
                                (Convert.ToDouble(school[2, 1]) + Convert.ToDouble(school[2, 2])) +
                                (Convert.ToDouble(school[3, 1]) + Convert.ToDouble(school[3, 2])) +
                                (Convert.ToDouble(school[4, 1]) + Convert.ToDouble(school[4, 2]))) / 2;

            Console.WriteLine("Class average = " + classaverage);

            Console.WriteLine("=================== Individual Average ===================");

            double individualaverage = 0;

            for (int l = 0; l <= 4; l++)
            {
                for (int c = 1; c <= 2; c++)
                {
                    individualaverage = (Convert.ToDouble(school[l, c]) + Convert.ToDouble(school[l, c])) / 2;

                    for (int count = 0; individualaverage > classaverage; count++)
                    {
                        Console.WriteLine(count+ " scored obove average.");
                    }
                }
            }
        }
    }
}
