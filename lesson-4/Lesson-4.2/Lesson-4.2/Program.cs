using System;

namespace Lesson_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа через пробел (некорректные значения будут заменены на 0)");
            string numberString = Console.ReadLine();

            Console.WriteLine($"S = {GetSum(numberString)}"); ;
        }

        static int GetSum(string numberString)
        {
            string[] numberStrArr = numberString.Split(' ');

            int sum = 0;

            for (int i = 0; i < numberStrArr.Length; i++)
            {
                int number;
                bool success = int.TryParse(numberStrArr[i], out number);
                if (success)
                {
                    sum += number;
                }
                else
                {

                    Console.WriteLine($"Неккоретное значение \"{numberStrArr[i]}\" было изменено на 0");
                    sum += 0;
                }
            }

            return sum;
        }
    }
}
