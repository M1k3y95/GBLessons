using System;
using System.Diagnostics;

namespace lesson_1_HardcoreUltraEdition_ver.over9000
{
    class Program
    {
        static void Main(string[] args)
        {
            var sw = new Stopwatch();

            sw.Start();

            ulong iterationCount = 0;

            for (int i = 1; i <= 100; i++)
            {
                iterationCount++;
                if (i == 100)
                {
                    Console.Write("buzz");
                    break;
                }

                if (i % 3 == 0 && i % 5 ==0)
                {
                    Console.Write("fizz buzz, ");
                    Console.Write($"{i + 1}, {i + 2}, ");
                    i += 2;
                }
                else if (i % 3 == 0)
                {
                    Console.Write("fizz, ");
                    //if ((i + 1) % 5 != 0)
                    //{
                    //    i++;
                    //    Console.Write($"{i}, ");
                    //}
                }
                else if (i % 5 == 0)
                {
                    Console.Write("buzz, ");
                    //if ((i + 1) % 3 != 0)
                    //{
                    //    i++;
                    //    Console.Write($"{i}, ");
                    //}
                }
                else
                {
                    Console.Write($"{i}, ");
                }
                
            }
            Console.WriteLine();
            Console.WriteLine($"Количество итераций: {iterationCount}");
            sw.Stop();
            Console.WriteLine($"Time Spent: {sw.ElapsedMilliseconds}");
        }
    }
}
