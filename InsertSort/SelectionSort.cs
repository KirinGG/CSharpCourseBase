using System;

namespace SelectionSort
{
    class SelectionSort
    {
        static void Main(string[] args)
        {
            int[] numbersArray = { 1, -9, -9, 5, 4, 3, 7, 9, -9, 67 };
            Sort(numbersArray);

            foreach (int e in numbersArray)
            {
                Console.Write("{0}, ", e);
            }
        }

        public static void Sort(int[] numbersArray)
        {
            for (int i = 0; i < numbersArray.Length - 1; i++)
            {
                int minimumIndex = i;

                for (int j = i + 1; j < numbersArray.Length; j++)
                {
                    if (numbersArray[minimumIndex] > numbersArray[j])
                    {
                        minimumIndex = j;
                    }
                }

                int temp = numbersArray[i];
                numbersArray[i] = numbersArray[minimumIndex];
                numbersArray[minimumIndex] = temp;
            }
        }
    }
}
