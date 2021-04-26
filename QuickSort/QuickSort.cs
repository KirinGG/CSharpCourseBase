using System;

namespace QuickSort
{
    class QuickSort
    {
        static void Main(string[] args)
        {
            int[] numbersArray = { 1, 5, 4, 3, -8, 14, 98, 0, 5 };
            int left = 0;
            int right = numbersArray.Length - 1;

            Sort(numbersArray, left, right);

            foreach (int e in numbersArray)
            {
                Console.Write("{0}, ", e);
            }
        }

        public static void Sort(int[] numbersArray, int left, int right)
        {
            if (left >= right)
            {
                return;
            }

            if ((right - left) == 1 )
            {
                if (numbersArray[left] > numbersArray[right])
                {
                    int temp = numbersArray[left];
                    numbersArray[left] = numbersArray[right];
                    numbersArray[right] = temp;
                }
                
                return;
            }

            int pivot = numbersArray[right];
            int i = left;
            int j = right;

            while (i <= j)
            {
                while (numbersArray[i] < pivot)
                {
                    i++;
                }

                while (numbersArray[j] > pivot)
                {
                    j--;
                }

                if (i <= j)
                {
                    int temp = numbersArray[i];
                    numbersArray[i] = numbersArray[j];
                    numbersArray[j] = temp;
                    i++;
                    j--;
                }
            }

            if (i < right)
            {
                Sort(numbersArray, i, right);
            }

            if (j > left)
            {
                Sort(numbersArray, left, j);
            }
        }
    }
}