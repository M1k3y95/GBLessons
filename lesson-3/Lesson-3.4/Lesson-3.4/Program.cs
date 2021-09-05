using System;

namespace Lesson_3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] battleShip =    { {  "O" ,  "O" ,  "O" ,  "O" ,  "O" ,  "O" ,  "O" ,  "O" ,  "O" ,  "O"  },
                                        {  "O" ,  "X" ,  "O" ,  "O" ,  "X" ,  "O" ,  "O" ,  "X" ,  "X" ,  "X"  },
                                        {  "O" ,  "X" ,  "O" ,  "O" ,  "O" ,  "O" ,  "O" ,  "O" ,  "O" ,  "O"  },
                                        {  "O" ,  "O" ,  "O" ,  "X" ,  "X" ,  "X" ,  "O" ,  "O" ,  "X" ,  "O"  },
                                        {  "O" ,  "O" ,  "O" ,  "O" ,  "O" ,  "O" ,  "O" ,  "O" ,  "X" ,  "O"  },
                                        {  "O" ,  "O" ,  "O" ,  "O" ,  "O" ,  "X" ,  "O" ,  "O" ,  "O" ,  "O"  },
                                        {  "O" ,  "O" ,  "X" ,  "X" ,  "O" ,  "X" ,  "O" ,  "O" ,  "O" ,  "O"  },
                                        {  "O" ,  "O" ,  "O" ,  "O" ,  "O" ,  "X" ,  "O" ,  "X" ,  "O" ,  "O"  },
                                        {  "O" ,  "X" ,  "O" ,  "O" ,  "O" ,  "X" ,  "O" ,  "O" ,  "O" ,  "O"  },
                                        {  "O" ,  "O" ,  "O" ,  "O" ,  "O" ,  "O" ,  "O" ,  "O" ,  "X" ,  "O"  }};

            for (int i = 0; i < battleShip.GetLength(0); i++)
            {
                for (int j = 0; j < battleShip.GetLength(1); j++)
                {
                    Console.Write($" {battleShip[i,j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
