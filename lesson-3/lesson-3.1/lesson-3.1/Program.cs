using System;

namespace lesson_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[5,5];

            Random random = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(0, 9);
                }
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i,j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine(array[i,i]);
            }
        }
    }
}
