using System;

namespace lesson_2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfCompany = "ООО ВК Друг";
            string service = "Прием с использованием медикаментов";
            string strPrice = "1 * 300";
            int price = 1 * 300;
            int summ = price;
            int received = 500;
            int change = received - summ;

            Console.WriteLine($"{nameOfCompany,20}");
            Console.WriteLine($"{"Кассовый чек", 20}");
            Console.WriteLine($"{service,20}");
            Console.WriteLine($"01. {strPrice,25} = {price}");
            Console.WriteLine($"ИТОГ: {summ,29}");
            Console.WriteLine($"Получено наличными: {received, 15}");
            Console.WriteLine($"Сдача: {change,28}");
        }
    }
}
