using System;

namespace lesson_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] phoneBook = new string[5, 2] { { "Spider-man", "88005553535" },
                                                     { "Kaneki", "1337000993" },
                                                     { "Gill Bates", "4041975" },
                                                     { "Elliot Alderson", "fuckthesociety@mrRobot.com" }, 
                                                     { "Cory Doctorow", "little_brother@Xnet.com" } };

            for (int i = 0; i < phoneBook.GetLength(0); i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    Console.Write($"{phoneBook[i,j]} | {phoneBook[i,j+1]}");
                }
                Console.WriteLine();
            }


        }
    }
}
