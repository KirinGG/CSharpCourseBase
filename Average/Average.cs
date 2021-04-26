using System;

namespace Average
{
    class Average
    {
        static void Main(string[] args)
        {
            const int numbersRangeBegin = 3;
            const int numbersRangeEnd = 10;

            int numbersSum = 0;
            int evenNumbersSum = 0;
            int evenNumbersCount = 0;
            int i = numbersRangeBegin;

            while (i <= numbersRangeEnd)
            {
                numbersSum += i;

                if (i % 2 == 0)
                {
                    evenNumbersSum += i;
                    evenNumbersCount++;
                }

                i++;
            }

            double numbersAverage = (double)numbersSum / ((numbersRangeEnd - numbersRangeBegin) + 1);
            Console.WriteLine("Среднее арифметическое чисел из диапазона от {0} до {1} = {2}", numbersRangeBegin, numbersRangeEnd, numbersAverage);

            double evenNumbersAverage = (double)evenNumbersSum / evenNumbersCount;
            Console.WriteLine("Среднее арифметическое четных чисел из диапазона от {0} до {1} = {2}", numbersRangeBegin, numbersRangeEnd, evenNumbersAverage);
        }
    }
}
