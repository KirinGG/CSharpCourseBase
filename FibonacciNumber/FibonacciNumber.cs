using System;

namespace FibonacciNumber
{
    class FibonacciNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите порядковый номер числа Фибоначчи:");
            int fibonacciNumberIndex = Convert.ToInt32(Console.ReadLine());

            int previousFibonacciNumber = 0;
            int currentFibonacciNumber = 1;

            if (fibonacciNumberIndex == 0)
            {
                Console.WriteLine("Число Фибоначчи под номером {0} = {1}", fibonacciNumberIndex, previousFibonacciNumber);
            }
            else if (fibonacciNumberIndex == 1)
            {
                Console.WriteLine("Число Фибоначчи под номером {0} = {1}", fibonacciNumberIndex, currentFibonacciNumber);
            }
            else
            {
                int i = 2;

                while (i <= fibonacciNumberIndex)
                {
                    int nextFibonacciNumber = previousFibonacciNumber + currentFibonacciNumber;
                    previousFibonacciNumber = currentFibonacciNumber;
                    currentFibonacciNumber = nextFibonacciNumber;
                    i++;
                }

                Console.WriteLine("Число Фибоначчи под номером {0} = {1}", fibonacciNumberIndex, currentFibonacciNumber);
            }
        }
    }
}
