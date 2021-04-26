using System;

namespace sum
{
    class Sum
    {
        static void Main(string[] args)
        {

            int i = 3;
            int evenNumbersSum = 0;
            int evenNumbersCount = 0;      

            while (i <= 21)
            {
                if (i % 2 == 0)
                {
                    evenNumbersSum += i;
                    evenNumbersCount++;
                }

                i++;
            }

            Console.WriteLine("Сумма четных чисел = {0}, количество четных чисел {1}", evenNumbersSum, evenNumbersCount);
        }
    }
}
