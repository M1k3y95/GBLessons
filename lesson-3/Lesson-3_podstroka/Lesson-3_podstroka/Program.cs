using System;

namespace Lesson_3_podstroka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первую строку:");
            string x = Console.ReadLine();

            Console.WriteLine("Введите вторую строку:");
            string x2 = Console.ReadLine();

            int[,] w = new int[x.Length, x2.Length];

            int maxValue = 0;
            int lenght = 0;

            for (int i = 0; i < x.Length; i++)
            {
                for (int j = 0; j < x2.Length; j++)
                {
                    if (x[i] == x2[j])
                    {
                        w[i, j] = (i == 0 || j == 0) ? 1 : w[i - 1, j - 1] + 1;
                        if (w[i,j] > lenght)
                        {
                            lenght = w[i, j];
                            maxValue = i;
                        }
                    }
                }
            }

            string result = x.Substring(maxValue + 1 - lenght, lenght);
            Console.WriteLine($"Наибольшая подстрока: {result}");
            
        }
    }
}
