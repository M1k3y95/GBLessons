using System;
using System.IO;

namespace lesson_5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите рандомный набор чисел через пробел (от 0 до 255)");

            string[] numbers = Console.ReadLine().Split(' ');
            int[] realNumbers = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                realNumbers[i] = byte.Parse(numbers[i]);
            }

            string path = @"D:\GeekBrains_Lessons\HomeWork\lesson-5\lesson-5.3\binaryFile.txt";

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
            {
                foreach (var item in realNumbers)
                {
                    writer.Write(item);
                }
            }

            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                while (reader.PeekChar() > -1)
                {
                    int number = reader.ReadInt32();
                    Console.WriteLine($"{number} ");
                }
            }
        }
    }
}
