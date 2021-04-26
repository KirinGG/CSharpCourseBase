using System;

namespace AverageArray
{
    class ArrayAverage
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 5, 3, 4 };
            Console.WriteLine("Среднеарифметическое элементов массива = {0}", GetEvenNumbersAverage(numbers));
        }

        public static double GetEvenNumbersAverage(int[] numbers)
        {
            int evenNumbersSum = 0;
            int evenNumbersCount = 0;

            foreach (int e in numbers)
            {
                if (e % 2 == 0)
                {
                    evenNumbersSum += e;
                    evenNumbersCount++;
                }
            }

            return (double)evenNumbersSum / evenNumbersCount;
        }
    }
}
