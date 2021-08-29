using System;

namespace lesson_2._2
{
    class Program
    {
        enum Month
        {
            Январь = 1,
            Февраль,
            Март,
            Апрель,
            Май,
            Июнь,
            Июль,
            Август,
            Сентябрь,
            Октябрь,
            Ноябрь,
            Декабрь
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите порядковый номер текущего месяца");
            int monthNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите самую низкую температуру за сутки");
            double minTemperature = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите самую высокую температуру за сутки");
            double maxTemperature = double.Parse(Console.ReadLine());

            double avTemperature = (minTemperature + maxTemperature) / 2;

            Console.WriteLine();

            Console.WriteLine($"Сейчас {(Month)monthNumber}");

            if (avTemperature > 0 )
            {
                switch (monthNumber)
                {
                    case 1:
                        Console.WriteLine("Дождливая зима");
                        break;
                    case 2:
                        Console.WriteLine("Дождливая зима");
                        break;
                    case 12:
                        Console.WriteLine("Дождливая зима");
                        break;
                    default:
                        break;
                }
            }
            
        }
    }
}
