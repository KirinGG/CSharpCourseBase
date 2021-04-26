using System;

namespace ChoiceSort
{
    class ChoiceSort
    {
        static void Main(string[] args)
        {
            int[] numbersArray = { 1, 5, 4, 3 };
            Sort(numbersArray);

            foreach (int e in numbersArray)
            {
                Console.Write("{0}, ", e);
            }
        }

        public static void Sort(int[] numbersArray)
        {
            for (int i = 0; i < numbersArray.Length; i++)
            {
                int indexMinimum = i;

                for (int j = i + 1; j < numbersArray.Length; j++)
                {
                    if (numbersArray[indexMinimum] >= numbersArray[j])
                    {
                        indexMinimum = j;
                    }
                }

                int temp = numbersArray[i];
                numbersArray[i] = numbersArray[indexMinimum];
                numbersArray[indexMinimum] = temp;
            }
        }
    }
}
