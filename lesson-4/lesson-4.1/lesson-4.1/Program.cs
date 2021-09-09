using System;

namespace lesson_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Имя: ");
                string firstName = Console.ReadLine();

                Console.Write("Фамилия: ");
                string lastName = Console.ReadLine();

                Console.Write("Отчество: ");
                string patronymic = Console.ReadLine();

                Console.WriteLine(GetFullName(firstName, lastName, patronymic));

                Console.WriteLine();

                Console.WriteLine("Чтобы выйти из программы, введите \"esc\"");

                string escapeOrNot = Console.ReadLine();

                if (escapeOrNot == "esc")
                {
                    break;
                }
            }
        }

        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            string wozaaaaa = $"Здравствуйте, {lastName} {firstName} {patronymic}";

            return wozaaaaa;
        }
    }
}
