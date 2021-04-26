using System;

namespace InsertSort
{
    class InsertSort
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
            for (int i = 1; i < numbersArray.Length; i++)
            {
                int temp = numbersArray[i];
                int j = i - 1;

                while (j >= 0 && temp < numbersArray[j])
                {
                    numbersArray[j + 1] = numbersArray[j];
                    j--;
                }

                numbersArray[j + 1] = temp;
            }
        }
    }
}