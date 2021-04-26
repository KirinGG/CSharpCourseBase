using System;

namespace L5For
{
    class L5For
    {
        static void Main(string[] args)
        {

            int i = 0;

            while (i <= 100)
            {
                if (i == 5 || i % 3 == 0 || (i >= 60 && i <= 80))
                {
                    i++;
                    continue;
                }

                Console.WriteLine(i);
                i++;
            }

            for (i = 0; i <= 100; i++)
            {
                if (i == 5 || i % 3 == 0 || (i >= 60 && i <= 80))
                {
                    continue;
                }

                Console.WriteLine(i);
            }

            /* Console.WriteLine("Пример 1:");

             for (int i = 100; i >= 1; i--)
             {
                 if (i % 4 == 0)
                 {
                     Console.Write("{0},", i);
                 }
             }

             Console.WriteLine("Пример 2:");

             int n = 3;

             for (int i = 1; i <= n; i++)
             {
                 int powI = (int)Math.Pow(i, 2);
                 Console.Write("{0}^2 = {1}; ", i, powI);
             }

             Console.WriteLine("Пример 3:");

             const int rangeBegin = 3;
             const int rangeEnd = 10;

             int numbersSum = 0;

             for (int i = rangeBegin; i <= rangeEnd; i++)
             {
                 numbersSum += i;
             }

             double numbersAverage = (double)numbersSum / ((rangeEnd - rangeBegin) + 1);
             Console.WriteLine("Среднее арифметическое чисел из диапазона от {0} до {1} = {2}", rangeBegin, rangeEnd, numbersAverage);
            */
        }
    }
}

