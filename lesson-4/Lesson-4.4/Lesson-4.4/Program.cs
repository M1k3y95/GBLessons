using System;

namespace Lesson_4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            do
            {
                Console.WriteLine("Находим число Фибоначчи. Введите n: ");

                bool success = int.TryParse(Console.ReadLine(), out n);
                if (success)
                {
                    Console.WriteLine(FindFibonacciNumber(n));
                    break;
                }
                else
                {
                    Console.WriteLine("Ошибка: введите корретное число");
                }
            } while (true);
            
        }

        static int FindFibonacciNumber(int n)
        {
            if (n <= 1)
            {
                return n;
            };

            return FindFibonacciNumber(n-1) + FindFibonacciNumber(n - 2);
        }
    }
}
