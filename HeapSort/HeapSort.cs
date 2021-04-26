using System;

namespace HeapSort
{
    class HeapSort
    {
        static void Main(string[] args)
        {
            int[] numbersArray = { 1, 5, 4, 3, -8, 14, 98, 0, 5 };

            Sort(numbersArray);

            foreach (int e in numbersArray)
            {
                Console.Write("{0}, ", e);
            }
        }

        public static void Sort(int[] numbersArray)
        {
            int parentIndex = numbersArray.Length / 2 - 1;
            int border = numbersArray.Length - numbersArray.Length % 2 == 0 ? 2 : 1;

            for (int i = parentIndex; i >= 0; i--)
            {
                Sift(numbersArray, border, i);
            }

            for (int i = border; i > 0; i--)
            {
                int temp = numbersArray[0];
                numbersArray[0] = numbersArray[i];
                numbersArray[i] = temp;

                Sift(numbersArray, i, 0);
            }
        }

        public static void Sift(int[] numbersArray, int border, int parentIndex)
        {
            int maximumIndex = parentIndex;

            while (parentIndex * 2 <= border)
            {
                int leftChildIndex = 2 * parentIndex + 1;
                int rightChildIndex = 2 * parentIndex + 2;

                if (leftChildIndex < border && numbersArray[leftChildIndex] > numbersArray[maximumIndex])
                {
                    maximumIndex = leftChildIndex;
                }

                if (rightChildIndex < border && numbersArray[rightChildIndex] > numbersArray[maximumIndex])
                {
                    maximumIndex = rightChildIndex;
                }

                if (maximumIndex != parentIndex)
                {
                    int temp = numbersArray[parentIndex];
                    numbersArray[parentIndex] = numbersArray[maximumIndex];
                    numbersArray[maximumIndex] = temp;

                    parentIndex = maximumIndex;
                }
                else
                {
                    return;
                }
            }
        }
    }
}