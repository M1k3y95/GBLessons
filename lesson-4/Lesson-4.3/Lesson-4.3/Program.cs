using System;

namespace Lesson_4._3
{
    class Program
    {
        enum Seasons
        {
            Зима = 1, Весна, Лето, Осень
        }

        static void Main(string[] args)
        {
            int number;
            do
            {
                Console.WriteLine("Введите порядковый номер месяца");

                bool success = int.TryParse(Console.ReadLine(), out number);
                if (success && number < 13 && number > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Ошибка: введите число от 1 до 12");
                }
            } while (true);

            Console.WriteLine($"Сейчас {GetSeason(number)}");
        }

        private static Seasons GetSeason(int number)
        {
            Seasons season = Seasons.Зима;

            switch (number)
            {
                case 1:
                case 11:
                case 12:
                    season = (Seasons)1;
                    break;

                case 2:
                case 4:
                case 3:                
                    season = (Seasons)2;
                    break;

                case 5:
                case 6:
                case 7:
                    season = (Seasons)3;
                    break;

                case 8:
                case 9:
                case 10:
                    season = (Seasons)4;
                    break;

                default:
                    break;
            }

            return season;
        }
    }
}
