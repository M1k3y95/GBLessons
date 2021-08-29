using System;

namespace lesson_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите самую низкую температуру за сутки");
            double minTemperature = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите самую высокую температуру за сутки");
            double maxTemperature = double.Parse(Console.ReadLine());

            Console.WriteLine($"Средняя температура за сутки: {(minTemperature + maxTemperature) / 2}");
        }
    }
}
