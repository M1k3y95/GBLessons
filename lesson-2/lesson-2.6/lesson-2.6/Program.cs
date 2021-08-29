using System;

namespace lesson_2._6
{
    class Program
    {
        [Flags]
        public enum DayOfWeek
        {
            Понедельник = 0b_0000001,
            Вторник = 0b_0000010,
            Среда = 0b_0000100,
            Четверг = 0b_0001000,
            Пятница = 0b_0010000,
            Суббота = 0b_0100000,
            Воскресенье = 0b_1000000
        }
        static void Main(string[] args)
        {
            DayOfWeek firstOffice = (DayOfWeek)0b_0011110;
            DayOfWeek secondOffice = (DayOfWeek)0b_1111111;

            Console.WriteLine($"Расписание рабочей недели первого офиса:\n {firstOffice}");
            Console.WriteLine();
            Console.WriteLine($"Расписание рабочей недели второго офиса:\n {secondOffice}");
        }
    }
}


