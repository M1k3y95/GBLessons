using System;

namespace lesson_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Это твой забор - пиши шо хошь");

            string inputStr = Console.ReadLine();

            char[] inputArr = inputStr.ToCharArray();

            Array.Reverse(inputArr);

            inputStr = new string (inputArr);

            Console.WriteLine(inputStr);
        }
    }
}
