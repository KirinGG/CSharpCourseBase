using System;
/*
Написать функцию, которая проверяет, что массив отсортирован по возрастанию
• И написать функцию, которая проверяет, что массив отсортирован по убыванию
*/
namespace SortingCheck
{
    class SortingCheck
    {
        static void Main(string[] args)
        {
            int[] numbers = { 3, 2, 1 };

            if (IsArraySortedAscending(numbers))
            {
                Console.WriteLine("Массив отсортирован по возрастанию.");
            }
            else if (IsArraySortedDescending(numbers))
            {
                Console.WriteLine("Массив отсортирован по убыванию.");
            }
            else
            {
                Console.WriteLine("Массив не отсортирован.");
            }
        }

        public static bool IsArraySortedAscending(int[] numbers)
        {
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[i - 1])
                {
                    return false;
                }
            }

            return true;
        }

        public static bool IsArraySortedDescending(int[] numbers)
        {
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > numbers[i - 1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}