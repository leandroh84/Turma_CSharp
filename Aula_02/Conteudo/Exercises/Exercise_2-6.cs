using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_02.Conteudo.Exercises
{
    class Exercise_2_6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many voters are there?");
            int voters = int.Parse(Console.ReadLine());
            Console.WriteLine("How many blank votes?");
            int blank = int.Parse(Console.ReadLine());
            Console.WriteLine("How many null votes?");
            int nulo = int.Parse(Console.ReadLine());
            Console.WriteLine("How many valid votes?");
            int valid = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Total voters: " +voters);
            
            double blankvotes = (blank * 100) / voters;
            Console.WriteLine("Blank votes: {0:0.00}%", blankvotes);

            double nullvotes = (nulo * 100) / voters;
            Console.WriteLine("Null votes: {0:0.00}%", nullvotes);

            double validvotes = (valid * 100) / voters;
            Console.WriteLine("Valid votes: {0:0.00}%", validvotes);
        }
    }
}
