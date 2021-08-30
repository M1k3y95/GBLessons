using System;

namespace palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            //Реализация с числовыми манипуляциями

            Console.WriteLine("Введите число для проверки");

            int numberAgain = int.Parse(Console.ReadLine());

            int andAgain = numberAgain;

            int result = 0;

            while (andAgain > 0)
            {
                result *= 10;
                result += andAgain % 10;
                andAgain /= 10;
            }

            if (numberAgain == result)
            {
                Console.WriteLine($"{numberAgain} | {result}");
                Console.WriteLine("Число является палиндромом!");
            }
            else
            {
                Console.WriteLine($"{numberAgain} | {result}");
                Console.WriteLine("Число не является палиндромом!");
            }


            // Реализация с уже заданным числом

            int[] numberArray = { 121, 199, 212, 405, 404 };
            string someNumber;
            string oneMoreNumber;
            char[] someArr;

            foreach (var item in numberArray)
            {
                someNumber = Convert.ToString(item);
                someArr = someNumber.ToCharArray();
                Array.Reverse(someArr);
                oneMoreNumber = new string(someArr);

                if (someNumber == oneMoreNumber)
                {
                    Console.WriteLine($"{item} | {oneMoreNumber}");
                    Console.WriteLine("Число является палиндромом!");
                }
                else
                {
                    Console.WriteLine($"{item} | {oneMoreNumber}");
                    Console.WriteLine("Число не является палиндромом!");
                }
            }


            // Реализация с пользовательским вводом

            Console.WriteLine("Введите число, чтобы узнать, является ли оно палиндромом:");
            string number = Console.ReadLine();

            char[] arr = number.ToCharArray();
            Array.Reverse(arr);
            string reverseNumber = new string(arr);

            Console.WriteLine();

            if (number == reverseNumber)
            {
                Console.WriteLine($"{number} | {reverseNumber}");
                Console.WriteLine("Число является палиндромом!");
            }
            else
            {
                Console.WriteLine($"{number} | {reverseNumber}");
                Console.WriteLine("Число не является палиндромом!");
            }

            Console.WriteLine();
        }
    }
}
