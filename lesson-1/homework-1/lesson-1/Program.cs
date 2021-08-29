using System;

namespace lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше имя:");
            string userName = Console.ReadLine();

            Console.WriteLine($"Привет, {userName}, сегодня {DateTime.Now.ToString("dd/MM/yyyy")}");
        }
    }
}
