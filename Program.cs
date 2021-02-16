using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 4;
            int number2 = 3;
            int number3 = 2;
            int sum = number1 + number2;
            int multi = sum * number3;
            Console.WriteLine($"julien a eu {number3} notes cette semaine, {number1}/10 et {number2}/10 ");
            Console.WriteLine($"julien a donc eu {multi}/40");

        }
    }
}
