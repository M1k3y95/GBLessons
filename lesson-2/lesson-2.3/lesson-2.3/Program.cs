using System;

namespace lesson_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int number = int.Parse(Console.ReadLine());

            bool evenOrNot = number % 2 == 0;

            if (evenOrNot)
            {
                Console.WriteLine($"{number} - четное число");
            }
            else
            {
                Console.WriteLine($"{number} - нечетное число");
            }
        }
    }
}
