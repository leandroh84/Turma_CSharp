using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_03.Conteudo.Exercises
{
    class Challenge
    {
        static void Main (string [] args)
        {
            Console.WriteLine("================= Zodiac Signs =================");
            Console.WriteLine("Type your birth month: ");
            int month = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Type your birth day: ");
            int day = int.Parse(Console.ReadLine());

            string sign = "";
            
            switch (month)
            {
                case 1:
                    sign = (day < 21) ? "Capricorn" : "Aquarius";
                    break;
                case 2:
                    sign = (day < 20) ? "Aquarius" : "Pisces";
                    break;
                case 3:
                    sign = (day < 21) ? "Pisces" : "Aries";
                    break;
                case 4:
                    sign = (day < 21) ? "Aries" : "Taurus";
                    break;
                case 5:
                    sign = (day < 21) ? "Taurus" : "Gemini";
                    break;
                case 6:
                    sign = (day < 21) ? "Gemini" : "Cancer";
                    break;
                case 7:
                    sign = (day < 22) ? "Cancer" : "Leo";
                    break;
                case 8:
                    sign = (day < 23) ? "Leo" : "Virgo";
                    break;
                case 9:
                    sign = (day < 23) ? "Virgo" : "Libra";
                    break;
                case 10:
                    sign = (day < 23) ? "Libra" : "Scorpio";
                    break;
                case 11:
                    sign = (day < 22) ? "Scorpio" : "Sagittarius";
                    break;
                case 12:
                    sign = (day < 22) ? "Sagitarius" : "Capricorn";
                    break;
                default:
                    Console.WriteLine("Invalid month.");
                    break;
            }
        }
    }
}
