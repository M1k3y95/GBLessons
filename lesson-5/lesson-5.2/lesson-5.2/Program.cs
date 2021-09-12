using System;
using System.IO;

namespace lesson_5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string date = $"{DateTime.Now} \n";

            File.AppendAllText(@"D:\GeekBrains_Lessons\HomeWork\lesson-5\lesson-5.2\startup.txt", date);
        }
    }
}
