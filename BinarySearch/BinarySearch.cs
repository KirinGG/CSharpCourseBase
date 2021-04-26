using System;

namespace BinarySearch
{
    class BinarySearch
    {
        static void Main(string[] args)
        {
            int[] numbersArray = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int element = 4;
            int left = 0;
            int right = numbersArray.Length - 1;

            int elementIndexInArray1 = FindElementIndexRecursively(numbersArray, left, right, element);
            Print("Рекурсивный алгоритм поиска:", element, elementIndexInArray1);

            int elementIndexInArray2 = FindElementIndex(numbersArray, element);
            Print("Обычный алгоритм поиска:", element, elementIndexInArray2);
        }

        public static int FindElementIndexRecursively(int[] numbersArray, int left, int right, int element)
        {
            if (left > right)
            {
                return -1;
            }

            int middle = (right + left) / 2;

            if (element > numbersArray[middle])
            {
                return FindElementIndexRecursively(numbersArray, middle + 1, right, element);
            }

            if (element < numbersArray[middle])
            {
                return FindElementIndexRecursively(numbersArray, left, middle - 1, element);
            }

            return middle;
        }

        public static int FindElementIndex(int[] numbersArray, int element)
        {
            int left = 0;
            int right = numbersArray.Length - 1;

            while (left <= right)
            {
                int middle = (right + left) / 2;

                if (element > numbersArray[middle])
                {
                    left = middle + 1;
                }
                else if (element < numbersArray[middle])
                {
                    right = middle - 1;
                }
                else
                {
                    return middle;
                }
            }

            return -1;
        }

        public static void Print(string title, int element, int elementIndexInArray)
        {
            Console.WriteLine(title);

            if (elementIndexInArray == -1)
            {
                Console.WriteLine("Число {0} не найдено в массиве.", element);
            }
            else
            {
                Console.WriteLine("Число {0} найдено в массиве. Индекс - {1}.", element, elementIndexInArray);
            }
        }
    }
}
