using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_01.Conteudo.Exercises
{
    class Exercise4
    {
        static void Main(string[] args)
        {
            //Calculating average speed
            double distance = 15000;
            double time = 3030;
            double averageSpeed = distance / time; //in meters/seconds
            double kmh = averageSpeed * 3.6;
            double mph = kmh * 0.6214;

            Console.WriteLine("Average Speed: {0:0.00}m/s", averageSpeed);
            Console.WriteLine("Average Speed: {0:0.00}km/h", kmh);
            Console.WriteLine("Average Speed: {0:0.00}mph", mph);
        }
    }
}
