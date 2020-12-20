using System;

namespace Aula_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers();
        }
        static void Numbers()
        {
            int[] keyboard = new int[2];
            Console.WriteLine("Type two numbers");
            keyboard[0] = int.Parse(Console.ReadLine());
            keyboard[1] = int.Parse(Console.ReadLine());

            int result;

            result = (keyboard[0] < keyboard[1]) ? -1 : 0;

            Console.WriteLine(result);
        }
    }
}
