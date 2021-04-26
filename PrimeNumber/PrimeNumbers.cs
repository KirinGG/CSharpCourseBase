using System;

namespace PrimeNumbers
{
    class PrimeNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int rangeEnd = Convert.ToInt32(Console.ReadLine());

            if (rangeEnd < 2)
            {
                Console.WriteLine("В диапазоне от [{0} до 2) нет простых чисел!", rangeEnd);
            }
            else
            {
                Console.WriteLine("Простые числа:");

                for (int i = 2; i <= rangeEnd; i++)
                {
                    bool isPrimeNumber = true;

                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            isPrimeNumber = false;
                            break;
                        }
                    }

                    if (isPrimeNumber)
                    {
                        Console.Write("{0}; ", i);
                    }
                }
            }
        }
    }
}
