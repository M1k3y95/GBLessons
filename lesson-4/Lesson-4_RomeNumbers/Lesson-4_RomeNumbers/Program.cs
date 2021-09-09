using System;
using System.Linq;

namespace Lesson_4_RomeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Введите римское число: ");
                string romeNumber = Console.ReadLine();

                Console.WriteLine(SomeMagic(romeNumber));
            } while (true);

        }

        static int SomeMagic(string romeNumber)
        {
            char[] charArr = romeNumber.ToCharArray();
            int[] numbArr = new int[charArr.Length];

            for (int i = 0; i < charArr.Length; i++)
            {
                switch (charArr[i])
                {
                    case 'I':
                        numbArr[i] = 1;
                        break;

                    case 'V':
                        numbArr[i] = 5;
                        break;

                    case 'X':
                        numbArr[i] = 10;
                        break;

                    case 'L':
                        numbArr[i] = 50;
                        break;

                    case 'C':
                        numbArr[i] = 100;
                        break;

                    case 'D':
                        numbArr[i] = 500;
                        break;

                    case 'M':
                        numbArr[i] = 1000;
                        break;

                    default:
                        Console.WriteLine("В введенных вами данных есть ошибка!");
                        return 0;
                }
            }

            int maxValue = numbArr.Max();
            int maxIndex = numbArr.ToList().IndexOf(maxValue);

            for (int i = 0; i < numbArr.Length; i++)
            {
                if (i < maxIndex)
                {
                    maxValue -= numbArr[i];
                }
                else if (i == maxIndex)
                {
                    continue;
                }
                else
                {
                    maxValue += numbArr[i];
                }
            }


            return maxValue;
        }
    }
}
