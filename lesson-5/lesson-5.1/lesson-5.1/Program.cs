using System;
using System.IO;

namespace lesson_5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите данные в консоль");

            string someText = Console.ReadLine();

            Console.WriteLine("Введите название файла");

            string fileName = Console.ReadLine();

            File.WriteAllText(@$"D:\GeekBrains_Lessons\HomeWork\lesson-5\lesson-5.1\{fileName}.txt", someText);
        }
    }
}
