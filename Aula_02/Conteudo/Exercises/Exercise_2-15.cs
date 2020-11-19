using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_02.Conteudo.Exercises
{
    class Exercise_2_15
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Worker name:");
            string name = Console.ReadLine();
            Console.WriteLine("How much " +name+ " earn per hour?");
            double salary = double.Parse(Console.ReadLine());
            Console.WriteLine("How many hours did he does this moth?");
            double hours = int.Parse(Console.ReadLine());

            double Overtime = hours - 120.0;
            double extraMoney = Overtime * ((salary * (50.0 / 100.0))+salary);
            double totalMonth = extraMoney + (120.0 * salary);
            double noExtra = salary * hours;

            if (hours > 120.0)
            {
                Console.WriteLine("\n\nHour unit: " +hours+ "              Rate: ${0:00.00}", salary);
                Console.WriteLine("Overtime: " +Overtime+ " hour(s)              Extra money ${0:00.00}: ", extraMoney);
                Console.WriteLine("Regular: ${0:00.00}", 120*salary);
                Console.WriteLine("Total month: ${0:00.00}", (120*salary)+extraMoney);
            }
            else
            {
                Console.WriteLine("\n\nHour unit: " + hours + "              Rate: ${0:00.00}", salary);
                Console.WriteLine("Overtime: " + Overtime + " hour(s)              Extra money: $00.00");
                Console.WriteLine("Salary = $" +noExtra);
            }
        }
    }
}
